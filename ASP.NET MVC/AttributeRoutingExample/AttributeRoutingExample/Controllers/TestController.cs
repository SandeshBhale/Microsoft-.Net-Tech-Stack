using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRoutingExample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        [Route("te/id")]
        [Route("tes/indx")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("samp/disp/{id:int}")]
        public string sayHello(string id)
        {
            return "sayHello called with id "+id;
        }

        [Route("samp/dis/{nm:double}")]
        public string sayBye(string nm)
        {
            return "sayBye Called with name "+nm;
        }
    }
}