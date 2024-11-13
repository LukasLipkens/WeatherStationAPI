using System.Text;
using System.Threading.Channels;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client;
using UCLL.Projects.WeatherStations.MQTT.Models;
using UCLL.Projects.WeatherStations.MQTT.Settings;

namespace UCLL.Projects.WeatherStations.MQTT.Services;

public class MqttService : IHostedService
{
    private readonly MqttSettings _mqttSettings;
    private readonly Channel<MqttMessage> _channel;
    private readonly ILogger<MqttService> _logger;
    private readonly IMqttClient _mqttClient;
    private readonly MqttClientOptions _mqttOptions;

    public MqttService(ILogger<MqttService> logger, IOptions<MqttSettings> mqttOptions, Channel<MqttMessage> channel)
    {
        _mqttSettings = mqttOptions.Value;
        _logger = logger;
        _channel = channel;
        MqttFactory factory = new();

        _mqttClient = factory.CreateMqttClient();

        _mqttOptions = new MqttClientOptionsBuilder()
            .WithClientId("MqttProcessing")
            .WithTcpServer(_mqttSettings.Host, _mqttSettings.Port)
            .WithCredentials(_mqttSettings.Username, _mqttSettings.Password)
            .WithCleanSession()
            .Build();
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Attempting to connect to the MQTT broker...");
            await _mqttClient.ConnectAsync(_mqttOptions, cancellationToken);
            _logger.LogInformation("Connected to MQTT broker successfully.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to connect to MQTT broker. Retrying...");
            await Task.Delay(5000, cancellationToken); // Wacht 5 seconden en probeer opnieuw
            await StartAsync(cancellationToken); // Probeer opnieuw te starten
        }

        // Als verbinding is gemaakt, stel de callback in voor het ontvangen van berichten
        _mqttClient.ApplicationMessageReceivedAsync += async e =>
        {
            try
            {
                string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                string topic = e.ApplicationMessage.Topic;
                _logger.LogInformation($"Received message on topic {topic}: {message}");

                var topicParts = topic.Split('/');
                var mqttMessage = new MqttMessage
                {
                    StationId = topicParts[^2],
                    Topic = topicParts[^1],
                    Payload = message
                };

                // Schrijf het bericht naar de channel
                await _channel.Writer.WriteAsync(mqttMessage, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error handling incoming MQTT message.");
            }
        };

        try
        {
            await _mqttClient.SubscribeAsync(_mqttSettings.SubscribeTopic);
            _logger.LogInformation($"Subscribed to topic: {_mqttSettings.SubscribeTopic}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to subscribe to MQTT topic.");
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Attempting to disconnect from MQTT broker...");
        try
        {
            await _mqttClient.DisconnectAsync();
            _logger.LogInformation("Disconnected from MQTT broker.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while disconnecting from MQTT broker.");
        }

        // Verbindingsherstel
        _mqttClient.DisconnectedAsync += async e =>
        {
            _logger.LogWarning("Disconnected from MQTT broker. Attempting to reconnect...");
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    await _mqttClient.ConnectAsync(_mqttOptions, cancellationToken);
                    _logger.LogInformation("Reconnected to MQTT broker.");
                    break; // Als de verbinding succesvol is hersteld, stop met proberen
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Reconnection failed. Trying again in 5 seconds.");
                    await Task.Delay(5000, cancellationToken); // Wacht 5 seconden en probeer opnieuw
                }
            }
        };
    }
}
