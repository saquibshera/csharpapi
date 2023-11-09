using createapiapp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace createapiapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet("getdata")]
        public List<Todo> Gettodo()
        {
            List<Todo> list = new List<Todo>();
            list.Add(new Todo { userId = 1, title = "user1", Validated = true });
                 list.Add(new Todo { userId = 2, title = "user2", Validated = false });
                 list.Add(new Todo { userId = 3, title = "user3", Validated = true });
            return list;
        }
    }
}
