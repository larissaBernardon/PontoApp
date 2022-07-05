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
    public class SolicitationsController : Controller
    {
        private readonly Context _context;

        public SolicitationsController(Context context)
        {
            _context = context;
        }

        // GET: Solicitations
        public async Task<IActionResult> Index()
        {
              return _context.Solicitations != null ? 
                          View(await _context.Solicitations.ToListAsync()) :
                          Problem("Entity set 'Context.Solicitations'  is null.");
        }

        // GET: Solicitations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Solicitations == null)
            {
                return NotFound();
            }

            var solicitations = await _context.Solicitations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitations == null)
            {
                return NotFound();
            }

            return View(solicitations);
        }

        // GET: Solicitations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solicitations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,createdAt")] Solicitations solicitations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitations);
        }

        // GET: Solicitations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Solicitations == null)
            {
                return NotFound();
            }

            var solicitations = await _context.Solicitations.FindAsync(id);
            if (solicitations == null)
            {
                return NotFound();
            }
            return View(solicitations);
        }

        // POST: Solicitations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,createdAt")] Solicitations solicitations)
        {
            if (id != solicitations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitationsExists(solicitations.Id))
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
            return View(solicitations);
        }

        // GET: Solicitations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Solicitations == null)
            {
                return NotFound();
            }

            var solicitations = await _context.Solicitations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (solicitations == null)
            {
                return NotFound();
            }

            return View(solicitations);
        }

        // POST: Solicitations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Solicitations == null)
            {
                return Problem("Entity set 'Context.Solicitations'  is null.");
            }
            var solicitations = await _context.Solicitations.FindAsync(id);
            if (solicitations != null)
            {
                _context.Solicitations.Remove(solicitations);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitationsExists(int id)
        {
          return (_context.Solicitations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
