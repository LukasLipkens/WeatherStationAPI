#region

using UCLL.Projects.WeatherStations.Shared.Models;
using UCLL.Projects.WeatherStations.WebApi.Dto;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Interfaces;

public interface IStationRepository
{
    List<Station> GetAllStations();

    public IEnumerable<StationDto> GetStationsLatestMeasurements(List<string> stationIds, int measurementAmount);
}