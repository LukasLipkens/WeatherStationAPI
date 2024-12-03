using System.Globalization;
using System.Threading.Channels;
using System.Web;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MqttService.Interfaces;
using UCLL.Projects.WeatherStations.MqttService.Models;

namespace UCLL.Projects.WeatherStations.MqttService.Services;

public class DatabaseService : IHostedService
{
    private readonly Channel<MqttMessage> _channel;
    private readonly ILogger<DatabaseService> _logger;

    private readonly IMeasurementRepository _measurementRepository;
    private readonly IStationRepository _stationRepository;

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
            try
            {
                // Controleer of het station bestaat
                _measurementRepository.CheckStationExists(message.StationId);

                switch (message.Topic)
                {
                    case "measurement":
                        try
                        {
                            string[] measurement = message.Payload.Trim('{', '}').Split(",");
                            foreach (var item in measurement)
                            {
                                string[] deeltjes = item.Split(":");
                                string value = deeltjes[1].Trim('"');
                                string[] typeUnit = deeltjes[0].Split("(");
                                string type = typeUnit[0].Trim('"');
                                string unit = typeUnit[1].Trim(')', '"');

                                // Voeg de meting toe aan de repository
                                _measurementRepository.AddMeasurement(message.StationId, value, type, unit);
                            }
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, $"Error processing 'measurement' topic for station {message.StationId}");
                        }
                        break;

                    case "location":
                        try
                        {
                            string[] location = message.Payload.Trim('{', '}').Split(",");

                            string input = location[0].Split(":")[1].Trim('"').Replace(',', '.');
                            double latitude = Convert.ToDouble(input, CultureInfo.InvariantCulture);

                            //double latitude = Convert.ToDouble(location[0].Split(":")[1].Trim('"'));

                            input = location[1].Split(":")[1].Trim('"').Replace(',', '.');
                            double longitude = Convert.ToDouble(input, CultureInfo.InvariantCulture);

                            //double longitude = Convert.ToDouble(location[1].Split(":")[1].Trim('"'));

                            // Voeg locatie toe aan de repository
                            _stationRepository.AddLocationStation(message.StationId, latitude, longitude);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, $"Error processing 'location' topic for station {message.StationId}");
                        }
                        break;

                    case "info":
                        try
                        {
                            string[] info = message.Payload.Trim('{', '}').Split(",");
                            string name = info[0].Split(":")[1].Trim('"');
                            string password = info[1].Split(":")[1].Trim('"');

                            password = HttpUtility.UrlDecode(password); 
                            name = HttpUtility.UrlDecode(name);
                            
                            _stationRepository.AddInfoStation(message.StationId, name, password);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex, $"Error processing 'info' topic for station {message.StationId}");
                        }

                        break;

                    default:
                        _logger.LogWarning($"Unknown topic '{message.Topic}' received for station {message.StationId}");
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error processing message from station {message.StationId}");
            }
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Stopping the service.");
    }
}