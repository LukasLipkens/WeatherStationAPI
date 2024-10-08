using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IMeasurementsRepository
    {
        // Voeg een nieuwe meting toe
        Task AddMeasurementAsync(Measurement measurement);

        Task DeleteMeasurementAsync(Measurement measurement);

        // Haal de laatst gemeten gegevens op van een station
        Task<Measurement> GetLatestMeasurementByStationAsync(int stationId);

        // Haal bepaalde aantal metingen op per station
        Task<List<Measurement>> GetAllMeasurementsByStationAsync(int stationId, int amount);
    }
}
