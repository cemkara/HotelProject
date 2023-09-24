using HotelProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace HotelProject.Admin.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly Context db = new Context();

        public IActionResult Index(int page = 1, string search = "", int status = 0)
        {
            var query = db.Restaurants.Include(x => x.Status).Include(x => x.Users).Include(x => x.RestaurantType).ToList();

            if (status != 0)
            {
                query = query.Where(x => x.Status.StatusId == status).ToList();
            }

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            var list = query.OrderBy(x => x.Status.StatusId).ThenByDescending(x => x.RecordDate).ToPagedList(page, 20);
            return View(list);
        }
        public IActionResult New()
        {
            CreateSelectListItem();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> New(RestaurantViewModel restaurant)
        {
            if (ModelState.IsValid)
            {
                Address address = new Address();
                address.District = db.Districts.Find(restaurant.SelectedDistrictId);
                address.Street = restaurant.AddressText;
                restaurant.Address = db.Add(address).Entity;

                restaurant.Status = db.Statuses.Find(restaurant.SelectedStatusId);
                restaurant.RestaurantType = db.RestaurantTypes.Find(restaurant.SelectedTypeId);

                RestaurantEmail restaurantEmail = new RestaurantEmail();
                restaurantEmail.Email = new Email { Mail = restaurant.Email, Status = restaurant.Status, RecordDate = DateTime.Now  };
                restaurant.RestaurantEmails.Add(restaurantEmail);

                RestaurantPhoneNumber restaurantPhone = new RestaurantPhoneNumber();
                restaurantPhone.PhoneNumber = new PhoneNumber { Number = restaurant.Phone, Status = restaurant.Status, RecordDate = DateTime.Now };
                restaurant.RestaurantPhoneNumbers.Add(restaurantPhone);

                restaurant.RecordDate = DateTime.Now;

                var user = db.Users.Find(restaurant.SelectedUserId);
                restaurant.Users.Add(user);

                db.Add(restaurant);

                await db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            CreateSelectListItem();
            return View(restaurant);
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
        public IActionResult NewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewProduct(Product product)
        {
            return View();
        }
        public IActionResult ProductUpdate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {
            return View();
        }

        //functions
        public void CreateSelectListItem()
        {
            List<SelectListItem> users = (from x in db.Users.Where(x => x.StatusId == 1 && x.UserTypeId == 3).ToList()
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
            List<SelectListItem> types = (from x in db.RestaurantTypes.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.Name,
                                              Value = x.RestaurantTypeId.ToString()
                                          }).ToList();

            ViewBag.Users = users;
            ViewBag.Districts = districts;
            ViewBag.Statuses = statuses;
            ViewBag.Types = types;
        }

    }
}
