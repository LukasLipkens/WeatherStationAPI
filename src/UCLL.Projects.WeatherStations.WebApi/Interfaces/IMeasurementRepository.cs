#region

using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.WebApi.Dto;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Interfaces;

public interface IMeasurementRepository
{
    List<Measurement> GetAllMeasurementsFromStationSensor(int stationSensorId);
    List<SensorDto> GetMeasurementsFromSensorInTimeRange(string stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
}