using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class Sub_BrakeTiresController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_BrakeTiresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_BrakeTires
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_BrakeTires.Include(s => s.Maintenance).Include(s => s.lu_Wheel);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_BrakeTires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sub_BrakeTires == null)
            {
                return NotFound();
            }

            var sub_BrakeTires = await _context.Sub_BrakeTires
                .Include(s => s.Maintenance)
                .Include(s => s.lu_Wheel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_BrakeTires == null)
            {
                return NotFound();
            }

            
            return View(sub_BrakeTires);
        }

        // GET: Sub_BrakeTires/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["lu_WheelId"] = new SelectList(_context.lu_Wheels, "Id", "WheelPosition");

            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_BrakeTires] WHERE[MaintenanceId] ='" + MaintenanceId + "'");
            while (db.Reader.Read())
            {
                x = db.Reader.GetInt32(0);
            }

            if (x >= 2)
            {
                Notify("Record already available", notificationType: NotificationType.warning);
                return RedirectToAction("Details", "Maintenances", new { id = MaintenanceId });
            }
            else
            {
                return View();
            }
        }

        // POST: Sub_BrakeTires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,lu_WheelId,BreakLining,TireTread,WearPattern,TirePressureBefore," +
            "TirePressureAfter,Remarks,LifeSpan,AcquisitionDate")] Sub_BrakeTires sub_BrakeTires)
        {
            if (ModelState.IsValid)
            {
                //Check wheel Id 
                int x = 0;
                db.Query("select COUNT(*) FROM [VMNS].[dbo].[Sub_BrakeTires] WHERE [MaintenanceId] = '"+ sub_BrakeTires.MaintenanceId + 
                    "' AND [lu_WheelId] = "+ sub_BrakeTires.lu_WheelId);
                while (db.Reader.Read())
                {
                    x = db.Reader.GetInt32(0);
                }

                if (x == 0)
                {
                    _context.Add(sub_BrakeTires);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", "Maintenances", new { id = sub_BrakeTires.MaintenanceId });
                }
                else
                {
                    Notify("Wheel position already in use.", notificationType: NotificationType.warning);
                }
            }

            ViewData["MaintenanceId"] = sub_BrakeTires.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["lu_WheelId"] = new SelectList(_context.lu_Wheels, "Id", "WheelPosition", sub_BrakeTires.lu_WheelId);
            return View(sub_BrakeTires);
        }

        // GET: Sub_BrakeTires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_BrakeTires == null)
            {
                return NotFound();
            }

            var sub_BrakeTires = await _context.Sub_BrakeTires.FindAsync(id);
            if (sub_BrakeTires == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_BrakeTires.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["lu_WheelId"] = new SelectList(_context.lu_Wheels, "Id", "WheelPosition", sub_BrakeTires.lu_WheelId);
            return View(sub_BrakeTires);
        }

        // POST: Sub_BrakeTires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,lu_WheelId,BreakLining,TireTread,WearPattern," +
            "TirePressureBefore,TirePressureAfter,Remarks,LifeSpan,AcquisitionDate")] Sub_BrakeTires sub_BrakeTires)
        {
            if (id != sub_BrakeTires.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_BrakeTires);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_BrakeTiresExists(sub_BrakeTires.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_BrakeTires.MaintenanceId });
            }

            ViewData["MaintenanceId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", sub_BrakeTires.MaintenanceId);
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["lu_WheelId"] = new SelectList(_context.lu_Wheels, "Id", "WheelPosition", sub_BrakeTires.lu_WheelId);
            return View(sub_BrakeTires);
        }

        // GET: Sub_BrakeTires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sub_BrakeTires == null)
            {
                return NotFound();
            }

            var sub_BrakeTires = await _context.Sub_BrakeTires
                .Include(s => s.Maintenance)
                .Include(s => s.lu_Wheel)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_BrakeTires == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_BrakeTires.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_BrakeTires);
        }

        // POST: Sub_BrakeTires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_BrakeTires == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_BrakeTires'  is null.");
            }
            var sub_BrakeTires = await _context.Sub_BrakeTires.FindAsync(id);
            if (sub_BrakeTires != null)
            {
                _context.Sub_BrakeTires.Remove(sub_BrakeTires);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_BrakeTires.MaintenanceId });
        }

        private bool Sub_BrakeTiresExists(int id)
        {
          return (_context.Sub_BrakeTires?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
