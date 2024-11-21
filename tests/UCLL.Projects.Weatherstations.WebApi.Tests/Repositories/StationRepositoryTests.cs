using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.WebApi.Repositories;

namespace UCLL.Projects.Weatherstations.WebApi.Tests.Repositories
{
    public class StationRepositoryTests : IDisposable
    {
        private readonly StationRepository _stationRepository;
        private readonly WeatherstationsContext _context;

        public StationRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<WeatherstationsContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new WeatherstationsContext(options);

            SeedDatabase();

            _stationRepository = new StationRepository(_context);
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
        public void StationRepository_GetAllStations_returnsAllStations_WhenStationsExist()
        {
            //Act
            var result = _stationRepository.GetAllStations();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void StationRepository_GetStationsLatestMeasurements_returnsStationMeasurements_WhenMeasurementsExist()
        {
            //Arrange
            List<string>stationIds = new List<string> { "1", "2"};
            int measurementAmount = 3;

            //Act
            var result = _stationRepository.GetStationsLatestMeasurements(stationIds, measurementAmount);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            foreach (var station in result)
            {
                Assert.Contains(station.Id, stationIds);
                Assert.NotNull(station.Sensors);

                foreach (var sensor in station.Sensors)
                {
                    //controleert of er evenveel metingen zijn als er gevraagd is geweest
                    Assert.True(sensor.Measurements?.Count() <= measurementAmount,
                        "Er zitten meer metingen in dan verwacht");

                    //controleert of de metingen juist staan gesorteerd
                    var timestamps = sensor.Measurements.Select(m => m.Timestamp).ToList();
                    Assert.True(timestamps.SequenceEqual(timestamps.OrderByDescending(t => t)),
                        $"De metingen voor sensor {sensor.Id} zijn niet correct gesorteerd.");
                }
            }

        }
        [Fact]
        public void StationRepository_GetStationsLatestMeasurements_returnsEmpty_WhenNoMeasurementsExist()
        {
            //Arrange
            List<string> stationIds = new List<string> { "3", "4" };
            int measurementAmount = 3;

            //Act
            var result = _stationRepository.GetStationsLatestMeasurements(stationIds, measurementAmount);

            //Assert
            Assert.NotNull(result);
            Assert.Empty(result);
        }


        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}