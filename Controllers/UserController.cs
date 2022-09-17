using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            var users = new List<User>()
            {
                new User
                {
                    Name = "John",
                    Password = "pass1"
                 },
                new User
                    {
                        Name = "Dave",
                         Password = "pass11"
                    }

            };
            return Ok(users);
        }
    }
}
