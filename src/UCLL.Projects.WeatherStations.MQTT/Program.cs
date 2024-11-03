using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Channels;
using UCLL.Projects.WeatherStations.MQTT.Data;
using UCLL.Projects.WeatherStations.MQTT.Services;


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
                services.AddSingleton(Channel.CreateUnbounded<string>(
                    new UnboundedChannelOptions
                    {
                        SingleReader = false,
                        SingleWriter = false,
                    }
                    )); // channel voor strings (json wordt ontvangens als een string)
                services.AddHostedService<MqttService>();
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