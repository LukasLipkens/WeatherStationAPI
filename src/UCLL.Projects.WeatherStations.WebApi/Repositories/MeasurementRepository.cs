#region

using UCLL.Projects.WeatherStations.WebApi.Data;
using UCLL.Projects.WeatherStations.WebApi.Dto;
using UCLL.Projects.WeatherStations.WebApi.Interfaces;
using UCLL.Projects.WeatherStations.WebApi.Models;

#endregion

namespace UCLL.Projects.WeatherStations.WebApi.Repositories
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly DataContext _dataContext;

        public MeasurementRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public List<Measurement> GetAllMeasurementsFromStationSensor(int stationId, int sensorId)
            => _dataContext.Measurements.Where(m => m.StationId == stationId && m.SensorId == sensorId).ToList();

        public List<SensorDto> GetMeasurementsFromSensorInTimeRange(int stationId, DateTime start, DateTime end, List<int>? sensorIds = null)
        {
            // Basisquery voor het filteren van metingen op basis van datumbereik en station
            var query = _dataContext.Measurements
                .Where(m => m.Timestamp >= start && m.Timestamp <= end && m.StationId == stationId);

            // Filteren op specifieke sensor-ID's als die zijn opgegeven
            if (sensorIds != null && sensorIds.Any())
            {
                query = query.Where(m => sensorIds.Contains(m.SensorId));
            }

            // Haal alle relevante sensor-ID's op uit de queryresultaten
            var sensorIdsFromQuery = query.Select(m => m.SensorId).Distinct().ToList();

            // Haal de sensoren op die overeenkomen met deze sensor-ID's
            var sensors = _dataContext.Sensors
                .Where(s => sensorIdsFromQuery.Contains(s.Id))
                .ToDictionary(s => s.Id, s => s); // Koppel de sensoren aan hun SensorId

            // Groeperen op SensorId en projecteren naar SensorDto
            return query
                .GroupBy(m => m.SensorId)
                .Select(g => new SensorDto
                {
                    Id = g.Key,
                    Unit = sensors.ContainsKey(g.Key) ? sensors[g.Key].Unit : "", // Zoek Unit op
                    Type = sensors.ContainsKey(g.Key) ? sensors[g.Key].Type : "", // Zoek Type op
                    Measurements = g.Select(m => new MeasurementDto
                    {
                        Timestamp = m.Timestamp,
                        Value = m.Value
                    }).ToList()
                }).ToList();
        }



    }
}
