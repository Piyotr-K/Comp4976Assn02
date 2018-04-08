using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LmycWeb.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Start Date Time is required.")]
        [Display(Name = "From")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date Time is required.")]
        [Display(Name = "To")]
        public DateTime EndDate { get; set; }

        [ForeignKey("User")]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        public ApplicationUser User { get; set; }

        [ForeignKey("Boat")]
        public int BoatId { get; set; }

        [Display(Name = "Boat Name")]
        public Boat Boat { get; set; }
    }
}
