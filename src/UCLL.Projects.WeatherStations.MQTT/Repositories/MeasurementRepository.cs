using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Services;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories;

public class MeasurementRepository : IMeasurementRepository
{
    private readonly WeatherstationsContext _weatherstationsContext;


    public MeasurementRepository(WeatherstationsContext weatherstationsContect, ILogger<DatabaseService> logger)
    {
        _weatherstationsContext = weatherstationsContect;
    }

    public bool AddMeasurements(string StationId, string Payload)
    {
        return false;
    }

    public bool CheckSensorExists(string type, string unit, string stationId)
    {
        // Check of de sensor al bestaat in de database
        Sensor? sensor = _weatherstationsContext.Sensors.FirstOrDefault(s => s.Type == type);

        if (sensor != null)
            // Sensor bestaat al, dus we hoeven niets te doen
            return true;

        // Als de sensor niet bestaat, maken we een nieuwe sensor aan
        sensor = new()
        {
            Type = type,
            Unit = unit
        };

        // Voeg de sensor toe aan de database
        _weatherstationsContext.Sensors.Add(sensor);
        _weatherstationsContext.SaveChanges(); // Zorg ervoor dat de wijzigingen worden opgeslagen en de sensor een ID krijgt

        // Maak een nieuwe Station_Sensor aan en koppel de nieuwe sensor
        Station_Sensor stationSensor = new Station_Sensor
        {
            StationId = stationId,
            SensorId = sensor.Id
        };

        // Voeg de Station_Sensor toe aan de database
        _weatherstationsContext.Station_Sensors.Add(stationSensor);
        _weatherstationsContext.SaveChanges(); // Zorg ervoor dat deze wijziging ook wordt opgeslagen

        // Retourneer true omdat de sensor is toegevoegd
        return true;
    }
}