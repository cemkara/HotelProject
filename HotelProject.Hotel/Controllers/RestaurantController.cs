using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Restaurant restaurant)
        {
            return View();
        }
    }
}
