using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class WeatherStation
    {
        [Key]
        public int StationId { get; set; }

        [Required]
        public string StationInfo { get; set; } = "";

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }

        public List<Sensor> Sensors { get; set; } = null!;

        public List<Measurement> Measurements { get; set; } = null!;

    }
}
