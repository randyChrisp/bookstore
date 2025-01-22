using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    /* AccountController manages user account-related actions such as registration, 
    login, logout, and handling access denied scenarios*/
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        /* Dependency Injection allowing the controller to utilize the functionalites
        provided by ASP.NET Core Identity for user mngmt and athentication*/
        public AccountController(UserManager<User> userMngr,
            SignInManager<User> signInMngr)
        {
            _userManager = userMngr;
            _signInManager = signInMngr;
        }

        // Returns registration view
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Processes registration form submission
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username };
                var result = await _userManager.CreateAsync(user, model.Password); // Create and register new user

                if (result.Succeeded)
                {
                    bool isPersistent = false;
                    await _signInManager.SignInAsync(user, isPersistent); // Sign in user after registration
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Display error messages if registration fails
                    foreach (var error in result.Errors) 
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        // Logs out the user, redirect to home page
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult LogIn(string returnURL = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnURL }; // Return URL is the URL the user was trying to access before being redirected to the login page
            return View(model);
        }

        // Processes login form submission
        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {                
                var result = await _signInManager.PasswordSignInAsync(
                    model.Username, model.Password, isPersistent: model.RememberMe, 
                    lockoutOnFailure: false); // Sign in user with provided credentials

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && 
                        Url.IsLocalUrl(model.ReturnUrl)) 
                    {
                        return Redirect(model.ReturnUrl); // Redirect user to the URL they were trying to access before being redirected to the login page
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid username/password."); // Display error message if login fails
            return View(model);
        }

        public ViewResult AccessDenied() // Returns access denied view
        {
            return View();
        }
    }
}