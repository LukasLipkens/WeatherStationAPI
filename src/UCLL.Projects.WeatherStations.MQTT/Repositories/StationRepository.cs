using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly WeatherstationsContext _weatherstationsContext;
        private readonly ILogger<StationRepository> _logger;

        public StationRepository(WeatherstationsContext weatherstationsContext, ILogger<StationRepository> logger)
        {
            _weatherstationsContext = weatherstationsContext;
            _logger = logger;
        } 

        public void AddInfoStation(string stationId, string name, string password)
        {
            try
            {
                Station? station = _weatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);

                if (station == null)
                {
                    _logger.LogError("Station with ID '{StationId}' does not exist.", stationId);
                    throw new ArgumentException("Station with the given ID does not exist.");
                }

                station.Name = name;
                station.Password = password;

                _weatherstationsContext.Stations.Update(station);
                _weatherstationsContext.SaveChanges();
                _logger.LogInformation("Info for station '{StationId}' updated to Name: {Name}, Password: {Password}.", stationId, name, password);
            }
            catch (ArgumentException ex)
            {
                // Specifieke afhandeling voor een station dat niet bestaat
                _logger.LogWarning(ex, "Argument exception occurred while updating info for station '{StationId}'.", stationId);
            }
            catch (Exception ex)
            {
                // Algemene foutafhandeling
                _logger.LogError(ex, "An error occurred while updating the info for station '{StationId}'.", stationId);
            }
        }

        public void AddLocationStation(string stationId, double latitude, double longitude)
        {
            try
            {
                Station? station = _weatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);

                if (station == null)
                {
                    _logger.LogError("Station with ID '{StationId}' does not exist.", stationId);
                    throw new ArgumentException("Station with the given ID does not exist.");
                }

                station.Latitude = latitude;
                station.Longitude = longitude;

                _weatherstationsContext.Stations.Update(station);
                _weatherstationsContext.SaveChanges();
                _logger.LogInformation("Location for station '{StationId}' updated to Latitude: {Latitude}, Longitude: {Longitude}.", stationId, latitude, longitude);
            }
            catch (ArgumentException ex)
            {
                // Specifieke afhandeling voor een station dat niet bestaat
                _logger.LogWarning(ex, "Argument exception occurred while updating location for station '{StationId}'.", stationId);
            }
            catch (Exception ex)
            {
                // Algemene foutafhandeling
                _logger.LogError(ex, "An error occurred while updating the location for station '{StationId}'.", stationId);
            }
        }
    }
}
