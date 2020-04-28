# build image
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 as build
WORKDIR /app

# copy csproj file
COPY webapi-k8s.csproj .
RUN dotnet restore

# copy everything else and build app
COPY . .
WORKDIR /app
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 as runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "webapi-k8s.dll"]