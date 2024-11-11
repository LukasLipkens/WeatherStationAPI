using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Models;
using UCLL.Projects.WeatherStations.MQTT.Repositories;
using UCLL.Projects.WeatherStations.MQTT.Services;
using UCLL.Projects.WeatherStations.Shared.Data;
//using UCLL.Projects.WeatherStations.MQTT.Data;


/*
    dit is een manier om mqtt te gebruiken in c#
    ik ben niet zeker dat dit een goede manier is om dit te doen
        er is namelijk niet veel structuur, hier ben ik nog mee bezig
 */


namespace UCLL.Projects.WeatherStations.MQTT;

internal class Program
{
    private static async Task Main()
    {
        IHost host = Host.CreateDefaultBuilder()
            .ConfigureHostConfiguration(hostConfigBuilder =>
            {
                //configHost.AddJsonFile("appsettings.json", optional: true);
            })
            .ConfigureAppConfiguration((hostBuilderContext, appConfigBuilder) =>
            {
                //appConfigBuilder.AddJsonFile("appsettings.json", optional: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton(Channel.CreateUnbounded<MqttMessage>(
                    new()
                    {
                        SingleReader = false,
                        SingleWriter = false
                    }
                )); // channel voor strings (json wordt ontvangens als een string)
                services.AddHostedService<MqttService>();
                services.AddHostedService<DatabaseService>();
                services.AddSingleton<IMeasurementRepository, MeasurementRepository>();

                string databaseConnectionString = context.Configuration.GetConnectionString("WeatherStationDb")
                    ?? throw new("ConnectionString 'WeatherStationDb' not found.");

                services.AddDbContext<WeatherstationsContext>(options =>
                {
                    options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(databaseConnectionString)
                        .EnableSensitiveDataLogging(false) // Don't log sensitive data
                        .UseLoggerFactory(LoggerFactory.Create(loggingBuilder =>
                        {
                            loggingBuilder // log only warning level and above for EF SQL commands
                                .AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);

                            loggingBuilder // log debug and information levels for SQL commands to debug output
                                .AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Debug)
                                .AddDebug();
                        }));
                });
            })
            .ConfigureLogging(loggingBuilder =>
            {
                //loggingBuilder.AddConsole();
                loggingBuilder.SetMinimumLevel(LogLevel.Information);
                loggingBuilder.ClearProviders();
                loggingBuilder.AddConsole();
            })
            .Build();

        // Apply any pending migrations automatically at startup
        using (IServiceScope scope = host.Services.CreateScope())
        {
            WeatherstationsContext context = scope.ServiceProvider.GetRequiredService<WeatherstationsContext>();
            await context.Database.MigrateAsync();
        }

        await host.RunAsync();
    }
}