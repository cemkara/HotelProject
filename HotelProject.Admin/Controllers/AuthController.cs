using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Admin.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }
    }
}
