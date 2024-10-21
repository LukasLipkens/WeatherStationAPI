using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class Station_Sensor
    {
        public int StationId { get; set; }

        public int SensorId { get; set; }

        //relationships
        public Station Station { get; set; } = null!;
        public Sensor Sensor { get; set; } = null!;
    }
}
