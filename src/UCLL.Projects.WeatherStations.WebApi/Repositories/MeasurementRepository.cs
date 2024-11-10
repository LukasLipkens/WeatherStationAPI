#region

using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Repositories;

public class MeasurementRepository(WeatherstationsContext weatherstationsContext) : IMeasurementRepository
{
    private readonly WeatherstationsContext _weatherstationsContext = weatherstationsContext;

    public List<Measurement> GetAllMeasurementsFromStationSensor(int stationSensorId) => _weatherstationsContext.Measurements.Where(measurement => measurement.StationSensorId == stationSensorId).ToList();

    public List<SensorDto> GetMeasurementsFromSensorInTimeRange(string stationId, DateTime start, DateTime end, List<int>? sensorIds = null)
    {
        IQueryable<Measurement> databaseMeasurements = _weatherstationsContext.Measurements.AsQueryable();

        databaseMeasurements = databaseMeasurements.Where(measurement => measurement.StationSensor.StationId == stationId);
        if (sensorIds is not null && sensorIds.Count != 0) databaseMeasurements = databaseMeasurements.Where(measurement => sensorIds.Contains(measurement.StationSensor.SensorId));
        databaseMeasurements = databaseMeasurements.Where(measurement => measurement.Timestamp >= start && measurement.Timestamp <= end);

        return databaseMeasurements
            .GroupBy(measurement => measurement.StationSensor)
            .Select(x => new SensorDto()
            {
                Id = x.Key.SensorId,
                Unit = x.Key.Sensor.Unit,
                Type = x.Key.Sensor.Type,
                Measurements = x.Select(measurement => new MeasurementDto()
                {
                    Timestamp = measurement.Timestamp,
                    SensorValue = measurement.SensorValue
                }).ToList()
            }).ToList();
    }
}