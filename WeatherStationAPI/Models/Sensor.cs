namespace WeatherStationAPI.Models
{
    public class Sensor
    {
        public int SensorId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }

        public int StationId { get; set; }
        public WeatherStation Station { get; set; }
    }
}
