using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WeatherStationAPI.Models
{
    public class Station_Sensor
    {
        public int StationId { get; set; }

        public int SensorId { get; set; }

        // navigation properties
        public Station Station { get; set; } = null!;
        public Sensor Sensor { get; set; } = null!;
    }
}
