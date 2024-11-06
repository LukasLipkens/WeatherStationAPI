﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using NuGet.Frameworks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.WebApi.Controllers;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;
using UCLL.Projects.WeatherStations.WebApi.Models;
using UCLL.Projects.WeatherStations.WebApi.Repositories;

namespace UCLL.Projects.WeatherStations.WebApi.Tests.Controllers
{
    public class MeasurementControllerTests
    {
        private Mock<IMeasurementRepository> _measurementRepositoryMock; //Mock simuleert een moch versie van de interface
        private MeasurementController _measurementController;

        public MeasurementControllerTests()
        {
            _measurementRepositoryMock = new Mock<IMeasurementRepository>();
            //Dit Object-eigenschap is de gesimuleerde versie van de repository, die de controller gebruikt alsof het de echte implementatie is
            _measurementController = new MeasurementController(_measurementRepositoryMock.Object); 
        }

        [Fact]
        public void MeasurementController_GetMeasurementsFromStationSensor_ReturnOK_WhenMeasurementExist()
        {
            //Arrange
            string stationId = "station123";
            int sensorId = 1;
            var measurements = new List<Measurement>
            {
                new Measurement { Timestamp = DateTime.Now.AddDays(-4), SensorId = sensorId, StationId = stationId, Value = 25.5 },
                new Measurement { Timestamp = DateTime.Now, SensorId = sensorId, StationId = stationId, Value = 30.0 }
            };

            //Deze simuleert het aanroepen van GetAllMeasurementsFromStationSensor met zijn parameters maar retourneert automatisch de measurements
            _measurementRepositoryMock.Setup(repo => repo.GetAllMeasurementsFromStationSensor(stationId, sensorId)).Returns(measurements);

            //Act

            //OkObjectResult geeft toegang tot statusCode en values van result
            var result = _measurementController.GetMeasurementsFromStationSensor(stationId, sensorId) as OkObjectResult;

            //Assert
            Assert.NotNull(result); //valideert dus als het OkObject is
            Assert.Equal(200, result.StatusCode); //kijkt of het een 200-OK status is
            Assert.Equal(measurements, result.Value); //kijkt of de 2 waarde gelijk zijn aan elkaar
        }

        [Fact]
        public void MeasurementController_GetMeasurementsFromStationSensor_ReturnNotFound_WhenNoMeasurementExists()
        {
            //Arrange
            string stationId = "station123";
            int sensorId = 1;

            _measurementRepositoryMock.Setup(repo => repo.GetAllMeasurementsFromStationSensor(stationId, sensorId)).Returns((List<Measurement>)null);

            //Act
            var result = _measurementController.GetMeasurementsFromStationSensor(stationId, sensorId) as NotFoundObjectResult;

            //Assert
            Assert.NotNull(result); //valideert als het NotFoundObjectResult is
            Assert.Equal(404, result.StatusCode); //kijkt of het een 404-NotFound status is
            Assert.Equal("Geen metingen gevonden voor het opgegeven station en sensor.", result.Value); //kijkt of de 2 waarde gelijk zijn aan elkaar
        }

        [Fact]
        public void MeasurementController_GetMeasurementsFromStation_ReturnOK_WhenMeasurementExist()
        {
            //Arrange
            string stationId = "station123";
            List<int> sensors = new List<int>{ 1, 2 };
            DateTime startDate = DateTime.UtcNow.AddDays(-7);
            DateTime endDate = DateTime.UtcNow;

            var measurements = new List<SensorDto>
            {
                new SensorDto
                {
                    Id = 1,
                    Unit = "Celsius",
                    Type = "Temperature",
                    Measurements = new List<MeasurementDto>
                    {
                        new MeasurementDto { Timestamp = startDate, Value = 7.0 },
                        new MeasurementDto { Timestamp = startDate.AddHours(2), Value = 8.0}
                    }
                },
                new SensorDto
                {
                    Id = 2,
                    Unit = "%",
                    Type = "Humidity",
                    Measurements = new List<MeasurementDto>
                    {
                        new MeasurementDto { Timestamp = endDate, Value = 76.0 },
                        new MeasurementDto { Timestamp = endDate.AddHours(-2), Value = 72.0}
                    }
                }
            };

            _measurementRepositoryMock.Setup(repo => repo.GetMeasurementsFromSensorInTimeRange(stationId, startDate, endDate, sensors)).Returns(measurements);

            //Act
            var result = _measurementController.GetMeasurementsFromStation(stationId, sensors, startDate, endDate) as OkObjectResult;
            
            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(measurements, result.Value);

            // Verifieer dat de response correct is en de juiste structuur heeft
            var sensorDtos = result.Value as List<SensorDto>;
            Assert.NotNull(sensorDtos);
            Assert.Equal(2, sensorDtos.Count);

            // Controleer details van de eerste SensorDto en zijn MeasurementDto items
            var firstSensor = sensorDtos[0];
            Assert.Equal(1, firstSensor.Id);
            Assert.Equal("Temperature", firstSensor.Type);
            Assert.Equal("Celsius", firstSensor.Unit);
            Assert.Equal(2, firstSensor.Measurements?.Count);
            Assert.Equal(7.0, firstSensor.Measurements?[0].Value);
            Assert.Equal(startDate, firstSensor.Measurements?[0].Timestamp);
            Assert.Equal(8.0, firstSensor.Measurements?[1].Value);
            Assert.Equal(startDate.AddHours(2), firstSensor.Measurements?[1].Timestamp);

            // Controleer details van de tweede SensorDto en zijn MeasurementDto items
            var secondSensor = sensorDtos[1];
            Assert.Equal(2, secondSensor.Id);
            Assert.Equal("Humidity", secondSensor.Type);
            Assert.Equal("%", secondSensor.Unit);
            Assert.Equal(2, secondSensor.Measurements?.Count);
            Assert.Equal(76.0, secondSensor.Measurements?[0].Value);
            Assert.Equal(endDate, secondSensor.Measurements?[0].Timestamp);
            Assert.Equal(72.0, secondSensor.Measurements?[1].Value);
            Assert.Equal(endDate.AddHours(-2), secondSensor.Measurements?[1].Timestamp);
        }
        [Fact]
        public void MeasurementController_GetMeasurementsFromStation_ReturnNotFound_WhenNoMeasurementExist()
        {
            //Arrange
            string stationId = "station123";
            List<int> sensors = new List<int> { 1, 2 };
            DateTime startDate = DateTime.UtcNow.AddDays(-7);
            DateTime endDate = DateTime.UtcNow;

            _measurementRepositoryMock.Setup(repo => repo.GetMeasurementsFromSensorInTimeRange(stationId, startDate, endDate, sensors)).Returns((List<SensorDto>)null);

            //Act
            var result = _measurementController.GetMeasurementsFromStation(stationId, sensors, startDate, endDate) as NotFoundObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(404, result.StatusCode);
            Assert.Equal("Geen metingen gevonden voor dit station", result.Value);
        }
    }
}
