using VMNS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using VMNS.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using VMNS.Migrations;
using Newtonsoft.Json;

namespace VMNS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly MySqlController db = new MySqlController();


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Administrator"))
            {
                return RedirectToAction("AdminView", "Vehicles");
            }

           


            var roleId = "2392f0ce-1c1e-4766-999e-bd99d58ee24a";
            db.Query("exec [dbo].[sp_UserRole] '" + roleId + "'");
            List<string> myListA = new List<string>();
            while (db.Reader.Read())
            { myListA.Add(db.Reader.GetString(0)); }

            int totalVehicles = _context.Vehicles.Count();
            int totalUsers = _context.Users.Count();


            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "FullDetail");
            ViewData["MotorpoolOfficer"] = myListA.Count();
            ViewData["TotalVehicles"] = totalVehicles;
            
            return View();
        }


        [HttpPost]
        public IActionResult VehicleMaintenanceInfo([FromBody] string vehicleId)
        {
            try
            {
                if (string.IsNullOrEmpty(vehicleId))
                {
                    return BadRequest("Vehicle ID is null or empty.");
                }

                //db.Query("exec [dbo].[sp_VehicleMaintenanceInfo] '" + vehicleId + "'" + "'" + "'");

                db.Query("exec [dbo].[sp_VehicleMaintenanceInfo] '" + vehicleId + "','MaintenanceInfo'");
                List<object> resultList = new List<object>();

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
                        resultList.Add(rowData);
                    }
                }
                return Json(resultList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        public IActionResult PartsCondition([FromBody] string MaintId)
        {
            List<object> myListA = new List<object>();
            List<object> myListB = new List<object>();

            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','For Monitoring'");
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
                    myListA.Add(rowData);
                }
            }

            db.Query("exec [dbo].[sp_Show] '" + MaintId + "','Needs Repair'");
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
                    myListB.Add(rowData);
                }
            }

            return Ok(new { myListA, myListB });
        }

        public IActionResult VehicleGeneralInfo([FromBody] string vehicleId)
        {
            try
            {
                if (string.IsNullOrEmpty(vehicleId))
                {
                    return BadRequest("Vehicle ID is null or empty.");
                }
                db.Query("exec [dbo].[sp_VehicleMaintenanceInfo] '" + vehicleId + "','GeneralInfo'");
                List<object> resultList = new List<object>();

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
                        resultList.Add(rowData);
                    }
                }
                return Json(resultList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}