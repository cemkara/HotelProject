using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
{
    public class MenuController : Controller
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
        public IActionResult New(HotelMenu menu)
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(HotelMenu menu)
        {
            return View();
        }
        public IActionResult Products(int id)
        {
            return View();
        }
        public IActionResult NewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewProduct(HotelMenuProduct hotelMenuProduct)
        {
            return View();
        }

        public IActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateProduct(HotelMenuProduct hotelMenuProduct)
        {
            return View();
        }


    }
}
