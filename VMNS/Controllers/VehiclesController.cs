using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Migrations;
using VMNS.Models;
using static NuGet.Packaging.PackagingConstants;
using VMNS.ViewModel;
using Humanizer;

namespace VMNS.Controllers
{
    public class VehiclesController : BaseController
    {
        private readonly ApplicationDbContext _context;

        private readonly MySqlController db = new MySqlController();

        public VehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vehicles
                .OrderByDescending(v => v.DateCreated)
                .Include(v => v.lu_FuelType)
                .Include(v => v.lu_Transmission)
                .Include(v => v.lu_VehicleType)
                .Include(v => v.lu_WheelDrive)
                .Include(v => v.lu_VehicleStatus);

            // Optionally, if you want to set ViewData for all vehicles (not ordered)
            ViewData["Vehicles"] = await _context.Vehicles.ToListAsync();

            return View(await applicationDbContext.ToListAsync());
        }


        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }
            ViewData["Vehicles"] = _context.Vehicles;
            var vehicle = await _context.Vehicles
                .Include(v => v.lu_FuelType)
                .Include(v => v.lu_Transmission)
                .Include(v => v.lu_VehicleType)
                .Include(v => v.lu_WheelDrive)
                .Include(v => v.lu_VehicleStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            ViewData["lu_FuelTypeId"] = new SelectList(_context.lu_FuelTypes, "Id", "FuelName");
            ViewData["lu_TransmissionId"] = new SelectList(_context.lu_Transmissions, "Id", "TransmissionName");
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.lu_VehicleTypes, "Id", "VehicleType");
            ViewData["lu_WheelDriveId"] = new SelectList(_context.lu_WheelDrives, "Id", "WheelDrive");
            ViewData["lu_VehicleStatusId"] = new SelectList(_context.lu_VehicleStatus, "Id", "VehicleStatus");
            ViewData["Vehicles"] = _context.Vehicles;
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model,lu_VehicleTypeId,lu_TransmissionId,Color," +
            "lu_FuelTypeId,PlateNo,ConductionNo,InsuranceType,InsuranceDate,LtoRegDate,LtoDueDate,AssignedOfficer,AssignedDriver,IssuedDate,AquisitionDate," +
            "Description,lu_WheelDriveId,Upload,lu_VehicleStatusId,EasyTripRFID,AutosweepRFID,Cost")] Vehicle vehicle, IFormFile[] file) //,CreatorId,ModifierId,DateCreated,DateModified,PassengerSeat,Wheels
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                vehicle.CreatorId = new Guid(userId);
                vehicle.ModifierId = new Guid(userId);
                vehicle.DateCreated = DateTime.Now;
                vehicle.DateModified = DateTime.Now;
                vehicle.Id = Guid.NewGuid();
                var folderId = vehicle.Id.ToString().ToUpper();

               

                if (file != null)
                {
                    foreach (IFormFile docu in file)
                    {
                        //Create Directory
                        var currentMonth = DateTime.Now.Year + DateTime.Now.Month;
                        var fileDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + folderId);
                        var fileDir2 = Path.Combine("images/" + folderId + "/" + docu.FileName);
                        if (!Directory.Exists(fileDir))
                        {
                            Directory.CreateDirectory(fileDir);
                        }

                        var path = Path.Combine(fileDir, docu.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await docu.CopyToAsync(stream);
                            vehicle.ImagePath = fileDir2;
                        }

                        _context.Add(vehicle);
                        await _context.SaveChangesAsync();
                        //db.Query("INSERT INTO [dbo].[Uploads] " +
                        //    "VALUES ('" + folderId + "','" + docu.FileName + "','" + fileDir2 + "',CURRENT_TIMESTAMP)");
                        //db.Con.Close();
                    }
                }

                Notify("Record added successfully.", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            ViewData["lu_FuelTypeId"] = new SelectList(_context.lu_FuelTypes, "Id", "FuelName", vehicle.lu_FuelTypeId);
            ViewData["lu_TransmissionId"] = new SelectList(_context.lu_Transmissions, "Id", "TransmissionName", vehicle.lu_TransmissionId);
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.lu_VehicleTypes, "Id", "VehicleType", vehicle.lu_VehicleTypeId);
            ViewData["lu_WheelDriveId"] = new SelectList(_context.lu_WheelDrives, "Id", "VehicleType", vehicle.lu_WheelDriveId);
            ViewData["lu_VehicleStatusId"] = new SelectList(_context.lu_VehicleStatus, "Id", "VehicleStatus");
            ViewData["Vehicles"] = _context.Vehicles;
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["lu_FuelTypeId"] = new SelectList(_context.lu_FuelTypes, "Id", "FuelName", vehicle.lu_FuelTypeId);
            ViewData["lu_TransmissionId"] = new SelectList(_context.lu_Transmissions, "Id", "TransmissionName", vehicle.lu_TransmissionId);
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.lu_VehicleTypes, "Id", "VehicleType", vehicle.lu_VehicleTypeId);
            ViewData["lu_WheelDriveId"] = new SelectList(_context.lu_WheelDrives, "Id", "WheelDrive", vehicle.lu_WheelDriveId);
            ViewData["lu_VehicleStatusId"] = new SelectList(_context.lu_VehicleStatus, "Id", "VehicleStatus");
            ViewData["Vehicles"] = _context.Vehicles;
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Brand,Model,lu_VehicleTypeId,lu_TransmissionId,Color," +
            "lu_FuelTypeId,PlateNo,ConductionNo,InsuranceType,InsuranceDate,LtoRegDate,LtoDueDate,AssignedOfficer,AssignedDriver,IssuedDate,AquisitionDate," +
            "Description,CreatorId,DateCreated,lu_WheelDriveId,lu_VehicleStatusId,EasyTripRFID,AutosweepRFID,Cost")] Vehicle vehicle, IFormFile[] file) //,PassengerSeat,Wheels
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (id != vehicle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    vehicle.ModifierId = new Guid(userId);
                    vehicle.DateModified = DateTime.Now;
                    var folderId = vehicle.Id.ToString().ToUpper();

                    if (file != null)
                    {
                        foreach (IFormFile docu in file)
                        {
                            //Create Directory
                            var currentMonth = DateTime.Now.Year + DateTime.Now.Month;
                            var fileDir = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + folderId);
                            var fileDir2 = Path.Combine("images/" + folderId + "/" + docu.FileName);
                            if (!Directory.Exists(fileDir))
                            {
                                Directory.CreateDirectory(fileDir);
                            }

                            var path = Path.Combine(fileDir, docu.FileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                await docu.CopyToAsync(stream);
                                vehicle.ImagePath = fileDir2;
                            }

                            
                           
                        }
                    }

                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.Id))
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
            ViewData["lu_FuelTypeId"] = new SelectList(_context.lu_FuelTypes, "Id", "FuelName", vehicle.lu_FuelTypeId);
            ViewData["lu_TransmissionId"] = new SelectList(_context.lu_Transmissions, "Id", "TransmissionName", vehicle.lu_TransmissionId);
            ViewData["lu_VehicleTypeId"] = new SelectList(_context.lu_VehicleTypes, "Id", "VehicleType", vehicle.lu_VehicleTypeId);
            ViewData["lu_VehicleStatusId"] = new SelectList(_context.lu_VehicleStatus, "Id", "VehicleStatus");
            ViewData["Vehicles"] = _context.Vehicles;
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles
                .Include(v => v.lu_FuelType)
                .Include(v => v.lu_Transmission)
                .Include(v => v.lu_VehicleType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["Vehicles"] = _context.Vehicles;
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Vehicles == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Vehicles'  is null.");
            }
            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(Guid id)
        {
            return (_context.Vehicles?.Any(e => e.Id == id)).GetValueOrDefault();
        }


        public async Task<IActionResult> History(Guid? id)
        {
            if (id == null || _context.Vehicles == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicles.OrderByDescending(m => m.DateCreated).FirstOrDefaultAsync(m => m.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            ViewData["Maintenance"] = _context.Maintenances.Where(m => m.VehicleId == id);
            ViewData["Vehicles"] = _context.Vehicles;
            return View(vehicle);
        }
        public async Task<IActionResult> AdminSearch()
        {

            int totalVehicles = _context.Vehicles.Count();

            var roleId = "2392f0ce-1c1e-4766-999e-bd99d58ee24a";
            db.Query("exec [dbo].[sp_UserRole] '" + roleId + "'");
            List<string> myListA = new List<string>();
            while (db.Reader.Read())
            { myListA.Add(db.Reader.GetString(0)); }

            ViewData["Vehicles"] = _context.Vehicles;
            ViewData["TotalVehicles"] = totalVehicles;
            ViewData["MotorpoolOfficer"] = myListA.Count();

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "FullDetail");
            //ViewData["TopLTODueDate"] = _context.Vehicles.OrderBy(s => s.LtoDueDate).Take(7);

            List<object> resultListA = new List<object>();
            List<object> resultListB = new List<object>();
            List<object> resultListC = new List<object>();
            List<object> dueDateList = new List<object>();
            List<object> insuranceDateList = new List<object>();

            var typeAcc = "Accidents";
            var typeMain = "Maintenances";

            db.Query("exec [dbo].[sp_chartsCategory] '" + typeAcc + "'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    resultListA.Add(rowData);
                }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_chartsCategory] '" + typeMain + "'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    resultListB.Add(rowData);
                }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_VehicleStatus]");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    resultListC.Add(rowData);
                }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_TopDueDate]");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    dueDateList.Add(rowData);
                }
            }
            db.Con.Close();

            db.Query("exec [dbo].[sp_TopInsuranceDue]");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    insuranceDateList.Add(rowData);
                }
            }
            db.Con.Close();


            ViewData["LTODueDates"] = Json(dueDateList);
            ViewData["InsuranceDueDates"] = Json(insuranceDateList);
            ViewData["AccidentsData"] = Json(resultListA);
            ViewData["MaintenancesData"] = Json(resultListB);
            ViewData["VehiclesData"] = Json(resultListC);


            return View();
        }


        public async Task<IActionResult> AdminView(Guid? id)
        {

            if (id == null || _context.Vehicles == null)
            {
                return RedirectToAction("AdminSearch");
            }

            var vehicle = await _context.Vehicles                
                .Include(v => v.lu_FuelType)
                .Include(v => v.lu_Transmission)
                .Include(v => v.lu_VehicleType)
                .Include(v => v.lu_VehicleStatus)
                .FirstOrDefaultAsync(m => m.Id == id);

            

            if (vehicle == null)
            {
                return RedirectToAction("AdminSearch");
            }

            //Pass Id value to View
            //Guid? MaintId = _context.Maintenances.Where(x => x.VehicleId == id).FirstOrDefault().Id;
            Guid? MaintId = _context.Maintenances.OrderByDescending(m => m.DateCreated).Where(x => x.VehicleId == id).FirstOrDefault()?.Id;

            if (MaintId != null)
            {
                ViewData["MaintenanceId"] = MaintId;
            }
            else
            {
                ViewData["Vehicles"] = _context.Vehicles;
                return View(vehicle);
            }

            ViewData["Maintenance"] = await _context.Maintenances.OrderByDescending(m => m.DateCreated).FirstOrDefaultAsync(m => m.VehicleId == id);
            //ViewData["VehicleId"] = _context.Maintenances.Where(m => m.Id == MaintId).FirstOrDefault().VehicleId;
            if (MaintId.HasValue)
            {
                ViewData["VehicleId"] = _context.Maintenances
                    .Where(m => m.Id == MaintId.Value)
                    .OrderByDescending(m => m.DateCreated)
                    .FirstOrDefault()?.VehicleId;

                //var maintenanceData = _context.Maintenances
                //.Where(m => m.CreatorId == _context.Users.FirstOrDefault(u => u.Id = m.CreatorId).Id)
            }
            else
            {
                ViewData["VehicleId"] = null; // or some default value
            }
            ViewData["VehicleImage"] = _context.Vehicles.Where(m => m.Id == id).FirstOrDefault().ImagePath;
            ViewData["Vehicles"] = _context.Vehicles;

            var VehicleId = _context.Maintenances.Where(m => m.Id == MaintId).OrderByDescending(m => m.DateCreated).FirstOrDefault().VehicleId;

            //Show All Parts with their corresponding Status 
            List<string> myListA = new List<string>();
            List<string> myListB = new List<string>();
            List<string> myListC = new List<string>();
            List<string> myListD = new List<string>();
            List<object[]> myListE = new List<object[]>();
            List<object[]> myListF = new List<object[]>();
            List<object> myListG = new List<object>();



            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','Good for Service'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                { myListA.Add(db.Reader.GetString(0)); }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','For Monitoring'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                { myListB.Add(db.Reader.GetString(0)); }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','Needs Repair'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                { myListC.Add(db.Reader.GetString(0)); }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','Not Available'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                { myListD.Add(db.Reader.GetString(0)); }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_PMSParts] '" + MaintId + "'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    object[] row = new object[db.Reader.FieldCount];
                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {

                        row[i] = db.Reader.GetValue(i);

                    }
                    myListE.Add(row);
                }
            }
            db.Con.Close();
            db.Query("exec [dbo].[sp_PMSTires] '" + MaintId + "'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    object[] row = new object[db.Reader.FieldCount];
                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {

                        row[i] = db.Reader.GetValue(i);

                    }
                    myListF.Add(row);
                }
            }
            db.Con.Close();

            db.Query("exec [dbo].[sp_CurrentVehicleStatus] '" + VehicleId + "'");
            if (db.Reader.HasRows)
            {
                while (db.Reader.Read())
                {
                    var rowData = new Dictionary<string, object>();

                    for (int i = 0; i < db.Reader.FieldCount; i++)
                    {
                        string fieldName = db.Reader.GetName(i);
                        object value = db.Reader.GetValue(i);
                        rowData[fieldName] = value;
                    }
                    myListG.Add(rowData);
                }
            }
            db.Con.Close();

            ViewData["GoodforService"] = myListA;
            ViewData["ForMonitoring"] = myListB;
            ViewData["NeedsRepair"] = myListC;
            ViewData["NotAvailable"] = myListD;
            ViewData["PMSParts"] = myListE;
            ViewData["PMSTires"] = myListF;
            ViewData["CurrentVehicleStatus"] = myListG;
            ViewData["CountVehicleStatus"] = myListG.Count();
            return View(vehicle);
        }









        [HttpPost]
        public IActionResult FilterByBrand(string selectedBrand, string selectedModel, int selectedType,
            int selectedTransmission, string selectedColor, int selectedPassenger, int selectedWheels)
        {
            string Brand = selectedBrand is null ? string.Empty : "'%" + selectedBrand.Trim() + "%'";
            string Model = selectedModel is null ? string.Empty : "'%" + selectedModel.Trim() + "%'";
            string Type = selectedType == 0 ? "'%%'" : "'%" + selectedType.ToString() + "%'";
            string Transmission = selectedTransmission == 0 ? "'%%'" : "'%" + selectedType.ToString() + "%'";
            string Color = selectedColor is null ? string.Empty : "'%" + selectedColor.Trim() + "%'";
            string Passenger = selectedPassenger == 0 ? "'%%'" : "'%" + selectedPassenger.ToString() + "%'";
            string Wheels = selectedWheels == 0 ? "'%%'" : "'%" + selectedWheels.ToString() + "%'";

            var filteredVehicles = _context.Vehicles
                .Where(v =>
                    (selectedBrand == null || v.Brand == selectedBrand) &&
                    (selectedModel == null || v.Model == selectedModel) &&
                    (selectedType == 0 || v.lu_VehicleTypeId == selectedType) &&
                    (selectedTransmission == 0 || v.lu_TransmissionId == selectedTransmission) &&
                    (selectedColor == null || v.Color == selectedColor)
                //(selectedPassenger == 0 || v.PassengerSeat == selectedPassenger) &&
                //(selectedWheels == 0 || v.Wheels == selectedWheels)
                ).Select(v => new { id = v.Id, plateNumber = v.PlateNo, brandName = v.Brand }).ToList();

            return Json(filteredVehicles);
        }

        public IActionResult VehicleTimeline()
        {
            return View();
        }

    }

}
