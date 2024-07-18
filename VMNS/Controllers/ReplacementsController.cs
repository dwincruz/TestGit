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
    public class ReplacementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReplacementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Replacements
        public async Task<IActionResult> Index()
        {
              return _context.Replacements != null ? 
                          View(await _context.Replacements.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Replacements'  is null.");
        }

        // GET: Replacements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Replacements == null)
            {
                return NotFound();
            }

            var replacement = await _context.Replacements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (replacement == null)
            {
                return NotFound();
            }

            return View(replacement);
        }

        // GET: Replacements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Replacements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Parts,DurationInKM,DurationInDays")] Replacement replacement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(replacement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(replacement);
        }

        // GET: Replacements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Replacements == null)
            {
                return NotFound();
            }

            var replacement = await _context.Replacements.FindAsync(id);
            if (replacement == null)
            {
                return NotFound();
            }
            return View(replacement);
        }

        // POST: Replacements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Parts,DurationInKM,DurationInDays")] Replacement replacement)
        {
            if (id != replacement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(replacement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReplacementExists(replacement.Id))
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
            return View(replacement);
        }

        // GET: Replacements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Replacements == null)
            {
                return NotFound();
            }

            var replacement = await _context.Replacements
                .FirstOrDefaultAsync(m => m.Id == id);
            if (replacement == null)
            {
                return NotFound();
            }

            return View(replacement);
        }

        // POST: Replacements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Replacements == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Replacements'  is null.");
            }
            var replacement = await _context.Replacements.FindAsync(id);
            if (replacement != null)
            {
                _context.Replacements.Remove(replacement);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReplacementExists(int id)
        {
          return (_context.Replacements?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
