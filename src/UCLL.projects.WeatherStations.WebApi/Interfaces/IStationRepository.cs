﻿#region

using UCLL.projects.WeatherStations.WebApi.Dto;

#endregion

namespace UCLL.projects.WeatherStations.WebApi.Interfaces
{
    public interface IStationRepository
    {
        //List<Station> GetAllStations();

        public IEnumerable<StationDto> GetStationsLatestMeasurements(List<int> stationIds, int measurementAmount);
    }
}