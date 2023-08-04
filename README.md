## History
- Install Azure Data Studio 
- Add Azure Sql Edge docker 
    https://hub.docker.com/_/microsoft-azure-sql-edge?tab=description
```
    docker pull mcr.microsoft.com/azure-sql-edge
```
```
    docker run -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=hola1234' -e "MSSQL_PID=Developer" -e "MSSQL_USER=SA" -p 1433:1433 -d --name=azuresqledge mcr.microsoft.com/azure-sql-edge
```
- Connect Azure Data Studio to Docker Image
    - Authentication type: SQL Login
    - Server: localhost
    - User name: SA
    - Password: hola1234
- Crear Proyecto 
    - F1: Create ".NET: New Project" -> ASP.NET Core Web API Web, WebApi -> Choice a project name
    - Add Controllers and Models
    - Move to project folder, build and run
```
cd MagicVilla.WebApi
dotnet build
dotnet run
```