using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Repositories
{
	public class EmployeeRepository: IEmployeeRepository
	{
        // Database context connect with the Employees table
        private readonly WaterlillyEmployeeManagementDB1 _context = new WaterlillyEmployeeManagementDB1();

        // Return list of all employees
        public List<Employee> GetAll() => _context.Employees.ToList();

        // Get a single employee by ID
        public Employee GetById(int id) => _context.Employees.Find(id);

        // Add new employee to the database
        public void Add(Employee emp)
		{
			_context.Employees.Add(emp);
			_context.SaveChanges();
		}

        // Update selected employee's data
        public void Update(Employee emp)
		{
			_context.Entry(emp).State = EntityState.Modified;
			_context.SaveChanges();
		}

        // Delete an employee by ID
        public void Delete(int id)
		{
			var emp = _context.Employees.Find(id);
			if (emp != null)
			{
				_context.Employees.Remove(emp);
				_context.SaveChanges();
			}
		}
	}
}