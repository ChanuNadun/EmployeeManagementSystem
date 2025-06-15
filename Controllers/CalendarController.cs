using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CalendarController : Controller
	{
        // Database context to access the PublicHolidays table
        private readonly WaterlillyEmployeeManagementDB1 _context = new WaterlillyEmployeeManagementDB1();

        public ActionResult Calculate() => View();


        public ActionResult Index()
		{
			return RedirectToAction("Calculate");
		}

        // Handles form submission  date range and calculate as working days
        [HttpPost]
		public ActionResult Calculate(DateRangeViewModel model)
		{
            // Fetch public holiday dates from the database
            var holidays = _context.PublicHolidays.Select(h => h.HolidayDate).ToList();
			int count = 0;

			for (DateTime date = model.StartDate; date <= model.EndDate; date = date.AddDays(1))
			{
                // Count only weekdays are not public holidays
                if (date.DayOfWeek != DayOfWeek.Saturday &&
					date.DayOfWeek != DayOfWeek.Sunday &&
					!holidays.Contains(date.Date))
				{
					count++;
				}
			}

			model.WorkingDays = count;
			return View(model);
		}
	}
}