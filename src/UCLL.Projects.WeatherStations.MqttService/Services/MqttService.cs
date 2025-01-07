using System.Text;
using System.Threading.Channels;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client;
using UCLL.Projects.WeatherStations.MqttService.Models;
using UCLL.Projects.WeatherStations.MqttService.Settings;

namespace UCLL.Projects.WeatherStations.MqttService.Services;

public class MqttService : IHostedService
{
    private readonly MqttSettings _mqttSettings;
    private readonly Channel<MqttMessage> _channel;
    private readonly ILogger<MqttService> _logger;
    private readonly IMqttClient _mqttClient;
    private readonly MqttClientOptions _mqttOptions;
    private bool _isStopping;

    public MqttService(ILogger<MqttService> logger, IOptions<MqttSettings> mqttOptions, Channel<MqttMessage> channel)
    {
        _mqttSettings = mqttOptions.Value;
        _logger = logger;
        _channel = channel;

        var factory = new MqttFactory();
        _mqttClient = factory.CreateMqttClient();

        _mqttOptions = new MqttClientOptionsBuilder()
            .WithClientId($"{_mqttSettings.ClientId}_{Guid.NewGuid()}")
            .WithTcpServer(_mqttSettings.Host, _mqttSettings.Port)
            .WithCredentials(_mqttSettings.Username, _mqttSettings.Password)
            .WithCleanSession()
            .Build();

        // Handle disconnection
        _mqttClient.DisconnectedAsync += HandleDisconnectionAsync;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Starting MQTT service...");

        try
        {
            await ConnectAsync(cancellationToken);

            _mqttClient.ApplicationMessageReceivedAsync += HandleIncomingMessageAsync;

            var subscribeOptions = new MqttClientSubscribeOptionsBuilder()
            .WithTopicFilter(f =>
            {
                f.WithTopic(_mqttSettings.SubscribeTopic);
            })
            .Build();

            await _mqttClient.SubscribeAsync(subscribeOptions, cancellationToken);
            _logger.LogInformation($"Subscribed to topic: {_mqttSettings.SubscribeTopic}");

            _logger.LogInformation($"Subscribed to topic: {_mqttSettings.SubscribeTopic}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to start MQTT service.");
            throw;
        }
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Attempting to disconnect from MQTT broker...");
        try
        {
            var disconnectOptions = new MqttClientDisconnectOptionsBuilder()
                .WithReason(MqttClientDisconnectOptionsReason.NormalDisconnection) // Correct enum type
                .Build();

            await _mqttClient.DisconnectAsync(disconnectOptions, cancellationToken);
            _logger.LogInformation("Disconnected from MQTT broker.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while disconnecting from MQTT broker.");
        }
    }



    private async Task ConnectAsync(CancellationToken cancellationToken)
    {
        try
        {
            _logger.LogInformation("Connecting to MQTT broker...");
            await _mqttClient.ConnectAsync(_mqttOptions, cancellationToken);
            _logger.LogInformation("Connected to MQTT broker.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to connect to MQTT broker. Retrying in 5 seconds...");
            await Task.Delay(5000, cancellationToken);
            if (!_isStopping) await ConnectAsync(cancellationToken);
        }
    }

    private async Task HandleDisconnectionAsync(MqttClientDisconnectedEventArgs e)
    {
        if (_isStopping) return;

        _logger.LogWarning("Disconnected from MQTT broker. Attempting to reconnect...");
        int retryDelay = 1000; // Start with 1 second delay
        const int maxRetryDelay = 30000; // Max delay of 30 seconds

        while (!_isStopping)
        {
            try
            {
                await ConnectAsync(CancellationToken.None);
                break;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Reconnection attempt failed.");
                await Task.Delay(retryDelay);

                retryDelay = Math.Min(retryDelay * 2, maxRetryDelay); // Exponential backoff
            }
        }
    }

    private async Task HandleIncomingMessageAsync(MqttApplicationMessageReceivedEventArgs e)
    {
        try
        {
            string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            string topic = e.ApplicationMessage.Topic;

            _logger.LogInformation($"Received message on topic '{topic}': {message}");

            var topicParts = topic.Split('/');
            var mqttMessage = new MqttMessage
            {
                StationId = topicParts[^2],
                Topic = topicParts[^1],
                Payload = message
            };

            await _channel.Writer.WriteAsync(mqttMessage);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing incoming MQTT message.");
        }
    }
}