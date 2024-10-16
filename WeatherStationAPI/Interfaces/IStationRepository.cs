using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IStationRepository
    {
        List<Station> GetAllStations();
    }
}
