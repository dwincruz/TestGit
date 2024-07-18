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
    public class Sub_UnderVehicleController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_UnderVehicleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_UnderVehicle
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_UnderVehicles.Include(s => s.Maintenance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_UnderVehicle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sub_UnderVehicles == null)
            {
                return NotFound();
            }

            var sub_UnderVehicle = await _context.Sub_UnderVehicles
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_UnderVehicle == null)
            {
                return NotFound();
            }

            return View(sub_UnderVehicle);
        }

        // GET: Sub_UnderVehicle/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");

            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_UnderVehicles] WHERE[MaintenanceId] ='" + MaintenanceId + "'");
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

        // POST: Sub_UnderVehicle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,TransmissionFluid,Coolant,ExhaustPipes,TransferCase,FluidLinesConnections,Wiring,EngineOil,ParkingBrakeCable,NutsAndBolts,Muffler,ShockAbsorber,DriveShaftBoots,TransmissionAssembly,UJoints,DustCover,Hoses,FuelTankVaporVentSystemsHoses,FluidTankBand,Remarks,AutomaticTransmissionFluid,BallJoints,BrakeLines,CatalyticConverter,ConstantVelocityBoots,Differential")] Sub_UnderVehicle sub_UnderVehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sub_UnderVehicle);
                await _context.SaveChangesAsync();
                
                return RedirectToAction("Details", "Maintenances", new { id = sub_UnderVehicle.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = sub_UnderVehicle.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderVehicle);
        }

        // GET: Sub_UnderVehicle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_UnderVehicles == null)
            {
                return NotFound();
            }

            var sub_UnderVehicle = await _context.Sub_UnderVehicles.FindAsync(id);
            if (sub_UnderVehicle == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderVehicles.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderVehicle);
        }

        // POST: Sub_UnderVehicle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,TransmissionFluid,Coolant,ExhaustPipes,TransferCase,FluidLinesConnections,Wiring,EngineOil,ParkingBrakeCable,NutsAndBolts,Muffler,ShockAbsorber,DriveShaftBoots,TransmissionAssembly,UJoints,DustCover,Hoses,FuelTankVaporVentSystemsHoses,FluidTankBand,Remarks,AutomaticTransmissionFluid,BallJoints,BrakeLines,CatalyticConverter,ConstantVelocityBoots,Differential")] Sub_UnderVehicle sub_UnderVehicle)
        {
            if (id != sub_UnderVehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_UnderVehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_UnderVehicleExists(sub_UnderVehicle.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_UnderVehicle.MaintenanceId });
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderVehicles.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            return View(sub_UnderVehicle);
        }

        // GET: Sub_UnderVehicle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sub_UnderVehicles == null)
            {
                return NotFound();
            }

            var sub_UnderVehicle = await _context.Sub_UnderVehicles
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_UnderVehicle == null)
            {
                return NotFound();
            }

            ViewData["MaintenanceId"] = _context.Sub_UnderVehicles.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_UnderVehicle);
        }

        // POST: Sub_UnderVehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_UnderVehicles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_UnderVehicles'  is null.");
            }
            var sub_UnderVehicle = await _context.Sub_UnderVehicles.FindAsync(id);
            if (sub_UnderVehicle != null)
            {
                _context.Sub_UnderVehicles.Remove(sub_UnderVehicle);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_UnderVehicle.MaintenanceId });
        }

        private bool Sub_UnderVehicleExists(int id)
        {
          return (_context.Sub_UnderVehicles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
