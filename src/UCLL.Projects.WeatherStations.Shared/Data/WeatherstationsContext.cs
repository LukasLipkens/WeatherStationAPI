﻿using System.Collections.Concurrent;
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

            entity.HasKey(measurement => new { measurement.Timestamp, measurement.StationSensorId })
                .HasName("PK_Measurements_Timestamp_StationSensorId");

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
    }

    public async Task SeedDatabaseAsync()
    {
        if (await Stations.AnyAsync() || await Sensors.AnyAsync() || await StationSensors.AnyAsync() || await Measurements.AnyAsync()) return;

        List<Station> mockStations =
        [
            new() { Id = "mockstation_ecd1218f0cb2", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 38.34, Latitude = 51.054342, Longitude = 3.717424, Name = "Gent-1", Description = "Weer station op de Koningin Astridlaan in Gent met een hele boel sensoren." },
            new() { Id = "mockstation_9310e8a9ce16", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 72.54, Latitude = 51.329448, Longitude = 4.402464, Name = "Antwerpen-1", Description = "Weer station op de Grote Markt in Antwerpen met een hele boel sensoren." },
            new() { Id = "mockstation_6cd246bbbac3", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 43.66, Latitude = 51.2194, Longitude = 4.4025, Name = "Antwerpen-2", Description = "Weer station op de Kleine Markt in Antwerpen met een hele boel sensoren." },
            new() { Id = "mockstation_0c455cbb2ceb", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 2.54, Latitude = 51.1055, Longitude = 3.9937, Name = "Lokeren-1", Description = "Weer station in Lokeren met een hele boel sensoren." },
            new() { Id = "mockstation_678a37c9a42c", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 88.47, Latitude = 51.2093, Longitude = 3.2247, Name = "Brugge-1", Description = "Weer station in Brugge met een hele boel sensoren." },
            new() { Id = "mockstation_42bf17205943", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 11.34, Latitude = 50.928467, Longitude = 5.394843, Name = "Diepenbeek-1", Description = "Weer station op de Rooistraat in Diepenbeek met een hele boel sensoren." },
            new() { Id = "mockstation_5328f1f993f9", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 56.43, Latitude = 50.870927, Longitude = 5.518267, Name = "Bilzen-1", Description = "Weer station op de Heidestraat in Bilzen met een hele boel sensoren." },
            new() { Id = "mockstation_8a9ca571f2e8", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 45.23, Latitude = 50.9304, Longitude = 5.3372, Name = "Hasselt-1", Description = "Weer station op de Molenstraat in Hasselt met een hele boel sensoren." },
            new() { Id = "mockstation_e927b3abfe77", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 14.65, Latitude = 50.9307, Longitude = 5.3322, Name = "Hasselt-2", Description = "Weer station in Hasselt met een hele boel sensoren." },
            new() { Id = "mockstation_bfd74310b1ff", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 87.35, Latitude = 51.1651, Longitude = 4.9891, Name = "Geel-1", Description = "Weer station in Geel met een hele boel sensoren." },
            new() { Id = "mockstation_27bf9faf9703", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 65.09, Latitude = 50.8445, Longitude = 3.6072, Name = "Oudenaarde-1", Description = "Weer station in Oudenaarde met een hele boel sensoren." },
            new() { Id = "mockstation_f4e3d2c1b0a9", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 98.12, Latitude = 51.143117, Longitude = 5.581044, Name = "Bree-1", Description = "Weer station in Bree met een hele boel sensoren." },
            new() { Id = "mockstation_a1b2c3d4e5f6", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 71.54, Latitude = 50.874192, Longitude = 4.703378, Name = "Leuven-1", Description = "Weer station in Leuven met een temperatuur sensor en een vochtigheidssensor." },
            new() { Id = "mockstation_1a2b3c4d5e6f", LastActivityTimestamp = DateTime.UtcNow, Password = "defaultPassword123!", BatteryLevel = 38.34, Latitude = 50.957940, Longitude = 5.495229, Name = "Genk-1", Description = "Weer station in Genk met een temperatuur sensor, een vochtigheidssensor, een luchtdruk sensor en een wind snelheid sensor." },
        ];
        await Stations.AddRangeAsync(mockStations);
        await SaveChangesAsync();

        List<Sensor> mockSensors =
        [
            new() { Type = "temperature", Unit = "C" },
            new() { Type = "humidity", Unit = "%" },
            new() { Type = "pressure", Unit = "HPa" },
            new() { Type = "AQI", Unit = "ppm" },
            new() { Type = "TVOC", Unit = "ppb" },
            new() { Type = "eCO2", Unit = "ppm" },
            new() { Type = "windspeed", Unit = "Km/h" },
        ];
        await Sensors.AddRangeAsync(mockSensors);
        await SaveChangesAsync();

        List<StationSensor> mockStationSensors = [];
        mockStationSensors.AddRange(from mockStation in mockStations.SkipLast(2) from mockSensor in mockSensors select new StationSensor() { StationId = mockStation.Id, SensorId = mockSensor.Id });

        mockStationSensors.Add(new() { StationId = mockStations[^2].Id, SensorId = mockSensors[0].Id });
        mockStationSensors.Add(new() { StationId = mockStations[^2].Id, SensorId = mockSensors[1].Id });

        mockStationSensors.Add(new() { StationId = mockStations.Last().Id, SensorId = mockSensors[0].Id });
        mockStationSensors.Add(new() { StationId = mockStations.Last().Id, SensorId = mockSensors[1].Id });
        mockStationSensors.Add(new() { StationId = mockStations.Last().Id, SensorId = mockSensors[2].Id });
        mockStationSensors.Add(new() { StationId = mockStations.Last().Id, SensorId = mockSensors[6].Id });

        await StationSensors.AddRangeAsync(mockStationSensors);
        await SaveChangesAsync();

        DateTime now = DateTime.Today.ToUniversalTime();
        Random random = new();
        int measurementIdCounter = 0;

        ConcurrentBag<Measurement> concurrentMockMeasurements = [];
        Parallel.ForEach(mockStationSensors, mockStationSensor =>
        {
            for (int daysBack = 0; daysBack < 60; daysBack++)
            {
                for (int i = 0; i < random.Next(100, 200); i++)
                {
                    DateTime uniqueTimestamp = now.AddDays(-daysBack)
                        .AddMicroseconds(measurementIdCounter + random.Next(10, 20))
                        .AddMilliseconds(measurementIdCounter + random.Next(0, 10))
                        .AddSeconds(random.Next(1, 60))
                        .AddMinutes(random.Next(1, 60))
                        .AddHours(random.Next(1, 24));

                    concurrentMockMeasurements.Add(new()
                    {
                        Timestamp = uniqueTimestamp,
                        StationSensorId = mockStationSensor.Id,
                        SensorValue = (15.0 + random.NextDouble() * (55.0 - 15.0)).ToString(CultureInfo.InvariantCulture),
                    });

                    measurementIdCounter++;
                }
            }
        });
        await Measurements.AddRangeAsync(concurrentMockMeasurements.ToList());
        await SaveChangesAsync();
    }

    public DbSet<Station> Stations { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<StationSensor> StationSensors { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
}