using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class MeasurementController : Controller
    {
        private readonly IMeasurementRepository _measurementRepository;
        public MeasurementController(IMeasurementRepository measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }

        [HttpGet("station/{stationId}/sensor/{sensorId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Measurement>))]
        [ProducesResponseType(400)]
        public IActionResult GetMeasurementsFromStationSensor(int stationId, int sensorId)
        {
            // Haal metingen op via de repository
            var measurements = _measurementRepository.GetAllMeasurementsFromStationSensor(stationId, sensorId);

            // Controleer of er resultaten zijn
            if (measurements == null || !measurements.Any())
            {
                return NotFound("Geen metingen gevonden voor het opgegeven station en sensor.");
            }

            // Retourneer de metingen
            return Ok(measurements);
        }

        [HttpGet("station/{stationId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SensorDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetMeasurementsFromStation(int stationId, [FromQuery] List<int> sensors, DateTime? startDate = null, DateTime? endDate = null)
        {
            //indien velden leeg gelaten wordt waarde rechts van ?? erin gestoken
            var start = startDate ?? DateTime.UtcNow.AddDays(-30);
            var end = endDate ?? DateTime.UtcNow;

            //haalt query uit MeasurementRepository
            var measurements = _measurementRepository.GetMeasurementsFromSensorInTimeRange(stationId, start, end, sensors);

            //kijkt of er waardes in measurements zit
            if (measurements == null || !measurements.Any())
            {
                return NotFound("Geen metingen gevonden voor dit station");
            }

            return Ok(measurements);
        }

    }
}
