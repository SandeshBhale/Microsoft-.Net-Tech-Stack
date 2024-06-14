using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTaskAPI.Models
{
    [Table("EmployeeTable")]
    public class Employee
    {
        [Key]
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpSal { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }

        [ForeignKey("Department")]
        public Int64 DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}
