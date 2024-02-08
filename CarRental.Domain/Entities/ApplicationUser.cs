using Microsoft.AspNetCore.Identity;

namespace CarRental.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FullName { get; set; }
        public string? DrivingLicenseNumber { get; set; }
    }
}
