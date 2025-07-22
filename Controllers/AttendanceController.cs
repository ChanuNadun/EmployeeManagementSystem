using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly WaterlillyEmployeeManagementDB1 _context = new WaterlillyEmployeeManagementDB1();

        public ActionResult MarkAttendance()
        {
            ViewBag.Employees = _context.Employees.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult MarkAttendance(EmployeeAttendance model)
        {
            if (ModelState.IsValid)
            {
                _context.EmployeeAttendances.Add(model);
                _context.SaveChanges();
                return RedirectToAction("AttendanceList");
            }
            ViewBag.Employees = _context.Employees.ToList();
            return View(model);
        }


        public ActionResult AttendanceList()
        {
            var list = _context.EmployeeAttendances.Include("Employee").ToList();
            return View(list);
        }
    }

}