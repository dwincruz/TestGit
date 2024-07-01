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
    public class Sub_InteriorExteriorController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_InteriorExteriorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_InteriorExterior
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_InteriorExteriors.Include(s => s.Maintenance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_InteriorExterior/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sub_InteriorExteriors == null)
            {
                return NotFound();
            }

            var sub_InteriorExterior = await _context.Sub_InteriorExteriors
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_InteriorExterior == null)
            {
                return NotFound();
            }

            return View(sub_InteriorExterior);
        }

        // GET: Sub_InteriorExterior/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");

            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_InteriorExteriors] WHERE[MaintenanceId] ='" + MaintenanceId + "'");
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

        // POST: Sub_InteriorExterior/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,HeadLights,TailLights,TurnSignals,BrakeLights,HazardLights,ExteriorLamps," +
            "LicensePlatesLights,WindshieldWiper,WiperBlades,WindshieldCondition,EmergencyBrakeAdjustment,HornOperation,FuelTankCapBasket," +
            "AirConGasket,AirConFilter,ClutchOperation,BackupLights,DashWarningLights,Carpet,Remarks,DateReplaced,GlassAndMirrors,Wiring")] Sub_InteriorExterior sub_InteriorExterior)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sub_InteriorExterior);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Maintenances", new { id = sub_InteriorExterior.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = sub_InteriorExterior.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_InteriorExterior);
        }

        // GET: Sub_InteriorExterior/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_InteriorExteriors == null)
            {
                return NotFound();
            }

            var sub_InteriorExterior = await _context.Sub_InteriorExteriors.FindAsync(id);
            if (sub_InteriorExterior == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_InteriorExteriors.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_InteriorExterior);
        }

        // POST: Sub_InteriorExterior/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,HeadLights,TailLights,TurnSignals,BrakeLights,HazardLights,ExteriorLamps," +
            "LicensePlatesLights,WindshieldWiper,WiperBlades,WindshieldCondition,EmergencyBrakeAdjustment,HornOperation,FuelTankCapBasket,AirConGasket," +
            "AirConFilter,ClutchOperation,BackupLights,DashWarningLights,Carpet,Remarks,DateReplaced,GlassAndMirrors,Wiring")] Sub_InteriorExterior sub_InteriorExterior)
        {
            if (id != sub_InteriorExterior.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_InteriorExterior);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_InteriorExteriorExists(sub_InteriorExterior.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_InteriorExterior.MaintenanceId });
            }

            ViewData["MaintenanceId"] = _context.Sub_BatteryPerformances.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_InteriorExterior);
        }

        // GET: Sub_InteriorExterior/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sub_InteriorExteriors == null)
            {
                return NotFound();
            }

            var sub_InteriorExterior = await _context.Sub_InteriorExteriors
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_InteriorExterior == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_InteriorExteriors.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_InteriorExterior);
        }

        // POST: Sub_InteriorExterior/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_InteriorExteriors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_InteriorExteriors'  is null.");
            }
            var sub_InteriorExterior = await _context.Sub_InteriorExteriors.FindAsync(id);
            if (sub_InteriorExterior != null)
            {
                _context.Sub_InteriorExteriors.Remove(sub_InteriorExterior);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_InteriorExterior.MaintenanceId });
        }

        private bool Sub_InteriorExteriorExists(int id)
        {
          return (_context.Sub_InteriorExteriors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
