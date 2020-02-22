using EmployeeConsoleApp.Repository;
using System;

namespace EmployeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.AddEmployee();
        }
    }
}
