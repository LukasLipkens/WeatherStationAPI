using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Services;
using UCLL.Projects.WeatherStations.MQTT.Data;
using UCLL.Projects.WeatherStations.Shared;
using UCLL.Projects.WeatherStations.Shared.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly DataContext _dataContext;


        public MeasurementRepository(DataContext dataContect, ILogger<DatabaseService> logger)
        {
            _dataContext = dataContect;
        }

        public bool AddMeasurements(string StationId, string Payload)
        {
            return false;
        }

        public bool CheckSensorExists(string type, string unit, string stationId)
        {
            // Check of de sensor al bestaat in de database
            var sensor = _dataContext.Sensors.FirstOrDefault(s => s.Type == type);

            if (sensor != null)
            {
                // Sensor bestaat al, dus we hoeven niets te doen
                return true;
            }

            // Als de sensor niet bestaat, maken we een nieuwe sensor aan
            sensor = new Sensor
            {
                Type = type,
                Unit = unit
            };

            // Voeg de sensor toe aan de database
            _dataContext.Sensors.Add(sensor);
            _dataContext.SaveChanges(); // Zorg ervoor dat de wijzigingen worden opgeslagen en de sensor een ID krijgt

            // Maak een nieuwe Station_Sensor aan en koppel de nieuwe sensor
            var stationSensor = new Station_Sensor
            {
                StationId = stationId,
                SensorId = sensor.Id
            };

            // Voeg de Station_Sensor toe aan de database
            _dataContext.Station_Sensors.Add(stationSensor);
            _dataContext.SaveChanges(); // Zorg ervoor dat deze wijziging ook wordt opgeslagen

            // Retourneer true omdat de sensor is toegevoegd
            return true;
        }

    }
}
