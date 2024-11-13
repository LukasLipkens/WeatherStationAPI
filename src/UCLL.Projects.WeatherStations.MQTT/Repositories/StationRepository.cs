using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly WeatherstationsContext _wheatherstationsContext;

        public StationRepository(WeatherstationsContext wheatherstationsContect)
        {
            _wheatherstationsContext = wheatherstationsContect;
        }

        public bool addBatteryPercentage(string stationId, double batteryPercentage)
        {
            Station station = _wheatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);
            station.BatteryLevel = batteryPercentage;

            _wheatherstationsContext.Stations.Update(station);
            return true;
        }

        public bool addLocationStation(string stationId, double latitude, double longitude)
        {
            Station station = _wheatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);
            station.Latitude = latitude;
            station.Longitude = longitude;
      
            _wheatherstationsContext.Stations.Update(station);
            return true;
        }
    }
}
