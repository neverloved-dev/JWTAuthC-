using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace BAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        public static User user = new User();
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            CreatePasswordHash(request.Password,out byte[] passwordHash,out byte[] passwordSalt);
            user.Name = request.Name;
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            return Ok(user);

        }

         [HttpPost("login")]
        public async Task<ActionResult<User>> LogIn(UserDto request)
        {
            if(user.Name != request.Name)
            {
                return BadRequest("User not found!");
            }
            if(!VerifyPassword(request.Password, user.PasswordHash,user.PasswordSalt))
            {
                return BadRequest("Wrong password!");
            }
            var token = CreateToken()
            return Ok(token);
        }

          private void CreatePasswordHash(string password, out byte[]passwordHash, out byte[]PasswordSalt)
         {
            using (var hmac = new HMACSHA256())
            {
                PasswordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
         }
         private bool VerifyPassword(string password, out byte[]passwordHash, out byte[]PasswordSalt)
         {
            using (var hmac = new HMACSHA256(PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
         }

  
    }
}
