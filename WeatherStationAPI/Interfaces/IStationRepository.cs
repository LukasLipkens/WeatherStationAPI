using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IStationRepository
    {
        ICollection<Station> GetAllStations();

        bool StationExists(int stationId);

        Station? GetStation(int stationId);

        StationDto? GetStationWithMeasurementsPerSensor(int stationId, int amount);

        // geeft al de stations terug met de laatste meting per sensor
        List<StationDto>? GetStationsWithMeasurementsPerSensor(int amount);

        // geeft de stations terug met de laatste meting per sensor van de meegegeven stations
        List<StationDto>? GetStationsWithMeasurementsPerSensor(List<int> stationIds, int amount);


    }
}
