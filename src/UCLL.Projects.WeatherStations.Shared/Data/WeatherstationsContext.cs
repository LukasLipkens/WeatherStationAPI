using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data.Models;

namespace UCLL.Projects.WeatherStations.Shared.Data;

public class WeatherstationsContext : DbContext
{
    public WeatherstationsContext(DbContextOptions<WeatherstationsContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Station>(entity =>
        {
            entity.ToTable("stations");

            entity.HasKey(station => station.Id).HasName("PK_Stations_Id");

            entity.Property(station => station.Id)
                .HasColumnName("id")
                .IsRequired();

            entity.Property(station => station.BatteryLevel)
                .HasColumnName("battery_level")
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Property(station => station.Latitude)
                .HasColumnName("latitude")
                .IsRequired();

            entity.Property(station => station.Longitude)
                .HasColumnName("longitude")
                .IsRequired();

            entity.Property(station => station.Name)
                .HasColumnName("name")
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Property(station => station.Description)
                .HasColumnName("description")
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Navigation(station => station.StationSensors)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        modelBuilder.Entity<Sensor>(entity =>
        {
            entity.ToTable("sensors");

            entity.HasKey(sensor => sensor.Id).HasName("PK_Sensors_Id");

            entity.Property(sensor => sensor.Id)
                .HasColumnName("id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(sensor => sensor.Type)
                .HasColumnName("type")
                .IsRequired();

            entity.Property(sensor => sensor.Unit)
                .HasColumnName("Unit")
                .IsRequired();

            entity.Navigation(sensor => sensor.StationSensors)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        modelBuilder.Entity<StationSensor>(entity =>
        {
            entity.ToTable("station_sensors");

            entity.HasKey(stationSensor => new { stationSensor.Id, stationSensor.StationId, stationSensor.SensorId }).HasName("PK_StationSensors_Id_StationId_SensorId");

            entity.Property(stationSensor => stationSensor.Id)
                .HasColumnName("id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(stationSensor => stationSensor.StationId)
                .HasColumnName("station_id")
                .IsRequired();

            entity.Property(stationSensor => stationSensor.SensorId)
                .HasColumnName("sensor_id")
                .IsRequired();

            entity.HasOne(stationSensor => stationSensor.Station)
                .WithMany(station => station.StationSensors)
                .HasForeignKey(stationSensor => stationSensor.StationId)
                .HasConstraintName("FK_StationSensors_StationId");

            // REMARK: maybe need to set principal key here
            entity.HasOne(stationSensor => stationSensor.Sensor)
                .WithMany(sensor => sensor.StationSensors)
                .HasForeignKey(stationSensor => stationSensor.SensorId)
                .HasConstraintName("FK_StationSensors_SensorId");

            entity.Navigation(stationSensor => stationSensor.Measurements)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        modelBuilder.Entity<Measurement>(entity =>
        {
            entity.ToTable("measurements");

            entity.HasKey(measurement => new { measurement.Timestamp, measurement.StationSensorId }).HasName("PK_Measurements_Timestamp_StationSensorId");

            entity.Property(measurement => measurement.Timestamp)
                .HasColumnName("timestamp")
                .IsRequired();

            entity.Property(measurement => measurement.StationSensorId)
                .HasColumnName("station_sensor_id")
                .IsRequired();

            entity.Property(measurement => measurement.SensorValue)
                .HasColumnName("sensor_value")
                .IsRequired();

            // REMARK: maybe need to set principal key here
            entity.HasOne(measurement => measurement.StationSensor)
                .WithMany(stationSensor => stationSensor.Measurements)
                .HasForeignKey(measurement => measurement.StationSensorId)
                .HasConstraintName("FK_Measurements_StationSensorId");
        });

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
            new StationSensor { Id = 1, StationId = "1", SensorId = 1 },
            new StationSensor { Id = 2, StationId = "1", SensorId = 2 },
            new StationSensor { Id = 3, StationId = "2", SensorId = 1 },
            new StationSensor { Id = 4, StationId = "2", SensorId = 2 }
        );

        // Seed Measurements
        modelBuilder.Entity<Measurement>().HasData(
            new Measurement { StationSensorId = 1, SensorValue = "23.5", Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationSensorId = 2, SensorValue = "60", Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationSensorId = 1, SensorValue = "22.5", Timestamp = DateTime.UtcNow.AddDays(-1) },
            new Measurement { StationSensorId = 2, SensorValue = "58", Timestamp = DateTime.UtcNow.AddDays(-1) },
            new Measurement { StationSensorId = 3, SensorValue = "19.2", Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationSensorId = 4, SensorValue = "61", Timestamp = DateTime.UtcNow.AddDays(-2) },
            new Measurement { StationSensorId = 3, SensorValue = "18.2", Timestamp = DateTime.UtcNow.AddHours(-6) },
            new Measurement { StationSensorId = 4, SensorValue = "57", Timestamp = DateTime.UtcNow.AddHours(-6) }
        );
    }

    public DbSet<Station> Stations { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<StationSensor> StationSensors { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
}