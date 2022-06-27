using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PontoApp;
using PontoApp.Models;

namespace PontoApp.Controllers
{
    public class PunchTheClocksController : Controller
    {
        private readonly Context _context;

        public PunchTheClocksController(Context context)
        {
            _context = context;
        }

        // GET: PunchTheClocks
        public async Task<IActionResult> Index()
        {
              return _context.PunchTheClock != null ? 
                          View(await _context.PunchTheClock.ToListAsync()) :
                          Problem("Entity set 'Context.PunchTheClock'  is null.");
        }

        // GET: PunchTheClocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PunchTheClock == null)
            {
                return NotFound();
            }

            var punchTheClock = await _context.PunchTheClock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (punchTheClock == null)
            {
                return NotFound();
            }

            return View(punchTheClock);
        }

        // GET: PunchTheClocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PunchTheClocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,userId,startedIn,finishedIn")] PunchTheClock punchTheClock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(punchTheClock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(punchTheClock);
        }

        // GET: PunchTheClocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PunchTheClock == null)
            {
                return NotFound();
            }

            var punchTheClock = await _context.PunchTheClock.FindAsync(id);
            if (punchTheClock == null)
            {
                return NotFound();
            }
            return View(punchTheClock);
        }

        // POST: PunchTheClocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,userId,startedIn,finishedIn")] PunchTheClock punchTheClock)
        {
            if (id != punchTheClock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(punchTheClock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PunchTheClockExists(punchTheClock.Id))
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
            return View(punchTheClock);
        }

        // GET: PunchTheClocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PunchTheClock == null)
            {
                return NotFound();
            }

            var punchTheClock = await _context.PunchTheClock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (punchTheClock == null)
            {
                return NotFound();
            }

            return View(punchTheClock);
        }

        // POST: PunchTheClocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PunchTheClock == null)
            {
                return Problem("Entity set 'Context.PunchTheClock'  is null.");
            }
            var punchTheClock = await _context.PunchTheClock.FindAsync(id);
            if (punchTheClock != null)
            {
                _context.PunchTheClock.Remove(punchTheClock);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PunchTheClockExists(int id)
        {
          return (_context.PunchTheClock?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
