using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DatingApp.Data;

namespace DatingApp.Data
{
    public class DatingAppContext(DbContextOptions<DatingAppContext> options) : IdentityDbContext<DatingAppUser>(options)
    {
        public DbSet<DatingApp.Domain.Profile> Profile { get; set; } = default!;
        public DbSet<DatingApp.Domain.Preference> Preference { get; set; } = default!;
        public DbSet<DatingApp.Domain.Swipe> Swipe { get; set; } = default!;
        public DbSet<DatingApp.Domain.Match> Match { get; set; } = default!;
        public DbSet<DatingApp.Domain.MatchParticipant> MatchParticipant { get; set; } = default!;
        public DbSet<DatingApp.Domain.Message> Message { get; set; } = default!;
        public DbSet<DatingApp.Domain.Report> Report { get; set; } = default!;
        public DbSet<DatingApp.Domain.Block> Block { get; set; } = default!;
    }

}
