using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class SensorTypeStationDto
    {
        public int Id { get; set; }
        public int SensorTypeId { get; set; }
        public int StationId { get; set; }
        public SensorTypeDto SensorType { get; set; } = null!;
        public List<MeasurementDto> Measurement { get; set; } = null!;
    }
}
