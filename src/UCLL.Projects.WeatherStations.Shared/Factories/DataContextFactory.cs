using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UCLL.Projects.WeatherStations.Shared.Data;

namespace UCLL.Projects.WeatherStations.Shared.Factories;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        DbContextOptionsBuilder<DataContext> optionsBuilder = new();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("WeatherStationDb"));

        return new(optionsBuilder.Options);
    }
}