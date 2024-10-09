using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class Station_Sensor
    {
        [Key]
        public int StationId { get; set; }

        [Key]
        public int SensorId { get; set; }
    }
}
