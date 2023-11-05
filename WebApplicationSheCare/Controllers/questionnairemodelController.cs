using Microsoft.AspNetCore.Mvc;
using WebApplicationSheCare.Data;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Controllers
{
    public class questionnairemodelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public questionnairemodelController(ApplicationDbContext context)
        {
            _context = context;
        }
        //suggetion branch check
        public IActionResult GetSuggetions() { 
            questionnairemodel model = new questionnairemodel();
            model.UserId = 1;
            return View(model);
        }
    }
}
