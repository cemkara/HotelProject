using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Admin.Controllers
{
    public class ReportController : Controller
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
        public IActionResult New(Report report)
        {
            return View();
        }
    }
}
