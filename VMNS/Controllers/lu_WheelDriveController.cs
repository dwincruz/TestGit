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
    [Authorize(Roles = "SysAd")]
    public class lu_WheelDriveController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_WheelDriveController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_WheelDrive
        public async Task<IActionResult> Index()
        {
              return _context.lu_WheelDrives != null ? 
                          View(await _context.lu_WheelDrives.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_WheelDrives'  is null.");
        }

        // GET: lu_WheelDrive/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_WheelDrives == null)
            {
                return NotFound();
            }

            var lu_WheelDrive = await _context.lu_WheelDrives
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_WheelDrive == null)
            {
                return NotFound();
            }

            return View(lu_WheelDrive);
        }

        // GET: lu_WheelDrive/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_WheelDrive/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WheelDrive")] lu_WheelDrive lu_WheelDrive)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_WheelDrive);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_WheelDrive);
        }

        // GET: lu_WheelDrive/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_WheelDrives == null)
            {
                return NotFound();
            }

            var lu_WheelDrive = await _context.lu_WheelDrives.FindAsync(id);
            if (lu_WheelDrive == null)
            {
                return NotFound();
            }
            return View(lu_WheelDrive);
        }

        // POST: lu_WheelDrive/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WheelDrive")] lu_WheelDrive lu_WheelDrive)
        {
            if (id != lu_WheelDrive.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_WheelDrive);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_WheelDriveExists(lu_WheelDrive.Id))
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
            return View(lu_WheelDrive);
        }

        // GET: lu_WheelDrive/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_WheelDrives == null)
            {
                return NotFound();
            }

            var lu_WheelDrive = await _context.lu_WheelDrives
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_WheelDrive == null)
            {
                return NotFound();
            }

            return View(lu_WheelDrive);
        }

        // POST: lu_WheelDrive/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_WheelDrives == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_WheelDrives'  is null.");
            }
            var lu_WheelDrive = await _context.lu_WheelDrives.FindAsync(id);
            if (lu_WheelDrive != null)
            {
                _context.lu_WheelDrives.Remove(lu_WheelDrive);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_WheelDriveExists(int id)
        {
          return (_context.lu_WheelDrives?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
