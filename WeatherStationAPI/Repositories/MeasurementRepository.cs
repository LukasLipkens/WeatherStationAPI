using WeatherStationAPI.Data;
using WeatherStationAPI.Dto;
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

        public List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end, List<int>? sensorIds = null)
        {
            //opstellen filter query, moet tussen start en eind datum liggen
            var query = _dataContext.Measurements.Where(m => m.Timestamp >= start && m.Timestamp <= end && m.StationId == stationId);
            
            //voegt de sensorId's toe aan de query indien ingevuld
            if (sensorIds != null && sensorIds.Any())
            {
                query = query.Where(m => sensorIds.Contains(m.SensorId));
            }

            //opmaken query
            return query
                .GroupBy(m => m.SensorId)
                .Select(g => new SensorDto
                {
                    Id = g.Key,
                    Measurements = g.Select(m => new MeasurementDto
                    {
                        Timestamp = m.Timestamp,
                        Value = m.Value
                    }).ToList()
                }).ToList();
        }

    }
}
