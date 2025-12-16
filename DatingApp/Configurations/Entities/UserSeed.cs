using DatingApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingApp.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<DatingAppUser>
    {
        public void Configure(EntityTypeBuilder<DatingAppUser> builder)
        {
            var hasher = new PasswordHasher<DatingAppUser>();

            builder.HasData(
                new DatingAppUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
