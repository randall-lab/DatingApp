using DatingApp.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DatingApp.Domain;

namespace DatingApp.Data
{
    public class DatingAppContext : IdentityDbContext<DatingAppUser>
    {
        public DatingAppContext(DbContextOptions<DatingAppContext> options)
            : base(options)
        {
        }
        public DbSet<DatingApp.Domain.Block> Block { get; set; } = default!;
        public DbSet<DatingApp.Domain.Match> Match { get; set; } = default!;
        public DbSet<DatingApp.Domain.Message> Message { get; set; } = default!;
        public DbSet<DatingApp.Domain.Preference> Preference { get; set; } = default!;
        public DbSet<DatingApp.Domain.Profile> Profile { get; set; } = default!;
        public DbSet<DatingApp.Domain.Swipe> Swipe { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());

            builder.Entity<Match>()
                .Ignore(m => m.UserOneName)
                .Ignore(m => m.UserTwoName)
                .Ignore(m => m.OtherUserName)
                .Ignore(m => m.OtherUserPhoto);

            builder.Entity<Preference>()
                .Ignore(p => p.UserFullName);

            builder.Entity<Swipe>()
                .Ignore(s => s.UserFromName)
                .Ignore(s => s.UserToName);
        }
        public DbSet<DatingApp.Domain.Report> Report { get; set; } = default!;
    }
}
