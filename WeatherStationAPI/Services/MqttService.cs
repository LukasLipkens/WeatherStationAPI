using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Services
{
    public class MqttService
    {
        private readonly IMeasurementsRepository _measurementsRepository;
        private readonly IWeatherStationsRepository _weatherStationsRepository;
        private IMqttClient _mqttClient;

        public MqttService(IMeasurementsRepository measurementsRepository, IWeatherStationsRepository weatherStationsRepository)
        {
            _measurementsRepository = measurementsRepository;
            _weatherStationsRepository = weatherStationsRepository;
        }

        public async Task ConnectAndSubscribeAsync()
        {
            var mqttFactory = new MqttFactory();
            _mqttClient = mqttFactory.CreateMqttClient();

            var mqttOptions = new MqttClientOptionsBuilder()
                .WithClientId("WeatherStationClient")
                .WithTcpServer("mqtt.yourbroker.com", 1883) // yet to replace
                .WithCleanSession()
                .Build();

            _mqttClient.ConnectedAsync += async e =>
            {
                Console.WriteLine("Connected to MQTT Broker.");
                
                var subscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => { f.WithTopic("weather/station/measurements"); }) // the topic structure we have to agree to
                    .Build();

                await _mqttClient.SubscribeAsync(subscribeOptions);
                Console.WriteLine("Subscribed to topic weather/station/measurements."); //confirmation in text what the topic is
            };

            _mqttClient.DisconnectedAsync += e =>
            {
                Console.WriteLine("Disconnected from MQTT Broker.");
                return Task.CompletedTask;
            };


            _mqttClient.ApplicationMessageReceivedAsync += async e =>
            {
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.PayloadSegment.ToArray());
                Console.WriteLine($"Received message: {payload} from topic: {e.ApplicationMessage.Topic}");

                var stations = JsonConvert.DeserializeObject<List<WeatherStationDto>>(payload);
                if (stations != null)
                {
                    foreach (var weatherStationDto in stations)
                    {
                        var station = new WeatherStation
                        {
                            StationId = weatherStationDto.Id,
                            StationInfo = weatherStationDto.StationInfo,
                            Sensors = weatherStationDto.SensorTypeStation.Select(sts => new Sensor
                            {
                                SensorId = sts.Id,
                                Name = sts.SensorType.Name,
                                Unit = sts.SensorType.Unit,
                                StationId = weatherStationDto.Id
                            }).ToList()
                        };
                        await _weatherStationsRepository.AddWeatherStationAsync(station);

                        foreach (var sensorTypeStation in weatherStationDto.SensorTypeStation)
                        {
                            foreach (var measurementDto in sensorTypeStation.Measurement)
                            {
                                var measurement = new Measurement
                                {
                                    Id = weatherStationDto.Id,
                                    SensorId = sensorTypeStation.SensorTypeId,
                                    Timestamp = measurementDto.Time,
                                    Value = measurementDto.Value,
                                };

                                await _measurementsRepository.AddMeasurementAsync(measurement);
                            }
                        }
                    }
                }
            };

            await _mqttClient.ConnectAsync(mqttOptions, CancellationToken.None);
        }
    }
}
