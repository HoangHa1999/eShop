#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["eShop.AdminApp/eShop.AdminApp.csproj", "eShop.AdminApp/"]
COPY ["eShop.ApiIntegration/eShop.ApiIntegration.csproj", "eShop.ApiIntegration/"]
COPY ["eShop.Utilities/eShop.Utilities.csproj", "eShop.Utilities/"]
COPY ["eShop.ViewModels/eShop.ViewModels.csproj", "eShop.ViewModels/"]
COPY ["eShop.Data/eShop.Data.csproj", "eShop.Data/"]
RUN dotnet restore "eShop.AdminApp/eShop.AdminApp.csproj"
COPY . .
WORKDIR "/src/eShop.AdminApp"
RUN dotnet build "eShop.AdminApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShop.AdminApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.AdminApp.dll"]