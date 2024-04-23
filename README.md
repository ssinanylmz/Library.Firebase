# .NET 8 Firebase Library

This .NET 8 class library provides easy-to-use Firebase integration, specifically tailored for applications needing Firebase authentication and database operations. This library simplifies working with Firebase by offering custom services and repositories that can be readily injected into any .NET application using dependency injection.

## Features

- Firebase Authentication
- CRUD operations on Firebase databases using a generic repository pattern

## Getting Started

### Prerequisites

Ensure you have the following installed:
- .NET 8 SDK
- An IDE (e.g., Visual Studio, Visual Studio Code)

### Installation

1. Clone this repository to your local machine:

    ```bash
    git clone https://github.com/ssinanylmz/Library.Firebase.git
    ```

2. Open your project in your IDE and ensure it builds correctly.

3. Add the project reference to your solution:

    ```bash
    dotnet add reference /path/to/your/FirebaseLibrary.csproj
    ```

### Configuration

Before using the Firebase services, you need to configure the Firebase API keys in your application settings:

1. Open your application's `appsettings.json` file.

2. Add a new section for FirebaseOptions:

    ```json
    {
      "FirebaseOptions": {
        "ApiKey": "YOUR_API_KEY",
        "AuthDomain": "YOUR_AUTH_DOMAIN"
      }
    }
    ```

### Usage

#### Registering Services

To utilize the Firebase services within your application, register them in your `Startup.cs` or wherever you configure services:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.RegisterServices();
    services.AddFirebaseAuthentication(Configuration);
}
```
## Using the Firebase Repository
The IFirebaseRepository<T> allows you to perform CRUD operations on your Firebase database:
```csharp
public class YourService
{
    private readonly IFirebaseRepository<YourEntity> _repository;

    public YourService(IFirebaseRepository<YourEntity> repository)
    {
        _repository = repository;
    }

    public async Task<YourEntity> GetEntityAsync(string key)
    {
        return await _repository.GetAsync(key);
    }

    // Implement other CRUD operations similarly
}
```
## Contributing
Contributions to improve this library are welcome. To contribute:

1. Fork the repository.
2. Create a new branch (git checkout -b feature-branch).
3. Make your changes and commit them (git commit -am 'Add some feature').
4. Push to the branch (git push origin feature-branch).
5. Create a new Pull Request.

