using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthorizationExample.Models;
using AuthorizationExample.CustAuth;

namespace AuthorizationExample.Areas.UserArea.Controllers
{

    [AuthLogin]
    public class UserHomeController : Controller
    {
        // GET: UserArea/UserHome
        userContext uc = new userContext();
        public ActionResult Index()
        {
            return View(this.uc.Products.ToList());
        }
    }
}