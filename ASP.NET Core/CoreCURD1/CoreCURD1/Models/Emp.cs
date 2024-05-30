using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCURD1.Models
{
    public class Emp
    {
        [Key]
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string Mob { get; set; }

        [ForeignKey("DeptName")]
        public Int64 DeptId { get; set; }
        public virtual Dept DeptName { get; set; }
    }
}
