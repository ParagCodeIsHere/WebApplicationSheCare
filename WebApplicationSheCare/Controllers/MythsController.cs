using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationSheCare.Data;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Controllers
{
    public class MythsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MythsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Myths
        [Authorize]
        public async Task<IActionResult> Index()
        {
              return _context.Myth != null ? 
                          View(await _context.Myth.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Myth'  is null.");
        }

        // GET: Myths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Myth == null)
            {
                return NotFound();
            }

            var myth = await _context.Myth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myth == null)
            {
                return NotFound();
            }

            return View(myth);
        }

        // GET: Myths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Myths/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Text")] Myth myth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myth);
        }

        // GET: Myths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Myth == null)
            {
                return NotFound();
            }

            var myth = await _context.Myth.FindAsync(id);
            if (myth == null)
            {
                return NotFound();
            }
            return View(myth);
        }

        // POST: Myths/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Text")] Myth myth)
        {
            if (id != myth.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MythExists(myth.Id))
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
            return View(myth);
        }

        // GET: Myths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Myth == null)
            {
                return NotFound();
            }

            var myth = await _context.Myth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (myth == null)
            {
                return NotFound();
            }

            return View(myth);
        }

        // POST: Myths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Myth == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Myth'  is null.");
            }
            var myth = await _context.Myth.FindAsync(id);
            if (myth != null)
            {
                _context.Myth.Remove(myth);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MythExists(int id)
        {
          return (_context.Myth?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
