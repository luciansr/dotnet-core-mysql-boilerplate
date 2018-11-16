# dotnet-core-mysql-boilerplate

## How to run 
1. Install dotnet core sdk
2. Run:
```sh
cd src/
dotnet build
dotnet run -p Api/Api.csproj
```

## See API Methods
1. Run
2. Go to: ```https://localhost:5001/swagger```

## How to test
1. Run:
```sh
cd src/Tests
dotnet test
```

## How to create Migrations
1. Run:
```sh
cd src
dotnet ef migrations -p Repository/Repository.csproj -s Api/Api.csproj add <Migration_Name>
```