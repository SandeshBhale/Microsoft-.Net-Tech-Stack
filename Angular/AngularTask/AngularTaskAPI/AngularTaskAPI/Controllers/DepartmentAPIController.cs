using AngularTaskAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AngularTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentAPIController : ControllerBase
    {
        EmployeeContext ec;

        public DepartmentAPIController(EmployeeContext ec)
        {
            this.ec = ec;
        }

        [HttpGet]
        public IActionResult DeptList()
        {
            return Ok(this.ec.Departments.ToList());
        }
    }
}
