using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cine.Models;

namespace Cine.Controllers
{
    public class CinesController : Controller
    {
        private readonly CineContext _context;

        public CinesController(CineContext context)
        {
            _context = context;
        }

        // GET: Cines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cines.ToListAsync());
        }

        // GET: Cines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines
                .FirstOrDefaultAsync(m => m.cineID == id);
            if (cine == null)
            {
                return NotFound();
            }

            return View(cine);
        }

        // GET: Cines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cineID,nombre")] Cine.Models.Cine cine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cine);
        }

        // GET: Cines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines.FindAsync(id);
            if (cine == null)
            {
                return NotFound();
            }
            return View(cine);
        }

        // POST: Cines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cineID,nombre")] Cine.Models.Cine cine)
        {
            if (id != cine.cineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CineExists(cine.cineID))
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
            return View(cine);
        }

        // GET: Cines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines
                .FirstOrDefaultAsync(m => m.cineID == id);
            if (cine == null)
            {
                return NotFound();
            }

            return View(cine);
        }

        // POST: Cines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cine = await _context.Cines.FindAsync(id);
            _context.Cines.Remove(cine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CineExists(int id)
        {
            return _context.Cines.Any(e => e.cineID == id);
        }
    }
}
