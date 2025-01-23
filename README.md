# ArveSvUtilities

A reusable library of utility functions for my projects.

## pgurl task

The `pgurl` task converts a PostgreSQL URL to a .NET PostgreSQL connection string.

### Usage

```sh
dotnet run --project Tool pgurl <url>
```

If the `<url>` argument is empty or `--`, the URL will be read from stdin.

### Example

```sh
dotnet run --project Tool pgurl postgres://user:password@localhost:5432/dbname
```

### Expected Output

```
Host=localhost;Port=5432;Username=user;Password=password;Database=dbname;SSL Mode=Require
```

## Installing the NuGet Package

You can install the `ArveSvUtilities.Core` package using the `dotnet` CLI or Visual Studio.

### Using the `dotnet` CLI

To install the package, run the following command:

```sh
dotnet add package ArveSvUtilities.Core
```

### Using Visual Studio

1. Right-click on your project in the Solution Explorer and select "Manage NuGet Packages".
2. Search for `ArveSvUtilities.Core` in the "Browse" tab.
3. Click "Install" to add the package to your project.

## Using the NuGet Package

Once you have installed the `ArveSvUtilities.Core` package, you can use it in your .NET project.

### Example

```csharp
using Core;

class Program
{
    static void Main()
    {
        var pgUrl = "postgres://user:password@localhost:5432/dbname";
        var connectionString = FlyIoUtilities.ConvertPostgresUrlToConnectionString(pgUrl);
        Console.WriteLine(connectionString);
    }
}
```

### Expected Output

```
Host=localhost;Port=5432;Username=user;Password=password;Database=dbname;SSL Mode=Require
```
