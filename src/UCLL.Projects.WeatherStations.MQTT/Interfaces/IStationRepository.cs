using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.MQTT.Interfaces
{
    public interface IStationRepository
    {
        void AddLocationStation(string stationId, double latitude, double longitude);
        void AddBatteryPercentage(string stationId, double batteryPercentage);
    }
}
