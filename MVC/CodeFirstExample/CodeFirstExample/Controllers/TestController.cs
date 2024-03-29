using CodeFirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstExample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        CompanyContext cnx  = new CompanyContext();
        public ActionResult Index()
        {
            return View(cnx.Customers.ToList());
        }
    }
}