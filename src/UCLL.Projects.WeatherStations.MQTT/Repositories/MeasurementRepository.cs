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


    public bool CheckStaitonExists(string StationId) 
    {
        // Check if the station already exists in the context
        var existingStation = _weatherstationsContext.Stations
                                 .FirstOrDefault(s => s.Id == StationId);

        if (existingStation != null)
        {
            return true; // The station exists, so return true
        }

        // Add the station if it doesn't exist
        Station station = new Station { Id = StationId };
        _weatherstationsContext.Stations.Add(station);
        _weatherstationsContext.SaveChanges();

        return true;


    }



    public int CheckSensorExists(string type, string unit)
    {
        // Check of de sensor al bestaat in de database
        Sensor? sensor = _weatherstationsContext.Sensors.FirstOrDefault(s => s.Type == type);

        if (sensor != null)
            // Sensor bestaat al, dus we hoeven niets te doen
            return sensor.Id;

        // Als de sensor niet bestaat, maken we een nieuwe sensor aan
        sensor = new()
        {
            Type = type,
            Unit = unit
        };

        // Voeg de sensor toe aan de database
        _weatherstationsContext.Sensors.Add(sensor);
        _weatherstationsContext.SaveChanges(); // Zorg ervoor dat de wijzigingen worden opgeslagen en de sensor een ID krijgt
        return sensor.Id;
    }

    public int CheckStationSensorExists(string StationId, int Sensorid) {

        // Check if the station already exists in the context
        var existingLink = _weatherstationsContext.StationSensors
                                 .FirstOrDefault(s => s.StationId == StationId && s.SensorId == Sensorid);

        if (existingLink != null)
        {
            return existingLink.Id; // The station exists, so return true
        }

        StationSensor stationSensor = new StationSensor { SensorId = Sensorid, StationId = StationId };
        _weatherstationsContext.StationSensors.Add(stationSensor);
        _weatherstationsContext.SaveChanges();

        return stationSensor.Id;

    }

    public bool AddMeasurement(string stationId, string value, string type, string unit)
    {

        int sensorId = CheckSensorExists(type, unit);

        int linkId = CheckStationSensorExists(stationId, sensorId);

        Measurement measurement = new Measurement
        {
            SensorValue = value,
            Timestamp = DateTime.UtcNow,
            StationSensorId = linkId,

        };

        _weatherstationsContext.Measurements.Add(measurement);
        _weatherstationsContext.SaveChanges(); // Save the new measurement
        return true;
    }

}