using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Admin.Controllers
{
    public class RestaurantController : Controller
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
        public IActionResult New(Restaurant restaurant)
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
        public IActionResult Update(Restaurant restaurant)
        {
            return View();
        }

        public IActionResult Products(string code)
        {
            return View();
        }
    }
}
