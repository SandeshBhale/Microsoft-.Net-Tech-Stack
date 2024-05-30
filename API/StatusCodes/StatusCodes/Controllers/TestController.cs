using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StatusCodes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

    }
}
