# dotnet-core-mysql-boilerplate

## How to run 
1. Install dotnet core sdk
2. Run:
```sh
cd src/
dotnet build
dotnet run -p Api/Api.csproj
```

## How to test
1. Run:
```sh
cd Tests
dotnet test
```

## How to create Migrations
1. Run:
```sh
cd src
dotnet ef migrations -p Repository/Repository.csproj -s Api/Api.csproj add <Migration_Name>
```