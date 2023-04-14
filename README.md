# Projects Managements API
A Projects management API built with ASP .NET Core, Entity Framework Core, and InMemory/Sqlite database provider.
This API expose interfaces for managing Users (Members or employees), Projects or administratif and non-administratif directions, and project's-related Tasks (A Jira-like software)

## Project setup
This project was created using .NET Core 6, following Controller-base API provided by the ASP .NET Core, using the below command
``` bash
dotnet new webapi -o WebApiP
```
<br>

## Manually add dependencies

``` bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
# Required for migrations
dotnet add package Microsoft.EntityFrameworkCore.Design
```
<br>

If you encountred versions compatibilty issues, you can add a package with a specific version (Must be less-or-equal than EF Core version)
``` bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v 7.0.0
```
<br>

## Run the project
You can run the project using the following .NET Command-line
``` bash
dotnet run
```
The above command will build the project, and run it on your local machine. <br>(Check the console output to get the running URL)

``` console
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: https://localhost:7140
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5072
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: /home/<user>/home/dotnet/WebApiP/
```