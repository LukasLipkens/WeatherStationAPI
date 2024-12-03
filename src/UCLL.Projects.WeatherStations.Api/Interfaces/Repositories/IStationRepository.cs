#region

using UCLL.Projects.WeatherStations.Api.Dto;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

#endregion

namespace UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;

public interface IStationRepository
{
    List<Station> GetAllStations();

    public IEnumerable<StationDto> GetStationsLatestMeasurements(List<string> stationIds, int measurementAmount);

    public bool UpdateStationInfo(UpdateStationDto data);
}