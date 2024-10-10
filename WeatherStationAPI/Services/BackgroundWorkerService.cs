
using MQTTnet;
using MQTTnet.Client;
using System.Text;
using System.Threading;

namespace WeatherStationAPI.Services
{
    public class BackgroundWorkerService : BackgroundService
    {
        private readonly ILogger<BackgroundWorkerService> _logger;

        public BackgroundWorkerService(ILogger<BackgroundWorkerService> logger)
        {
            _logger = logger;
        }
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            string broker = "www.lukaslipkens.be";
            int port = 1883;
            string clientId = Guid.NewGuid().ToString();
            string username = "station";
            string password = "Elo-Ict-2024";
            string topic = "station/data/#";

            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithClientId(clientId)
                .WithTcpServer(broker, port)
                .WithCredentials(username, password)
                .WithCleanSession()
                .Build();


            _logger.LogInformation("worker is running at: {time}", DateTimeOffset.Now);


            var connectResult = await mqttClient.ConnectAsync(options, stoppingToken);

            if (connectResult.ResultCode == MqttClientConnectResultCode.Success)
            {
                _logger.LogInformation("Connected to MQTT broker");
                await mqttClient.SubscribeAsync(topic);

                mqttClient.ApplicationMessageReceivedAsync += e =>
                {
                    _logger.LogInformation($"Received message: {Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment)}");
                    return Task.CompletedTask;
                };

            }
            else
            {
                _logger.LogError("Failed to connect to MQTT broker");
            }



            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
