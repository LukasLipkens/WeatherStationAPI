#region

using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Models;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Interfaces
{
    public interface IStationRepository
    {
        List<Station> GetAllStations();

        public IEnumerable<StationDto> GetStationsLatestMeasurements(List<int> stationIds, int measurementAmount);
    }
}