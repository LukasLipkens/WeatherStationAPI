using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.MQTT.Interfaces
{
    public interface IStationRepository
    {
        bool addLocationStation(string stationId, double latitude, double longitude);
        bool addBatteryPercentage(string stationId, double batteryPercentage);
    }
}
