using HotelProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HotelProject.Admin.Controllers
{
    public class HotelController : Controller
    {
        private readonly Context db = new Context();
        private readonly UserManager<MyUser> userManager;

        public HotelController(UserManager<MyUser> _userManager)
        {
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            List<SelectListItem> users = (from x in db.Users.Where(x => x.StatusId == 1 && x.UserTypeId == 2).ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.Id.ToString()
                                          }).ToList();

            List<SelectListItem> districts = (from x in db.Districts.ToList()
                                              select new SelectListItem
                                              {
                                                  Text = x.DistrictName,
                                                  Value = x.DistrictId.ToString()
                                              }).ToList();

            List<SelectListItem> statuses = (from x in db.Statuses.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.StatusId.ToString()
                                             }).ToList();

            ViewBag.Users = users;
            ViewBag.Districts = districts;
            ViewBag.Statuses = statuses;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> New(IFormFile hotelLogo, HotelViewModel hotel)
        {
            if (true)
            {
                string fileName, filePath;

                if (hotelLogo != null && hotelLogo.Length > 0)
                {
                    fileName = hotel.Name + " Logo -" + Guid.NewGuid() + Path.GetExtension(hotelLogo.FileName);
                    filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/hotels",
                        fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        hotelLogo.CopyTo(fileStream);
                    }
                }
                else
                {
                    fileName = "unknow.png";
                }

                Address address = new Address();
                address.District = db.Districts.Find(hotel.SelectedDistrictId);
                address.Street = hotel.AddressText;
                hotel.Address = db.Add(address).Entity;

                hotel.Status = db.Statuses.Find(hotel.SelectedStatusId);
                hotel.LogoUrl = fileName;

                HotelEmail hotelEmail = new HotelEmail();
                hotelEmail.Email = new Email { Mail = hotel.Email, Status = hotel.Status, RecordDate = DateTime.Now };
                hotel.HotelEmails.Add(hotelEmail);

                HotelPhoneNumber hotelPhone = new HotelPhoneNumber();
                hotelPhone.PhoneNumber = new PhoneNumber { Number = hotel.Phone, Status = hotel.Status, RecordDate = DateTime.Now };
                hotel.HotelPhoneNumbers.Add(hotelPhone);

                hotel.RecordDate = DateTime.Now;

                var user = db.Users.Find(hotel.SelectedUserId);
                hotel.Users.Add(user);

                db.Add(hotel);

                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
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
        public IActionResult NewRestaurant(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewRestaurant(Restaurant restaurant)
        {
            return View();
        }

    }
}
