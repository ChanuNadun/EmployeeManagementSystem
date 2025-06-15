using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
	public class DateRangeViewModel
	{
        // Start date
        [Required]
		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }

        // End date
        [Required]
		[Display(Name = "End Date")]
		public DateTime EndDate { get; set; }

        // Calculated working days
        public int WorkingDays { get; set; }

	}
}