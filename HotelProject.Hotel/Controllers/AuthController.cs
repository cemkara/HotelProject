using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.Hotel.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly SignInManager<MyUser> _signInManager;
        private readonly UserManager<MyUser> _userManager;
        public AuthController(SignInManager<MyUser> signInManager, UserManager<MyUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(userLogin.Username);
                if (user != null && user.StatusId == 1 && user.UserTypeId == 2)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.UserName, userLogin.Password, true, true);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username and password are incorrect");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Username and password are incorrect");
                }
            }
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }
    }
}
