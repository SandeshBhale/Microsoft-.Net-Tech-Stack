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
            var v = from t in this.ec.Employees
                    join t1 in this.ec.Departments
                    on t.DeptId equals t1.DeptId
                    where t.DeptId == t1.DeptId
                    select new EmpVM
                    {
                        EmpId = t.EmpId,
                        EmpName = t.EmpName,
                        EmpSal = t.EmpSal,
                        Address = t.Address,
                        Designation = t.Designation,
                        DeptId = t1.DeptId,
                        DeptName = t1.DeptName
                    };

            return Ok(v.ToList());
            //return Ok(this.ec.Employees.ToList());
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
        [HttpPost]
        public IActionResult CreateEmployee(Employee rec)
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
                e.Department = rec.Department;

                this.ec.Employees.Add(e);
                this.ec.SaveChanges();
                return Ok("Employee Saved!");
            }

            return BadRequest(ModelState);
        }


        [HttpPut]
        public IActionResult UpdateEmployee(EmpVM rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                EmpVM e = new EmpVM();
                e.EmpName = rec.EmpName;
                e.EmpSal = rec.EmpSal;
                e.Designation = rec.Designation;
                e.Address = rec.Address;
                e.DeptId = rec.DeptId;
                e.DeptName = rec.DeptName;
                this.ec.Add(e);
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
