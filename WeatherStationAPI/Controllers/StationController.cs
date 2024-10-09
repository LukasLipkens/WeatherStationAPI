using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StationController :Controller
    {
        private readonly IStationRepository _stationRepository;
        private readonly IMapper _mapper;

        public StationController(IStationRepository stationRepository, IMapper mapper)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<StationDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllStations()
        {
            var stations = _mapper.Map<List<StationDto>>(_stationRepository.GetAllStations());

            if (stations == null || !stations.Any())
            {
                return NotFound("Geen stations gevonden.");
            }

            return Ok(stations);
        }

        [HttpGet("latest")]
        [ProducesResponseType(200, Type = typeof(StationDto))]
        [ProducesResponseType(400)]
        public IActionResult GetStationsWithLatestMeasurements([FromQuery]List<int> stationIds)
        {
            var stations = _stationRepository.GetStationWithLatestMeasurementsPerSensor(stationIds[0]);

            if (stations == null)
            {
                return NotFound("Geen stations gevonden.");
            }

            return Ok(stations);
        }



    }
}
