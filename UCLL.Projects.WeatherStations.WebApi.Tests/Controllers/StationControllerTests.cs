using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.WebApi.Controllers;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;
using UCLL.Projects.WeatherStations.WebApi.Models;

namespace UCLL.Projects.WeatherStations.WebApi.Tests.Controllers
{
    public class StationControllerTests
    {
        private Mock<IStationRepository> _stationRepositoryMock;
        private Mock<IMapper> _mapperMock;
        private StationController _stationController;

        public StationControllerTests()
        {
            _stationRepositoryMock = new Mock<IStationRepository>();
            _mapperMock = new Mock<IMapper>();
            _stationController = new StationController(_stationRepositoryMock.Object, _mapperMock.Object);
        }

        [Fact]
        public void StationController_GetAllStations_ReturnOK_WhenStationsExist()
        {
            // Arrange
            var stations = new List<Station>
            {
                new Station { Id = "1", Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
                new Station { Id = "2", Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
            };

            var stationDtos = new List<SimpleStationDto>
            {
                new SimpleStationDto { Id = "1", Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
                new SimpleStationDto { Id = "2", Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
            };

            _stationRepositoryMock.Setup(repo => repo.GetAllStations()).Returns(stations);
            _mapperMock.Setup(mapper => mapper.Map<List<SimpleStationDto>>(It.IsAny<List<Station>>())).Returns(stationDtos);

            // Act
            var result = _stationController.GetAllStations();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result); // Controleert of resultaat een OkObjectResult is
            var returnValue = Assert.IsType<List<SimpleStationDto>>(okResult.Value); // Controleert of de waarde van okValue een lijst is van SimpleStationDtos
            Assert.Equal(2, returnValue.Count);
            Assert.Equal("Station A", returnValue[0].Name); // Correcte naam
            Assert.Equal("Station B", returnValue[1].Name); // Correcte naam

        }

        [Fact]
        public void StationController_GetAllStations_ReturnNotFound_WhenNoStationsExist()
        {
            //Arrange
            _stationRepositoryMock.Setup(repo => repo.GetAllStations()).Returns(new List<Station>());
            _mapperMock.Setup(mapper => mapper.Map<List<SimpleStationDto>>(It.IsAny<List<Station>>())).Returns(new List<SimpleStationDto>());

            // Act
            var result = _stationController.GetAllStations();

            // Assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result); // Controleert of het resultaat een NotFoundObjectResult is
            Assert.Equal("Geen metingen gevonden voor het opgegeven station en sensor.", notFoundResult.Value); // Controleert de inhoud van de foutmelding
        }

        [Fact]
        public void StationController_GetLatestMeasurementsByStationId_ReturnOk_WhenMeasurementsFromStationExists()
        {
            // Arrange
            var stationIds = new List<string> { "1", "2" };
            int measurementAmount = 1;

            // Voorbeelddata die de mock moet retourneren
            var stationsWithMeasurements = new List<StationDto>
            {
                new StationDto
                {
                    Id = "1",
                    Name = "Station A",
                    Latitude = 40.7128,
                    Longitude = -74.0060,
                    Description = "Weather station in New York",
                    Sensors = new List<SensorDto>
                    {
                        new SensorDto
                        {
                            Id = 1,
                            Type = "Temperature",
                            Measurements = new List<MeasurementDto>
                            {
                                new MeasurementDto { Value = 25.5, Timestamp = DateTime.Now }
                            }
                        }
                    }
                },
                new StationDto
                {
                    Id = "2",
                    Name = "Station B",
                    Latitude = 34.0522,
                    Longitude = -118.2437,
                    Description = "Weather station in Los Angeles",
                    Sensors = new List<SensorDto>
                    {
                        new SensorDto
                        {
                            Id = 2,
                            Type = "Humidity",
                            Measurements = new List<MeasurementDto>
                            {
                                new MeasurementDto { Value = 55.2, Timestamp = DateTime.Now }
                            }
                        }
                    }
                }
            };

            // Stel de mock in om de voorbeelddata terug te geven
            _stationRepositoryMock.Setup(repo => repo.GetStationsLatestMeasurements(stationIds, measurementAmount)).Returns(stationsWithMeasurements);

            // Act
            var result = _stationController.GetLatestMeasurementsByStationId(stationIds, measurementAmount);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result); // Controleert of het resultaat een OkObjectResult is
            var returnValue = Assert.IsType<List<StationDto>>(okResult.Value); // Controleert of de waarde een lijst van StationDto's is
            Assert.Equal(2, returnValue.Count); // Controleert dat er 2 stations zijn teruggegeven

            // Controleer de eerste stationgegevens
            Assert.Equal("Station A", returnValue[0].Name);
            Assert.Equal(40.7128, returnValue[0].Latitude);
            Assert.Single(returnValue[0].Sensors); // Controleert dat er precies één sensor is
            Assert.Equal("Temperature", returnValue[0].Sensors[0].Type);
            Assert.Single(returnValue[0].Sensors[0].Measurements); // Controleert dat er één meting is
            Assert.Equal(25.5, returnValue[0].Sensors[0].Measurements[0].Value);

            // Controleer de tweede stationgegevens
            Assert.Equal("Station B", returnValue[1].Name);
            Assert.Equal(34.0522, returnValue[1].Latitude);
            Assert.Single(returnValue[1].Sensors); // Controleert dat er precies één sensor is
            Assert.Equal("Humidity", returnValue[1].Sensors[0].Type);
            Assert.Single(returnValue[1].Sensors[0].Measurements); // Controleert dat er één meting is
            Assert.Equal(55.2, returnValue[1].Sensors[0].Measurements[0].Value);
        }

        [Fact]
        public void StationController_GetLatestMeasurementsByStationId_ReturnNotFound_WhenNoMeasurementsFromStationExists()
        {
            // Arrange
            var stationIds = new List<string> { "1", "2" };
            int measurementAmount = 1;

            // Stel de mock zo in dat de repository een lege lijst van StationDto's retourneert
            _stationRepositoryMock.Setup(repo => repo.GetStationsLatestMeasurements(stationIds, measurementAmount)).Returns(new List<StationDto>());

            // Act
            var result = _stationController.GetLatestMeasurementsByStationId(stationIds, measurementAmount);

            // Assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result); // Controleert of het resultaat een NotFoundObjectResult is
            Assert.Equal("No measurements found for the specified stations.", notFoundResult.Value); // Controleert de foutmelding
        }
    }
}
