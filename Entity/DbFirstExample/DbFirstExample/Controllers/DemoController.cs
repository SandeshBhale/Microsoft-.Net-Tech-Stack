using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbFirstExample.Models;

namespace DbFirstExample.Controllers
{
    public class DemoController : Controller
    {
        AssignmentEntities asn = new AssignmentEntities();
        // GET: Demo
        public ActionResult Index()
        {
            return View(asn.Emptb1.ToList());
        }
    }
}