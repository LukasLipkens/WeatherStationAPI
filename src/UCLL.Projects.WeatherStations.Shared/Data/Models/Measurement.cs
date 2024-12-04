namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Measurement
{
    public required DateTime Timestamp { get; set; }
    public required int StationSensorId { get; set; }
    public required string SensorValue { get; set; }

    // navigation properties

    public virtual StationSensor StationSensor { get; set; } = null!;
}