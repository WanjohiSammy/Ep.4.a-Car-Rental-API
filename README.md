
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

## Layers Overview
1. **Api Layer:**
- Crafted with ASP.NET Core Web API. 
- Gateway to our system, handling incoming HTTP requests and delivering well-structured responses.
- Contains controllers, program.cs and appsettings for application configurations
- Preoject dependencies: Application and Data Layers.

2. **Application Layer:**
- Encompasses business rules and logic.
- Contain components to implement these rules, and profiles for AutoMapper, which helps in mapping DTOs to domain entities and vice versa.
- Has project dependency on Domain Layer

3. **Data Layer:**
- Manages the interaction with the database.
- Includes DbContext, Migrations, and Repository implementations on how to handle data in the database.
- References Domain Layer

4. **Domain Layer:**
- Defines entities that represent the business objects like User and Car entities in our case.
- Contains repository interfaces that are implemented in the Data Layer.
- Project dependencies: Utility Layer.

5. **Utility Layer:**
- Houses helper methods and internal or external services.
- Also Provides utility functions that can be shared across different layers.
- Project dependencies: Contracts Layer

6. **Contracts Layer:**
- Defines the communication contracts between API and the outside world.
- Project dependencies: Reference Commons Layer

7. **Commons Layer:**
- Contains constants and enums that are shared across the application.
- Provides a centralized place for maintaining commonly used elements.
- No project reference, indicating it's a standalone layer.

## Get Started
```sh
git clone https://github.com/WanjohiSammy/Ep.3-Car-Rental-API.git
```

Add `appsettings.Development.json` file in CarRental.Api layer:

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

Build the project to restore packages and ensure it follows the Project Structure.

