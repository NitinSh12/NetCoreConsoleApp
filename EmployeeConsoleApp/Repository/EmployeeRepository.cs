using EmployeeConsoleApp.DbAccess;
using EmployeeConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeConsoleApp.Repository
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbContext employeeDbContext;
        public EmployeeRepository()
        {
            employeeDbContext = new EmployeeDbContext();
        }
        public void AddEmployee()
        {
            var employee = new Employee { Name = "Harsh" };
            
            employeeDbContext.employees.Add(employee);
            employeeDbContext.SaveChanges();
        }
    }
}
