﻿using UCLL.Projects.WeatherStations.Shared.Enums;

namespace UCLL.Projects.WeatherStations.Api.Dto;

public class StationDto
{
    public string Id { get; set; }
    public required StationOnlineStatus OnlineStatus { get; set; }
    public double? BatteryLevel { get; set; } = null;
    public double? Latitude { get; set; } = null;
    public double? Longitude { get; set; } = null;
    public string? Name { get; set; } = null;
    public string? Description { get; set; } = null;
    public List<SensorDto> Sensors { get; set; } = [];
}