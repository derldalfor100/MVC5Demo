using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5Demo.Context
{
    public class EmployeeContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeContext(): base("DefaultConnection")
        {
            
        }
    }
}