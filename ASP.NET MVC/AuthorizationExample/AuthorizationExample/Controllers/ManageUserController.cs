using AuthorizationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizationExample.Controllers
{
    public class ManageUserController : Controller
    {
        // GET: ManageUser
        userContext uc = new userContext();
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var userExists = this.uc.Users.SingleOrDefault(p => p.Email == rec.Email && p.Password == rec.Password);

                if (userExists != null)
                {
                    //Session["UserId"] = userExists.UserId;
                    //Session["UserName"] = userExists.UserName;
                    return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
                }
                else
                {
                    ModelState.AddModelError("", "Email id not found");
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User rec)
        {
            if (ModelState.IsValid)
            {
                this.uc.Users.Add(rec);
                this.uc.SaveChanges();
                return RedirectToAction("SignIn");
            }
            return View();
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            Session.Clear();
            Session.Abandon();
            return View();
        }
    }
}