using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(string code)
        {
            return View(code);
        }
    }
}
