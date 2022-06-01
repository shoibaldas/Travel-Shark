using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TourismManagementSystem.Data;
using TourismManagementSystem.Models;
using TourismManagementSystem.Models.IdentityModels;

namespace TourismManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        

        public AccountController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid email or password.");
                    }
                }
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            var userNameExistsTest = await _userManager.FindByEmailAsync(registerViewModel.Email);
            if (userNameExistsTest == null)
            {
                var user = new ApplicationUser();
                user.UserName = registerViewModel.FirstName;
                string FullName = registerViewModel.FirstName + " " + registerViewModel.LastName;
                user.FullName = FullName;
                user.FirstName = registerViewModel.FirstName;
                user.LastName = registerViewModel.LastName;
                user.Email = registerViewModel.Email;
                user.PhoneNumber = registerViewModel.PhoneNumber;
                user.Confirmpwd = registerViewModel.Confirmpwd;
                user.Gender = registerViewModel.Gender;
                user.SecurityAnwser = registerViewModel.SecurityAnwser;
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "An account already exists with this email.");
                }
            }

            //var allUsers = _userManager.Users.ToList();
            return View(registerViewModel);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}
