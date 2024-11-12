using System.Globalization;
using System.Threading.Channels;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Services;

public class DatabaseService : IHostedService
{
    private readonly Channel<MqttMessage> _channel;
    private readonly ILogger<DatabaseService> _logger;

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
        await foreach (MqttMessage message in _channel.Reader.ReadAllAsync(cancellationToken))
        {
            //_logger.LogInformation($"db service opgestart");
            //_logger.LogInformation($"db service message: {message.Topic}");
            //_logger.LogInformation($"db service message: {message.StationId}");
            //_logger.LogInformation($"db service message: {message.Payload}");

            string type;
            string unit;
            string value;

            _measurementRepository.CheckStaitonExists(message.StationId);

            switch (message.Topic)
            {
                case "measurement":


                    string[] measurement = message.Payload.Trim('{', '}').Split(",");
                    for (int i = 0; i < measurement.Length; i++)
                    {
                        string[] deeltjes = measurement[i].Split(":");
                        value = deeltjes[1].Trim('"');

                        string[] typeUnit = deeltjes[0].Split("(");

                        type = typeUnit[0].Trim('"');
                        unit = typeUnit[1].Trim(')', '"');


                        _measurementRepository.AddMeasurement(message.StationId, value, type, unit);

                        //if (_measurementRepository.CheckSensorExists(type, unit, message.StationId))
                        //    _logger.LogInformation("Found");
                        //else
                        //    _logger.LogInformation("Not found");

                        _logger.LogInformation($"{type}");
                        _logger.LogInformation($"{unit}");
                        _logger.LogInformation($"{value}");
                    }

                    break;
                case "location":
                    _logger.LogInformation($"{message.Topic}");
                    break;

                default: 
                    break;
            }
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Stopt");
    }
}