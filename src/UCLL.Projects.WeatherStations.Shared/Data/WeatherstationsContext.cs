using System.Globalization;
using Microsoft.EntityFrameworkCore;
using UCLL.Projects.WeatherStations.Shared.Data.Models;
using UCLL.Projects.WeatherStations.Shared.Enums;

namespace UCLL.Projects.WeatherStations.Shared.Data;

public class WeatherstationsContext(DbContextOptions<WeatherstationsContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Station>(entity =>
        {
            entity.ToTable("stations");

            entity.HasKey(station => station.Id).HasName("PK_Stations_Id");

            entity.Property(station => station.Id)
                .HasColumnName("id")
                .HasMaxLength(100) // REMARK: check this with the MQTT topic
                .IsRequired();

            entity.Property(station => station.LastActivityTimestamp)
                .HasColumnName("last_activity_timestamp")
                .IsRequired();

            entity.Property(station => station.BatteryLevel)
                .HasColumnName("battery_level")
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Property(station => station.Latitude)
                .HasColumnName("latitude")
                .IsRequired(false);

            entity.Property(station => station.Longitude)
                .HasColumnName("longitude")
                .IsRequired(false);

            entity.Property(station => station.Name)
                .HasColumnName("name")
                .HasMaxLength(100) // REMARK: check this in the requests
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Property(station => station.Description)
                .HasColumnName("description")
                .HasMaxLength(500) // REMARK: check this in the requests
                .IsRequired(false)
                .HasDefaultValue(null);

            entity.Property(station => station.OnlineStatus)
                .HasColumnName("online_status")
                .HasComputedColumnSql(
                    sql: "CASE WHEN last_activity_timestamp < DATEADD(MINUTE, -30, GETUTCDATE()) THEN 'Offline' ELSE 'Online' END",
                    stored: false // Persisted computed columns in SQL Server do not allow nondeterministic functions like GETDATE()
                ).HasConversion<string>();

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
                .HasMaxLength(100) // REMARK: check this with the MQTT message
                .IsRequired();

            entity.Property(sensor => sensor.Unit)
                .HasColumnName("Unit")
                .HasMaxLength(100) // REMARK: check this with the MQTT message
                .IsRequired();

            entity.Navigation(sensor => sensor.StationSensors)
                .UsePropertyAccessMode(PropertyAccessMode.Field);
        });

        modelBuilder.Entity<StationSensor>(entity =>
        {
            entity.ToTable("station_sensors");

            entity.HasKey(stationSensor => new { stationSensor.StationId, stationSensor.SensorId }).HasName("PK_StationSensors_StationId_SensorId");

            entity.Property(stationSensor => stationSensor.Id)
                .HasColumnName("id")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(stationSensor => stationSensor.StationId)
                .HasColumnName("station_id")
                .HasMaxLength(100) // REMARK: check this with the MQTT topic
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
                .HasMaxLength(50) // REMARK: check this with the MQTT message
                .IsRequired();

            entity.HasOne(measurement => measurement.StationSensor)
                .WithMany(stationSensor => stationSensor.Measurements)
                .HasForeignKey(measurement => measurement.StationSensorId)
                .HasPrincipalKey(stationSensor => stationSensor.Id)
                .HasConstraintName("FK_Measurements_StationSensorId");
        });
        /*
        // Seed Stations
        modelBuilder.Entity<Station>().HasData(
            new Station { Id = "1", BatteryLevel = 3.784, Latitude = 34.0522, Longitude = -118.2437, Name = "WSTATION_821A7C4FB923-DUMMY", Description = "Dummy weather station with random MAC addresses: 82:1A:7C:4F:B9:23" },
            new Station { Id = "2", BatteryLevel = 4.153, Latitude = -22.9068, Longitude = -43.1729, Name = "WSTATION_D35F986B4E17-DUMMY", Description = "Dummy weather station with random MAC addresses: D3:5F:98:6B:4E:17" },
            new Station { Id = "3", Latitude = 48.8566, Longitude = 2.3522, Name = "WSTATION_A43B915DC72A-DUMMY", Description = "Dummy weather station with random MAC addresses: A4:3B:91:5D:C7:2A" },
            new Station { Id = "4", BatteryLevel = 4.031, Latitude = 35.6895, Longitude = 139.6917, Name = "WSTATION_1F8E5A3C7961-DUMMY", Description = "Dummy weather station with random MAC addresses: 1F:8E:5A:3C:79:61" },
            new Station { Id = "5", Latitude = -33.8688, Longitude = 151.2093, Name = "WSTATION_5B9DE622F108-DUMMY", Description = "Dummy weather station with random MAC addresses: 5B:9D:E6:22:F1:08" }
        );

        // Seed Sensors
        modelBuilder.Entity<Sensor>().HasData(
            new Sensor { Id = 1, Type = "Temperature-DUMMY", Unit = "Celsius" },
            new Sensor { Id = 2, Type = "Humidity-DUMMY", Unit = "%" },
            new Sensor { Id = 3, Type = "Pressure-DUMMY", Unit = "hPa" },
            new Sensor { Id = 4, Type = "Wind Speed-DUMMY", Unit = "m/s" },
            new Sensor { Id = 5, Type = "Wind Direction-DUMMY", Unit = "Degrees" },
            new Sensor { Id = 6, Type = "Rainfall-DUMMY", Unit = "mm" },
            new Sensor { Id = 7, Type = "UV Index-DUMMY", Unit = "Index" },
            new Sensor { Id = 8, Type = "Soil Moisture-DUMMY", Unit = "%" },
            new Sensor { Id = 9, Type = "Solar Radiation-DUMMY", Unit = "W/m²" },
            new Sensor { Id = 10, Type = "CO2-DUMMY", Unit = "ppm" },
            new Sensor { Id = 11, Type = "NO2-DUMMY", Unit = "ppb" },
            new Sensor { Id = 12, Type = "O3-DUMMY", Unit = "ppb" },
            new Sensor { Id = 13, Type = "PM2.5-DUMMY", Unit = "µg/m³" },
            new Sensor { Id = 14, Type = "PM10-DUMMY", Unit = "µg/m³" }
        );

        // Seed Station_Sensors relationships
        modelBuilder.Entity<StationSensor>().HasData(
            new StationSensor { Id = 1, StationId = "1", SensorId = 1 },
            new StationSensor { Id = 2, StationId = "1", SensorId = 2 },
            new StationSensor { Id = 3, StationId = "1", SensorId = 3 },
            new StationSensor { Id = 4, StationId = "1", SensorId = 5 },
            new StationSensor { Id = 5, StationId = "2", SensorId = 1 },
            new StationSensor { Id = 6, StationId = "2", SensorId = 2 },
            new StationSensor { Id = 7, StationId = "2", SensorId = 4 },
            new StationSensor { Id = 8, StationId = "2", SensorId = 6 },
            new StationSensor { Id = 9, StationId = "3", SensorId = 1 },
            new StationSensor { Id = 10, StationId = "3", SensorId = 2 },
            new StationSensor { Id = 11, StationId = "3", SensorId = 3 },
            new StationSensor { Id = 12, StationId = "3", SensorId = 7 },
            new StationSensor { Id = 13, StationId = "3", SensorId = 8 },
            new StationSensor { Id = 14, StationId = "4", SensorId = 1 },
            new StationSensor { Id = 15, StationId = "4", SensorId = 3 },
            new StationSensor { Id = 16, StationId = "4", SensorId = 6 },
            new StationSensor { Id = 17, StationId = "4", SensorId = 10 },
            new StationSensor { Id = 18, StationId = "5", SensorId = 1 },
            new StationSensor { Id = 19, StationId = "5", SensorId = 2 },
            new StationSensor { Id = 20, StationId = "5", SensorId = 5 },
            new StationSensor { Id = 21, StationId = "5", SensorId = 9 },
            new StationSensor { Id = 22, StationId = "5", SensorId = 13 },
            new StationSensor { Id = 23, StationId = "1", SensorId = 11 },
            new StationSensor { Id = 24, StationId = "2", SensorId = 12 },
            new StationSensor { Id = 25, StationId = "3", SensorId = 14 },
            new StationSensor { Id = 26, StationId = "4", SensorId = 7 },
            new StationSensor { Id = 27, StationId = "5", SensorId = 4 }
        );

        // Seed Measurements
        Random random = new();
        for (int daysAgo = 1; daysAgo <= 30; daysAgo++)
        {
            for (int amount = 0; amount < random.Next(10, 31); amount++)
            {
                modelBuilder.Entity<Measurement>().HasData( new Measurement
                {
                    Timestamp = DateTime.UtcNow.AddDays(-daysAgo),
                    StationSensorId = random.Next(1, 28),
                    SensorValue = (10 + (random.NextDouble() * (100 - 10))).ToString(CultureInfo.InvariantCulture),
                } );
            }
        }
        */
    }

    public DbSet<Station> Stations { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<StationSensor> StationSensors { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
}