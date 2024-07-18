using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Migrations;
using VMNS.Models;

namespace VMNS.Controllers
{
    [Authorize]
    public class AccidentsController : BaseController
    {
        private readonly ApplicationDbContext _context;

        private readonly MySqlController db = new MySqlController();

        public AccidentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Accidents
        public async Task<IActionResult> Index()
        {

            var applicationDbContext = _context.Accidents.Include(a => a.Vehicle).Include(x => x.lu_DamageScale);
            ViewData["Vehicles"] = _context.Vehicles;
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accidents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }
            var accident = await _context.Accidents.FindAsync(id);
            if (accident == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = _context.Accidents.Where(m => m.Id == id).FirstOrDefault().VehicleId;

            ViewData["lu_VehicleTypeId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", accident.VehicleId);
            ViewData["lu_DamageScaleId"] = new SelectList(_context.lu_DamageScales, "Id", "DamageScale");
            ViewData["FilePath"] = _context.Uploads.Where(x=>x.ConcernId == id.ToString()).FirstOrDefault().FilePath;

            return View(accident);
        }

        // GET: Accidents/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo");
            ViewData["DamageScaleId"] = new SelectList(_context.lu_DamageScales, "Id", "DamageScale");
            ViewData["Vehicles"] = _context.Vehicles;
            return View();
        }

        // POST: Accidents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,AccidentDate,Damage,lu_DamageScaleId,Remarks,RepairDate")] Accident accident, IFormFile[] file)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                accident.CreatorId = new Guid(userId);
                accident.ModifierId = new Guid(userId);
                accident.DateCreated = DateTime.Now;
                accident.DateModified = DateTime.Now;
                _context.Add(accident);

                await _context.SaveChangesAsync();

                var folderId = accident.Id.ToString().ToUpper();
                if (file != null)
                {
                    foreach (IFormFile docu in file)
                    {
                        //Create Directory
                        var currentMonth = DateTime.Now.Year + DateTime.Now.Month;
                        var fileDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/" + folderId);
                        var fileDir2 = Path.Combine("uploads/" + folderId + "/" + docu.FileName);
                        if (!Directory.Exists(fileDir))
                        {
                            Directory.CreateDirectory(fileDir);
                        }

                        var path = Path.Combine(fileDir, docu.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await docu.CopyToAsync(stream);

                        }

                        db.Query("INSERT INTO [dbo].[Uploads] " +
                            "VALUES ('" + folderId + "','" + docu.FileName + "','" + fileDir2 + "',CURRENT_TIMESTAMP)");
                        db.Con.Close();
                    }
                }

                Notify("Record added successfully.", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", accident.VehicleId);
            ViewData["Vehicles"] = _context.Vehicles;
            return View(accident);
        }
        public async Task<IActionResult> History(Guid? selectedValue)
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo");
            ViewData["Vehicles"] = _context.Vehicles;
            if (selectedValue == Guid.Empty || selectedValue == null)
            {
                var applicationDbContext = _context.Accidents.Include(x => x.lu_DamageScale).Include(m => m.Vehicle).GroupBy(m => m.Vehicle.PlateNo).Select(group => group.OrderByDescending(m => m.DateCreated).First());
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                var applicationDbContext = _context.Accidents.Include(x => x.lu_DamageScale).Include(m => m.Vehicle).Where(x => x.VehicleId == selectedValue).OrderByDescending(m => m.DateCreated);
                return View(await applicationDbContext.ToListAsync());
            }
            return View();

        }
        public async Task<IActionResult> AccidentRecord(int? id)
        {
            if (id != null)
            {
                ViewData["Vehicles"] = _context.Vehicles;
                var accident = await _context.Accidents
                                    .Include(a => a.Vehicle)
                                    .Include(x => x.lu_DamageScale)
                                    .FirstOrDefaultAsync(a => a.Id == id);

            if (accident == null)
            {
                return NotFound();
            }
                return View(accident);
            }
            else
            {
                return NotFound();
            }
            
        }
        // GET: Accidents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }
            var accident = await _context.Accidents.FindAsync(id);
            if (accident == null)
            {
                return NotFound();
            }           
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", accident.VehicleId);
            ViewData["lu_DamageScaleId"] = new SelectList(_context.lu_DamageScales, "Id", "DamageScale");
            ViewData["FilePath"] = _context.Uploads.Where(x => x.ConcernId == id.ToString()).FirstOrDefault().FilePath;
            return View(accident);
        }
        // POST: Accidents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleId,AccidentDate,Damage,lu_DamageScaleId,Remarks,RepairDate,CreatorId,DateCreated")] Accident accident, IFormFile[] file)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewData["Vehicles"] = _context.Vehicles;
            if (id != accident.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    accident.ModifierId = new Guid(userId);
                    accident.DateModified = DateTime.Now;
                    _context.Update(accident);
                    await _context.SaveChangesAsync();

                    
                    var folderId = accident.Id.ToString().ToUpper();
                    if (file.Length > 0)
                    {
                        foreach (IFormFile docu in file)
                        {
                            //Create Directory
                            var currentMonth = DateTime.Now.Year + DateTime.Now.Month;
                            var fileDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/" + folderId);
                            var fileDir2 = Path.Combine("uploads/" + folderId + "/" + docu.FileName);
                            if (!Directory.Exists(fileDir))
                            {
                                Directory.CreateDirectory(fileDir);
                            }

                            var path = Path.Combine(fileDir, docu.FileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await docu.CopyToAsync(stream);

                            }

                            db.Query("UPDATE [dbo].[Uploads] " +
                                "SET FilePath = '"+ fileDir2 + "' "+
                                "WHERE ConcernId = '"+id.ToString()+"'");
                            db.Con.Close();
                        }
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccidentExists(accident.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                Notify("Record updated.", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", accident.VehicleId);
           
            return View(accident);
        }

        // GET: Accidents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }
            ViewData["Vehicles"] = _context.Vehicles;
            var accident = await _context.Accidents
                .Include(a => a.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accident == null)
            {
                return NotFound();
            }

            return View(accident);
        }

        // POST: Accidents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (_context.Accidents == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Accidents'  is null.");
            }
            var accident = await _context.Accidents.FindAsync(id);
            if (accident != null)
            {
                _context.Accidents.Remove(accident);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccidentExists(int id)
        {
          return (_context.Accidents?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
