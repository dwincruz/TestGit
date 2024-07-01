using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;

namespace VMNS.Controllers
{
    public class lu_EquipmentStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_EquipmentStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_EquipmentStatus
        public async Task<IActionResult> Index()
        {
              return _context.lu_EquipmentStatus != null ? 
                          View(await _context.lu_EquipmentStatus.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_EquipmentStatus'  is null.");
        }

        // GET: lu_EquipmentStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_EquipmentStatus == null)
            {
                return NotFound();
            }

            var lu_EquipmentStatus = await _context.lu_EquipmentStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_EquipmentStatus == null)
            {
                return NotFound();
            }

            return View(lu_EquipmentStatus);
        }

        // GET: lu_EquipmentStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_EquipmentStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] lu_EquipmentStatus lu_EquipmentStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_EquipmentStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_EquipmentStatus);
        }

        // GET: lu_EquipmentStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_EquipmentStatus == null)
            {
                return NotFound();
            }

            var lu_EquipmentStatus = await _context.lu_EquipmentStatus.FindAsync(id);
            if (lu_EquipmentStatus == null)
            {
                return NotFound();
            }
            return View(lu_EquipmentStatus);
        }

        // POST: lu_EquipmentStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] lu_EquipmentStatus lu_EquipmentStatus)
        {
            if (id != lu_EquipmentStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_EquipmentStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_EquipmentStatusExists(lu_EquipmentStatus.Id))
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
            return View(lu_EquipmentStatus);
        }

        // GET: lu_EquipmentStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_EquipmentStatus == null)
            {
                return NotFound();
            }

            var lu_EquipmentStatus = await _context.lu_EquipmentStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_EquipmentStatus == null)
            {
                return NotFound();
            }

            return View(lu_EquipmentStatus);
        }

        // POST: lu_EquipmentStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_EquipmentStatus == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_EquipmentStatus'  is null.");
            }
            var lu_EquipmentStatus = await _context.lu_EquipmentStatus.FindAsync(id);
            if (lu_EquipmentStatus != null)
            {
                _context.lu_EquipmentStatus.Remove(lu_EquipmentStatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_EquipmentStatusExists(int id)
        {
          return (_context.lu_EquipmentStatus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
