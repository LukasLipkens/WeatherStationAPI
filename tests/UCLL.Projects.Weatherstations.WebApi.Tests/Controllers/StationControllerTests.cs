using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.Shared.Enums;
using UCLL.Projects.WeatherStations.WebApi.Controllers;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces.Repositories;

namespace UCLL.Projects.WeatherStations.WebApi.Tests.Controllers
{
    public class StationControllerTests
    {
        private readonly Mock<IStationRepository> _stationRepositoryMock = new();
        private readonly Mock<IMapper> _mapperMock = new();
        private readonly StationController _stationController;

        public StationControllerTests()
        {
            _stationController = new(_stationRepositoryMock.Object, _mapperMock.Object);
        }

        [Fact]
        public void StationController_GetAllStations_ReturnOK_WhenStationsExist()
        {
            // Arrange
            List<Station> stations = [
                new() { Id = "1", LastActivityTimestamp = DateTime.UtcNow, Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
                new() { Id = "2", LastActivityTimestamp = DateTime.UtcNow, Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
            ];

            List<SimpleStationDto> stationDtos = [
                new() { Id = "1", OnlineStatus = StationOnlineStatus.Online, Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
                new() { Id = "2", OnlineStatus = StationOnlineStatus.Online, Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
            ];

            _stationRepositoryMock.Setup(repo => repo.GetAllStations()).Returns(stations);
            _mapperMock.Setup(mapper => mapper.Map<List<SimpleStationDto>>(It.IsAny<List<Station>>())).Returns(stationDtos);

            // Act
            IActionResult result = _stationController.GetAllStations();

            // Assert
            OkObjectResult okResult = Assert.IsType<OkObjectResult>(result); // Controleert of resultaat een OkObjectResult is
            List<SimpleStationDto> returnValue = Assert.IsType<List<SimpleStationDto>>(okResult.Value); // Controleert of de waarde van okValue een lijst is van SimpleStationDtos
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
            IActionResult result = _stationController.GetAllStations();

            // Assert
            NotFoundObjectResult notFoundResult = Assert.IsType<NotFoundObjectResult>(result); // Controleert of het resultaat een NotFoundObjectResult is
            Assert.Equal("Geen metingen gevonden voor het opgegeven station en sensor.", notFoundResult.Value); // Controleert de inhoud van de foutmelding
        }

        [Fact]
        public void StationController_GetLatestMeasurementsByStationId_ReturnOk_WhenMeasurementsFromStationExists()
        {
            // Arrange
            List<string> stationIds = [ "1", "2" ];
            int measurementAmount = 1;

            // Voorbeelddata die de mock moet retourneren
            List<StationDto> stationsWithMeasurements =
            [
                new()
                {
                    Id = "1",
                    OnlineStatus = StationOnlineStatus.Online,
                    Name = "Station A",
                    Latitude = 40.7128,
                    Longitude = -74.0060,
                    Description = "Weather station in New York",
                    Sensors = [
                        new()
                        {
                            Id = 1,
                            Type = "Temperature",
                            Measurements = [
                                new() { SensorValue = "25.5", Timestamp = DateTime.Now }
                            ],
                        }
                    ],
                },
                new()
                {
                    Id = "2",
                    OnlineStatus = StationOnlineStatus.Online,
                    Name = "Station B",
                    Latitude = 34.0522,
                    Longitude = -118.2437,
                    Description = "Weather station in Los Angeles",
                    Sensors = [
                        new()
                        {
                            Id = 2,
                            Type = "Humidity",
                            Measurements = [
                                new() { SensorValue = "55.2", Timestamp = DateTime.Now }
                            ],
                        }
                    ],
                }
            ];

            // Stel de mock in om de voorbeelddata terug te geven
            _stationRepositoryMock.Setup(repo => repo.GetStationsLatestMeasurements(stationIds, measurementAmount)).Returns(stationsWithMeasurements);

            // Act
            IActionResult result = _stationController.GetLatestMeasurementsByStationId(stationIds, measurementAmount);

            // Assert
            OkObjectResult okResult = Assert.IsType<OkObjectResult>(result); // Controleert of het resultaat een OkObjectResult is
            List<StationDto> returnValue = Assert.IsType<List<StationDto>>(okResult.Value); // Controleert of de waarde een lijst van StationDto's is
            Assert.Equal(2, returnValue.Count); // Controleert dat er 2 stations zijn teruggegeven

            // Controleer de eerste stationgegevens
            Assert.Equal("Station A", returnValue[0].Name);
            Assert.Equal(40.7128, returnValue[0].Latitude);
            Assert.Single(returnValue[0].Sensors); // Controleert dat er precies één sensor is
            Assert.Equal("Temperature", returnValue[0].Sensors[0].Type);
            Assert.Single(returnValue[0].Sensors[0].Measurements); // Controleert dat er één meting is
            Assert.Equal("25.5", returnValue[0].Sensors[0].Measurements[0].SensorValue);

            // Controleer de tweede stationgegevens
            Assert.Equal("Station B", returnValue[1].Name);
            Assert.Equal(34.0522, returnValue[1].Latitude);
            Assert.Single(returnValue[1].Sensors); // Controleert dat er precies één sensor is
            Assert.Equal("Humidity", returnValue[1].Sensors[0].Type);
            Assert.Single(returnValue[1].Sensors[0].Measurements); // Controleert dat er één meting is
            Assert.Equal("55.2", returnValue[1].Sensors[0].Measurements[0].SensorValue);
        }

        [Fact]
        public void StationController_GetLatestMeasurementsByStationId_ReturnNotFound_WhenNoMeasurementsFromStationExists()
        {
            // Arrange
            List<string> stationIds = [ "1", "2" ];
            int measurementAmount = 1;

            // Stel de mock zo in dat de repository een lege lijst van StationDto's retourneert
            _stationRepositoryMock.Setup(repo => repo.GetStationsLatestMeasurements(stationIds, measurementAmount)).Returns(new List<StationDto>());

            // Act
            IActionResult result = _stationController.GetLatestMeasurementsByStationId(stationIds, measurementAmount);

            // Assert
            NotFoundObjectResult notFoundResult = Assert.IsType<NotFoundObjectResult>(result); // Controleert of het resultaat een NotFoundObjectResult is
            Assert.Equal("No measurements found for the specified stations.", notFoundResult.Value); // Controleert de foutmelding
        }
    }
}