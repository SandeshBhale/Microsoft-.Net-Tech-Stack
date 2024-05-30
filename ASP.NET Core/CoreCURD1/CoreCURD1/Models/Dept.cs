using System;
using System.ComponentModel.DataAnnotations;

namespace CoreCURD1.Models
{
    public class Dept
    {
        [Key]
        public Int64 DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
