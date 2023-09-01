using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
