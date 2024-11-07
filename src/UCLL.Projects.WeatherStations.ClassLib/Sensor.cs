using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.ClassLib
{
    public class Sensor
    {
        [Key] public int Id { get; set; }

        public string Unit { get; set; } = "";
        public string Type { get; set; } = "";

        // Relationships
        public ICollection<Station_Sensor> Station_Sensors { get; set; } = null!;
        public ICollection<Measurement> Measurements { get; set; } = null!;
    }
}
