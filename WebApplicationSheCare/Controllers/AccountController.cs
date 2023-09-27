using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSheCare.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
