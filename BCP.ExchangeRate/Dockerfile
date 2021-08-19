FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY . .

RUN dotnet restore

COPY . .

RUN dotnet build "BCP.ExchangeRate.Api/BCP.ExchangeRate.Api.csproj" -c Release -o /app/build    

FROM build AS publish
RUN dotnet publish "BCP.ExchangeRate.Api/BCP.ExchangeRate.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BCP.ExchangeRate.Api.dll"]