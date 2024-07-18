using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;

namespace VMNS.Controllers
{
    [Authorize]
    public class Sub_AccessoriesController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public Sub_AccessoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sub_Accessories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sub_Accessories.Include(s => s.Maintenance);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sub_Accessories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sub_Accessories == null)
            {
                return NotFound();
            }

            var sub_Accessories = await _context.Sub_Accessories
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_Accessories == null)
            {
                return NotFound();
            }

            return View(sub_Accessories);
        }

        // GET: Sub_Accessories/Create
        public IActionResult Create(string? MaintenanceId)
        {
            ViewData["MaintenanceId"] = MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Model");
            
            // Check existing input
            int x = 0;
            db.Query("select COUNT(*) FROM[VMNS].[dbo].[Sub_Accessories] WHERE[MaintenanceId] ='" + MaintenanceId + "'");
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

        // POST: Sub_Accessories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MaintenanceId,Antennae,AshTray,BackupRearLights,CigaretteLighter,DoorGlass," +
            "DoorHandles,Emblem,EngineHood,FloorMats,GasTankCap,HeadRest,HubCaps,IgnitionSwitch,MudGuards,NamePlate,NamePlateLight,ParkingLights," +
            "RadiatorCap,RearViewMirror,SideMirrors,SpareTire,StereoSpeakers,SunVisors,Tools,TrunkCompartment,Upholstery," +
            "WindshieldGlass,WipeArm,WiperKnob,Manuals,Remarks")] Sub_Accessories sub_Accessories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sub_Accessories);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "Maintenances", new { id = sub_Accessories.MaintenanceId });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["MaintenanceId"] = sub_Accessories.MaintenanceId;
            ViewData["Status"] = new SelectList(_context.lu_EquipmentStatus, "Name", "Name");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", sub_Accessories.MaintenanceId);
            return View(sub_Accessories);
        }

        // GET: Sub_Accessories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sub_Accessories == null)
            {
                return NotFound();
            }

            var sub_Accessories = await _context.Sub_Accessories.FindAsync(id);
            if (sub_Accessories == null)
            {
                return NotFound();
            }
            ViewData["MaintenanceId"] = _context.Sub_Accessories.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_Accessories);
        }

        // POST: Sub_Accessories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MaintenanceId,Antennae,AshTray,BackupRearLights,CigaretteLighter,DoorGlass,DoorHandles,Emblem,EngineHood,FloorMats,GasTankCap,HeadRest,HubCaps,IgnitionSwitch,MudGuards,NamePlate,NamePlateLight,ParkingLights,RadiatorCap,RearViewMirror,SideMirrors,SpareTire,StereoSpeakers,SunVisors,Tools,TrunkCompartment,Upholstery,WindshieldGlass,WipeArm,WiperKnob,Manuals,Remarks")] Sub_Accessories sub_Accessories)
        {
            if (id != sub_Accessories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sub_Accessories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Sub_AccessoriesExists(sub_Accessories.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Maintenances", new { id = sub_Accessories.MaintenanceId });
            }
            ViewData["MaintenanceId"] = _context.Sub_Accessories.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_Accessories);
        }

        // GET: Sub_Accessories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sub_Accessories == null)
            {
                return NotFound();
            }

            var sub_Accessories = await _context.Sub_Accessories
                .Include(s => s.Maintenance)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sub_Accessories == null)
            {
                return NotFound();
            }
            ViewData["MaintenanceId"] = _context.Sub_Accessories.Where(m => m.Id == id).FirstOrDefault().MaintenanceId;
            return View(sub_Accessories);
        }

        // POST: Sub_Accessories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sub_Accessories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Sub_Accessories'  is null.");
            }
            var sub_Accessories = await _context.Sub_Accessories.FindAsync(id);
            if (sub_Accessories != null)
            {
                _context.Sub_Accessories.Remove(sub_Accessories);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Maintenances", new { id = sub_Accessories.MaintenanceId });
        }

        private bool Sub_AccessoriesExists(int id)
        {
          return (_context.Sub_Accessories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
