using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class Measurement
    {
        public int StationId { get; set; }
        public int SensorId { get; set; }
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }

        public WeatherStation Station { get; set; }
        public Sensor Sensor { get; set; }
    }
}
