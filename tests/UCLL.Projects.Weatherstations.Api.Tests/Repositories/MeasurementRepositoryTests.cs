﻿using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Api.Repositories;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.Weatherstations.Api.Tests.Repositories
{
    public class MeasurementRepositoryTests : IDisposable
    {
        private readonly WeatherstationsContext _context;
        private readonly MeasurementRepository _measurementRepository;

        public MeasurementRepositoryTests()
        {
            //Aanmaken van een in-memory database, isoleren zo de repository
            var options = new DbContextOptionsBuilder<WeatherstationsContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new WeatherstationsContext(options);

            //seed db
            SeedDatabase();

            //measurementRepository initialiseren
            _measurementRepository = new MeasurementRepository(_context);
        }

        private void SeedDatabase()
        {
            // Voeg het station toe
            _context.Stations.Add(new Station { Id = "1", LastActivityTimestamp = DateTime.UtcNow, Latitude = 34.0522, Longitude = -118.2437 });

            // Voeg de sensoren toe
            _context.Sensors.Add(new Sensor { Id = 1, Type = "Temperature", Unit = "Celsius" });
            _context.Sensors.Add(new Sensor { Id = 2, Type = "Humidity", Unit = "%" });
            _context.Sensors.Add(new Sensor { Id = 3, Type = "Pressure", Unit = "hPa" });

            // Voeg de station-sensor relaties toe
            _context.StationSensors.Add(new StationSensor { Id = 1, StationId = "1", SensorId = 1 });
            _context.StationSensors.Add(new StationSensor { Id = 2, StationId = "1", SensorId = 2 });
            _context.StationSensors.Add(new StationSensor { Id = 3, StationId = "1", SensorId = 3 });

            // Voeg measurements toe die binnen het tijdsbereik vallen
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
        public void MeasurementRepository_GetAllMeasurementsFromStationSensor_ReturnsMeasurements_WhenMeasurementsExists()
        {
            //Arrange
            int stationSensorId = 1; //deze stationSensorId is aanwezig in de database seeder

            //Act
            var result = _measurementRepository.GetAllMeasurementsFromStationSensor(stationSensorId);

            //Assert
            Assert.NotNull(result); //kijkt of het niet null is
            Assert.True(result.Count() > 0); //kijkt of er meer als 0 gegevens zijn opgehaald
        }
        [Fact]
        public void MeasurementRepository_GetMeasurementsFromSensorInTimeRange_ReturnsMeasurements_WhenMeasurementsInTimeRange()
        {
            //Arrange

            //zorg dat de parameters overeenkomen met de geseede data
            string stationId = "1";
            DateTime startDate = DateTime.UtcNow.AddDays(-10);
            DateTime endDate = DateTime.UtcNow;
            List<int>sensorIds = new List<int> { 1, 2, 3};

            //Act
            var result = _measurementRepository.GetMeasurementsFromSensorInTimeRange(stationId, startDate, endDate, sensorIds);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
            var sensorDto = result.First();
            Assert.Contains(sensorDto.Id, sensorIds);
        }

        [Fact]
        public void MeasurementRepository_GetMeasurementsFromSensorInTimeRange_ReturnsEmpty_WhenNoMeasurementsInTimeRange()
        {
            //Arrange

            //zorg dat de parameters overeenkomen met de geseede data
            string stationId = "1";
            DateTime startDate = DateTime.UtcNow.AddYears(-1);
            DateTime endDate = DateTime.UtcNow.AddYears(-1).AddDays(1);
            List<int> sensorIds = new List<int> { 1, 2, 3 };

            //Act
            var result = _measurementRepository.GetMeasurementsFromSensorInTimeRange(stationId, startDate, endDate, sensorIds);

            //Assert
            Assert.NotNull (result);
            Assert.Empty(result);
        }

        public void Dispose()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }
    }
}