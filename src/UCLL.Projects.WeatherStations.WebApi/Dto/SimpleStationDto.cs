using UCLL.Projects.WeatherStations.Shared.Enums;

namespace UCLL.Projects.WeatherStations.WebApi.Dto;

public class SimpleStationDto
{
    public string Id { get; set; }
    public required StationOnlineStatus OnlineStatus { get; set; }
    public double? BatteryLevel { get; set; } = null;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
}