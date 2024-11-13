using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.Shared.Data;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.MQTT.Repositories
{
    public class StationRepository : IStationRepository
    {
        private readonly WeatherstationsContext _wheatherstationsContext;

        public StationRepository(WeatherstationsContext wheatherstationsContect)
        {
            _wheatherstationsContext = wheatherstationsContect;
        }

        public void AddBatteryPercentage(string stationId, double batteryPercentage)
        {
            try
            {
                Station? station = _wheatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);

                if (station == null)
                {
                    throw new ArgumentException("Station with the given ID does not exist.");
                }

                station.BatteryLevel = batteryPercentage;

                _wheatherstationsContext.Stations.Update(station);
                _wheatherstationsContext.SaveChanges(); // Vergeet niet om wijzigingen op te slaan
            }
            catch (ArgumentException ex)
            {
                // Specifieke afhandeling voor een station dat niet bestaat
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Algemene foutafhandeling
                Console.WriteLine($"An error occurred while updating the battery percentage: {ex.Message}");
            }
        }


        public void AddLocationStation(string stationId, double latitude, double longitude)
        {
            try
            {
                Station? station = _wheatherstationsContext.Stations.FirstOrDefault(s => s.Id == stationId);

                if (station == null)
                {
                    throw new ArgumentException("Station with the given ID does not exist.");
                }

                station.Latitude = latitude;
                station.Longitude = longitude;

                _wheatherstationsContext.Stations.Update(station);
                _wheatherstationsContext.SaveChanges(); // Wijzigingen opslaan in de database
            }
            catch (ArgumentException ex)
            {
                // Specifieke afhandeling als het station niet bestaat
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Algemene foutafhandeling
                Console.WriteLine($"An error occurred while updating the station location: {ex.Message}");
            }
        }

    }
}
