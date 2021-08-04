using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoreTest.Models;

namespace WebApiCoreTest.IServices
{
	public interface IEmployeeService
	{

		IEnumerable<Employee> GetEmployee();
		Employee GetEmployeeById(int id);
		Employee AddEmployee(Employee employee);
		Employee UpdateEmployee(Employee employee);
		Employee DeleteEmployee(int id);
	}
}
