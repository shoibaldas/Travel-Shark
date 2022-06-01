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
    public class BookModelsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public BookModelsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        //GET: BookModels
        public IActionResult BookingIndex()/*async Task<IActionResult>*/
        {
            return View();
        }

        // GET: BookModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Bookings
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // GET: BookModels/Create
        public IActionResult Booking()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: BookModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Booking([Bind("Id,From,Destination,CheckIn,CheckOut,Room,Adults,Child,HotelPackage,VechiclePackage,Status,Email,PhoneNumber,Date,ApplicationUserId")] BookModel bookModel)
        {
            var userid = _userManager.GetUserId(HttpContext.User);
            bookModel.Status = "Pending";
            bookModel.Date = DateTime.Now;
            bookModel.ApplicationUserId = userid;
            if (ModelState.IsValid)
            {
                _context.Add(bookModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BookingIndex));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", bookModel.ApplicationUserId);
            return View(bookModel);
        }

        // GET: BookModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Bookings.FindAsync(id);
            //bookModel.Status = 1;
            //_context.Update(bookModel);
            //await _context.SaveChangesAsync();

            if (bookModel == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", bookModel.ApplicationUserId);
            return View(bookModel);
        }

        // POST: BookModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,From,Destination,CheckIn,CheckOut,Room,Adults,Child,HotelPackage,VechiclePackage,Email,PhoneNumber,Date,ApplicationUserId")] BookModel bookModel)
        {
            if (id != bookModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookModelExists(bookModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(BookingIndex));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.Users, "Id", "Id", bookModel.ApplicationUserId);
            return View(bookModel);
        }

        // GET: BookModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookModel = await _context.Bookings
                .Include(b => b.ApplicationUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookModel == null)
            {
                return NotFound();
            }

            return View(bookModel);
        }

        // POST: BookModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookModel = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(bookModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(BookingIndex));
        }

        private bool BookModelExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}
