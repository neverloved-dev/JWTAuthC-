// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Mvc;

// namespace BAuth.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class UserController : Controller
//     {
//          public static List<User> users = new List<User>()
//             {
//                 new User
//                 {
//                     Name = "John",
//                     Password = "pass1"
//                  },
//                 new User
//                     {
//                         Name = "Dave",
//                          Password = "pass11"
//                     }

//             };

//         [HttpGet]
//         public async Task<ActionResult<List<User>>> GetAll()
//         {
//             return Ok(users);
//         }

//         [HttpGet ("{name}")]
//         public async Task<ActionResult<List<User>>>GetUser( string name)
//         {
//             var user = users.Find(user=>user.Name == name);
//             if (user == null)
//             {
//                 return BadRequest("User not found");
//             }
//             return Ok(user);
//         }

//         [HttpPost]
//         public async Task<ActionResult<List<User>>>AddUser(User user)
//         {
//             users.Add(user);
//             return Ok(users);
//         }
//         [HttpDelete ("{name}")]
//          public async Task<ActionResult<List<User>>>DeleteUSer(string name)
//          {
//             var user = users.Find(user=>user.Name == name);
//             users.Remove(user);
//             return Ok(users);
//          }
//     }
// }
