using CarRental.Data.Database;
using CarRental.Data.Extensions;
using CarRental.Domain.Entities;
using CarRental.Utility.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataLayerServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            NullCheckHelper.ThrowIfNull(connectionString);

            services
                .AddIdentityCore<ApplicationUser>()
                .AddRoles<ApplicationRole>()
                .AddEntityFrameworkStores<CarRentalDbContext>();

            services.AddDbContext<CarRentalDbContext>((options) =>
            {
                options.UseSqlServer(connectionString);
            });

            services
                .AddScoped<DefaultDataInitializer>();

            return services;
        }
    }
}
