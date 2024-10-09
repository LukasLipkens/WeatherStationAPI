using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        public List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId)
        {
            throw new NotImplementedException();
        }
    }
}
