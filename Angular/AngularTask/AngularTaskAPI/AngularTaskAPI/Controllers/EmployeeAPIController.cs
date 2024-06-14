using AngularTaskAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AngularTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        EmployeeContext ec;

        public EmployeeAPIController(EmployeeContext ec)
        {
            this.ec = ec;
        }

        [HttpGet]
        public IActionResult EmpList()
        {
            return Ok(this.ec.Employees.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpById(Int64 id)
        {
            if (id == 0)
                return BadRequest();
            var v = this.ec.Employees.Find(id);
            if (v != null)
                return Ok(v);
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmpVM rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                Employee e = new Employee();
                e.EmpName = rec.EmpName;
                e.EmpSal = rec.EmpSal;
                e.Designation = rec.Designation;
                e.Address = rec.Address;
                e.DeptId = rec.DeptId;
                this.ec.Employees.Add(e);
                //this.ec.Employees.Add(rec);
                this.ec.SaveChanges();
                return Ok("Customer Saved!");
            }

            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                Employee e = new Employee();
                e.EmpName = rec.EmpName;
                e.EmpSal = rec.EmpSal;
                e.Designation = rec.Designation;
                e.Address = rec.Address;
                e.DeptId = rec.DeptId;
                this.ec.Employees.Add(e);
                //this.ec.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.ec.SaveChanges();
                return Ok("Employee Updated !!");
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(Int64 id)
        {
            if (id <= 0)
                return BadRequest();
            var rec = this.ec.Employees.Find(id);

            if (rec == null)
                return NotFound();

            this.ec.Employees.Remove(rec);
            this.ec.SaveChanges();
            return Ok("Employee Deleted !!");
        }


    }
}
