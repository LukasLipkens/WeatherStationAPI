using Microsoft.EntityFrameworkCore;
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

        public List<SensorDto> GetMeasurementsFromSensorInTimeRange(List<int> sensorIds, int stationId, DateTime start, DateTime end)
        {
            return _dataContext.Measurements
                .Where(m => sensorIds.Contains(m.SensorId) && m.Timestamp >= start && m.Timestamp <= end && m.StationId == stationId)
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

        public List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end)

        {
            return _dataContext.Measurements
                .Where(m => m.Timestamp >= start && m.Timestamp <= end && m.StationId == stationId)
                .Include(m => m.Sensor)  // Include the Sensor entity
                .GroupBy(m => new { m.SensorId, m.Sensor.Unit, m.Sensor.Type })  // Group by SensorId and include Sensor's Unit and Type
                .Select(g => new SensorDto
                {
                    Id = g.Key.SensorId,
                    Unit = g.Key.Unit,  // Fill in Unit from the Sensor entity
                    Type = g.Key.Type,  // Fill in Type from the Sensor entity
                    Measurements = g.Select(m => new MeasurementDto
                    {
                        Timestamp = m.Timestamp,
                        Value = m.Value
                    }).ToList()
                }).ToList();

        }
    }
}
