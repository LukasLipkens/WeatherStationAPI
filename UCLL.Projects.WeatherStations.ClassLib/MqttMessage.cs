using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.ClassLib
{
    public class MqttMessage
    {
        public string Topic { get; set; }
        public string StationId{ get; set; }
        public string Payload { get; set; }
    }
}
