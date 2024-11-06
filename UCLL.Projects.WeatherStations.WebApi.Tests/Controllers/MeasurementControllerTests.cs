using Microsoft.AspNetCore.Mvc;
using Moq;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.WebApi.Controllers;
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
    }
}
