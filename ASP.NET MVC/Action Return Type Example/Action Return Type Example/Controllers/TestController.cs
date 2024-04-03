using Microsoft.Ajax.Utilities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Return_Type_Example.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult GotoSite()
        {
            return Redirect("https://google.com");
        }
         
        public RedirectToRouteResult GotoIndex()
        {
            return RedirectToAction("GotoSite");
        }

        public ContentResult GotoContent()
        {
            return Content("Apple");
        }

        public EmptyResult Empty()
        {
            //return null;
            return new EmptyResult();
        }

        public FileResult File()
        {
            return File("~/Content/Site.css","text/css");
        }

        public JsonResult json()
        {
            
        }
    }
}