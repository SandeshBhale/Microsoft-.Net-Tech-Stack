using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewExample.Models
{
    public class Emp
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Emp()
        {
            this.EmpId = 1;
            this.EmpName = "Sandesh";
            this.Address = "Chinchvad,Pune";
            this.Email = "sandeshbhale51@gmail.com";
        }
    }
}