using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingExample.Controllers
{
    public class TestController : Controller
    {
        public string sayHello()
        {
            return "Say Hello Called !!";
        }

        public string sayBye()
        {
            return "Say Bye Called !!";
        }
    }
}