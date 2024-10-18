using System.ComponentModel.DataAnnotations;

namespace UCLL.projects.WeatherStations.WebApi.Models
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public string Unit { get; set; } = "";
        public string Type { get; set; } = "";

        // Relationships
        public ICollection<Station_Sensor> Station_Sensors { get; set; } = null!;
        public ICollection<Measurement> Measurements { get; set; } = null!;
    }
}
