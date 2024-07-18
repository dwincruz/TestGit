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
    public class lu_TransmissionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_TransmissionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_Transmission
        public async Task<IActionResult> Index()
        {
              return _context.lu_Transmissions != null ? 
                          View(await _context.lu_Transmissions.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.lu_Transmissions'  is null.");
        }

        // GET: lu_Transmission/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_Transmissions == null)
            {
                return NotFound();
            }

            var lu_Transmission = await _context.lu_Transmissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Transmission == null)
            {
                return NotFound();
            }

            return View(lu_Transmission);
        }

        // GET: lu_Transmission/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_Transmission/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TransmissionName")] lu_Transmission lu_Transmission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_Transmission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_Transmission);
        }

        // GET: lu_Transmission/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_Transmissions == null)
            {
                return NotFound();
            }

            var lu_Transmission = await _context.lu_Transmissions.FindAsync(id);
            if (lu_Transmission == null)
            {
                return NotFound();
            }
            return View(lu_Transmission);
        }

        // POST: lu_Transmission/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TransmissionName")] lu_Transmission lu_Transmission)
        {
            if (id != lu_Transmission.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_Transmission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_TransmissionExists(lu_Transmission.Id))
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
            return View(lu_Transmission);
        }

        // GET: lu_Transmission/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_Transmissions == null)
            {
                return NotFound();
            }

            var lu_Transmission = await _context.lu_Transmissions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Transmission == null)
            {
                return NotFound();
            }

            return View(lu_Transmission);
        }

        // POST: lu_Transmission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_Transmissions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_Transmissions'  is null.");
            }
            var lu_Transmission = await _context.lu_Transmissions.FindAsync(id);
            if (lu_Transmission != null)
            {
                _context.lu_Transmissions.Remove(lu_Transmission);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_TransmissionExists(int id)
        {
          return (_context.lu_Transmissions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
