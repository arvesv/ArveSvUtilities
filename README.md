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
