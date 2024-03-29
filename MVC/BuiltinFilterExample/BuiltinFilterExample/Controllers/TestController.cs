using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiltinFilterExample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test

        [OutputCache(Duration=0)]
        public string dtime()
        {
            return DateTime.Now.ToString();
        }

        [HandleError(View="zero")]
        public int divison(int a, int b)
        {
            return a / b;
        }
    }
}