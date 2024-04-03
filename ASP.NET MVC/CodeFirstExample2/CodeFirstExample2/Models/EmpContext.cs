using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstExample2.Models
{
    public class EmpContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}