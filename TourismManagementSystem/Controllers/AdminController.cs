using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TourismManagementSystem.Data;
using TourismManagementSystem.Models;
using TourismManagementSystem.Models.IdentityModels;

namespace TourismManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult AdminPanel()
        {
            ViewData["BookCount"] = _context.Bookings.Count();
            ViewData["UserCount"] = _context.Users.Count();
            ViewData["PendingBookingCount"] = _context.Bookings.Count(m => m.Status == "Pending");
            return View();
        }

        public async Task<IActionResult> ManageBooking()
        {
            var applicationDbContext = _context.Bookings.Include(b => b.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> BookingDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Bookings.Include(b => b.ApplicationUser).FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        public async Task<IActionResult> Approve(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var bookModel = await _context.Bookings.FindAsync(id);
                bookModel.Status = "Approved";
                _context.Update(bookModel);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ManageBooking));
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
            return RedirectToAction(nameof(ManageBooking));
        }
        public IActionResult GoBack()
        {
            return RedirectToAction(nameof(ManageBooking));
        }

    }
}
