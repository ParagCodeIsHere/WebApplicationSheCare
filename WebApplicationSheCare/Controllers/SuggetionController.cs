using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSheCare.Data;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Controllers
{
    public class SuggetionController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly AppUser _user;

        public SuggetionController(ILogger<HomeController> logger,
                                ApplicationDbContext context,
                                AppUser user)
        {
            _context = context;
            _logger = logger;
            _user= user;
        }

        // GET: SuggetionController
        public IActionResult Index()
        {
            return View();
        }

        // GET: SuggetionController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: SuggetionController/Create
        public IActionResult CreateRequest()
        {
            //var suggetions = (ICollection<Suggetion>)_context.Suggetions;
            return View(_context.Suggetions.ToList());
        }

        // POST: SuggetionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRequest(IList<Suggetion> suggetions)
        {
            try
            {
                
                if (suggetions != null) 
                {
                    _user.UserSuggetions = suggetions;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuggetionController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuggetionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuggetionController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuggetionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
