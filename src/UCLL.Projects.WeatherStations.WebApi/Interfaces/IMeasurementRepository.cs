#region

using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Models;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Interfaces
{
    public interface IMeasurementRepository
    {
        List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId);
        List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
    }
}
