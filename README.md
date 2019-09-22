# dotnet-core-mysql-boilerplate

## How to run docker compose
```sh
docker-compose up
```

## See API Methods
1. Run
2. Go to: ```http://localhost:5000/swagger```

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
cd src/Tests
dotnet test Tests/Tests.csproj
```

## How to create Migrations
1. Run:
```sh
cd src
dotnet ef migrations -p Repository/Repository.csproj -s Api/Api.csproj add <Migration_Name>
```

## How to run Docker

```
cd src
docker build -t lucian/dotnetcore .
docker run --name dotnetcore -d -p 5000:5000 lucian/dotnetcore
```  
 
 
