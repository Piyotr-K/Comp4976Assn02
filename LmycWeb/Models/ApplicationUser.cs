using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LymcWeb.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public double SailingExperience { get; set; }

        public ICollection<Boat> Boats { get; set; }
    }
}
