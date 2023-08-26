using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Admin.Controllers
{
    public class HotelController : Controller
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
        public IActionResult New(Hotel hotel)
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
        public IActionResult Update(Hotel hotel)
        {
            return View();
        }

        public IActionResult Menu(string code)
        {
            return View();
        }
        public IActionResult Restaurants(string code)
        {
            return View();
        }
        public IActionResult Users(string code)
        {
            return View();
        }
    }
}
