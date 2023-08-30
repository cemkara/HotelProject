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
        public IActionResult NewMenu(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMenu(HotelMenu menu)
        {
            return View();
        }
        public IActionResult UpdateMenu(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateMenu(HotelMenu menu)
        {
            return View();
        }
        public IActionResult MenuProducts(int id)
        {
            return View();
        }

    }
}
