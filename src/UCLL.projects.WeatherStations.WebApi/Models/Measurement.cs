namespace UCLL.projects.WeatherStations.WebApi.Models
{
    public class Measurement
    {
        public DateTime Timestamp { get; set; }

        public int StationId { get; set; }

        public int SensorId { get; set; }

        public double Value { get; set; }
    }
}
