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

        [HttpGet("GetList")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<StationDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllStations()
        {
            var stations = _mapper.Map<List<SimpleStationDto>>(_stationRepository.GetAllStations());

            if (stations == null || !stations.Any())
            {
                return NotFound("Geen stations gevonden.");
            }

            return Ok(stations);
        }

        [HttpGet("Latest")]
        [ProducesResponseType(200, Type = typeof(StationDto))]
        [ProducesResponseType(400)]
        public IActionResult GetStationsWithLatestMeasurements([FromQuery]List<int> stationIds, int measurementAmount = 1)
        {
            //var stations = _stationRepository.GetStationsWithMeasurementsPerSensor(stationIds, 2);
            List<StationDto>? stations;

            if (stationIds == null || !stationIds.Any())
            {
                stations = _stationRepository.GetStationsWithMeasurementsPerSensor(measurementAmount);
            }
            else
            {
                stations = _stationRepository.GetStationsWithMeasurementsPerSensor(stationIds, measurementAmount);
            }


            if (stations == null)
            {
                return NotFound("Geen stations gevonden.");
            }

            return Ok(stations);
        }



    }
}
