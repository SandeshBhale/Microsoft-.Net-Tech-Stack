using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstExample3.Models
{
    public class Employee
    {
        [Key]
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpSal { get; set; }
        public string Mobile { get; set; }

        [ForeignKey("Name")]
        public Int64 DeptId { get; set; }

        public virtual Dept Name { get; set; }

    }
}