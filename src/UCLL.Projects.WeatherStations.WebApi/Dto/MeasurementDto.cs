namespace UCLL.Projects.WeatherStations.WebApi.Dto;

public class MeasurementDto
{
    public required DateTime Timestamp { get; set; }
    public required string SensorValue { get; set; }
}