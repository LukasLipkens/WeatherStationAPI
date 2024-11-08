namespace UCLL.Projects.WeatherStations.MQTT.Interfaces;

public interface IMeasurementRepository
{
    bool AddMeasurements(string StationId, string Payload);

    bool CheckSensorExists(string type, string unit, string stationId);
}