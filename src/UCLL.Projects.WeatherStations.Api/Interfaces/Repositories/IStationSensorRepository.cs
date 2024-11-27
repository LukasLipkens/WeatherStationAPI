using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;

public interface IStationSensorRepository
{
    StationSensor? FindStationSensor(string stationId, int sensorId);
}