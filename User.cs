using Microsoft.AspNetCore.Identity;

namespace BAuth
{
    public class User
    {
        public Int32 ID {get;set;}
        public string Name { get; set; }
        public byte[] PasswordSalt {get;set;}
        public byte[] PasswordHash {get;set;}
    }
}
