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
    public class UserviewController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public UserviewController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult UserProfile()
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = _userManager.FindByIdAsync(userid).Result;
            ViewData["UserBookings"] = _context.Bookings.Where(m => m.ApplicationUserId == userid).ToList();
            return View(user);

        }

        [HttpGet]
        public IActionResult EditUserProfile()
        {
            var id = _userManager.GetUserId(HttpContext.User);
            ApplicationUser userid = _userManager.FindByIdAsync(id).Result;
            return View(userid);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserProfile(ApplicationUser usedetails)
        {
            var id = _userManager.GetUserId(HttpContext.User);
            ApplicationUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.UserName = usedetails.FirstName;
                string FullName = usedetails.FirstName + " " + usedetails.LastName;
                user.FullName = FullName;
                user.FirstName = usedetails.FirstName;
                user.LastName = usedetails.LastName;
                user.Email = usedetails.Email;
                user.PhoneNumber = usedetails.PhoneNumber;
                user.Gender = usedetails.Gender;

                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserProfile", "Userview");
                }
            }
            return View(usedetails);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel userdetalis)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                var result = await _userManager.ChangePasswordAsync(user, userdetalis.CurrentPassword, userdetalis.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);
                return View("ChangePassword");
            }
            return View(userdetalis);
        }

        public async Task<IActionResult> Reject(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var bookModel = await _context.Bookings.FindAsync(id);
                bookModel.Status = "Cancelled";
                _context.Update(bookModel);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(UserProfile));
        }
    }
}
