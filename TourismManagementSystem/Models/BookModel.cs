using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TourismManagementSystem.Models.IdentityModels;

namespace TourismManagementSystem.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Destination { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Room { get; set; }
        public string Adults { get; set; }
        public string Child { get; set; }
        public string HotelPackage { get; set; }
        public string VechiclePackage { get; set; }
        public string Status { get; set; }

        //[Required]
        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "Phone Number Required!")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        //public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
