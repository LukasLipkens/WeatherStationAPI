﻿namespace UCLL.Projects.WeatherStations.WebApi.Dto;

public class StationDto
{
    public string Id { get; set; }
    public double? BatteryLevel { get; set; } = null;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Name { get; set; } = null;
    public string? Description { get; set; } = null;
    public List<SensorDto> Sensors { get; set; } = [];
}