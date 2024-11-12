namespace UCLL.Projects.WeatherStations.MQTT.Interfaces;

public interface IMeasurementRepository
{
    bool AddMeasurements(string StationId, string Payload);

    int CheckSensorExists(string type, string unit);

    bool CheckStaitonExists(string StationId);
    bool AddMeasurement(string stationId, string value, string type, string unit);

}