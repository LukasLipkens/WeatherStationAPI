﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WeatherStationAPI.Models
{
    public class Measurement
    {
        [Key]
        public DateTime Timestamp { get; set; }

        [Key]
        public int StationId { get; set; }

        [Key]
        public int SensorId { get; set; }

        public double Value { get; set; }
    }
}
