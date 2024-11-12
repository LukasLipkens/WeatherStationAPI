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
        _mqttClient.ConnectedAsync += async e =>
        {
            _logger.LogInformation("Connected to MQTT broker");

            // subscribe to all topics
            await _mqttClient.SubscribeAsync(_mqttSettings.SubscribeTopic);

            _logger.LogInformation($"Subscribed to topic: {_mqttSettings.SubscribeTopic}");
        };

        //handler when disconnected from broker
        _mqttClient.DisconnectedAsync += e =>
        {
            _logger.LogWarning("Disconnected from MQTT broker");
            return Task.CompletedTask;
        };

        //handler when message is received
        _mqttClient.ApplicationMessageReceivedAsync += e =>
        {
            string message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
            string? topic = e.ApplicationMessage.Topic;
            _logger.LogInformation($"\u001b[32mReceived on topic {topic} message: {message}\u001b[0m");

            string[] topicParts = topic.Split('/');

            MqttMessage mqttmessage = new();

            mqttmessage.StationId = topicParts[^2];
            mqttmessage.Topic = topicParts[^1];
            mqttmessage.Payload = message;


            // hier zou je de data in de queue moeten stoppen
            _channel.Writer.TryWrite(mqttmessage);

            //_channel.Reader.TryRead(out var data);

            //_logger.LogInformation($"\u001b[34mData in queue: {data}\u001b[0m");


            return Task.CompletedTask;
        };

        //connect to the broker
        await _mqttClient.ConnectAsync(_mqttOptions, cancellationToken);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        _logger.LogWarning("Disconnected from MQTT Broker...");
        await _mqttClient.DisconnectAsync();
    }
}