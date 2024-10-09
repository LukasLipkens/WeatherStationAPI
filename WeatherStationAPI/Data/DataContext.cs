using Microsoft.EntityFrameworkCore;

namespace WeatherStationAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Models.Measurement> Measurements { get; set; }
        public DbSet<Models.Sensor> Sensors { get; set; }
        public DbSet<Models.Station> Stations { get; set; }
        public DbSet<Models.Station_Sensor> Station_Sensors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // hier komen de relaties
        }
    }
}
