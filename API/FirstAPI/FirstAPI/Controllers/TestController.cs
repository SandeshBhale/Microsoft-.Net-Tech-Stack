using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string GetCalled()
        {
            return "Get Called !";
        }

        [HttpPost]
        public string PostCalled()
        {
            return "Post Called";
        }

        [HttpPut]
        public string PutCalled()
        {
            return "Put Called";
        }

        [HttpDelete]
        public string DeleteCalled()
        {
            return "Delete Called";
        }
    }
}
