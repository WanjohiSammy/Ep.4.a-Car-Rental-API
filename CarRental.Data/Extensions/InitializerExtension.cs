using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Data.Extensions
{
    public static class InitializerExtension
    {
        public static async Task InitialiseDatabaseAsync(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var initialiser = scope.ServiceProvider.GetRequiredService<DefaultDataInitializer>();

                await initialiser.SeedAsync();
            }
        }
    }
}
