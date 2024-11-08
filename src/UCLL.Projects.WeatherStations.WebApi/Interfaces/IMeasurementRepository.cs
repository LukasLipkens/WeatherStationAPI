#region

using UCLL.Projects.WeatherStations.Shared.Models;
using UCLL.Projects.WeatherStations.WebApi.Dto;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Interfaces;

public interface IMeasurementRepository
{
    List<Measurement> GetAllMeasurementsFromStationSensor(string stationId, int sensorId);
    List<SensorDto> GetMeasurementsFromSensorInTimeRange(string stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
}