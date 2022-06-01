using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TourismManagementSystem.Models;
using TourismManagementSystem.Models.IdentityModels;

namespace TourismManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        //public DbSet<ProfileData> ProfileData { get; set; }
        public DbSet<BookModel> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "a682b56a-6135-4111-a0k0-bdec547e3waz", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "da9a3b0e-8b6f-8529-71d0-4fd255e23f15" },
                new IdentityRole { Id = "d925b59b-7456-1442-d0n0-bdec765e3awv", Name = "User", NormalizedName = "USER", ConcurrencyStamp = "ea9a3b0f-9b5f-7153-81e0-4fd799e23f17" }

             );
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser() { Id = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507", FirstName = "", UserName = "Admin", NormalizedUserName = "ADMIN", Email = "admin@mail.com", NormalizedEmail = "ADMIN@MAIL.COM", PasswordHash = "AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==", SecurityStamp = "5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHJ", ConcurrencyStamp = "26d21881-0a3a-44ab-aa4d-10664ace1e2d" }


             );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { UserId = "8ab6ee61-f36c-41b1-ae27-dbb23cbfb507", RoleId = "a682b56a-6135-4111-a0k0-bdec547e3waz" }
             );

        }



    }
}
