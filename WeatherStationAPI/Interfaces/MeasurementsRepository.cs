using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Models;
using WeatherStationAPI.Services;

namespace WeatherStationAPI.Interfaces
{
    public class MeasurementsRepository : IMeasurementsRepository
    {
        private readonly WeatherStationContext _context;

        public MeasurementsRepository(WeatherStationContext context)
        {
            _context = context;
        }

        public async Task AddMeasurementAsync(Measurement measurement)
        {
            // Add measurement to the context
            _context.Measurements.Add(measurement);
            // Save changes to the database
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMeasurementAsync(Measurement measurement)
        {
            _context.Measurements.Remove(measurement);
            await _context.SaveChangesAsync();
        }

        public async Task<Measurement> GetLatestMeasurementByStationAsync(int stationId)
        {
            // Get the latest measurement for a specific station
            return await _context.Measurements
                .Where(m => m.StationId == stationId)
                .OrderByDescending(m => m.Timestamp)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Measurement>> GetAllMeasurementsByStationAsync(int stationId, int amount)
        {
            // Get a certain number of measurements for a specific station
            return await _context.Measurements
                .Where(m => m.StationId == stationId)
                .OrderByDescending(m => m.Timestamp)
                .Take(amount)
                .ToListAsync();
        }
    }
}
