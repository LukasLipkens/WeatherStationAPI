using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.ClassLib;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;

namespace UCLL.Projects.WeatherStations.MQTT.Services
{
    public class DatabaseService : IHostedService
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

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await foreach (var message in _channel.Reader.ReadAllAsync(cancellationToken))
            {
                //_logger.LogInformation($"db service opgestart");
                //_logger.LogInformation($"db service message: {message.Topic}");
                //_logger.LogInformation($"db service message: {message.StationId}");
                //_logger.LogInformation($"db service message: {message.Payload}");

                string type;
                string unit;
                double value;

                switch (message.Topic)
                {
                    case "measurement":
                        var measurement = message.Payload.Trim('{', '}').Split(",");
                        for (int i = 0; i < measurement.Length; i++)
                        {
                            var deeltjes = measurement[i].Split(":");
                            value = double.Parse(deeltjes[1].Trim('"'), CultureInfo.InvariantCulture);

                            var typeUnit = deeltjes[0].Split("(");

                            type = typeUnit[0].Trim('"');
                            unit = typeUnit[1].Trim(')', '"');

                            if (_measurementRepository.CheckSensorExists(type, unit, message.StationId))
                            {
                                _logger.LogInformation("Found");
                            } else
                            {
                                _logger.LogInformation("Not found");
                            }

                            //_logger.LogInformation($"{type}");
                            //_logger.LogInformation($"{unit}");
                            //_logger.LogInformation($"{value}");
                        }
                        break;
                    case "Station":
                        //
                        break;
                    default:
                        //
                        break;
                }

            }
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogWarning("Stopt");

        }

    }
}
