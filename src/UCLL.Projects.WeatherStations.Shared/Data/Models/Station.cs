using UCLL.Projects.WeatherStations.Shared.Enums;

namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Station
{
    public required string Id { get; set; }
    public required DateTime LastActivityTimestamp { get; set; }
    public double? BatteryLevel { get; set; } = null;
    public double? Latitude { get; set; } = null;
    public double? Longitude { get; set; } = null;
    public string? Name { get; set; } = null;
    public string? Password { get; set; } = null;
    public string? Description { get; set; } = null;

    //REMARK: this is a computed property that is not stored in the database
    public StationOnlineStatus OnlineStatus { get; private set; }

    // navigation properties
    [UseFiltering]

    public virtual ICollection<StationSensor> StationSensors { get; set; } = null!;
}