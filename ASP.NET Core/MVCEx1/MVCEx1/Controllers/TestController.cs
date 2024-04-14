using Microsoft.AspNetCore.Mvc;

namespace MVCEx1.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public string About()
        {
            return "this is about";
        }
    }
}
