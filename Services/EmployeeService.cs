using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;
using WebApplication4.Repositories;

namespace WebApplication4.Services
{
    // Service class as between the controller and repository
    public class EmployeeService: IEmployeeService
	{
        // Define the repository for data access
        private readonly IEmployeeRepository _repo;

        // Constructor for repository dependency
        public EmployeeService(IEmployeeRepository repo)
		{
			_repo = repo;
		}

		public List<Employee> GetAll() => _repo.GetAll();
		public Employee GetById(int id) => _repo.GetById(id);
		public void Add(Employee emp) => _repo.Add(emp);
		public void Update(Employee emp) => _repo.Update(emp);
		public void Delete(int id) => _repo.Delete(id);
	}
}