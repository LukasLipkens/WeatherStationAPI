using WeatherStationAPI.Data;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly DataContext _dataContext;

        public MeasurementRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId)
            => _dataContext.Measurements.Where(m => m.StationId == stationId && m.SensorId == sensorId).ToList();
    }
}
