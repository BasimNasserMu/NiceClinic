using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NiceClinic.Models
{
    public class NiceClinicContext : IdentityDbContext<AppUser>
    {
        public NiceClinicContext(DbContextOptions<NiceClinicContext> options) : base(options)
        {
        }
    }
}
