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
    public class lu_VehicleTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_VehicleTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_VehicleType
        public async Task<IActionResult> Index()
        {
              return _context.lu_VehicleTypes != null ? 
                          View(await _context.lu_VehicleTypes.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_VehicleTypes'  is null.");
        }

        // GET: lu_VehicleType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_VehicleTypes == null)
            {
                return NotFound();
            }

            var lu_VehicleType = await _context.lu_VehicleTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_VehicleType == null)
            {
                return NotFound();
            }

            return View(lu_VehicleType);
        }

        // GET: lu_VehicleType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_VehicleType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleType")] lu_VehicleType lu_VehicleType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_VehicleType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_VehicleType);
        }

        // GET: lu_VehicleType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_VehicleTypes == null)
            {
                return NotFound();
            }

            var lu_VehicleType = await _context.lu_VehicleTypes.FindAsync(id);
            if (lu_VehicleType == null)
            {
                return NotFound();
            }
            return View(lu_VehicleType);
        }

        // POST: lu_VehicleType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleType")] lu_VehicleType lu_VehicleType)
        {
            if (id != lu_VehicleType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_VehicleType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_VehicleTypeExists(lu_VehicleType.Id))
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
            return View(lu_VehicleType);
        }

        // GET: lu_VehicleType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_VehicleTypes == null)
            {
                return NotFound();
            }

            var lu_VehicleType = await _context.lu_VehicleTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_VehicleType == null)
            {
                return NotFound();
            }

            return View(lu_VehicleType);
        }

        // POST: lu_VehicleType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_VehicleTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_VehicleTypes'  is null.");
            }
            var lu_VehicleType = await _context.lu_VehicleTypes.FindAsync(id);
            if (lu_VehicleType != null)
            {
                _context.lu_VehicleTypes.Remove(lu_VehicleType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_VehicleTypeExists(int id)
        {
          return (_context.lu_VehicleTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
