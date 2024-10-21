using MQTTnet;
using MQTTnet.Client;
using System.Text;

/*
    dit is een manier om mqtt te gebruiken in c#
    ik ben niet zeker dat dit een goede manier is om dit te doen
        er is namelijk niet veel structuur, hier ben ik nog mee bezig
 */


namespace WeatherStationMQTT
{
    class Publisher
    {
        static async Task Main(string[] args)
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

            var connectionResult = mqttClient.ConnectAsync(options).Result;

            if(connectionResult.ResultCode == MqttClientConnectResultCode.Success)
            {
                Console.WriteLine("Connected to MQTT broker");
                await mqttClient.SubscribeAsync(topic);

                mqttClient.ApplicationMessageReceivedAsync += e =>
                {
                    Console.WriteLine("Received message on topic: " + e.ApplicationMessage.Topic);
                    Console.WriteLine($"Received message: {Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment)}");

                    // hier bericht verwerken


                    return Task.CompletedTask;
                };

            }
            else
            {
                Console.WriteLine("Failed to connect to MQTT broker");
                return;
            }

            while (true)
            {

            }

        }
    }
}