using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStationAPI.Models
{
    public class Sensor
    {
        [Key]
        public int SensorId { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Unit { get; set; } = "";

        public int StationId { get; set; }

        public WeatherStation Station { get; set; } = null!;

        public List<Measurement> Measurements { get; set; } = null!;
    }
}
