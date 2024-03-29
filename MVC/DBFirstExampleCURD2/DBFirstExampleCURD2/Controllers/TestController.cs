using DBFirstExampleCURD2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;

namespace DBFirstExampleCURD2.Controllers
{
    public class TestController : Controller
    {

        DemoDB2Entities entity = new DemoDB2Entities();
        public ActionResult Index()
        {
            ViewBag.AreaId = new SelectList(this.entity.Areas.ToList(), "AreaId", "AreaName");
            ViewBag.DeptId = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            return View(this.entity.Emps.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.AreaId = new SelectList(this.entity.Areas.ToList(), "AreaId", "AreaName");
            ViewBag.DeptId = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Emp id)
        {
            ViewBag.AreaId = new SelectList(this.entity.Areas.ToList(), "AreaId", "AreaName");
            ViewBag.DeptId = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            this.entity.Emps.Add(id);
            this.entity.SaveChanges();
            return View("Index", this.entity.Emps.ToList());
        }

        [HttpGet]
        public ActionResult Update(Int64 id)
        {
            var rec = this.entity.Emps.Find(id);
            ViewBag.DeptId = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName", rec.DeptId);
            ViewBag.AreaId = new SelectList(this.entity.Areas.ToList(), "AreaId", "AreaName",rec.AreaId);
            return View(rec);
        }

        [HttpPost]
        public ActionResult Update(Emp e)
        {
            ViewBag.DeptId = new SelectList(this.entity.Depts.ToList(), "DeptId", "DeptName");
            ViewBag.AreaId = new SelectList(this.entity.Areas.ToList(), "AreaId", "AreaName");
            this.entity.Entry(e).State = System.Data.Entity.EntityState.Modified;
            this.entity.SaveChanges();
            return View("Index", this.entity.Emps.ToList());
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var rec = this.entity.Emps.Find(id);
            this.entity.Emps.Remove(rec);
            this.entity.SaveChanges();
            return View();

        }

    }
}