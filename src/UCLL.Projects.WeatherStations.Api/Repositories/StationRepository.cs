#region

using UCLL.Projects.WeatherStations.Api.Dto;
using UCLL.Projects.WeatherStations.Api.Interfaces.Repositories;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

#endregion

namespace UCLL.Projects.WeatherStations.Api.Repositories;

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
        // eerst checken of het passwoord klopt, passwoord niet aanpassen

        Station? station = _weatherstationsContext.Stations.FirstOrDefault(s => s.Id == data.Id);




        if (station != null)
        {
            if (!ValidateStationPass(data, station))
            {
                return false;
            }


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

    public bool ValidateStationPass(UpdateStationDto update, Station station)
    {

        var pass = update.Password;

        if (pass == null)
            return false;


        if (station != null) {
            if (station.Password == pass)
                return true;
        }


        return false;
    }
}