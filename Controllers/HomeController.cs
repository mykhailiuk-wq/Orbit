using Microsoft.AspNetCore.Mvc;
using Orbit.Models;

namespace Orbit.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : ControllerBase
    {
        
        private static readonly User[] users = new User[]
        {
            new User { Name = "Alice" },
            new User { Name = "Bob" },
            new User { Name = "Charlie" },
            new User { Name = "David" },
            new User { Name = "Eve" }
        };
        [HttpGet(Name = "GetUsernames")]
        public IEnumerable<User> Get()
        {
            return users;
        }
    }
}