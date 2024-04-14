using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoredProcedureCodeFirst.Models
{
    public class EmpContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emp>().MapToStoredProcedures();
        }

        public DbSet<Emp> Emps { get; set; }
    }
}