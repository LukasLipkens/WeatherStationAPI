using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WeatherStationAPI.Dto;
using WeatherStationAPI.Interfaces;
using WeatherStationAPI.Models;
using WeatherStationAPI.Repositories;

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
        [ProducesResponseType(200, Type = typeof(IEnumerable<StationDto>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllStations()
        {
            // Haal metingen op via de repository
            var stations = _mapper.Map<List<StationDto>>(_stationRepository.GetAllStations());

            // Controleer of er resultaten zijn
            if (stations == null || !stations.Any())
            {
                return NotFound("Geen metingen gevonden voor het opgegeven station en sensor.");
            }

            // Retourneer de metingen
            return Ok(stations);
        }
    }
}
