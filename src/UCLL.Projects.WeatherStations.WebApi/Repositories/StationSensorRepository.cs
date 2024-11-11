using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.WebApi.Interfaces.Repositories;

namespace UCLL.Projects.WeatherStations.WebApi.Repositories;

public class StationSensorRepository(WeatherstationsContext weatherstationsContext) : IStationSensorRepository
{
    private readonly WeatherstationsContext _weatherstationsContext = weatherstationsContext;

    public StationSensor? FindStationSensor(string stationId, int sensorId) => _weatherstationsContext.StationSensors.Find(stationId, sensorId);
}