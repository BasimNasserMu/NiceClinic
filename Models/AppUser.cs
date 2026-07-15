using Microsoft.AspNetCore.Identity;

namespace NiceClinic.Models
{
    public class AppUser: IdentityUser
    {
        public string FullName { get; set; } = "New User";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
