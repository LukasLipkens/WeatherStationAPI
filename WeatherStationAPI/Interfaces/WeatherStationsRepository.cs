using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Models;
using WeatherStationAPI.Services;

namespace WeatherStationAPI.Interfaces
{
    public class WeatherStationsRepository : IWeatherStationsRepository
    {
        private readonly WeatherStationContext _context;

        public WeatherStationsRepository(WeatherStationContext context)
        {
            _context = context;
        }
        public async Task AddWeatherStationAsync(WeatherStation weatherStation)
        {
            _context.WeatherStations.Add(weatherStation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<WeatherStation>> GetAllWeatherStationsAsync()
        {
            return await _context.WeatherStations.Include(ws => ws.Sensors).ToListAsync();
        }

        public async Task<WeatherStation> GetWeatherStationByIdAsync(int stationId)
        {
            return await _context.WeatherStations.Include(ws => ws.Sensors)
                    .FirstOrDefaultAsync(ws => ws.StationId == stationId);
            
        }

        public async Task UpdateWeatherStationAsync(WeatherStation weatherStation)
        {
            _context.WeatherStations.Update(weatherStation);
            await _context.SaveChangesAsync();
        }
    }
}
