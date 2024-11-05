using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using UCLL.Projects.WeatherStations.ClassLib;

namespace UCLL.Projects.WeatherStations.MQTT.Services
{
    public class DatabaseService : BackgroundService
    {
        private readonly ILogger<DatabaseService> _logger;
        private readonly Channel<MqttMessage> _channel;
        private readonly string _connectionString;

        public DatabaseService(ILogger<DatabaseService> logger, Channel<MqttMessage> channel)
        {
            _logger = logger;
            _channel = channel;
            _connectionString = "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;";
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await foreach (var message in _channel.Reader.ReadAllAsync(stoppingToken))
            {
                _logger.LogInformation($"db service opgestart");
                _logger.LogInformation($"db service message: {message.Topic}");
                _logger.LogInformation($"db service message: {message.StationId}");
                _logger.LogInformation($"db service message: {message.Payload}");
                //try
                //{
                //    // Sla het bericht op in de database
                //    using (var connection = new SqlConnection(_connectionString))
                //    {
                //        await connection.OpenAsync(stoppingToken);
                //        string query = "INSERT INTO Messages (Content, ReceivedAt) VALUES (@content, @receivedAt)";
                //        using (SqlCommand command = new SqlCommand(query, connection))
                //        {
                //            command.Parameters.AddWithValue("@content", message);
                //            command.Parameters.AddWithValue("@receivedAt", DateTime.Now);

                //            await command.ExecuteNonQueryAsync(stoppingToken);
                //            _logger.LogInformation("Bericht opgeslagen in database: " + message);
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    _logger.LogError("Fout bij opslaan in database: " + ex.Message);
                //}
            }
        }
    }
}
