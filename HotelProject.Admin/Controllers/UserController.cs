using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(User user)
        {
            return View();
        }
        public IActionResult Details(string code)
        {
            return View(code);
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(User user)
        {
            return View();
        }

        public IActionResult Hotels(string code)
        {
            return View();
        }
        public IActionResult Restaurants(string code)
        {
            return View();
        }
    }
}
