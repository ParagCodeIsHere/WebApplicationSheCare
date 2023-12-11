using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata;
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

        public IActionResult CreateRequest()
        {
            //var suggetions = (ICollection<Suggetion>)_context.Suggetions;
            return View(_context.Suggetions.ToList());
        }

        public IActionResult GenerateResponse(IList<Suggetion> suggetions)
        {
            //var suggetions = (ICollection<Suggetion>)_context.Suggetions;
            return View(suggetions);
        }

        // POST: SuggetionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRequest(IList<Suggetion> suggetions)
        {
            try
            {
                IList<Suggetion> suggetions1 = suggetions.ToList();
                if (suggetions != null) 
                {
                    var blog = from b in suggetions
                               where b.IsActive == true
                               select b;
                    foreach (var suggetion in blog)
                    {
                        var response =
                        _context.Suggetions.FirstOrDefault(t => t.Id == suggetion.Id);
                        suggetions1.Add(response);
                    }

                    //var blogs = from b in _context.Suggetions
                    //            where b.Id == suggetions[0].Id
                    //            select b;
                    //var blog = from b in suggetions1
                    //           where b.IsActive == true
                    //           select b;
                    //suggetions = blog.ToList();
                    //_user.UserSuggetions = blog.ToList();

                }
                return View("GenerateResponse", suggetions1);
            }
            catch
            {
                return View();
            }
        }

    }
}
