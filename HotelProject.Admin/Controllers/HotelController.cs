using HotelProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace HotelProject.Admin.Controllers
{
    public class HotelController : Controller
    {
        private readonly Context db = new Context();

        public IActionResult Index(int page = 1, string search = "", int status = 0)
        {
            var query = db.Hotels.Include(x => x.Status).Include(x => x.Users).ToList();

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
        public async Task<IActionResult> New(IFormFile LogoUrl, HotelViewModel hotel)
        {
            if (ModelState.IsValid)
            {
                string fileName, filePath;

                if (LogoUrl != null && LogoUrl.Length > 0)
                {

                    fileName = hotel.Name + " Logo -" + Guid.NewGuid() + Path.GetExtension(LogoUrl.FileName);
                    filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/hotels",
                        fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        LogoUrl.CopyTo(fileStream);
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
            CreateSelectListItem();
            return View(hotel);
        }
        public IActionResult Details(int id)
        {
            var hotel = db.Hotels
                        .Include(x => x.Address)
                            .ThenInclude(x => x.District)
                        .Include(x => x.Status)
                        .Include(x => x.HotelEmails)
                            .ThenInclude(e => e.Email)
                        .Include(x => x.HotelPhoneNumbers)
                            .ThenInclude(p => p.PhoneNumber)
                        .Include(x => x.Users)
                        .FirstOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound();
            }

            HotelViewModel model = new HotelViewModel();
            model.SelectedStatusId = hotel.Status.StatusId;
            model.Email = hotel.HotelEmails.FirstOrDefault().Email.Mail;
            model.Phone = hotel.HotelPhoneNumbers.FirstOrDefault().PhoneNumber.Number;
            model.AddressText = hotel.Address.Street;
            model.SelectedDistrictId = hotel.Address.District.DistrictId;
            model.Name = hotel.Name;
            model.LogoUrl = hotel.LogoUrl;
            model.SelectedUserId = hotel.Users.FirstOrDefault().Id;
            model.UserName = hotel.Users.FirstOrDefault().Name;
            model.DistrictName = hotel.Address.District.DistrictName;
            model.StatusName = hotel.Status.Name;
            return View(model);
        }
        public IActionResult Update(int id)
        {
            var hotel = db.Hotels
                        .Include(x => x.Address)
                            .ThenInclude(x => x.District)
                        .Include(x => x.Status)
                        .Include(x => x.HotelEmails)
                            .ThenInclude(e => e.Email)
                        .Include(x => x.HotelPhoneNumbers)
                            .ThenInclude(p => p.PhoneNumber)
                        .Include(x => x.Users)
                        .FirstOrDefault(x => x.HotelId == id);
            if (hotel == null)
            {
                return NotFound();
            }

            HotelViewModel model = new HotelViewModel();
            model.SelectedStatusId = hotel.Status.StatusId;
            model.Email = hotel.HotelEmails.FirstOrDefault().Email.Mail;
            model.Phone = hotel.HotelPhoneNumbers.FirstOrDefault().PhoneNumber.Number;
            model.AddressText = hotel.Address.Street;
            model.SelectedDistrictId = hotel.Address.District.DistrictId;
            model.Name = hotel.Name;
            model.LogoUrl = hotel.LogoUrl;
            model.SelectedUserId = hotel.Users.FirstOrDefault().Id;
            CreateSelectListItem();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, HotelViewModel hotel)
        {
            if (ModelState.IsValid)
            {
                var existingHotel = db.Hotels.Include(x => x.Address)
                                        .Include(x => x.Status)
                                        .Include(x => x.HotelEmails)
                                            .ThenInclude(e => e.Email)
                                        .Include(x => x.HotelPhoneNumbers)
                                            .ThenInclude(p => p.PhoneNumber)
                                        .Include(x => x.Users)
                                        .FirstOrDefault(x => x.HotelId == id);
                if (existingHotel == null)
                {
                    return NotFound();
                }

                Address existAddress = db.Addresses.Include(x => x.District).Where(x => x.AddressId == existingHotel.Address.AddressId).FirstOrDefault();
                existAddress.District = db.Districts.Find(hotel.SelectedDistrictId);
                existAddress.Street = hotel.AddressText;
                db.Update(existAddress);

                existingHotel.Status = db.Statuses.Find(hotel.SelectedStatusId);

                HotelEmail hotelEmail = existingHotel.HotelEmails.FirstOrDefault();
                hotelEmail.Email.Mail = hotel.Email;
                db.Update(hotelEmail);


                HotelPhoneNumber hotelPhone = existingHotel.HotelPhoneNumbers.FirstOrDefault();
                hotelPhone.PhoneNumber.Number = hotel.Phone;
                db.Update(hotelPhone);

                existingHotel.Name = hotel.Name;

                var user = db.Users.Find(hotel.SelectedUserId);
                var existUser = existingHotel.Users.FirstOrDefault();
                if (existUser.Id != hotel.SelectedUserId)
                {
                    existingHotel.Users.Remove(existUser);
                    existingHotel.Users.Add(user);
                }

                db.Update(existingHotel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            CreateSelectListItem();

            return View(hotel);
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
        public IActionResult StatusChange(int id)
        {
            var hotel = db.Hotels.Include(x => x.Status).Where(x => x.HotelId == id).FirstOrDefault();
            if (hotel.Status.StatusId == 1)
            {
                hotel.Status = db.Statuses.Find(2);
            }
            else
            {
                hotel.Status = db.Statuses.Find(1);
            }
            db.Update(hotel);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        //funtions
        public void CreateSelectListItem()
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
        }
    }
}
