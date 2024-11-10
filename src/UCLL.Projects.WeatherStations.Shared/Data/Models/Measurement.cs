﻿namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Measurement
{
    public DateTime Timestamp { get; set; }

    public string StationId { get; set; }

    public int SensorId { get; set; }

    public double Value { get; set; }
}