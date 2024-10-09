using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Data;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly DataContext _context;

        public StationRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Station> GetAllStations()
        {
            return _context.Stations.ToList();
        }

        public Station? GetStation(int stationId)
        {
            return _context.Stations.Where(s => s.Id == stationId).FirstOrDefault();
        }

        public StationDto? GetStationWithLatestMeasurementsPerSensor(int stationId)
        {
            // alles ophalen en dan omzetten naar DTO
            return _context.Stations
                .Include(s => s.Station_Sensors)
                    .ThenInclude(ss => ss.Sensor)
                        .ThenInclude(s => s.Measurements)
                .Where(s => s.Id == stationId)
                .Select(s => new StationDto
                {
                    Id = s.Id,
                    Name = s.Name,
                    Latitude = s.Latitude,
                    Longitude = s.Longitude,
                    Description = s.Description,
                    Sensors = s.Station_Sensors.Select(ss => new SensorDto
                    {
                        Id = ss.Sensor.Id,
                        Type = ss.Sensor.Type,
                        Unit = ss.Sensor.Unit,
                        Measurements = ss.Sensor.Measurements.OrderByDescending(m => m.Timestamp).Select(m => new MeasurementDto
                        {
                            Value = m.Value,
                            Timestamp = m.Timestamp

                        }).ToList()
                    }).ToList()
                }).FirstOrDefault();
        }

        public bool StationExists(int stationId)
        {
            return _context.Stations.Any(s => s.Id == stationId);
        }
    }
}
