using CarRental.Data.Extensions;
using CarRental.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Data.Database
{
    internal class CarRentalDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public CarRentalDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ChangeIdentityTableNames();
        }
    }
}
