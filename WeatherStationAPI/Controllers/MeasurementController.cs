using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/[Controller]")]
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
    }
}
