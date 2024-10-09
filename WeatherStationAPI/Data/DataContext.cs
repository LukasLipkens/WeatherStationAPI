using Microsoft.EntityFrameworkCore;
using WeatherStationAPI.Models;

namespace WeatherStationAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { 
        
        }

        public DbSet<Station> Stations { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<Station_Sensor> Station_Sensors { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relationships:
            modelBuilder.Entity<Measurement>()
                .HasKey(m => new { m.StationId, m.SensorId, m.Timestamp }); //3 primary keys

            modelBuilder.Entity<Station_Sensor>()
                .HasKey(ss => new { ss.StationId, ss.SensorId });

            modelBuilder.Entity<Station_Sensor>()
                .HasOne<Station>()
                .WithMany(s => s.Station_Sensors)
                .HasForeignKey(ss => ss.StationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Station_Sensor>()
                .HasOne<Sensor>()
                .WithMany(s => s.Station_Sensors)
                .HasForeignKey(ss => ss.SensorId)
                .OnDelete(DeleteBehavior.Cascade);

            // Measurement relationship with Station
            modelBuilder.Entity<Measurement>()
                .HasOne<Station>()
                .WithMany(s => s.Measurements)
                .HasForeignKey(m => m.StationId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if a Station is deleted

            // Measurement relationship with Sensor
            modelBuilder.Entity<Measurement>()
                .HasOne<Sensor>()
                .WithMany(s => s.Measurements)
                .HasForeignKey(m => m.SensorId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete if a Sensor is deleted


            // Seed Stations
            modelBuilder.Entity<Station>().HasData(
                new Station { Id = 1, Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
                new Station { Id = 2, Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
            );

            // Seed Sensors
            modelBuilder.Entity<Sensor>().HasData(
                new Sensor { Id = 1, Type = "Temperature", Unit = "Celsius" },
                new Sensor { Id = 2, Type = "Humidity", Unit = "%" }
            );

            // Seed Station_Sensors relationships
            modelBuilder.Entity<Station_Sensor>().HasData(
                new Station_Sensor { StationId = 1, SensorId = 1 },
                new Station_Sensor { StationId = 1, SensorId = 2 },
                new Station_Sensor { StationId = 2, SensorId = 1 }
            );

            // Seed Measurements
            modelBuilder.Entity<Measurement>().HasData(
                new Measurement { StationId = 1, SensorId = 1, Value = 23.5, Timestamp = DateTime.UtcNow.AddDays(-1) },
                new Measurement { StationId = 1, SensorId = 2, Value = 60, Timestamp = DateTime.UtcNow.AddDays(-1) },
                new Measurement { StationId = 2, SensorId = 1, Value = 18.2, Timestamp = DateTime.UtcNow.AddHours(-6) }
            );
        }
    }
}
