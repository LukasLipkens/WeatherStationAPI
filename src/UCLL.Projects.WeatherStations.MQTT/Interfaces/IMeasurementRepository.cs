using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.MQTT.Interfaces
{
    public interface IMeasurementRepository
    {
        bool AddMeasurements(string StationId, string Payload);

        bool CheckSensorExists(string type, string unit, string stationId);
    }
}
