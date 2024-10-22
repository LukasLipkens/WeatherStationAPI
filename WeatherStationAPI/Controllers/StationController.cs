using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class StationController : Controller
    {
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public StationController(IStationRepository stationRepository, IMapper mapper)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;

        }

        [HttpGet("getList")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SimpleStationDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllStations()
        {
            // Haal metingen op via de repository
            var stations = _mapper.Map<List<SimpleStationDto>>(_stationRepository.GetAllStations());

            // Controleer of er resultaten zijn
            if (stations == null || !stations.Any())
            {
                return NotFound("Geen metingen gevonden voor het opgegeven station en sensor.");
            }

            // Retourneer de metingen
            return Ok(stations);
        }


        //Endpoint = .../api/v1/Station/Latest?stationIds=1&stationIds=2&measurementAmount=1

        [HttpGet("Latest")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<StationDto>))] // Good response
        [ProducesResponseType(404)] // Not found
        public IActionResult GetLatestMeasurementsByStationId([FromQuery] List<int> stationIds, [FromQuery] int measurementAmount = 1)
        {
            var stationsWithMeasurements = _stationRepository.GetStationsLatestMeasurements(stationIds, measurementAmount);

            if (stationsWithMeasurements == null || !stationsWithMeasurements.Any())
            {
                return NotFound("No measurements found for the specified stations.");
            }

            return Ok(stationsWithMeasurements);
        }

    }
}
