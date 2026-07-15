using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NiceClinic.Models
{
    public class NiceClinicContext : IdentityDbContext<AppUser>
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<VisitNote> VisitNotes { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
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
