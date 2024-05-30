using CoreCURD1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;

namespace CoreCURD1.Controllers
{
    public class TestController : Controller
    {
        EmpContext ec;
        public TestController(EmpContext ec)
        {
            this.ec = ec;
        }
        public IActionResult Index()
        {
            ViewBag.DeptId = new SelectList(this.ec.Depts.ToList(),"DeptId","DeptName");
            return View(this.ec.Emps.ToList());
        }
    }
}
