using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMNS.Areas.Identity.Data;
using VMNS.Models;
using Microsoft.AspNetCore.Authorization;

namespace VMNS.Controllers
{
    
    [Authorize(Roles = "SysAd")]
    public class lu_OfficeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public lu_OfficeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: lu_Office
        public async Task<IActionResult> Index()
        {
              return View(await _context.lu_Offices.ToListAsync());
        }

        // GET: lu_Office/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.lu_Offices == null)
            {
                return NotFound();
            }

            var lu_Office = await _context.lu_Offices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Office == null)
            {
                return NotFound();
            }

            return View(lu_Office);
        }

        // GET: lu_Office/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lu_Office/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,OfficeCode,OfficeName")] lu_Office lu_Office)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lu_Office);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lu_Office);
        }

        // GET: lu_Office/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.lu_Offices == null)
            {
                return NotFound();
            }

            var lu_Office = await _context.lu_Offices.FindAsync(id);
            if (lu_Office == null)
            {
                return NotFound();
            }
            return View(lu_Office);
        }

        // POST: lu_Office/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OfficeCode,OfficeName")] lu_Office lu_Office)
        {
            if (id != lu_Office.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lu_Office);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lu_OfficeExists(lu_Office.Id))
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
            return View(lu_Office);
        }

        // GET: lu_Office/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.lu_Offices == null)
            {
                return NotFound();
            }

            var lu_Office = await _context.lu_Offices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lu_Office == null)
            {
                return NotFound();
            }

            return View(lu_Office);
        }

        // POST: lu_Office/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.lu_Offices == null)
            {
                return Problem("Entity set 'ApplicationDbContext.lu_Offices'  is null.");
            }
            var lu_Office = await _context.lu_Offices.FindAsync(id);
            if (lu_Office != null)
            {
                _context.lu_Offices.Remove(lu_Office);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lu_OfficeExists(int id)
        {
          return _context.lu_Offices.Any(e => e.Id == id);
        }
    }
}
