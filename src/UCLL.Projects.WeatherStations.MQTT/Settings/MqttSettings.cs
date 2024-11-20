namespace UCLL.Projects.WeatherStations.MQTT.Settings;

public class MqttSettings
{
    public required string Host { get; init; }
    public required int Port { get; init; }
    public required string Username { get; init; }
    public required string Password { get; init; }
    public required int ReceiveMaximumCount { get; init; }
    public required string ClientId { get; init; }
    public required string SubscribeTopic { get; init; }
}