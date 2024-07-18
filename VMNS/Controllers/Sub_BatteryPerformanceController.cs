using System;
using System.Collections.Generic;
using System.Linq;
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
    public class Sub_BatteryPerformanceController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_BatteryPerformanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_BatteryPerformance
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_BatteryPerformances.Include(s => s.Maintenance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_BatteryPerformance/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null || _context.Sub_BatteryPerformances == null)
            {
                return NotFound();
            }

            var sub_BatteryPerformance = await _context.Sub_BatteryPerformances
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_BatteryPerformance == null)
            {
                return NotFound();
            }

            return View(sub_BatteryPerformance);
        }

        // GET: Sub_BatteryPerformance/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Model");

            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_BatteryPerformances] WHERE[MaintenanceId] ='" + MaintenanceId +"'");
            while (db.Reader.Read())
            {
                x = db.Reader.GetInt32(0);
            }

            if (x != 0)
            {
                Notify("Record already available", notificationType: NotificationType.warning);
                return RedirectToAction("Details", "Maintenances", new { id = MaintenanceId });
            }
            else
            {
                return View();
            }            
        }

        // POST: Sub_BatteryPerformance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,BatteryTerminal," +
            "ConditionOfBattery,Remarks,DateReplaced")] Sub_BatteryPerformance sub_BatteryPerformance)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(sub_BatteryPerformance);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Maintenances", new { id = sub_BatteryPerformance.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = sub_BatteryPerformance.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", sub_BatteryPerformance.MaintenanceId);
            return View(sub_BatteryPerformance);
        }

        // GET: Sub_BatteryPerformance/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_BatteryPerformances == null)
            {
                return NotFound();
            }

            var sub_BatteryPerformance = await _context.Sub_BatteryPerformances.FindAsync(id);
            if (sub_BatteryPerformance == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_BatteryPerformances.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", sub_BatteryPerformance.MaintenanceId);
            return View(sub_BatteryPerformance);
        }

        // POST: Sub_BatteryPerformance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,BatteryTerminal,ConditionOfBattery," +
            "Remarks,DateReplaced")] Sub_BatteryPerformance sub_BatteryPerformance)
        {
            if (id != sub_BatteryPerformance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_BatteryPerformance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_BatteryPerformanceExists(sub_BatteryPerformance.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_BatteryPerformance.MaintenanceId });
            }

            ViewData["MaintenanceId"] = _context.Sub_BatteryPerformances.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", sub_BatteryPerformance.MaintenanceId);
            return View(sub_BatteryPerformance);
        }

        // GET: Sub_BatteryPerformance/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {           
            if (id == null || _context.Sub_BatteryPerformances == null)
            {
                return NotFound();
            }

            var sub_BatteryPerformance = await _context.Sub_BatteryPerformances
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_BatteryPerformance == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_BatteryPerformances.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_BatteryPerformance);
        }

        // POST: Sub_BatteryPerformance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_BatteryPerformances == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_BatteryPerformances'  is null.");
            }
            var sub_BatteryPerformance = await _context.Sub_BatteryPerformances.FindAsync(id);
            if (sub_BatteryPerformance != null)
            {
                _context.Sub_BatteryPerformances.Remove(sub_BatteryPerformance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_BatteryPerformance.MaintenanceId });
        }

        private bool Sub_BatteryPerformanceExists(int id)
        {
          return (_context.Sub_BatteryPerformances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
