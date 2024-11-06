using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Services;
using UCLL.Projects.WeatherStations.WebApi.Data;
using UCLL.Projects.WeatherStations.WebApi.Dto;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly DataContext _dataContect;
        private readonly ILogger<DatabaseService> _logger;


        public MeasurementRepository(DataContext dataContect, ILogger<DatabaseService> logger)
        {
            _dataContect = dataContect;
            _logger = logger;
        }

        public bool AddMeasurements(string StationId, string Payload)
        {
            MeasurementDto measuremnt = JsonSerializer.Deserialize<MeasurementDto>(Payload);
            _logger.LogInformation($"{measuremnt}");
            return false; 
        }
    }
}
