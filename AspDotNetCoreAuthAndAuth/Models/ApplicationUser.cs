using Microsoft.AspNetCore.Identity;

namespace AspDotNetCoreAuthAndAuth.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
