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
    public class lu_WheelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_WheelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_Wheel
        public async Task<IActionResult> Index()
        {
              return _context.lu_Wheels != null ? 
                          View(await _context.lu_Wheels.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_Wheels'  is null.");
        }

        // GET: lu_Wheel/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_Wheels == null)
            {
                return NotFound();
            }

            var lu_Wheel = await _context.lu_Wheels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Wheel == null)
            {
                return NotFound();
            }

            return View(lu_Wheel);
        }

        // GET: lu_Wheel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_Wheel/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WheelPosition")] lu_Wheel lu_Wheel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_Wheel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_Wheel);
        }

        // GET: lu_Wheel/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_Wheels == null)
            {
                return NotFound();
            }

            var lu_Wheel = await _context.lu_Wheels.FindAsync(id);
            if (lu_Wheel == null)
            {
                return NotFound();
            }
            return View(lu_Wheel);
        }

        // POST: lu_Wheel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WheelPosition")] lu_Wheel lu_Wheel)
        {
            if (id != lu_Wheel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_Wheel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_WheelExists(lu_Wheel.Id))
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
            return View(lu_Wheel);
        }

        // GET: lu_Wheel/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_Wheels == null)
            {
                return NotFound();
            }

            var lu_Wheel = await _context.lu_Wheels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Wheel == null)
            {
                return NotFound();
            }

            return View(lu_Wheel);
        }

        // POST: lu_Wheel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_Wheels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_Wheels'  is null.");
            }
            var lu_Wheel = await _context.lu_Wheels.FindAsync(id);
            if (lu_Wheel != null)
            {
                _context.lu_Wheels.Remove(lu_Wheel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_WheelExists(int id)
        {
          return (_context.lu_Wheels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
