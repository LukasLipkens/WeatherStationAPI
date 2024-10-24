﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MQTTnet;
using MQTTnet.Client;
using System.Text;

namespace UCLL.Projects.WeatherStations.MQTT.Services
{
    public class MqttService : IHostedService
    {
        private readonly ILogger<MqttService> _logger;
        private IMqttClient _mqttClient;
        private  MqttClientOptions _mqttOptions;

        public MqttService(ILogger<MqttService> logger)
        {
            _logger = logger;
            var factory = new MqttFactory();

            _mqttClient = factory.CreateMqttClient();

            // dit kan eventueel beter in een appsettings.json
            _mqttOptions = new MqttClientOptionsBuilder()
                .WithClientId("MqttProcessing")
                .WithTcpServer("k106.ucll-labo.be", 1883)
                .WithCredentials("project", "eloict1234")
                .WithCleanSession()
                .Build();

        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _mqttClient.ConnectedAsync += async e =>
            {
                _logger.LogInformation("Connected to MQTT broker");

                // subscribe to all topics
                await _mqttClient.SubscribeAsync("weatherstations/data/#");

                _logger.LogInformation("Subscribed to topic: weatherstations/data/#");
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
                var message = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                var topic = e.ApplicationMessage.Topic;
                _logger.LogInformation($"Received on topic {topic} message: {message}");


                // hier zou je de data in de queue moeten stoppen


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
}
