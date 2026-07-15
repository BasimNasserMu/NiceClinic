using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NiceClinic.Models
{
    public class NiceClinicContext : IdentityDbContext<AppUser>
    {
        public NiceClinicContext(DbContextOptions<NiceClinicContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AppUser>().ToTable("Users", "auth");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles", "auth");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "auth");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "auth");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "auth");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "auth");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "auth");
        }
    }
}
