using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProcedureCodeFirst.Models
{
    public class Emp
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpSal { get; set; }
        public string EmpDept { get; set; }
    }
}