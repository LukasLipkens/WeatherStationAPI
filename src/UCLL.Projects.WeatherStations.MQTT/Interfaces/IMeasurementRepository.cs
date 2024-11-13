namespace UCLL.Projects.WeatherStations.MQTT.Interfaces;

public interface IMeasurementRepository
{
    void CheckStationExists(string StationId);
    void AddMeasurement(string stationId, string value, string type, string unit);

}