FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app

EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["UCLL.Projects.WeatherStations.WebApi/UCLL.Projects.WeatherStations.WebApi.csproj", "UCLL.Projects.WeatherStations.WebApi/"]
RUN dotnet restore "UCLL.Projects.WeatherStations.WebApi/UCLL.Projects.WeatherStations.WebApi.csproj"
COPY . .
WORKDIR "/src/UCLL.Projects.WeatherStations.WebApi"
RUN dotnet build "UCLL.Projects.WeatherStations.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "UCLL.Projects.WeatherStations.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UCLL.Projects.WeatherStations.WebApi.dll"]