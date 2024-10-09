using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IStationRepository
    {
        ICollection<Station> GetAllStations();

        bool StationExists(int stationId);

        Station? GetStation(int stationId);

        StationDto? GetStationWithLatestMeasurementsPerSensor(int stationId);

    }
}
