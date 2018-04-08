using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LmycWeb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [MaxLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }
        public string SailingExperience { get; set; }

        public ICollection<Boat> Boats { get; set; }
    }
}
