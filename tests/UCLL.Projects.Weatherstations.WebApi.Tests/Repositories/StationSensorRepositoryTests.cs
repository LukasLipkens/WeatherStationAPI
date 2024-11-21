using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.WebApi.Repositories;

namespace UCLL.Projects.Weatherstations.WebApi.Tests.Repositories
{
    public class StationSensorRepositoryTests
    {
        private readonly StationSensorRepository _stationSensorRepository;
        private readonly WeatherstationsContext _context;

        public StationSensorRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<WeatherstationsContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new(options);

            SeedDatabase();

            _stationSensorRepository = new(_context);
        }

        private void SeedDatabase()
        {
            // Voeg stations toe
            _context.Stations.Add(new Station { Id = "1", LastActivityTimestamp = DateTime.UtcNow, Latitude = 34.0522, Longitude = -118.2437 });
            _context.Stations.Add(new Station { Id = "2", LastActivityTimestamp = DateTime.UtcNow, Latitude = 67.5768, Longitude = 12.9878 });

            // Voeg de sensoren toe
            _context.Sensors.Add(new Sensor { Id = 1, Type = "Temperature", Unit = "Celsius" });
            _context.Sensors.Add(new Sensor { Id = 2, Type = "Humidity", Unit = "%" });
            _context.Sensors.Add(new Sensor { Id = 3, Type = "Pressure", Unit = "hPa" });

            // Voeg de station-sensor relaties toe
            _context.StationSensors.Add(new StationSensor { Id = 1, StationId = "1", SensorId = 1 });
            _context.StationSensors.Add(new StationSensor { Id = 2, StationId = "1", SensorId = 2 });
            _context.StationSensors.Add(new StationSensor { Id = 3, StationId = "1", SensorId = 3 });

            _context.StationSensors.Add(new StationSensor { Id = 4, StationId = "2", SensorId = 1 });
            _context.StationSensors.Add(new StationSensor { Id = 5, StationId = "2", SensorId = 2 });
            _context.StationSensors.Add(new StationSensor { Id = 6, StationId = "2", SensorId = 3 });

            // Voeg measurements toe
            _context.Measurements.Add(new Measurement
            {
                Timestamp = DateTime.UtcNow.AddDays(-5),
                StationSensorId = 1,
                SensorValue = "25.5"
            });
            _context.Measurements.Add(new Measurement
            {
                Timestamp = DateTime.UtcNow.AddDays(-3),
                StationSensorId = 2,
                SensorValue = "60"
            });
            _context.Measurements.Add(new Measurement
            {
                Timestamp = DateTime.UtcNow.AddDays(-2),
                StationSensorId = 3,
                SensorValue = "1013"
            });

            _context.SaveChanges();
        }

        [Fact]
        public void StationRepository_FindStationSensor_ReturnsSensor_WhenItExistsInStation()
        {
            //Arrange
            string stationId = "1";
            int sensorId = 1;

            //Act
            var result = _stationSensorRepository.FindStationSensor(stationId, sensorId);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(stationId, result.StationId);
            Assert.Equal(sensorId, result.SensorId);
        }
        [Fact]
        public void StationRepository_FindStationSensor_ReturnEmpty_WhenNoSensorOrStationExist()
        {
            //Arrange
            string stationId = "10";
            int sensorId = 1;

            //Act
            var result = _stationSensorRepository.FindStationSensor(stationId, sensorId);

            //Assert
            Assert.Null(result);
        }

    }
}