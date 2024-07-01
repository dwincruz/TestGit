using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;

namespace VMNS.Controllers
{
    //[Authorize(Roles = "SuperAdmin")]
    public class RolesAdminController : BaseController
    {
        private readonly MySqlController db = new MySqlController();

        private readonly RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;
        [ViewData]
        public string Page { get; set; }

        private readonly ApplicationDbContext _context;
        public RolesAdminController(ApplicationDbContext context, RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            this._roleManager = roleManager;
            this._userManager = userManager;
            Page = "Um";
        }

        // GET: RolesAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _context.ApplicationRole.ToListAsync());
        }

        // GET: RolesAdmin/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.ApplicationRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            return View(applicationRole);
        }

        // GET: RolesAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RolesAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id,Name,ConcurrencyStamp")] ApplicationRole applicationRole)
        {
            if (ModelState.IsValid)
            {
                applicationRole.NormalizedName = applicationRole.Name.ToUpper();
                _context.Add(applicationRole);

                string holder = "";
                db.Query("select [NormalizedName] FROM [AspNetRoles] where [Name] = '" + applicationRole.Name.ToUpper() + "'");
                while (db.Reader.Read())
                {
                    holder = db.Reader[0].ToString();
                }

                if (holder != applicationRole.Name.ToUpper())
                {
                    //Notify("Role saved");
                    await _context.SaveChangesAsync();
                }
                else
                {
                    ModelState.AddModelError("", "Role Name already exist.");
                    return View();
                }

                Notify("User Role added successfully.", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            return View(applicationRole);
        }

        // GET: RolesAdmin/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.ApplicationRole.FindAsync(id);
            if (applicationRole == null)
            {
                return NotFound();
            }            
            return View(applicationRole);
        }

        // POST: RolesAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Description,Id,Name,NormalizedName,ConcurrencyStamp")] ApplicationRole applicationRole)
        {
            if (id != applicationRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    applicationRole.NormalizedName = applicationRole.Name.ToUpper();
                    _context.Update(applicationRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationRoleExists(applicationRole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                Notify("User Role updated.", notificationType: NotificationType.info);
                return RedirectToAction(nameof(Index));
            }            
            return View(applicationRole);
        }

        // GET: RolesAdmin/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.ApplicationRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
               
                return NotFound();
            }            
            return View(applicationRole);
        }

        // POST: RolesAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var applicationRole = await _context.ApplicationRole.FindAsync(id);
            _context.ApplicationRole.Remove(applicationRole);
            await _context.SaveChangesAsync();

            Notify("User Role deleted.", notificationType: NotificationType.error);
            return RedirectToAction(nameof(Index));
        }


        private bool ApplicationRoleExists(string id)
        {
            return _context.ApplicationRole.Any(e => e.Id == id);
        }
    }
}
