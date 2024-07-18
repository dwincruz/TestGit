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
    public class lu_VehicleStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_VehicleStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_VehicleStatus
        public async Task<IActionResult> Index()
        {
              return _context.lu_VehicleStatus != null ? 
                          View(await _context.lu_VehicleStatus.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_VehicleStatus'  is null.");
        }

        // GET: lu_VehicleStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_VehicleStatus == null)
            {
                return NotFound();
            }

            var lu_VehicleStatus = await _context.lu_VehicleStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_VehicleStatus == null)
            {
                return NotFound();
            }

            return View(lu_VehicleStatus);
        }

        // GET: lu_VehicleStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_VehicleStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleStatus")] lu_VehicleStatus lu_VehicleStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_VehicleStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_VehicleStatus);
        }

        // GET: lu_VehicleStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_VehicleStatus == null)
            {
                return NotFound();
            }

            var lu_VehicleStatus = await _context.lu_VehicleStatus.FindAsync(id);
            if (lu_VehicleStatus == null)
            {
                return NotFound();
            }
            return View(lu_VehicleStatus);
        }

        // POST: lu_VehicleStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleStatus")] lu_VehicleStatus lu_VehicleStatus)
        {
            if (id != lu_VehicleStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_VehicleStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_VehicleStatusExists(lu_VehicleStatus.Id))
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
            return View(lu_VehicleStatus);
        }

        // GET: lu_VehicleStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_VehicleStatus == null)
            {
                return NotFound();
            }

            var lu_VehicleStatus = await _context.lu_VehicleStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_VehicleStatus == null)
            {
                return NotFound();
            }

            return View(lu_VehicleStatus);
        }

        // POST: lu_VehicleStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_VehicleStatus == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_VehicleStatus'  is null.");
            }
            var lu_VehicleStatus = await _context.lu_VehicleStatus.FindAsync(id);
            if (lu_VehicleStatus != null)
            {
                _context.lu_VehicleStatus.Remove(lu_VehicleStatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_VehicleStatusExists(int id)
        {
          return (_context.lu_VehicleStatus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
