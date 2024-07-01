using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using VMNS.Areas.Identity.Data;
using VMNS.Migrations;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class MonitoringsController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public MonitoringsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Monitorings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Monitorings.Include(m => m.Maintenance).Include(m => m.Replacement);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Monitorings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Monitorings == null)
            {
                return NotFound();
            }

            var monitoring = await _context.Monitorings
                .Include(m => m.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monitoring == null)
            {
                return NotFound();
            }

            return View(monitoring);
        }

        // GET: Monitorings/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["ReplacementId"] = new SelectList(_context.Replacements, "Id", "Parts");

            return View();
        }

        // POST: Monitorings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,ReplacementId,CurrentKM,CurrentDays,DateAcquired, LifeSpan")] Monitoring monitoring)
        {

            string Parts = _context.Replacements.Where(x => x.Id == monitoring.ReplacementId).FirstOrDefault().Parts;
            int x = 0;
            db.Query("select * FROM [VMNS].[dbo].[Monitorings] where [ReplacementId] = " + monitoring.ReplacementId + " and MaintenanceId = '"+ monitoring.MaintenanceId+ "'");
            while (db.Reader.Read())
            {
                x = db.Reader.GetInt32(0);
            }

            if (x != 0)
            {
                ViewData["MaintenanceId"] = monitoring.MaintenanceId;
                ViewData["ReplacementId"] = new SelectList(_context.Replacements, "Id", "Parts");

                Notify("\"" + Parts + "\" already available", notificationType: NotificationType.warning);
                return View(monitoring);
            }

            if (ModelState.IsValid)
            {
                _context.Add(monitoring);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Details", "Maintenances", new { id = monitoring.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = monitoring.MaintenanceId;
            ViewData["ReplacementId"] = new SelectList(_context.Replacements, "Id", "Parts");
            return View(monitoring);
        }


        // GET: Monitorings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Monitorings == null)
            {
                return NotFound();
            }

            var monitoring = await _context.Monitorings.FindAsync(id);
            if (monitoring == null)
            {
                return NotFound();
            }
            ViewData["MaintenanceId"] = _context.Monitorings.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["ReplacementId"] = new SelectList(_context.Replacements, "Id", "Parts");

            return View(monitoring);
        }

        // POST: Monitorings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,ReplacementId,CurrentKM,CurrentDays,DateAcquired,LifeSpan")] Monitoring monitoring)
        {
            if (id != monitoring.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monitoring);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonitoringExists(monitoring.Id))
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
            ViewData["MaintenanceId"] = new SelectList(_context.Maintenances, "Id", "Remarks", monitoring.MaintenanceId);
            return View(monitoring);
        }

        // GET: Monitorings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Monitorings == null)
            {
                return NotFound();
            }

            var monitoring = await _context.Monitorings
                .Include(m => m.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (monitoring == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Monitorings.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(monitoring);
        }

        // POST: Monitorings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Monitorings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Monitorings'  is null.");
            }
            var monitoring = await _context.Monitorings.FindAsync(id);
            if (monitoring != null)
            {
                _context.Monitorings.Remove(monitoring);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = monitoring.MaintenanceId });
        }

        private bool MonitoringExists(int id)
        {
            return (_context.Monitorings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
