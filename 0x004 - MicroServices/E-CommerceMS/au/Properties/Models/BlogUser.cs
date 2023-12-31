using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Auth_Service.Models
{
    public class BlogUser:IdentityUser
    {
        public string Name { get; set; } = string.Empty;

        
    }
}
