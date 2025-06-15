using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;
using WebApplication4.Repositories;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
		private readonly IEmployeeService _service;

		public EmployeeController()
		{
			_service = new EmployeeService(new EmployeeRepository());
		}

        // Displays the all employees list
        public ActionResult Index() => View(_service.GetAll());

        // Shows the form to create a new employee
        public ActionResult Create() => View();

        // POST request to create a new employee
        [HttpPost]
		public ActionResult Create(Employee emp)
		{
			if (ModelState.IsValid)
			{
				_service.Add(emp);
				return RedirectToAction("Index");
			}
			return View(emp);
		}

        // Show the edit form with employee details 
        public ActionResult Edit(int id) => View(_service.GetById(id));

        // POST request to update employee details
        [HttpPost]
		public ActionResult Edit(Employee emp)
		{
			if (ModelState.IsValid)
			{
				_service.Update(emp);
				return RedirectToAction("Index");
			}
			return View(emp);
		}

        // Delete employee with using ID
        public ActionResult Delete(int id)
		{
			_service.Delete(id);
			return RedirectToAction("Index");
		}
	}
}