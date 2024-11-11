namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Station
{
    public required string Id { get; set; }
    public double? BatteryLevel { get; set; } = null;
    public required double Latitude { get; set; }
    public required double Longitude { get; set; }
    public string? Name { get; set; } = null;
    public string? Description { get; set; } = null;

    // navigation properties
    public virtual ICollection<StationSensor> StationSensors { get; set; } = null!;
}