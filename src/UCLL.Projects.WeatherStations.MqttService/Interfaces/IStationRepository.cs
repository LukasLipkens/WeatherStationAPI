namespace UCLL.Projects.WeatherStations.MqttService.Interfaces
{
    public interface IStationRepository
    {
        void AddLocationStation(string stationId, double latitude, double longitude);
        void AddInfoStation(string stationId, string name, string password);
    }
}
