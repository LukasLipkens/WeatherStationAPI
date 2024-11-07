namespace UCLL.Projects.WeatherStations.Shared
{
    public class MqttMessage
    {
        public string Topic { get; set; }
        public string StationId{ get; set; }
        public string Payload { get; set; }
    }
}
