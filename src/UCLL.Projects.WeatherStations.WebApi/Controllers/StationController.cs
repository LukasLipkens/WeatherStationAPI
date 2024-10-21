#region

using Microsoft.AspNetCore.Mvc;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Controllers
{
    [Route("api/v1/[Controller]")]
    [ApiController]
    public class StationController : Controller
    {
        private readonly IStationRepository _stationRepository;
        public StationController(IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
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
