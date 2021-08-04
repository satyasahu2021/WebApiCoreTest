using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCoreTest.IServices;
using WebApiCoreTest.Models;

namespace WebApiCoreTest.Services
{
	public class EmployeeService: IEmployeeService
	{

		elifedealContext dbContext;
		public EmployeeService(elifedealContext _db)
		{
			dbContext = _db;
		}

        public IEnumerable<Employee> GetEmployee()
        {
            var employee = dbContext.Employees.ToList();
            return employee;
        }
        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            dbContext.Entry(employee).State = EntityState.Modified;
            dbContext.SaveChanges();
            return employee;
        }
        public Employee DeleteEmployee(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(employee).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return employee;
        }
        public Employee GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(x => x.Id == id);
            return employee;
        }
    }
}
