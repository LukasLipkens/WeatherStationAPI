using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PusherServer;
using UCLL.Projects.WeatherStations.MqttService.Settings;

namespace UCLL.Projects.WeatherStations.MqttService.Services
{
    public class PusherService
    {
        private readonly ILogger<PusherService> _logger;
        private readonly Pusher _pusher;

        public PusherService(ILogger<PusherService> logger, IOptions<PusherSettings> pusherOptions)
        {
            _logger = logger;
            PusherSettings pusherSettings = pusherOptions.Value;

            // pusher config
            PusherOptions options = new()
            {
                Cluster = "eu", // Vervang door jouw cluster
                Encrypted = true
            };

            _pusher = new(
                appId: pusherSettings.AppId,
                appKey: pusherSettings.AppKey,
                appSecret: pusherSettings.AppSecret,
                options: options
            );
        }
        public async Task SendStationId(string data)
        {
            try
            {
                ITriggerResult? result = await _pusher.TriggerAsync(
                  "WheaterStation-Channel",
                  "StationId-Event",
                  new { message = data }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError("Error sending message to Pusher: {ex.Message}", ex.Message);
            }

        }
    }
}