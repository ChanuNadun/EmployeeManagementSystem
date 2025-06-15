using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    // Define interface for employee management
    public interface IEmployeeService
	{
		List<Employee> GetAll();
		Employee GetById(int id);
		void Add(Employee emp);
		void Update(Employee emp);
		void Delete(int id);
	}
}
