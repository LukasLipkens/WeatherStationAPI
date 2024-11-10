using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.Shared.Data;

public class WeatherstationsContext : DbContext
{
    public WeatherstationsContext(DbContextOptions<WeatherstationsContext> options)
        : base(options)
    {
    }

    public DbSet<Station> Stations { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<StationSensor> Station_Sensors { get; set; }
    public DbSet<Measurement> Measurements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Relationships:
        modelBuilder.Entity<Measurement>()
            .HasKey(m => new { m.StationId, m.SensorId, m.Timestamp }); //3 primary keys

        modelBuilder.Entity<StationSensor>()
            .HasKey(ss => new { ss.StationId, ss.SensorId });

        modelBuilder.Entity<StationSensor>()
            .HasOne(ss => ss.Sensor)
            .WithMany(s => s.StationSensors)
            .HasForeignKey(ss => ss.StationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<StationSensor>()
            .HasOne(ss => ss.Sensor)
            .WithMany(s => s.StationSensors)
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
            new Station { Id = "1", Name = "Station A", Latitude = 40.7128, Longitude = -74.0060, Description = "Weather station in New York" },
            new Station { Id = "2", Name = "Station B", Latitude = 34.0522, Longitude = -118.2437, Description = "Weather station in Los Angeles" }
        );

        // Seed Sensors
        modelBuilder.Entity<Sensor>().HasData(
            new Sensor { Id = 1, Type = "Temperature", Unit = "Celsius" },
            new Sensor { Id = 2, Type = "Humidity", Unit = "%" }
        );

        // Seed Station_Sensors relationships
        modelBuilder.Entity<StationSensor>().HasData(
            new StationSensor { StationId = "1", SensorId = 1 },
            new StationSensor { StationId = "1", SensorId = 2 },
            new StationSensor { StationId = "2", SensorId = 1 },
            new StationSensor { StationId = "2", SensorId = 2 }
        );

        // Seed Measurements
        modelBuilder.Entity<Measurement>().HasData(
            new Measurement { StationId = "1", SensorId = 1, Value = 23.5, Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationId = "1", SensorId = 2, Value = 60, Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationId = "1", SensorId = 1, Value = 22.5, Timestamp = DateTime.UtcNow.AddDays(-1) },
            new Measurement { StationId = "1", SensorId = 2, Value = 58, Timestamp = DateTime.UtcNow.AddDays(-1) },
            new Measurement { StationId = "2", SensorId = 1, Value = 19.2, Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationId = "2", SensorId = 2, Value = 61, Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationId = "2", SensorId = 1, Value = 18.2, Timestamp = DateTime.UtcNow.AddHours(-6) },
            new Measurement { StationId = "2", SensorId = 2, Value = 57, Timestamp = DateTime.UtcNow.AddHours(-6) }
        );
    }
}