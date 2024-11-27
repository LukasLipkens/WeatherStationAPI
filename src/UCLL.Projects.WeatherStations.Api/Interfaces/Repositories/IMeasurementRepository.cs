#region

using UCLL.Projects.WeatherStations.Api.Dto;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

#endregion

namespace UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;

public interface IMeasurementRepository
{
    List<Measurement> GetAllMeasurementsFromStationSensor(int stationSensorId);
    List<SensorDto> GetMeasurementsFromSensorInTimeRange(string stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
}