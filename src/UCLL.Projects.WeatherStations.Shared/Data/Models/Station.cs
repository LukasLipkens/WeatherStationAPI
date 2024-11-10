﻿using System.ComponentModel.DataAnnotations;

namespace UCLL.Projects.WeatherStations.Shared.Data.Models;

public class Station
{
    [Key] public string Id { get; set; }

    public string Name { get; set; } = "";
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Description { get; set; } = "";

    // Relationships
    public ICollection<Station_Sensor> Station_Sensors { get; set; } = null!;
    public ICollection<Measurement> Measurements { get; set; } = null!;
}