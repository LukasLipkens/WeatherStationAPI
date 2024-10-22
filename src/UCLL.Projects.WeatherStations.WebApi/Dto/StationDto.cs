namespace UCLL.Projects.WeatherStations.WebApi.Dto
{
    public class StationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; } = "";
        public List<SensorDto> Sensors { get; set; } = new List<SensorDto>();
    }

}
