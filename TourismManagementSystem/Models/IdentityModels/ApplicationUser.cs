using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourismManagementSystem.Models.IdentityModels
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Confirmpwd { get; set; }
        public string Gender { get; set; }
        public string SecurityAnwser { get; set; }
    }
}
