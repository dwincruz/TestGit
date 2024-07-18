using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.ViewModels;
using Newtonsoft.Json.Linq;
using VMNS.Models;

namespace VMNS.Controllers
{
    [Authorize(Roles = "SysAd")]
    public class UsersAdminController : BaseController
    {
        //private readonly ApplicationDbContext _context;

        private readonly RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;
        [ViewData]
        public string Page { get; set; }
        private readonly ApplicationDbContext _context;

        public UsersAdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            this._roleManager = roleManager;
            this._userManager = userManager;
            Page = "Um";
        }

        // GET: /Users/
        public async Task<IActionResult> Index()
        {            
            var userManager = _context.Users.Include(g => g.Office);
            return View(await userManager.ToListAsync());
        }

        // GET: UsersAdminController/Details/5
        public async Task<ActionResult> Details(string id)
        {
            //var roles = new List<string>();
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.Users.Include(r => r.Office).FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.RoleNames = await _userManager.GetRolesAsync(user);

            return View(user);
        }

        // GET: /Users/Create
        public async Task<ActionResult> Create()
        {
            var user = new ApplicationUser();
            ViewData["OfficeId"] = new SelectList(_context.lu_Offices, "Id", "OfficeName", user.OfficeId);
            //Get the list of Roles
            ViewBag.RoleId = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public async Task<ActionResult> Create(RegisterViewModel userViewModel, params string[] selectedRoles)
        {
            var Modifier = User.Identity.Name;
            var user = new ApplicationUser
            {
                UserName = userViewModel.UserName,
                Email = userViewModel.Email,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName,
                Position = userViewModel.Position,
                OfficeId = userViewModel.OfficeId,
                EmpNo = userViewModel.EmpNo,
                DateCreated = DateTime.Today
            };


            // Then create:
            var adminresult = await _userManager.CreateAsync(user, userViewModel.Password);
            Notify("Account added successfully.", notificationType: NotificationType.success);

            if (ModelState.IsValid)
            {       
                //Add User to the selected Roles 
                if (adminresult.Succeeded)
                {
                    if (selectedRoles != null)
                    {
                        var result = await _userManager.AddToRolesAsync(user, selectedRoles);
                        if (!result.Succeeded)
                        {
                            ModelState.AddModelError("", result.Errors.First().ToString());
                            ViewData["OfficeId"] = new SelectList(_context.lu_Offices, "Id", "OfficeName", user.OfficeId);
                            ViewBag.RoleId = new SelectList(await _roleManager.Roles.ToListAsync(), "Name", "Name");

                            return View();
                        }
                    }

                    //JObject obj = (JObject)JToken.FromObject(user);
                    //CreateFile(obj);
                }
                else
                {
                    //ModelState.AddModelError("", adminresult.Errors.First().ToString());
                    ModelState.AddModelError("", "Username already exist.");
                    ViewData["OfficeId"] = new SelectList(_context.lu_Offices, "Id", "OfficeName", user.OfficeId);
                    ViewBag.RoleId = new SelectList(_roleManager.Roles, "Name", "Name");
                    return View();

                }
                return RedirectToAction("Index");
            }
            ViewData["OfficeId"] = new SelectList(_context.lu_Offices, "Id", "OfficeName", user.OfficeId);
            ViewBag.RoleId = new SelectList(_roleManager.Roles, "Name", "Name");
            return View();
        }

        //private void CreateFile(JObject obj)
        //{
        //    string uploadDir = Path.Combine("D:\\xampp\\htdocs\\dts\\", "json/insert_users");
        //    var filename = Guid.NewGuid().ToString() + ".json";
        //    string filePath = Path.Combine(uploadDir, filename);
        //    System.IO.File.WriteAllText(filePath, obj.ToString());
        //}

        // GET: /Users/Edit/1
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            ViewBag.RoleId = new SelectList(_roleManager.Roles, "Name", "Name");

            ViewData["OfficeId"] = new SelectList(_context.lu_Offices, "Id", "OfficeName", user.OfficeId);
            return View(new EditUserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                EmpNo = user.EmpNo,
                Position = user.Position,
                OfficeId = user.OfficeId,

                RolesList = _roleManager.Roles.ToList().Select(x => new SelectListItem()
                {
                    Selected = userRoles.Contains(x.Name),
                    Text = x.Name,
                    Value = x.Name
                })
            });

        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind("Id,Email,UserName,FirstName,LastName,Position,OfficeId,EmpNo")] EditUserViewModel editUser, params string[] selectedRole)
        {
            var Modifier = User.Identity.Name;

            if (ModelState.IsValid || !ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(editUser.Id);
                if (user == null)
                {
                    return NotFound();
                }

                // Add the other Info:
                user.Email = editUser.Email;
                user.UserName = editUser.UserName;
                user.FirstName = editUser.FirstName;
                user.LastName = editUser.LastName;
                user.Position = editUser.Position;
                user.OfficeId = editUser.OfficeId;
                user.EmpNo = editUser.EmpNo;

                var userRoles = await _userManager.GetRolesAsync(user);

                selectedRole = selectedRole ?? new string[] { };

                var result = await _userManager.AddToRolesAsync(user, selectedRole.Except(userRoles).ToArray<string>());

                if (!result.Succeeded)
                {
                    //ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRole).ToArray<string>());

                if (!result.Succeeded)
                {
                    //ModelState.AddModelError("", result.Errors.First());
                    return View();
                }

                Notify("User updated.", notificationType: NotificationType.info);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Something failed.");
            return View();
        }

        // GET: UsersAdminController/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users.Include(r => r.Office)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // POST: UsersAdminController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            Notify("User deleted.", notificationType: NotificationType.error);
            return RedirectToAction(nameof(Index));
        }

    }
}
