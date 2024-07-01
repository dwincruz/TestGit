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
    public class Sub_UnderHoodController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_UnderHoodController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_UnderHood
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_UnderHoods.Include(s => s.Maintenance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_UnderHood/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sub_UnderHoods == null)
            {
                return NotFound();
            }

            var sub_UnderHood = await _context.Sub_UnderHoods
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_UnderHood == null)
            {
                return NotFound();
            }

            return View(sub_UnderHood);
        }

        // GET: Sub_UnderHood/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");

            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_UnderHoods] WHERE[MaintenanceId] ='" + MaintenanceId + "'");
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

        // POST: Sub_UnderHood/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,FluidLevels,HeaterHoses,AirCondition,DriveBelt,ComputerBox,ElectricFuses,Alternator,CoolantRecoveryReservoirFluidLevel,AirConditionerCondenser,CoolingSystemHoses,EngineAirFilter,ClutchReservoirFluid,AuxiliaryBelt,Washer,RadiatorCore,PowerSteering,BrakeFluid,HosesandConnections, Remarks")] Sub_UnderHood sub_UnderHood)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sub_UnderHood);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Maintenances", new { id = sub_UnderHood.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = sub_UnderHood.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderHood);
        }

        // GET: Sub_UnderHood/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_UnderHoods == null)
            {
                return NotFound();
            }

            var sub_UnderHood = await _context.Sub_UnderHoods.FindAsync(id);
            if (sub_UnderHood == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderHoods.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderHood);
        }

        // POST: Sub_UnderHood/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,FluidLevels,HeaterHoses,AirCondition,DriveBelt,ComputerBox,ElectricFuses,Alternator,CoolantRecoveryReservoirFluidLevel,AirConditionerCondenser,CoolingSystemHoses,EngineAirFilter,ClutchReservoirFluid,AuxiliaryBelt,Washer,RadiatorCore,PowerSteering,BrakeFluid,HosesandConnections, Remarks")] Sub_UnderHood sub_UnderHood)
        {
            if (id != sub_UnderHood.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_UnderHood);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_UnderHoodExists(sub_UnderHood.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_UnderHood.MaintenanceId });
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderHoods.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderHood);
        }

        // GET: Sub_UnderHood/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sub_UnderHoods == null)
            {
                return NotFound();
            }

            var sub_UnderHood = await _context.Sub_UnderHoods
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_UnderHood == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderHoods.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_UnderHood);
        }

        // POST: Sub_UnderHood/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_UnderHoods == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_UnderHoods'  is null.");
            }
            var sub_UnderHood = await _context.Sub_UnderHoods.FindAsync(id);
            if (sub_UnderHood != null)
            {
                _context.Sub_UnderHoods.Remove(sub_UnderHood);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_UnderHood.MaintenanceId });
        }

        private bool Sub_UnderHoodExists(int id)
        {
          return (_context.Sub_UnderHoods?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
