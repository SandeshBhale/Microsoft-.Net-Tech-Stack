using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstExample2.Models
{
    public class Employee
    {

        [Key]  public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpPost { get; set; }

        public string EmpSal { get; set; }
    }
}