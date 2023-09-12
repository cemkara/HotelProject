using HotelProject.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[AllowAnonymous]
public class RegisterController : Controller
{
    private readonly UserManager<MyUser> _userManager;
    private readonly SignInManager<MyUser> _signInManager;
    Context c = new Context();
    public RegisterController(UserManager<MyUser> userManager, SignInManager<MyUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(int model)
    {
        if (ModelState.IsValid)
        {
            var user = new MyUser
            {
                Email = "cemkara1992@gmail.com",
                UserName = "cem",
                UserTypeId = 3,
                StatusId = 1,
                RecordDate = DateTime.Now
            };
            var result = await _userManager.CreateAsync(user, "123456Aa*");
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View(model);
    }
}
