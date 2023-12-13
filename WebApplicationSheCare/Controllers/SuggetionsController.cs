using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationSheCare.Data;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Controllers
{
    public class SuggetionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuggetionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Suggetions
        public async Task<IActionResult> Index()
        {
              return _context.Suggetions != null ? 
                          View(await _context.Suggetions.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Suggetions'  is null.");
        }

        // GET: Suggetions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Suggetions == null)
            {
                return NotFound();
            }

            var suggetion = await _context.Suggetions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suggetion == null)
            {
                return NotFound();
            }

            return View(suggetion);
        }

        // GET: Suggetions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suggetions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Label,Question,Answer,IsActive")] Suggetion suggetion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(suggetion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suggetion);
        }

        // GET: Suggetions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Suggetions == null)
            {
                return NotFound();
            }

            var suggetion = await _context.Suggetions.FindAsync(id);
            if (suggetion == null)
            {
                return NotFound();
            }
            return View(suggetion);
        }

        // POST: Suggetions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Label,Question,Answer,IsActive")] Suggetion suggetion)
        {
            if (id != suggetion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suggetion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuggetionExists(suggetion.Id))
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
            return View(suggetion);
        }

        // GET: Suggetions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Suggetions == null)
            {
                return NotFound();
            }

            var suggetion = await _context.Suggetions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suggetion == null)
            {
                return NotFound();
            }

            return View(suggetion);
        }

        // POST: Suggetions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Suggetions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Suggetions'  is null.");
            }
            var suggetion = await _context.Suggetions.FindAsync(id);
            if (suggetion != null)
            {
                _context.Suggetions.Remove(suggetion);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuggetionExists(int id)
        {
          return (_context.Suggetions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
