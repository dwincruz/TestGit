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
    public class lu_FuelTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_FuelTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_FuelType
        public async Task<IActionResult> Index()
        {
              return _context.lu_FuelTypes != null ? 
                          View(await _context.lu_FuelTypes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_FuelTypes'  is null.");
        }

        // GET: lu_FuelType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_FuelTypes == null)
            {
                return NotFound();
            }

            var lu_FuelType = await _context.lu_FuelTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_FuelType == null)
            {
                return NotFound();
            }

            return View(lu_FuelType);
        }

        // GET: lu_FuelType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_FuelType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FuelName")] lu_FuelType lu_FuelType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_FuelType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_FuelType);
        }

        // GET: lu_FuelType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_FuelTypes == null)
            {
                return NotFound();
            }

            var lu_FuelType = await _context.lu_FuelTypes.FindAsync(id);
            if (lu_FuelType == null)
            {
                return NotFound();
            }
            return View(lu_FuelType);
        }

        // POST: lu_FuelType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FuelName")] lu_FuelType lu_FuelType)
        {
            if (id != lu_FuelType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_FuelType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_FuelTypeExists(lu_FuelType.Id))
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
            return View(lu_FuelType);
        }

        // GET: lu_FuelType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_FuelTypes == null)
            {
                return NotFound();
            }

            var lu_FuelType = await _context.lu_FuelTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_FuelType == null)
            {
                return NotFound();
            }

            return View(lu_FuelType);
        }

        // POST: lu_FuelType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_FuelTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_FuelTypes'  is null.");
            }
            var lu_FuelType = await _context.lu_FuelTypes.FindAsync(id);
            if (lu_FuelType != null)
            {
                _context.lu_FuelTypes.Remove(lu_FuelType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_FuelTypeExists(int id)
        {
          return (_context.lu_FuelTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
