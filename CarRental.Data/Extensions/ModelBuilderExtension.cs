using CarRental.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CarRental.Data.Extensions
{
    internal static class ModelBuilderExtension
    {
        public static void ChangeIdentityTableNames(this ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("Users");
            });

            builder.Entity<ApplicationRole>(b =>
            {
                b.ToTable("Roles");
            });

            builder.Entity<IdentityUserClaim<Guid>>(b =>
            {
                b.ToTable("UserClaims");
            });

            builder.Entity<IdentityUserLogin<Guid>>(b =>
            {
                b.ToTable("UserLogins");
            });

            builder.Entity<IdentityUserToken<Guid>>(b =>
            {
                b.ToTable("UserTokens");
            });

            builder.Entity<IdentityRoleClaim<Guid>>(b =>
            {
                b.ToTable("RoleClaims");
            });

            builder.Entity<IdentityUserRole<Guid>>(b =>
            {
                b.ToTable("UserRoles");
            });
        }
    }
}
