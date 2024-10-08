﻿using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class Sensor
    {
        [Key]
        public int Id { get; set; }
        public string Unit { get; set; } = "";
        public string Type { get; set; } = "";

        // Relaties
        public ICollection<Station_Sensor> Station_Sensors { get; set; }
        public ICollection<Measurement> Measurements { get; set; }
    }
}
