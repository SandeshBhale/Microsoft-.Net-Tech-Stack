using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildFunctionCall.Models
{
    public class Emp
    {
        public Int64 EmpId { get; set; }
        public string Password { get; set; }

        public Emp()
        {
            this.EmpId = 1;
            this.Password = "Pass@123";
        }
    }
}