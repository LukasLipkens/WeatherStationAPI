using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UCLL.Projects.WeatherStations.Shared.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWeatherstationsData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<WeatherstationsContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("WeatherStationsDb")));
            return services;
        }
    }
}
