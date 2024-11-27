#region

using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.Shared.Migrations;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;
using UCLL.Projects.WeatherStations.WebApi.Interfaces.Repositories;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Repositories;

public class StationRepository(WeatherstationsContext weatherstationsContext) : IStationRepository
{
    private readonly WeatherstationsContext _weatherstationsContext = weatherstationsContext;

    public List<Station> GetAllStations() => _weatherstationsContext.Stations.OrderBy(station => station.Id).ToList();

    public IEnumerable<StationDto> GetStationsLatestMeasurements(List<string> stationIds, int measurementAmount)
    {
        IQueryable<Station> databaseStations = _weatherstationsContext.Stations.AsQueryable();

        if (stationIds.Count != 0) databaseStations = databaseStations.Where(station => stationIds.Contains(station.Id));

        return databaseStations.Select(databaseStation => new StationDto()
        {
            Id = databaseStation.Id,
            OnlineStatus = databaseStation.OnlineStatus,
            Name = databaseStation.Name,
            Latitude = databaseStation.Latitude,
            Longitude = databaseStation.Longitude,
            Description = databaseStation.Description,
            Sensors = databaseStation.StationSensors.Select(stationSensor => new SensorDto
            {
                Id = stationSensor.SensorId,
                Unit = stationSensor.Sensor.Unit,
                Type = stationSensor.Sensor.Type,
                Measurements = stationSensor.Measurements
                    .OrderByDescending(measurement => measurement.Timestamp)
                    .Take(measurementAmount)
                    .Select(measurement => new MeasurementDto
                    {
                        Timestamp = measurement.Timestamp,
                        SensorValue = measurement.SensorValue
                    }).ToList()
            }).ToList()
        }).ToList();
    }

    public bool UpdateStationInfo(UpdateStationDto data)
    {
        Station? station = _weatherstationsContext.Stations.FirstOrDefault(s => s.Id == data.Id);
        if (station != null)
        {
            station.Name = data.Name;
            station.Description = data.Description;

            _weatherstationsContext.Stations.Update(station);
            _weatherstationsContext.SaveChanges();

            return true;
        } else
        {
            return false;
        }

    }
}