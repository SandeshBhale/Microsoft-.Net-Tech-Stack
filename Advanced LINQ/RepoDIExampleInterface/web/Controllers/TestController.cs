using core;
using entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;

namespace web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        //ProductContext pc = new ProductContext();
        //ProductRepo prepo;
        //CategoryRepo crepo;

        IProduct prepo;
        ICategory crepo;

        public TestController(IProduct trepo,ICategory tcrepo)
        {
            //this.prepo = new ProductRepo();
            //this.crepo = new CategoryRepo();
            this.prepo = trepo;
            this.crepo = tcrepo;
        }
        //public ActionResult Index()
        //{
        //    return View(this.pc.Products.ToList());
        //}

        public ActionResult Index()
        {
            return View(this.prepo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(this.crepo.GetAllCat(), "CategoryId", "CategoryName");
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Product p)
        //{
        //    ViewBag.CategoryId = new SelectList(this.pc.Categories.ToList(), "CategoryId", "CategoryName");
        //    this.pc.Products.Add(p);
        //    this.pc.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public ActionResult Create(Product p)
        {
            ViewBag.CategoryId = new SelectList(this.crepo.GetAllCat(), "CategoryId", "CategoryName");
            this.prepo.Add(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            ViewBag.CategoryId = new SelectList(this.crepo.GetAllCat(), "CategoryId", "CategoryName");
            var rec = this.prepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            ViewBag.CategoryId = new SelectList(this.crepo.GetAllCat(), "CategoryId", "CategoryName");
            this.prepo.Edit(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(Int64 id)
        {
            this.prepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}