using WeatherStationAPI.Dto;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Interfaces
{
    public interface IStationRepository
    {
        //List<Station> GetAllStations();

        public IEnumerable<StationDto> GetStationsLatestMeasurements(List<int> stationIds, int measurementAmount);
    }
}
