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
    [Authorize]
    public class lu_DamageScaleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_DamageScaleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_DamageScale
        public async Task<IActionResult> Index()
        {
              return _context.lu_DamageScales != null ? 
                          View(await _context.lu_DamageScales.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_DamageScales'  is null.");
        }

        // GET: lu_DamageScale/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_DamageScales == null)
            {
                return NotFound();
            }

            var lu_DamageScale = await _context.lu_DamageScales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_DamageScale == null)
            {
                return NotFound();
            }

            return View(lu_DamageScale);
        }

        // GET: lu_DamageScale/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_DamageScale/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DamageScale")] lu_DamageScale lu_DamageScale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_DamageScale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_DamageScale);
        }

        // GET: lu_DamageScale/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_DamageScales == null)
            {
                return NotFound();
            }

            var lu_DamageScale = await _context.lu_DamageScales.FindAsync(id);
            if (lu_DamageScale == null)
            {
                return NotFound();
            }
            return View(lu_DamageScale);
        }

        // POST: lu_DamageScale/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DamageScale")] lu_DamageScale lu_DamageScale)
        {
            if (id != lu_DamageScale.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_DamageScale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_DamageScaleExists(lu_DamageScale.Id))
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
            return View(lu_DamageScale);
        }

        // GET: lu_DamageScale/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_DamageScales == null)
            {
                return NotFound();
            }

            var lu_DamageScale = await _context.lu_DamageScales
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_DamageScale == null)
            {
                return NotFound();
            }

            return View(lu_DamageScale);
        }

        // POST: lu_DamageScale/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_DamageScales == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_DamageScales'  is null.");
            }
            var lu_DamageScale = await _context.lu_DamageScales.FindAsync(id);
            if (lu_DamageScale != null)
            {
                _context.lu_DamageScales.Remove(lu_DamageScale);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_DamageScaleExists(int id)
        {
          return (_context.lu_DamageScales?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
