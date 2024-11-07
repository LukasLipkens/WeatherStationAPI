using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;
using UCLL.Projects.WeatherStations.MQTT.Interfaces;
using UCLL.Projects.WeatherStations.MQTT.Repositories;





//using UCLL.Projects.WeatherStations.MQTT.Data;
using UCLL.Projects.WeatherStations.MQTT.Services;
using UCLL.Projects.WeatherStations.MQTT.Models;
using UCLL.Projects.WeatherStations.Shared.Data;


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
                    new UnboundedChannelOptions
                    {
                        SingleReader = false,
                        SingleWriter = false,
                    }
                    )); // channel voor strings (json wordt ontvangens als een string)
                services.AddHostedService<MqttService>();
                services.AddHostedService<DatabaseService>();
                services.AddSingleton<IMeasurementRepository, MeasurementRepository>();
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseSqlServer(context.Configuration.GetConnectionString("WeatherStationDb"))
                                .EnableSensitiveDataLogging(false) // Zet logging van gevoelige data uit
                                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddFilter((category, level) =>
                                !category.Contains("Microsoft.EntityFrameworkCore") || level >= LogLevel.Warning))); // Filter EF Core logs;
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

        await host.RunAsync();
    }
}