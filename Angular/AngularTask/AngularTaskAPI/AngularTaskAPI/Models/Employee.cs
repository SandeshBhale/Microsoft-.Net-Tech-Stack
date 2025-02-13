using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTaskAPI.Models
{
    [Table("EmployeeTable")]
    public class Employee
    {
        [Key]
        public Int64 EmpId { get; set; }

        [Required]
        public string EmpName { get; set; }

        [Required]
        public string EmpSal { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [ForeignKey("Department")]
        public Int64? DeptId { get; set; }

        public virtual Department? Department { get; set; }
    }

}
