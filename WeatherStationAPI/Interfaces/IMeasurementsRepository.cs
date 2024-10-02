using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IMeasurementsRepository
    {
        // Voeg een nieuwe meting toe
        Task AddMeasurementAsync(Measurement measurement);

        // Verkrijg alle metingen
        Task<IEnumerable<Measurement>> GetAllMeasurementsAsync();
    }
}
