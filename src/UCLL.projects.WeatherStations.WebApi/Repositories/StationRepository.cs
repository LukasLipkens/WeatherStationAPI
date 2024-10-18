#region

using Microsoft.EntityFrameworkCore;
using UCLL.projects.WeatherStations.WebApi.Data;
using UCLL.projects.WeatherStations.WebApi.Dto;
using UCLL.projects.WeatherStations.WebApi.Interfaces;

#endregion

namespace UCLL.projects.WeatherStations.WebApi.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly DataContext _dataContext;

        public StationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //public List<Station> GetAllStations()
        //{
        //    return _dataContext.Stations.ToList<Station>(); // check later //untested, probably disfunctional
        //}

        public IEnumerable<StationDto> GetStationsLatestMeasurements(List<int> stationIds, int measurementAmount)
        {
            var query = _dataContext.Stations
                .Include(s => s.Station_Sensors) // Include the Station_Sensor navigation
                .ThenInclude(ss => ss.Sensor) // Then include the Sensor navigation from Station_Sensor
                .Include(s => s.Measurements) // Include Measurements directly from Station
                .AsQueryable();

            // check if any station ID's are existant, if not; search for all existant ones.
            if (stationIds != null && stationIds.Any())
            {
                query = query.Where(s => stationIds.Contains(s.Id));
            }

            var stations = query.Select(station => new StationDto
            {
                Id = station.Id,
                Name = station.Name,
                Latitude = station.Latitude,
                Longitude = station.Longitude,
                Description = station.Description,
                Sensors = station.Station_Sensors.Select(ss => new SensorDto
                {
                    Id = ss.SensorId,
                    Unit = ss.Sensor.Unit,
                    Type = ss.Sensor.Type,
                    Measurements = station.Measurements
                        .Where(m => m.SensorId == ss.SensorId)
                        .OrderByDescending(m => m.Timestamp)
                        .Take(measurementAmount)
                        .Select(m => new MeasurementDto
                        {
                            Timestamp = m.Timestamp,
                            Value = m.Value
                        }).ToList()
                }).ToList()
            }).ToList();

            return stations;
        }
    }
}
