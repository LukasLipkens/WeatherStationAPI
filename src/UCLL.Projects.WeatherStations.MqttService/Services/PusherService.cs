using PusherServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UCLL.Projects.WeatherStations.MqttService.Services
{
    public class PusherService
    {
        private readonly Pusher? _pusher;

        public PusherService()
        {
            // Hardcoded configuratie
            var options = new PusherOptions
            {
                Cluster = "eu", // Vervang door jouw cluster
                Encrypted = true
            };

            _pusher = new Pusher(
                "1909710",       // AppId
                "49d9d357bd1cd6ab9268", // Key
                "b32c743d7f8b9711f7a6", // Secret
                options);
        }
        public async Task<bool> SendStationId(string data)
        {
            try
            {
                var result = await _pusher.TriggerAsync(
                  "WheaterStation-Channel",
                  "StationId-Event",
                  new { message = data });

                return result.StatusCode == HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending message to Pusher: {ex.Message}");
                return false;
            }

        }
    }
}
