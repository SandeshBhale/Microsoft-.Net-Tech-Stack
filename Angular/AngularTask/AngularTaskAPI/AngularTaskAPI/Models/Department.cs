using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularTaskAPI.Models
{
    [Table("DepartmentTable")]
    public class Department
    {
        [Key]
        public Int64 DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
