using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Myproject.Models;

namespace Myproject.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> LoginController(string? userName, string? passWord)
        {
            if (userName != null && passWord != null)
            {
                var check = await _signInManager.PasswordSignInAsync(userName, passWord, false, false);
                if (check.Succeeded)
                {
                    return Redirect("/Home/Index");
                }
            }
            return View();
        }

        public async Task<IActionResult> RegisterController(string? userName, string? passWord)
        {
            if (userName != null && passWord != null)
            {

                var User = new IdentityUser
                {
                    UserName =userName,
                    Email =userName,
                };

                await _userManager.CreateAsync(User, passWord);
                return Redirect("~/Authentication/LoginController");
            }
            return View();
        }
    }
}
