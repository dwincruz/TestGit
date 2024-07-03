using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Migrations;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class AccidentsController : BaseController
    {
        private readonly ApplicationDbContext _context;

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
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", accident.VehicleId);
            ViewData["lu_DamageScaleId"] = new SelectList(_context.lu_DamageScales, "Id", "DamageScale");

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
        public async Task<IActionResult> Create([Bind("Id,VehicleId,AccidentDate,Damage,lu_DamageScaleId,Remarks,RepairDate")] Accident accident)
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
            var applicationDbContext = _context.Accidents.OrderByDescending(m => m.DateCreated).Include(m => m.Vehicle).Where(x => x.VehicleId == selectedValue);
            ViewData["Vehicles"] = _context.Vehicles;
            return View(await applicationDbContext.ToListAsync());
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
            
            return View(accident);
        }
        // POST: Accidents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleId,AccidentDate,Damage,lu_DamageScaleId,Remarks,RepairDate,CreatorId,DateCreated")] Accident accident)
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
