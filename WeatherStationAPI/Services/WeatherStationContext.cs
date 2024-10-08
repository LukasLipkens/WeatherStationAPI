using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Services
{
    public class WeatherStationContext : DbContext
    {
        public WeatherStationContext(DbContextOptions<WeatherStationContext> options)
            : base(options)
        {

        }

        public DbSet<WeatherStation> WeatherStations { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Disable cascade delete for the Station relationship
            modelBuilder.Entity<Measurement>()
                .HasOne(m => m.Station)
                .WithMany(s => s.Measurements)
                .HasForeignKey(m => m.StationId)
                .OnDelete(DeleteBehavior.Restrict); // Or you can use DeleteBehavior.NoAction
        }
    }
}
