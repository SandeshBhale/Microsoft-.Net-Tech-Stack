using CodeFirstExample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstExample2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        EmpContext cnx =  new EmpContext();
        public ActionResult Index()
        {
            return View(cnx.Employees.ToList());
        }
    }
}