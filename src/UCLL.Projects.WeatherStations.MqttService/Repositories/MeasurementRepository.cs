using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MqttService.Interfaces;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MqttService.Repositories
{
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
                _logger.LogInformation("Measurement added successfully for station '{StationId}' with sensor '{SensorType}' of unit '{SensorUnit}'.", stationId, type, unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding a measurement for station '{StationId}' and sensor '{SensorType}' with unit '{SensorUnit}'.", stationId, type, unit);
                transaction.Rollback(); // Rollback bij een fout
            }
        }

        public void CheckStationExists(string stationId)
        {
            try
            {
                Station? existingStation = _weatherstationsContext.Stations.Find(stationId);

                if (existingStation != null) // Station exists, update last activity timestamp and early return
                {
                    existingStation.LastActivityTimestamp = DateTime.UtcNow;
                    return;
                }

                _weatherstationsContext.Stations.Add(new()
                {
                    Id = stationId,
                    LastActivityTimestamp = DateTime.UtcNow,
                });
                _weatherstationsContext.SaveChanges();

                _logger.LogInformation("New station '{StationId}' added to the system.", stationId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while checking or adding station '{StationId}'.", stationId);
            }
        }

        public int CheckSensorExists(string type, string unit)
        {
            try
            {
                // Geen transactie nodig: een enkele insert is afdoende
                Sensor? sensor = _weatherstationsContext.Sensors.FirstOrDefault(s => s.Type == type);

                if (sensor != null)
                {
                    //_logger.LogInformation("Sensor '{SensorType}' already exists with ID {SensorId}.", type, sensor.Id);
                    return sensor.Id; // Sensor bestaat al, return het bestaande ID
                }

                sensor = new Sensor
                {
                    Type = type,
                    Unit = unit
                };

                _weatherstationsContext.Sensors.Add(sensor);
                _weatherstationsContext.SaveChanges(); // SaveChanges creëert een interne transactie voor de enkele insert

                //_logger.LogInformation("New sensor '{SensorType}' of unit '{SensorUnit}' added to the system with ID {SensorId}.", type, unit, sensor.Id);
                return sensor.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while checking or adding sensor '{SensorType}' with unit '{SensorUnit}'.", type, unit);
                throw; // Gooi de uitzondering opnieuw zodat de caller weet dat er een fout is opgetreden
            }
        }

        public int CheckStationSensorExists(string stationId, int sensorId)
        {
            try
            {
                // Geen transactie nodig: een enkele insert is afdoende
                var existingLink = _weatherstationsContext.StationSensors
                                 .FirstOrDefault(s => s.StationId == stationId && s.SensorId == sensorId);

                if (existingLink != null)
                {
                    //_logger.LogInformation("Station-Sensor link for station '{StationId}' and sensor ID {SensorId} already exists.", stationId, sensorId);
                    return existingLink.Id; // Link bestaat, return het bestaande ID
                }

                StationSensor stationSensor = new StationSensor
                {
                    SensorId = sensorId,
                    StationId = stationId
                };

                _weatherstationsContext.StationSensors.Add(stationSensor);
                _weatherstationsContext.SaveChanges(); // SaveChanges creëert een interne transactie voor de enkele insert

                //_logger.LogInformation("New station-sensor link created for station '{StationId}' and sensor ID {SensorId}.", stationId, sensorId);
                return stationSensor.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while checking or adding station-sensor link for station '{StationId}' and sensor ID {SensorId}.", stationId, sensorId);
                throw; // Gooi de uitzondering opnieuw zodat de caller weet dat er een fout is opgetreden
            }
        }
    }
}