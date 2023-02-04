using Day8MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Day8MVC.ViewModel;
namespace Day8MVC.Controllers
{
    public class AcountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AcountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await userManager.FindByEmailAsync(loginVM.Email);
                if (user != null)
                {
                    bool valid = await userManager.CheckPasswordAsync(user, loginVM.Password);
                    if (valid)
                    {
                        // await signInManager.SignInAsync(user, loginVM.RememberMe);
                        List<Claim> claims = new List<Claim>()
                        {
                            new Claim("Address",user.Address),
                            new Claim("Age",user.Age.ToString())
                        };
                        await signInManager.SignInWithClaimsAsync(user, loginVM.RememberMe, claims);
                        return RedirectToAction("Index", "User");
                    }
                }
                ModelState.AddModelError("", "Wrong email or password");
                return View(loginVM);
            }
            return View(loginVM);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
