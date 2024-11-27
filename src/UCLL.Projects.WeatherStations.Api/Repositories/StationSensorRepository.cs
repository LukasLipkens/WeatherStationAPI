using UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.Api.Repositories;

public class StationSensorRepository(WeatherstationsContext weatherstationsContext) : IStationSensorRepository
{
    private readonly WeatherstationsContext _weatherstationsContext = weatherstationsContext;

    public StationSensor? FindStationSensor(string stationId, int sensorId) => _weatherstationsContext.StationSensors.Find(stationId, sensorId);
}