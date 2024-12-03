using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UCLL.Projects.WeatherStations.Shared.Data;

namespace UCLL.Projects.WeatherStations.Shared.Factories;

public class WeatherstationsContextFactory : IDesignTimeDbContextFactory<WeatherstationsContext>
{
    public WeatherstationsContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<WeatherstationsContext> optionsBuilder = new();
        optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=weatherstationdata;Trusted_Connection=True;MultipleActiveResultSets=true");

        return new(optionsBuilder.Options);
    }
}