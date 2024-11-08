using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UCLL.Projects.WeatherStations.Shared.Data;

namespace UCLL.Projects.WeatherStations.Shared.Factories;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<DataContext> optionsBuilder = new();
        optionsBuilder.UseSqlServer("connstr");

        return new(optionsBuilder.Options);
    }
}