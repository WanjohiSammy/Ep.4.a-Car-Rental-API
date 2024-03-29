
# Ep.4(a): Car Rental System API - Project Preparation for User Register and Login Enpoints

This Project follows a layered architecture, which is a good practice for building scalable and maintainable applications. Each layer has its specific responsibilities, making the codebase modular and easy to understand. 
This clean separation of concerns keeps things organized and manageable, making maintenance and testing easy.

## Additional Codes or Features
1. **Nuget packages installation**
- **Microsoft.AspNetCore.Identity.EntityFrameworkCore**: Installed in Domain project
- **Microsoft.EntityFrameworkCore**: Added in Data Layer
- **Microsoft.EntityFrameworkCore.SqlServer**: Installed in Data Layer
- **Microsoft.EntityFrameworkCore.Tools**: Installed in Data Layer

2. **ApplicationUser and ApplicationRole Creation**
- Utilizing ASP.NET Core Identity framework.
- ApplicationUser inherits IdentityUser with Guid as its primary key type.
- ApplicationRole inherits IdentityRole with Guid as its primary key type.

3. **CarRentalDbContext Creation**
- Development of CarRentalDbContext.
- This DbContext inherits IdentityDbContext<ApplicationUser, ApplicationRole, Guid> rather than normal DbContext.

4. **Dependency Injection Setup**
- Registration of IdentityUser and IdentityRole.
- Addition of CarRentalDbContext to the service collection with SQL Server provider specification.
- Integration of Data Layer services into the global DI configurations, facilitating easy access to essential application services throughout the codebase.

5. **Migration Execution**
- Generation of migrations.
- Guidelines on renaming tables.
- Creation of Identity tables using generated migrations.

6. **Seeding Implementation**
- Initialization of default roles.
- Customizable seeding process

7. **Utilizing Extensions in C#**
- In-depth exploration of extension methods, showcasing their versatility in enhancing existing types and functionality in C#.
- Practical examples illustrating various scenarios where extension methods can be applied, empowering developers to leverage C# language features effectively.

## Get Started
1. Clone the repo
```sh
git clone https://github.com/WanjohiSammy/Ep.3-Car-Rental-API.git
```

2. Add `appsettings.Development.json` file in CarRental.Api layer:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalStore;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
  }
}
```

3. **Build the project to restore packages and ensure it follows the Project Structure.**

## Layers Overview
Project follows a **Layered Architecture**, which is a good practice for building scalable and maintainable applications. Each layer has its specific responsibilities. This structure promotes separation of concerns, making it easier to maintain and test each layer independently. 

![Project-Structure-Diagram](https://github.com/WanjohiSammy/Ep.3-Car-Rental-API/assets/12447806/fe5712c4-5016-48d6-8d26-baf8201033f4)

