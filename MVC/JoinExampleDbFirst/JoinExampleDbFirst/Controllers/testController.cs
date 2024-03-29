using JoinExampleDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Mvc;

namespace JoinExampleDbFirst.Controllers
{
    public class testController : Controller
    {
        DemoDB2Entities entity = new DemoDB2Entities();
        // GET: test
        public ActionResult Index()
        {
            var v = from t in this.entity.Emps
                    join t1 in this.entity.Depts
                    on t.DeptId equals t1.DeptId
                    join t2 in this.entity.Areas
                    on t.AreaId equals t2.AreaId
                    select new EADVM
                    {
                        EmpId = t.EmpId,
                        EmpName = t.EmpName,
                        Mob = t.Mob,
                        DeptName = t1.DeptName,
                        AreaName = t2.AreaName
                    };

            return View(v.ToList());
            //return View(entity.Emps.ToList());
        }
    }
}