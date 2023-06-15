using GymManager.Web.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class IdentityController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public IdentityController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _userManager= userManager;
            _signInManager= signInManager;

            if (!_userManager.Users.Any())
            {
                var result = _userManager.CreateAsync(new IdentityUser 
                { 
                    Email = "anibal@gmail.com", 
                    EmailConfirmed = true,
                    UserName = "anibal@gmail.com"

                }, "R2d22000.").Result;
            }
        }

        [Route("/Identity/Account/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Identity/Account/Login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            string returnUrl = string.IsNullOrEmpty(Request.Query["returnUrl"]) ? Url.Content("~/") : Request.Query["returnUrl"];

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                } 
                if (result.IsLockedOut)
                {
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt"); 
                    return View();
                }
            }
            return View();
        }
    }
}
