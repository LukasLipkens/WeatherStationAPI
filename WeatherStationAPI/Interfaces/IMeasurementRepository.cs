using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IMeasurementRepository
    {
        List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId);
    }
}
