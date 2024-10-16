using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Data;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly DataContext _dataContext;

        public StationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Station> GetAllStations()
        {
            return _dataContext.Stations
                //.Include(s => s.Station_Sensors)
                //.Include(s => s.Measurements)
                .OrderBy(s => s.Id).ToList();
        }
    }
}
