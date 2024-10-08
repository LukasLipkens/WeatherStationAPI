namespace WeatherStationAPI.Models
{
    public class WeatherStationDto
    {
        public int Id { get; set; }

        public string StationInfo { get; set; } = "";
        public List<SensorTypeStationDto> SensorTypeStation { get; set; } = null!;
    }
}
