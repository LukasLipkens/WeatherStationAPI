namespace UCLL.Projects.WeatherStations.Api.Dto;

public class SensorDto
{
    public int Id { get; set; }
    public string Unit { get; set; }
    public string Type { get; set; }

    public List<MeasurementDto>? Measurements { get; set; }
}