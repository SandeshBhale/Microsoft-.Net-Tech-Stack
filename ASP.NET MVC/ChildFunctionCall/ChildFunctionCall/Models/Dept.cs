using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildFunctionCall.Models
{
    public class Dept
    {
        public Int64 DeptId { get; set; }
        public string DeptName { get; set; }
        
        public Dept()
        {
            this.DeptId = 1;
            this.DeptName = "Computer";
        }
    }
}