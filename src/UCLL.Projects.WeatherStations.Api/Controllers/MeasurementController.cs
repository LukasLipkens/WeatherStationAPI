﻿#region

using Microsoft.AspNetCore.Mvc;
using UCLL.Projects.WeatherStations.Api.Dto;
using UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

#endregion

namespace UCLL.Projects.WeatherStations.Api.Controllers;

[Route("api/v1/measurement")]
[ApiController]
public class MeasurementController(IStationSensorRepository stationSensorRepository, IMeasurementRepository measurementRepository) : Controller
{
    private readonly IStationSensorRepository _stationSensorRepository = stationSensorRepository;
    private readonly IMeasurementRepository _measurementRepository = measurementRepository;

    [HttpGet("station/{stationId}/sensor/{sensorId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Measurement>))]
    [ProducesResponseType(400)]
    public IActionResult GetMeasurementsFromStationSensor(string stationId, int sensorId)
    {
        StationSensor? stationSensor = _stationSensorRepository.FindStationSensor(
            stationId: stationId,
            sensorId: sensorId
        );

        if (stationSensor is null) return NotFound("StationSensor not found.");

        // Haal metingen op via de repository
        List<Measurement>? measurements = _measurementRepository.GetAllMeasurementsFromStationSensor(stationSensor.Id);

        // Controleer of er resultaten zijn
        if (measurements.Count == 0) return NotFound("Geen metingen gevonden voor het opgegeven station en sensor.");

        // Retourneer de metingen
        return Ok(measurements.Select(measurement => new MeasurementDto
        {
            Timestamp = measurement.Timestamp,
            SensorValue = measurement.SensorValue
        }).ToList());
    }

    [HttpGet("station/{stationId}")]
    [ProducesResponseType(200, Type = typeof(IEnumerable<SensorDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetMeasurementsFromStation(string stationId, [FromQuery] List<int> sensors, DateTime? startDate = null,
        DateTime? endDate = null)
    {
        //indien velden leeg gelaten wordt waarde rechts van ?? erin gestoken
        DateTime start = startDate ?? DateTime.UtcNow.AddDays(-7);
        DateTime end = endDate ?? DateTime.UtcNow;

        //haalt query uit MeasurementRepository
        List<SensorDto>? measurements = _measurementRepository.GetMeasurementsFromSensorInTimeRange(stationId, start, end, sensors);

        //kijkt of er waardes in measurements zit
        if (!measurements.Any()) return NotFound("Geen metingen gevonden voor dit station");

        return Ok(measurements);
    }
}