using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.ClassLib;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;

namespace UCLL.Projects.WeatherStations.MQTT.Services
{
    public class DatabaseService : BackgroundService
    {
        private readonly ILogger<DatabaseService> _logger;
        private readonly Channel<MqttMessage> _channel;
        private readonly IMeasurementRepository _measurementRepository;
        //private readonly string _connectionString;

        public DatabaseService(ILogger<DatabaseService> logger, Channel<MqttMessage> channel, IMeasurementRepository measurementRepository)
        {
            _logger = logger;
            _channel = channel;
            _measurementRepository = measurementRepository;
            //_connectionString = "Server=;Database=;User Id=;Password=;";
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await foreach (var message in _channel.Reader.ReadAllAsync(stoppingToken))
            {
                _logger.LogInformation($"db service opgestart");
                _logger.LogInformation($"db service message: {message.Topic}");
                _logger.LogInformation($"db service message: {message.StationId}");
                _logger.LogInformation($"db service message: {message.Payload}");

                switch (message.Topic)
                {
                    case "measurement":
                        _measurementRepository.AddMeasurements(message.StationId, message.Payload);
                        break;
                    case "Station":
                        //
                    break;
                }

            }
        }
    }
}
