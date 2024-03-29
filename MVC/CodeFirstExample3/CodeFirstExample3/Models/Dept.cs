using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstExample3.Models
{
    public class Dept
    {
        [Key]
        public Int64 DeptId { get; set; }

        public String DeptName { get; set; }

        public string DeptDesc { get; set; }

        public virtual List<Employee> Employees { get; set; }


    }
}