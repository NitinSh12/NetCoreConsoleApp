using EmployeeConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeConsoleApp.DbAccess
{
    public class EmployeeDbContext: DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-N0V35EK;Database=EmployeeDB;Trusted_Connection=True;");
        }
    }
}
