using ChildFunctionCall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChildFunctionCall.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Emp e = new Emp();
            return View(e);
        }

        public PartialViewResult GetEmps()
        {
            var lst = EmpInfo.GetEmps();
            return PartialView("_dispEmpInfo", lst);
        }

        public PartialViewResult GetEmp()
        {
            Emp e = new Emp();
            return PartialView("_dispEmp", e);
        }

        public PartialViewResult GetDept()
        {
            Dept d = new Dept();
            return PartialView("_dispDept", d);
        }
    }
}