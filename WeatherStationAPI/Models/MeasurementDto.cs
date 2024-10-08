namespace WeatherStationAPI.Models
{
    public class MeasurementDto
    {
        public int Id { get; set; }
        public int SensorTypeStationId { get; set; }
        public DateTime Time { get; set; }
        public double Value { get; set; }
    }
}
