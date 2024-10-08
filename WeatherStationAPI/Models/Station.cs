using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace WeatherStationAPI.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; } = "";

        // Relaties
        public ICollection<Station_Sensor> Station_Sensors { get; set; }
        public ICollection<Measurement> Measurements { get; set; }
    }
}
