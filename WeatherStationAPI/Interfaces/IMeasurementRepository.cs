using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IMeasurementRepository
    {
        IEnumerable<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId);
    }
}
