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

        [HttpGet("station/v1/{stationId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SensorDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetMeasurementsFromStation(int stationId, [FromQuery]List<int> sensors, DateTime? startDateTime = null, DateTime? endDateTime = null)
        {

            List<SensorDto> measurements;
            // if startDateTime is not provided, set it to 1 week ago
            if (startDateTime == null)
            {
                startDateTime = DateTime.Now.AddDays(-7);
            }
            // if endDateTime is not provided, set it to now
            if (endDateTime == null)
            {
                endDateTime = DateTime.Now;
            }

            if(sensors == null || !sensors.Any())
            {
                measurements = _measurementRepository.GetMeasurementsFromSensorInTimeRange(stationId, startDateTime.Value, endDateTime.Value);
            }
            else
            {
                measurements = _measurementRepository.GetMeasurementsFromSensorInTimeRange(sensors, stationId, startDateTime.Value, endDateTime.Value);
            }

            // Controleer of er resultaten zijn
            if (measurements == null || !measurements.Any())
            {
                return NotFound("Geen metingen gevonden voor het opgegeven station.");
            }

            // Retourneer de metingen
            return Ok(measurements);
        }
    }
}
