using DBFirstExampleCURD1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;

namespace DBFirstExampleCURD1.Controllers
{
    public class testController : Controller
    {
        DemoDB2Entities entity = new DemoDB2Entities();
        // GET: test
        public ActionResult Index()
        {
            ViewBag.Dept = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            return View(entity.Emps.ToList());
        }

        [HttpPost]
        public ActionResult searchByName(string EName)
        {
            ViewBag.Dept = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            if (EName == "")
            {
                return View("index", this.entity.Emps.ToList());
            }
            else
            {
                var v = from t in this.entity.Emps
                        where t.EmpName.StartsWith(EName)
                        select t;
                return View("index",v.ToList());
            }
        }

        public ActionResult searchByDept(long Dept= 0)
        {
            ViewBag.Dept = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            if (Dept == 0)
            {
                return View("index",this.entity.Depts.ToList());
            }
            else
            {
                var v = from t in this.entity.Emps
                        where t.DeptId == Dept
                        select t;

                return View("index",v.ToList());
            }
        }
    }
}