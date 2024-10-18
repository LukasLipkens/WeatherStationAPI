#region

using UCLL.projects.WeatherStations.WebApi.Dto;
using UCLL.projects.WeatherStations.WebApi.Models;

#endregion

namespace UCLL.projects.WeatherStations.WebApi.Interfaces
{
    public interface IMeasurementRepository
    {
        List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId);
        List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
    }
}
