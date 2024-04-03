using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample.Areas.Manager.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager/Manager
        public ActionResult Index()
        {
            return View();
        }
    }
}