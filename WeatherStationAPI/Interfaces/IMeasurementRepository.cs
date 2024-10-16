using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IMeasurementRepository
    {
        List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId);
        List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end, List<int>? sensorIds = null);
    }
}

