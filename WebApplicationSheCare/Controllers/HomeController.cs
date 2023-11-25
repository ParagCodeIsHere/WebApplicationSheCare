using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplicationSheCare.Data;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,
                                ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SuggetionForm() {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> SuggetionIndexAsync()
        {
            return _context.Suggetions != null ?
                          View(await _context.Suggetions.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Suggetion'  is null.");
        }
        [Authorize]
        public async Task<IActionResult> SuggetionAsync(int id = 0)
        {
            Suggetion suggetion = new Suggetion();
            if (id != 0)
            {
                suggetion = await _context.Suggetions
                .FirstOrDefaultAsync(m => m.Id == id);
                if (suggetion == null)
                {
                    return NotFound();
                }
                return View(suggetion);
            }
            return View(suggetion);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Suggetion(int id, [Bind("Id,Question,Answer")] Suggetion suggetion)
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
                    ViewBag.Status = "Saved!";
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
                return RedirectToAction(nameof(SuggetionIndexAsync));
            }
            return View(suggetion);
        }
        [Authorize]
        public async Task<IActionResult> DeleteSuggetion(int? id)
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
        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("DeleteSuggetion")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteSuggetionConfirmed(int id)
        {
            if (_context.Suggetions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Suggetion'  is null.");
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