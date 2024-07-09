using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class MaintenancesController : BaseController
    {
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();

        public MaintenancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maintenances
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Maintenances.OrderByDescending(m => m.DateCreated).Include(m => m.Vehicle);
            ViewData["Vehicles"] = _context.Vehicles;
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> History(Guid? selectedValue)
        {
            
            if (selectedValue == Guid.Empty || selectedValue == null)
            {
                ViewData["VehicleId"] = new SelectList(_context.Vehicles.OrderBy(x => x.PlateNo), "Id", "PlateNo");
                var applicationDbContext = _context.Maintenances.OrderByDescending(m => m.DateCreated).Include(m => m.Vehicle);
                ViewData["Vehicles"] = _context.Vehicles;
                return View(await applicationDbContext.ToListAsync());
            }
            else {
                ViewData["VehicleId"] = new SelectList(_context.Vehicles.OrderBy(x=>x.PlateNo), "Id", "PlateNo");
                ViewData["Vehicles"] = _context.Vehicles;
                var applicationDbContext = _context.Maintenances.OrderByDescending(m => m.DateCreated).Include(m => m.Vehicle).Where(x => x.VehicleId == selectedValue);
                return View(await applicationDbContext.ToListAsync());
            }
            return View();

        }

        // GET: Maintenances/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances
                .Include(m => m.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);

            //Pass Id value to View
            ViewData["MaintenanceId"] = _context.Maintenances.Where(m => m.Id == id).FirstOrDefault().Id;
            ViewData["Monitoring"] = _context.Monitorings.Where(m => m.MaintenanceId == id).Include(m => m.Replacement);
            

            //Pass Sub tables

            ViewData["Sub_BatteryPerformances"] = _context.Sub_BatteryPerformances.Where(x => x.MaintenanceId == id);
            ViewData["Sub_BrakeTires"] = _context.Sub_BrakeTires.Where(x => x.MaintenanceId == id).Include(x => x.lu_Wheel);
            ViewData["Sub_InteriorExterior"] = _context.Sub_InteriorExteriors.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderHood"] = _context.Sub_UnderHoods.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderVehicle"] = _context.Sub_UnderVehicles.Where(x => x.MaintenanceId == id);
            ViewData["Vehicles"] = _context.Vehicles;

            //Get Car Image
            ViewData["VehicleImage"] = _context.Vehicles.Where(m => m.Id == maintenance.VehicleId).FirstOrDefault()?.ImagePath;


            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        public async Task<IActionResult> DetailsHistory(Guid? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances
                .Include(m => m.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);

            //Pass Id value to View
            ViewData["MaintenanceId"] = _context.Maintenances.Where(m => m.Id == id).FirstOrDefault().Id;
            ViewData["VehicleId"] = _context.Maintenances.Where(m => m.Id == id).FirstOrDefault().VehicleId;
            ViewData["Monitoring"] = _context.Monitorings.Where(m => m.MaintenanceId == id).Include(m => m.Replacement);


            //Pass Sub tables
            ViewData["Sub_BatteryPerformances"] = _context.Sub_BatteryPerformances.Where(x => x.MaintenanceId == id);
            ViewData["Sub_BrakeTires"] = _context.Sub_BrakeTires.Where(x => x.MaintenanceId == id).Include(x => x.lu_Wheel);
            ViewData["Sub_InteriorExterior"] = _context.Sub_InteriorExteriors.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderHood"] = _context.Sub_UnderHoods.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderVehicle"] = _context.Sub_UnderVehicles.Where(x => x.MaintenanceId == id);

            //Get Car Image
            ViewData["VehicleImage"] = _context.Vehicles.Where(m => m.Id == maintenance.VehicleId).FirstOrDefault()?.ImagePath;

            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }



        public async Task<IActionResult> Checkform(Guid? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Maintenances == null)
            {
                return View("AdminSearch");
            }

            var maintenance = await _context.Maintenances
                .Include(m => m.Vehicle).ThenInclude(m => m.lu_Transmission)
                .Include(m => m.Vehicle).ThenInclude(m => m.lu_WheelDrive)
                .Include(m => m.Vehicle).ThenInclude(m => m.lu_FuelType)
                .FirstOrDefaultAsync(m => m.Id == id);

            //Pass Id value to View
                
            ViewData["MaintenanceId"] = _context.Maintenances.Where(m => m.Id == id).FirstOrDefault().Id;
            ViewData["Monitoring"] = _context.Monitorings.Where(m => m.MaintenanceId == id).Include(m => m.Replacement);


            //Pass Sub tables

            var xy = _context.Sub_BatteryPerformances.Where(x => x.MaintenanceId == id);
            var total = xy.Count();
            ViewData["Sub_BatteryPerformances"] = xy;

            
            
            ViewData["Sub_Accessories"] = _context.Extras.Where(x => x.VehicleId == maintenance.VehicleId);
            ViewData["Sub_BrakeTires"] = _context.Sub_BrakeTires.Where(x => x.MaintenanceId == id).Include(x => x.lu_Wheel);
            ViewData["Sub_InteriorExterior"] = _context.Sub_InteriorExteriors.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderHood"] = _context.Sub_UnderHoods.Where(x => x.MaintenanceId == id);
            ViewData["Sub_UnderVehicle"] = _context.Sub_UnderVehicles.Where(x => x.MaintenanceId == id);

            if (maintenance == null)
            {
                return View("AdminSearch");
            }
            return View(maintenance);
        }


        // GET: Maintenances/Create
        public IActionResult Create()
        {
            ViewData["Vehicles"] = _context.Vehicles;
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo");
            return View();
        }

        // POST: Maintenances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,DateChecked,Mileage,Remarks,Upload,InspectorName")] Maintenance maintenance, IFormFile[] file)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                maintenance.CreatorId = new Guid(userId);
                maintenance.ModifierId = new Guid(userId);
                maintenance.DateCreated = DateTime.Now;
                maintenance.DateModified = DateTime.Now;
                maintenance.Id = Guid.NewGuid();
                var folderId = maintenance.Id.ToString().ToUpper();

                _context.Add(maintenance);
                await _context.SaveChangesAsync();

                //Upload File
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
                            //document.FilePath = fileDir2;
                        }
                        db.Query("INSERT INTO [dbo].[Uploads] " +
                            "VALUES ('" + folderId + "','" + docu.FileName + "','" + fileDir2 + "',CURRENT_TIMESTAMP)");
                        db.Con.Close();
                    }
                }

                return RedirectToAction("Details", "Maintenances", new { id = maintenance.Id });
                //return RedirectToAction(nameof(Index));
            }

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo");
            return View(maintenance);
        }

        // GET: Maintenances/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances.FindAsync(id);
            if (maintenance == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", maintenance.VehicleId);
            return View(maintenance);
        }

        // POST: Maintenances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,VehicleId,DateChecked,Mileage,Remarks,CreatorId,ModifierId,DateCreated,DateModified,InspectorName")] Maintenance maintenance)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id != maintenance.Id)
            {
                return NotFound();
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(maintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceExists(maintenance.Id))
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
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "AssignedOfficer", maintenance.VehicleId);
            return View(maintenance);
        }

        // GET: Maintenances/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances
                .Include(m => m.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // POST: Maintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            ViewData["Vehicles"] = _context.Vehicles;
            if (_context.Maintenances == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Maintenances'  is null.");
            }
            var maintenance = await _context.Maintenances.FindAsync(id);
            if (maintenance != null)
            {
                _context.Maintenances.Remove(maintenance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceExists(Guid id)
        {
          return (_context.Maintenances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
