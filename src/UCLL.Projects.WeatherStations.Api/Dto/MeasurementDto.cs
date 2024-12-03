namespace UCLL.Projects.WeatherStations.Api.Dto;

public class MeasurementDto
{
    public required DateTime Timestamp { get; set; }
    public required string SensorValue { get; set; }
}