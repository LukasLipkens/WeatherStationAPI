namespace WeatherStationAPI.Models
{
    public class WeatherStation
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }

        public List<Sensor> Sensors { get; set; }

    }
}
