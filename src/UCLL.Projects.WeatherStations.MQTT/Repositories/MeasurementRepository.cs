using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories;

public class MeasurementRepository : IMeasurementRepository
{
    private readonly WeatherstationsContext _weatherstationsContext;
    private readonly ILogger<MeasurementRepository> _logger;

    public MeasurementRepository(WeatherstationsContext weatherstationsContext, ILogger<MeasurementRepository> logger)
    {
        _weatherstationsContext = weatherstationsContext;
        _logger = logger;
    }

    public void AddMeasurement(string stationId, string value, string type, string unit)
    {
        using var transaction = _weatherstationsContext.Database.BeginTransaction();

        try
        {
            // Controleren of de sensor en station-sensorlink bestaan of toevoegen indien nodig
            int sensorId = CheckSensorExists(type, unit);
            int linkId = CheckStationSensorExists(stationId, sensorId);

            // Meting toevoegen
            Measurement measurement = new Measurement
            {
                SensorValue = value,
                Timestamp = DateTime.UtcNow,
                StationSensorId = linkId,
            };

            _weatherstationsContext.Measurements.Add(measurement);
            _weatherstationsContext.SaveChanges();

            transaction.Commit(); // Commit de transactie als alles succesvol is
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while adding a measurement.");
            transaction.Rollback(); // Rollback bij een fout
            throw; // Optioneel: gooi de uitzondering verder als je dit elders wilt afhandelen
        }
    }

    public void CheckStationExists(string stationId)
    {
        // Deze methode heeft geen transactie nodig omdat alleen een enkele insert wordt uitgevoerd
        var existingStation = _weatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);

        if (existingStation != null)
        {
            return; // Station bestaat, dus verder niets te doen
        }

        Station station = new Station { Id = stationId };
        _weatherstationsContext.Stations.Add(station);
        _weatherstationsContext.SaveChanges(); // SaveChanges creëert een interne transactie voor de enkele insert
    }

    public int CheckSensorExists(string type, string unit)
    {
        // Geen transactie nodig: een enkele insert is afdoende
        Sensor? sensor = _weatherstationsContext.Sensors.FirstOrDefault(s => s.Type == type);

        if (sensor != null)
        {
            return sensor.Id; // Sensor bestaat al, return het bestaande ID
        }

        sensor = new Sensor
        {
            Type = type,
            Unit = unit
        };

        _weatherstationsContext.Sensors.Add(sensor);
        _weatherstationsContext.SaveChanges(); // SaveChanges creëert een interne transactie voor de enkele insert

        return sensor.Id;
    }

    public int CheckStationSensorExists(string stationId, int sensorId)
    {
        // Geen transactie nodig: een enkele insert is afdoende
        var existingLink = _weatherstationsContext.StationSensors
                             .FirstOrDefault(s => s.StationId == stationId && s.SensorId == sensorId);

        if (existingLink != null)
        {
            return existingLink.Id; // Link bestaat, return het bestaande ID
        }

        StationSensor stationSensor = new StationSensor
        {
            SensorId = sensorId,
            StationId = stationId
        };

        _weatherstationsContext.StationSensors.Add(stationSensor);
        _weatherstationsContext.SaveChanges(); // SaveChanges creëert een interne transactie voor de enkele insert

        return stationSensor.Id;
    }
}
