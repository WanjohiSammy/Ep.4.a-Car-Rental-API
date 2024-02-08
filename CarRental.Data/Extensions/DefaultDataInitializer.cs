using CarRental.Commons.Enums;
using CarRental.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace CarRental.Data.Extensions
{
    internal class DefaultDataInitializer
    {
        private readonly ILogger<DefaultDataInitializer> _logger;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public DefaultDataInitializer(
            RoleManager<ApplicationRole> roleManager,
            ILogger<DefaultDataInitializer> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            await TrySeedingRolesAsync();
        }

        private async Task TrySeedingRolesAsync()
        {
            try
            {
                _logger.LogInformation("Start Seeding Roles");
                // Default roles
                foreach (DefaultRolesEnum role in Enum.GetValues(typeof(DefaultRolesEnum)))
                {
                    var roleExists = await _roleManager.RoleExistsAsync(role.ToString());
                    if (!roleExists)
                    {
                        await _roleManager.CreateAsync(new ApplicationRole { Name = role.ToString() });
                        _logger.LogInformation("{RoleName} Role Created.", role);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    new Exception("An error occurred while seeding Roles the database."), ex.Message);
            }
        }
    }
}
