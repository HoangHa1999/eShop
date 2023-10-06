#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["eShop.BackendApi/eShop.BackendApi.csproj", "eShop.BackendApi/"]
COPY ["eShop.Application/eShop.Application.csproj", "eShop.Application/"]
COPY ["eShop.Data/eShop.Data.csproj", "eShop.Data/"]
COPY ["eShop.Utilities/eShop.Utilities.csproj", "eShop.Utilities/"]
COPY ["eShop.ViewModels/eShop.ViewModels.csproj", "eShop.ViewModels/"]
RUN dotnet restore "eShop.BackendApi/eShop.BackendApi.csproj"
COPY . .
WORKDIR "/src/eShop.BackendApi"
RUN dotnet build "eShop.BackendApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShop.BackendApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "eShop.BackendApi.dll"]