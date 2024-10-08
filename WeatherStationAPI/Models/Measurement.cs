using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStationAPI.Models
{
    public class Measurement
    {
        [Key]
        public int Id { get; set; }

        public int StationId { get; set; }
        public int SensorId { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }

        [Required]
        public double Value { get; set; }

        [ForeignKey("StationId")]
        public WeatherStation Station { get; set; } = null!;

        [ForeignKey("SensorId")]
        public Sensor Sensor { get; set; } = null!;
    }
}
