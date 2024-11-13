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
    private readonly IStationRepository _stationRepository;
    //private readonly string _connectionString;

    public DatabaseService(ILogger<DatabaseService> logger, Channel<MqttMessage> channel, IMeasurementRepository measurementRepository, IStationRepository stationRepository)
    {
        _logger = logger;
        _channel = channel;
        _measurementRepository = measurementRepository;
        _stationRepository = stationRepository;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await foreach (MqttMessage message in _channel.Reader.ReadAllAsync(cancellationToken))
        {
            _measurementRepository.CheckStationExists(message.StationId);

            switch (message.Topic)
            {
                case "measurement":
                    string type;
                    string unit;
                    string value;

                    string[] measurement = message.Payload.Trim('{', '}').Split(",");
                    for (int i = 0; i < measurement.Length; i++)
                    {
                        string[] deeltjes = measurement[i].Split(":");
                        value = deeltjes[1].Trim('"');

                        string[] typeUnit = deeltjes[0].Split("(");

                        type = typeUnit[0].Trim('"');
                        unit = typeUnit[1].Trim(')', '"');


                        _measurementRepository.AddMeasurement(message.StationId, value, type, unit);
                    }

                    break;
                case "location":
                    string[] location = message.Payload.Trim('{', '}').Split(",");
                    string[] lactionDeeltjes1 = location[0].Split(":");
                    double latitude = Convert.ToDouble(lactionDeeltjes1[1].Trim('"'));

                    string[] lactionDeeltjes2 = location[1].Split(":");
                    double longtitude = Convert.ToDouble(lactionDeeltjes2[1].Trim('"'));

                    _stationRepository.AddLocationStation(message.StationId, latitude, longtitude);

                    break;

                case "status":
                    string[] status = message.Payload.Trim('{', '}').Split(",");
                    string[] statusDeeltjes = status[0].Split(":");
                    double batteryLevel = Convert.ToDouble(statusDeeltjes[1].Trim('"'));

                    _stationRepository.AddBatteryPercentage(message.StationId, batteryLevel);
                    break;

                default:
                    // We hebben geen default
                    break;
            }
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Stopt");
    }
}