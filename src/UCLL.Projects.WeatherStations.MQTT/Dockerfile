FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["UCLL.Projects.WeatherStations.MQTT/UCLL.projects.WeatherStations.MQTT.csproj", "UCLL.Projects.WeatherStations.MQTT/"]
RUN dotnet restore "UCLL.Projects.WeatherStations.MQTT/UCLL.Projects.WeatherStations.MQTT.csproj"
COPY . .
WORKDIR "/src/UCLL.Projects.WeatherStations.MQTT"
RUN dotnet build "UCLL.Projects.WeatherStations.MQTT.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "UCLL.Projects.WeatherStations.MQTT.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UCLL.Projects.WeatherStations.MQTT.dll"]