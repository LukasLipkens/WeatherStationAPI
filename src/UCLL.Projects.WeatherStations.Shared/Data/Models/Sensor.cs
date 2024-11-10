namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Sensor
{
    public int Id { get; set; }
    public required string Type { get; set; }
    public required string Unit { get; set; }

    // navigation properties
    public virtual ICollection<StationSensor> StationSensors { get; set; } = null!;
}