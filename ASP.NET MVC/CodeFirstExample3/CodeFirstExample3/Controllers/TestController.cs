using CodeFirstExample3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstExample3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        EmpContext emp = new EmpContext();
        public ActionResult Index()
        {
            return View(this.emp.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DeptId = new SelectList(this.emp.Depts.ToList(), "DeptId", "DeptName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            ViewBag.DeptId = new SelectList(this.emp.Depts.ToList(), "DeptId", "DeptName");

            this.emp.Employees.Add(e);
            this.emp.SaveChanges();
            return View ("Index",this.emp.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.DeptId = new SelectList(this.emp.Depts.ToList(), "DeptId", "DeptName");

            var v = this.emp.Employees.Find(id);
            return View(v);
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            ViewBag.DeptId = new SelectList(this.emp.Depts.ToList(), "DeptId", "DeptName");

            this.emp.Entry(e).State = System.Data.Entity.EntityState.Modified;
            this.emp.SaveChanges();
            return View("Index",this.emp.Employees.ToList());
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            var v = this.emp.Employees.Find(id);
            this.emp.Employees.Remove(v);
            this.emp.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(Int64 id)
        {
            var rec = this.emp.Employees.Find(id);
            return View(rec);
        }
    }
}