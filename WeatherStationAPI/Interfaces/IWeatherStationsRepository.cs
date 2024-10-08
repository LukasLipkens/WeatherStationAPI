using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IWeatherStationsRepository
    {
        // Maak een nieuw weerstation aan
        Task AddWeatherStationAsync(WeatherStation weatherStation);

        // Werk een bestaand weerstation bij
        Task UpdateWeatherStationAsync(WeatherStation weatherStation);

        // Verkrijg alle weerstations
        Task<List<WeatherStation>> GetAllWeatherStationsAsync();

        // Verkrijg een weerstation op basis van ID
        Task<WeatherStation> GetWeatherStationByIdAsync(int stationId);
    }
}
