using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
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
