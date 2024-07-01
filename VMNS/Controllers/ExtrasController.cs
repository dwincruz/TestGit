using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Migrations;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class ExtrasController : BaseController
    {
        private readonly ApplicationDbContext _context;

        public ExtrasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Extras
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Extras.Include(e => e.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Extras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Extras == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras
                .Include(e => e.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extra == null)
            {
                return NotFound();
            }

            return View(extra);
        }

        // GET: Extras/Create
        public IActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo");
            return View();
        }

        // POST: Extras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,Tools,Remarks,Manuals,SpareTires")] Extra extra)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                extra.CreatorId = new Guid(userId);
                extra.ModifierId = new Guid(userId);
                extra.DateCreated = DateTime.Now;
                extra.DateModified = DateTime.Now;
                _context.Add(extra);
                await _context.SaveChangesAsync();

                Notify("Record added successfully.", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", extra.VehicleId);
            return View(extra);
        }

        // GET: Extras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Extras == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras.FindAsync(id);
            if (extra == null)
            {
                return NotFound();
            }
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", extra.VehicleId);
            return View(extra);
        }

        // POST: Extras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleId,Tools,Remarks,Manuals,SpareTires,ModifierId,DateModified")] Extra extra)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (id != extra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    extra.ModifierId = new Guid(userId);
                    extra.DateModified = DateTime.Now;
                    _context.Update(extra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtraExists(extra.Id))
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
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "PlateNo", extra.VehicleId);
            return View(extra);
        }

        // GET: Extras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Extras == null)
            {
                return NotFound();
            }

            var extra = await _context.Extras
                .Include(e => e.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (extra == null)
            {
                return NotFound();
            }

            return View(extra);
        }

        // POST: Extras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Extras == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Extras'  is null.");
            }
            var extra = await _context.Extras.FindAsync(id);
            if (extra != null)
            {
                _context.Extras.Remove(extra);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtraExists(int id)
        {
          return (_context.Extras?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
