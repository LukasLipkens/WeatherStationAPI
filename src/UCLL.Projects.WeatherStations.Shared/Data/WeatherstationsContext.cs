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

        modelBuilder.Entity<Station>().HasData(
            new() { Id = "mockstation_ecd1218f0cb2", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = 38, Latitude = 51.054342, Longitude = 3.717424, Name = "Gent", Description = "Koningin Astridlaan Gent" },
            new() { Id = "mockstation_9310e8a9ce16", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = 72, Latitude = 51.329448, Longitude = 4.402464, Name = null, Description = "Grote Markt Antwerpen" },
            new() { Id = "mockstation_6cd246bbbac3", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 51.2194, Longitude = 4.4025, Name = null, Description = "kleine Markt Antwerpen" },
            new() { Id = "mockstation_0c455cbb2ceb", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = 2, Latitude = 51.1055, Longitude = 3.9937, Name = null, Description = "Lokeren" },
            new() { Id = "mockstation_678a37c9a42c", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = 88.47, Latitude = 51.2093, Longitude = 3.2247, Name = null, Description = "Brugge" },
            new() { Id = "mockstation_42bf17205943", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = 0, Latitude = 50.928467, Longitude = 5.394843, Name = null, Description = "Rooistraat Diepenbeek" },
            new() { Id = "mockstation_5328f1f993f9", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 50.870927, Longitude = 5.518267, Name = null, Description = "Heidestraat Bilzen" },
            new() { Id = "mockstation_8a9ca571f2e8", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 50.9304, Longitude = 5.3372, Name = null, Description = "Molenstraat Hasselt" },
            new() { Id = "mockstation_e927b3abfe77", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 50.9307, Longitude = 5.3322, Name = "weerstation hasselt", Description = "Hasselt" },
            new() { Id = "mockstation_bfd74310b1ff", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 51.1651, Longitude = 4.9891, Name = "Weerstation geel", Description = "Geel" },
            new() { Id = "mockstation_27bf9faf9703", LastActivityTimestamp = DateTime.UtcNow, BatteryLevel = null, Latitude = 50.8445, Longitude = 3.6072, Name = "weerstation oudenaarde", Description = "Oudenaarde" }
        );

        modelBuilder.Entity<Sensor>().HasData(
            new() { Id = 100, Type = "temperature", Unit = "C" },
            new() { Id = 101, Type = "humidity", Unit = "%" },
            new() { Id = 102, Type = "pressure", Unit = "HPa" },
            new() { Id = 103, Type = "AQI", Unit = "ppm" },
            new() { Id = 104, Type = "TVOC", Unit = "ppb" },
            new() { Id = 105, Type = "eCO2", Unit = "ppm" },
            new() { Id = 106, Type = "windspeed", Unit = "Km/h" },
            new() { Id = 107, Type = "temperature", Unit = "C" }
        );

        modelBuilder.Entity<StationSensor>().HasData(
            new() { Id = 100, StationId = "mockstation_ecd1218f0cb2", SensorId = 100 },
            new() { Id = 101,  StationId = "mockstation_ecd1218f0cb2", SensorId = 101 },
            new() { Id = 102,  StationId = "mockstation_ecd1218f0cb2", SensorId = 102 },
            new() { Id = 103,  StationId = "mockstation_9310e8a9ce16", SensorId = 106 },
            new() { Id = 104,  StationId = "mockstation_6cd246bbbac3", SensorId = 100 },
            new() { Id = 105,  StationId = "mockstation_6cd246bbbac3", SensorId = 101 },
            new() { Id = 106,  StationId = "mockstation_6cd246bbbac3", SensorId = 102 },
            new() { Id = 107,  StationId = "mockstation_6cd246bbbac3", SensorId = 103 },
            new() { Id = 108,  StationId = "mockstation_6cd246bbbac3", SensorId = 104 },
            new() { Id = 109,  StationId = "mockstation_6cd246bbbac3", SensorId = 105 },
            new() { Id = 110,  StationId = "mockstation_678a37c9a42c", SensorId = 107 },
            new() { Id = 111,  StationId = "mockstation_42bf17205943", SensorId = 100 },
            new() { Id = 112,  StationId = "mockstation_42bf17205943", SensorId = 101 },
            new() { Id = 113,  StationId = "mockstation_42bf17205943", SensorId = 102 },
            new() { Id = 114,  StationId = "mockstation_42bf17205943", SensorId = 103 },
            new() { Id = 115,  StationId = "mockstation_42bf17205943", SensorId = 104 },
            new() { Id = 116,  StationId = "mockstation_42bf17205943", SensorId = 105 },
            new() { Id = 117,  StationId = "mockstation_5328f1f993f9", SensorId = 100 },
            new() { Id = 118,  StationId = "mockstation_5328f1f993f9", SensorId = 101 },
            new() { Id = 119,  StationId = "mockstation_5328f1f993f9", SensorId = 102 },
            new() { Id = 120,  StationId = "mockstation_5328f1f993f9", SensorId = 103 },
            new() { Id = 121,  StationId = "mockstation_5328f1f993f9", SensorId = 104 },
            new() { Id = 122,  StationId = "mockstation_5328f1f993f9", SensorId = 105 },
            new() { Id = 123,  StationId = "mockstation_8a9ca571f2e8", SensorId = 100 },
            new() { Id = 124,  StationId = "mockstation_8a9ca571f2e8", SensorId = 101 },
            new() { Id = 125,  StationId = "mockstation_8a9ca571f2e8", SensorId = 102 },
            new() { Id = 126,  StationId = "mockstation_8a9ca571f2e8", SensorId = 103 },
            new() { Id = 127,  StationId = "mockstation_8a9ca571f2e8", SensorId = 104 },
            new() { Id = 128,  StationId = "mockstation_8a9ca571f2e8", SensorId = 105 },
            new() { Id = 129,  StationId = "mockstation_e927b3abfe77", SensorId = 100 },
            new() { Id = 130,  StationId = "mockstation_e927b3abfe77", SensorId = 101 },
            new() { Id = 131,  StationId = "mockstation_e927b3abfe77", SensorId = 102 },
            new() { Id = 132,  StationId = "mockstation_bfd74310b1ff", SensorId = 106 },
            new() { Id = 133,  StationId = "mockstation_27bf9faf9703", SensorId = 100 },
            new() { Id = 134,  StationId = "mockstation_27bf9faf9703", SensorId = 101 },
            new() { Id = 135,  StationId = "mockstation_27bf9faf9703", SensorId = 102 },
            new() { Id = 136,  StationId = "mockstation_27bf9faf9703", SensorId = 103 },
            new() { Id = 137,  StationId = "mockstation_27bf9faf9703", SensorId = 104 },
            new() { Id = 138,  StationId = "mockstation_27bf9faf9703", SensorId = 105 }
        );

        modelBuilder.Entity<Measurement>().HasData(
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.1921091"), StationSensorId = 100, SensorValue = "86.10" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.8266621"), StationSensorId = 100, SensorValue = "25.97" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.1310548"), StationSensorId = 100, SensorValue = "39.19" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.1915437"), StationSensorId = 100, SensorValue = "61.04" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.1885534"), StationSensorId = 100, SensorValue = "79.52" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.6165453"), StationSensorId = 100, SensorValue = "59.09" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6012887"), StationSensorId = 100, SensorValue = "30.57" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.8912721"), StationSensorId = 100, SensorValue = "45.28" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.4478214"), StationSensorId = 100, SensorValue = "76.54" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.3001714"), StationSensorId = 100, SensorValue = "33.87" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.2452393"), StationSensorId = 101, SensorValue = "55.83" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.9128166"), StationSensorId = 101, SensorValue = "46.90" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.1873668"), StationSensorId = 101, SensorValue = "99.99" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.2822383"), StationSensorId = 101, SensorValue = "12.89" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.2336692"), StationSensorId = 101, SensorValue = "86.74" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.6637601"), StationSensorId = 101, SensorValue = "17.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6437189"), StationSensorId = 101, SensorValue = "47.66" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.9368453"), StationSensorId = 101, SensorValue = "55.93" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.5028826"), StationSensorId = 101, SensorValue = "14.56" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.3891112"), StationSensorId = 101, SensorValue = "33.82" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.3169133"), StationSensorId = 102, SensorValue = "33.43" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.9591489"), StationSensorId = 102, SensorValue = "49.51" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.2349924"), StationSensorId = 102, SensorValue = "49.17" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.3486229"), StationSensorId = 102, SensorValue = "82.83" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.2873032"), StationSensorId = 102, SensorValue = "74.84" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.7013706"), StationSensorId = 102, SensorValue = "80.80" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6830954"), StationSensorId = 102, SensorValue = "95.46" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:20.0076768"), StationSensorId = 102, SensorValue = "80.58" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.5613821"), StationSensorId = 102, SensorValue = "69.79" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.4656417"), StationSensorId = 102, SensorValue = "23.46" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.3010361"), StationSensorId = 103, SensorValue = "49.15" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.4210462"), StationSensorId = 103, SensorValue = "58.47" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.4611188"), StationSensorId = 103, SensorValue = "45.45" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.6890201"), StationSensorId = 104, SensorValue = "74.77" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.1201079"), StationSensorId = 104, SensorValue = "45.92" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.6456318"), StationSensorId = 104, SensorValue = "46.33" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.6300521"), StationSensorId = 104, SensorValue = "93.81" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.7951169"), StationSensorId = 104, SensorValue = "65.48" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.2373858"), StationSensorId = 104, SensorValue = "70.27" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.1650442"), StationSensorId = 104, SensorValue = "80.86" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.3376089"), StationSensorId = 104, SensorValue = "49.26" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:17.9639188"), StationSensorId = 104, SensorValue = "13.86" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:15.8010299"), StationSensorId = 104, SensorValue = "89.32" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9076356"), StationSensorId = 105, SensorValue = "18.67" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.3935865"), StationSensorId = 105, SensorValue = "84.32" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.8770293"), StationSensorId = 105, SensorValue = "88.30" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.8323009"), StationSensorId = 105, SensorValue = "39.40" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.9794387"), StationSensorId = 105, SensorValue = "66.89" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4182635"), StationSensorId = 105, SensorValue = "47.06" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.3831481"), StationSensorId = 105, SensorValue = "90.13" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6136872"), StationSensorId = 105, SensorValue = "35.48" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.1913733"), StationSensorId = 105, SensorValue = "26.00" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0068166"), StationSensorId = 105, SensorValue = "13.56" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9591687"), StationSensorId = 106, SensorValue = "16.13" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.4508839"), StationSensorId = 106, SensorValue = "57.55" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.9292325"), StationSensorId = 106, SensorValue = "81.12" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.9072997"), StationSensorId = 106, SensorValue = "53.34" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.0293205"), StationSensorId = 106, SensorValue = "59.07" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4622079"), StationSensorId = 106, SensorValue = "47.48" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.4300214"), StationSensorId = 106, SensorValue = "68.31" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6764549"), StationSensorId = 106, SensorValue = "59.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.2576997"), StationSensorId = 106, SensorValue = "86.37" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0732301"), StationSensorId = 106, SensorValue = "53.92" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3261125"), StationSensorId = 107, SensorValue = "40.74" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.7599821"), StationSensorId = 107, SensorValue = "44.60" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4237428"), StationSensorId = 107, SensorValue = "12.40" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5219294"), StationSensorId = 107, SensorValue = "22.38" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6349256"), StationSensorId = 107, SensorValue = "47.07" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6277492"), StationSensorId = 107, SensorValue = "95.68" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.6755409"), StationSensorId = 107, SensorValue = "63.82" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7140058"), StationSensorId = 107, SensorValue = "89.60" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7168344"), StationSensorId = 107, SensorValue = "73.62" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7389448"), StationSensorId = 107, SensorValue = "91.52" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3527933"), StationSensorId = 108, SensorValue = "44.07" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8093009"), StationSensorId = 108, SensorValue = "40.79" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4567759"), StationSensorId = 108, SensorValue = "96.95" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5606172"), StationSensorId = 108, SensorValue = "27.72" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6724627"), StationSensorId = 108, SensorValue = "85.49" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6730973"), StationSensorId = 108, SensorValue = "53.55" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7194717"), StationSensorId = 108, SensorValue = "43.12" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7540378"), StationSensorId = 108, SensorValue = "37.37" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7599367"), StationSensorId = 108, SensorValue = "91.86" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7795148"), StationSensorId = 108, SensorValue = "16.98" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3806762"), StationSensorId = 109, SensorValue = "68.11" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8359883"), StationSensorId = 109, SensorValue = "91.24" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4858164"), StationSensorId = 109, SensorValue = "63.01" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.6072605"), StationSensorId = 109, SensorValue = "40.43" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.7089022"), StationSensorId = 109, SensorValue = "66.81" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.7088211"), StationSensorId = 109, SensorValue = "64.92" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7592261"), StationSensorId = 109, SensorValue = "84.39" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7938891"), StationSensorId = 109, SensorValue = "81.37" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7973129"), StationSensorId = 109, SensorValue = "62.94" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.8261688"), StationSensorId = 109, SensorValue = "56.26" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:22:45.6602261"), StationSensorId = 110, SensorValue = "86.69" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.6890201"), StationSensorId = 111, SensorValue = "47.45" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.1201079"), StationSensorId = 111, SensorValue = "21.94" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.6456318"), StationSensorId = 111, SensorValue = "66.36" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.6300521"), StationSensorId = 111, SensorValue = "77.74" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.7951169"), StationSensorId = 111, SensorValue = "42.69" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.2373858"), StationSensorId = 111, SensorValue = "42.16" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.1650442"), StationSensorId = 111, SensorValue = "45.21" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.3376089"), StationSensorId = 111, SensorValue = "39.82" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:17.9639188"), StationSensorId = 111, SensorValue = "29.10" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:15.8010299"), StationSensorId = 111, SensorValue = "65.05" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9076556"), StationSensorId = 112, SensorValue = "22.67" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.3933865"), StationSensorId = 112, SensorValue = "47.37" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.8770293"), StationSensorId = 112, SensorValue = "77.59" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.8323009"), StationSensorId = 112, SensorValue = "61.01" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.9739387"), StationSensorId = 112, SensorValue = "66.68" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4182635"), StationSensorId = 112, SensorValue = "72.82" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.3831481"), StationSensorId = 112, SensorValue = "46.76" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6136872"), StationSensorId = 112, SensorValue = "20.55" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.1911333"), StationSensorId = 112, SensorValue = "65.15" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0068166"), StationSensorId = 112, SensorValue = "64.87" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9591687"), StationSensorId = 113, SensorValue = "95.24" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.4508839"), StationSensorId = 113, SensorValue = "94.34" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.9292325"), StationSensorId = 113, SensorValue = "33.62" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.9072997"), StationSensorId = 113, SensorValue = "32.01" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.0293205"), StationSensorId = 113, SensorValue = "54.57" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4622079"), StationSensorId = 113, SensorValue = "43.03" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.4300214"), StationSensorId = 113, SensorValue = "37.51" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6764549"), StationSensorId = 113, SensorValue = "86.39" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.2576997"), StationSensorId = 113, SensorValue = "86.37" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0732301"), StationSensorId = 113, SensorValue = "43.28" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3261125"), StationSensorId = 114, SensorValue = "55.95" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.7599821"), StationSensorId = 114, SensorValue = "64.85" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4273428"), StationSensorId = 114, SensorValue = "23.93" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5219294"), StationSensorId = 114, SensorValue = "75.69" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6349256"), StationSensorId = 114, SensorValue = "72.14" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6277492"), StationSensorId = 114, SensorValue = "58.73" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.6755409"), StationSensorId = 114, SensorValue = "63.50" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7140058"), StationSensorId = 114, SensorValue = "43.58" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7168344"), StationSensorId = 114, SensorValue = "12.07" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7389448"), StationSensorId = 114, SensorValue = "91.71" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3527933"), StationSensorId = 115, SensorValue = "11.55" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8093009"), StationSensorId = 115, SensorValue = "45.61" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4567759"), StationSensorId = 115, SensorValue = "63.55" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5606172"), StationSensorId = 115, SensorValue = "48.78" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6742627"), StationSensorId = 115, SensorValue = "28.90" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6130973"), StationSensorId = 115, SensorValue = "23.83" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7194717"), StationSensorId = 115, SensorValue = "59.83" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7540378"), StationSensorId = 115, SensorValue = "69.24" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7599367"), StationSensorId = 115, SensorValue = "96.45" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7795148"), StationSensorId = 115, SensorValue = "30.08" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3806762"), StationSensorId = 116, SensorValue = "15.19" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8359883"), StationSensorId = 116, SensorValue = "12.55" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4858164"), StationSensorId = 116, SensorValue = "73.27" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.6072605"), StationSensorId = 116, SensorValue = "19.49" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.7089022"), StationSensorId = 116, SensorValue = "32.60" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.7088211"), StationSensorId = 116, SensorValue = "22.97" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7592261"), StationSensorId = 116, SensorValue = "29.54" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7938891"), StationSensorId = 116, SensorValue = "49.28" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7973129"), StationSensorId = 116, SensorValue = "80.64" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.8261688"), StationSensorId = 116, SensorValue = "56.29" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.6890201"), StationSensorId = 117, SensorValue = "68.08" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.1201079"), StationSensorId = 117, SensorValue = "46.34" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.6456318"), StationSensorId = 117, SensorValue = "41.75" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.6300521"), StationSensorId = 117, SensorValue = "53.37" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.7951169"), StationSensorId = 117, SensorValue = "12.09" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.2376858"), StationSensorId = 117, SensorValue = "78.75" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.1650442"), StationSensorId = 117, SensorValue = "52.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.3376089"), StationSensorId = 117, SensorValue = "61.37" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:17.9639188"), StationSensorId = 117, SensorValue = "18.35" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:15.8010299"), StationSensorId = 117, SensorValue = "96.97" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9072656"), StationSensorId = 118, SensorValue = "82.41" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.3938565"), StationSensorId = 118, SensorValue = "72.64" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.8770293"), StationSensorId = 118, SensorValue = "56.55" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.8323009"), StationSensorId = 118, SensorValue = "51.34" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.9793487"), StationSensorId = 118, SensorValue = "15.96" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4182635"), StationSensorId = 118, SensorValue = "42.40" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.3831481"), StationSensorId = 118, SensorValue = "78.38" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6136872"), StationSensorId = 118, SensorValue = "48.05" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.1911333"), StationSensorId = 118, SensorValue = "22.72" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0068166"), StationSensorId = 118, SensorValue = "30.45" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9591687"), StationSensorId = 119, SensorValue = "64.76" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.4508839"), StationSensorId = 119, SensorValue = "50.99" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.9292325"), StationSensorId = 119, SensorValue = "59.02" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.9072997"), StationSensorId = 119, SensorValue = "64.40" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.0293205"), StationSensorId = 119, SensorValue = "35.52" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4622079"), StationSensorId = 119, SensorValue = "58.17" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.4300214"), StationSensorId = 119, SensorValue = "12.71" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6764549"), StationSensorId = 119, SensorValue = "77.01" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.2576997"), StationSensorId = 119, SensorValue = "23.16" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0732301"), StationSensorId = 119, SensorValue = "47.36" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3261125"), StationSensorId = 120, SensorValue = "16.00" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.7599821"), StationSensorId = 120, SensorValue = "72.96" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4247428"), StationSensorId = 120, SensorValue = "56.71" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5219294"), StationSensorId = 120, SensorValue = "56.94" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6349256"), StationSensorId = 120, SensorValue = "94.36" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6277492"), StationSensorId = 120, SensorValue = "15.35" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.6755409"), StationSensorId = 120, SensorValue = "23.98" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7140058"), StationSensorId = 120, SensorValue = "77.42" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7168344"), StationSensorId = 120, SensorValue = "37.74" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7389448"), StationSensorId = 120, SensorValue = "37.71" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3527933"), StationSensorId = 121, SensorValue = "46.34" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8093009"), StationSensorId = 121, SensorValue = "85.99" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4567759"), StationSensorId = 121, SensorValue = "43.22" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5606172"), StationSensorId = 121, SensorValue = "92.31" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6726527"), StationSensorId = 121, SensorValue = "41.63" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6730973"), StationSensorId = 121, SensorValue = "85.23" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7194717"), StationSensorId = 121, SensorValue = "65.99" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7540378"), StationSensorId = 121, SensorValue = "38.31" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7599367"), StationSensorId = 121, SensorValue = "67.58" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7795148"), StationSensorId = 121, SensorValue = "98.05" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3806762"), StationSensorId = 122, SensorValue = "38.49" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8359883"), StationSensorId = 122, SensorValue = "62.14" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4858164"), StationSensorId = 122, SensorValue = "56.58" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.6072605"), StationSensorId = 122, SensorValue = "66.38" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.7089022"), StationSensorId = 122, SensorValue = "88.90" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.7088211"), StationSensorId = 122, SensorValue = "70.96" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7592261"), StationSensorId = 122, SensorValue = "46.16" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7938891"), StationSensorId = 122, SensorValue = "62.12" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7973129"), StationSensorId = 122, SensorValue = "40.23" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.8261688"), StationSensorId = 122, SensorValue = "77.81" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.6890201"), StationSensorId = 123, SensorValue = "89.10" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.1201079"), StationSensorId = 123, SensorValue = "48.30" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.6456318"), StationSensorId = 123, SensorValue = "83.87" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.6300521"), StationSensorId = 123, SensorValue = "92.56" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.7951169"), StationSensorId = 123, SensorValue = "67.96" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.2374858"), StationSensorId = 123, SensorValue = "55.05" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.1650442"), StationSensorId = 123, SensorValue = "35.47" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.3376089"), StationSensorId = 123, SensorValue = "39.00" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:17.9639188"), StationSensorId = 123, SensorValue = "78.95" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:15.8010299"), StationSensorId = 123, SensorValue = "98.40" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9057656"), StationSensorId = 124, SensorValue = "67.60" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.3935265"), StationSensorId = 124, SensorValue = "61.42" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.8770293"), StationSensorId = 124, SensorValue = "74.94" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.8323009"), StationSensorId = 124, SensorValue = "40.12" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.9793187"), StationSensorId = 124, SensorValue = "32.14" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4182635"), StationSensorId = 124, SensorValue = "50.83" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.3831481"), StationSensorId = 124, SensorValue = "12.81" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6136872"), StationSensorId = 124, SensorValue = "12.05" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.1913533"), StationSensorId = 124, SensorValue = "32.68" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0068166"), StationSensorId = 124, SensorValue = "26.42" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9591687"), StationSensorId = 125, SensorValue = "10.55" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.4508839"), StationSensorId = 125, SensorValue = "12.70" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.9292325"), StationSensorId = 125, SensorValue = "63.89" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.9072997"), StationSensorId = 125, SensorValue = "27.42" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.0293205"), StationSensorId = 125, SensorValue = "68.05" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4622079"), StationSensorId = 125, SensorValue = "40.00" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.4300214"), StationSensorId = 125, SensorValue = "27.59" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6764549"), StationSensorId = 125, SensorValue = "10.70" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.2576997"), StationSensorId = 125, SensorValue = "14.86" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0732301"), StationSensorId = 125, SensorValue = "84.97" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3261125"), StationSensorId = 126, SensorValue = "64.31" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.7599821"), StationSensorId = 126, SensorValue = "31.22" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4274258"), StationSensorId = 126, SensorValue = "49.68" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5219294"), StationSensorId = 126, SensorValue = "11.44" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6349256"), StationSensorId = 126, SensorValue = "64.57" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6277492"), StationSensorId = 126, SensorValue = "21.92" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.6755409"), StationSensorId = 126, SensorValue = "43.94" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7140058"), StationSensorId = 126, SensorValue = "10.28" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7168344"), StationSensorId = 126, SensorValue = "47.09" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7389448"), StationSensorId = 126, SensorValue = "12.25" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3527933"), StationSensorId = 127, SensorValue = "66.93" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8093009"), StationSensorId = 127, SensorValue = "82.42" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4567759"), StationSensorId = 127, SensorValue = "79.99" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5606172"), StationSensorId = 127, SensorValue = "73.21" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6742627"), StationSensorId = 127, SensorValue = "65.40" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6730973"), StationSensorId = 127, SensorValue = "52.68" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7194717"), StationSensorId = 127, SensorValue = "61.02" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7540378"), StationSensorId = 127, SensorValue = "56.35" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7599367"), StationSensorId = 127, SensorValue = "15.85" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7795148"), StationSensorId = 127, SensorValue = "41.71" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3806762"), StationSensorId = 128, SensorValue = "13.68" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8359883"), StationSensorId = 128, SensorValue = "54.43" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4858164"), StationSensorId = 128, SensorValue = "41.18" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.6072605"), StationSensorId = 128, SensorValue = "78.15" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.7089022"), StationSensorId = 128, SensorValue = "55.35" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.7088211"), StationSensorId = 128, SensorValue = "63.12" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7592261"), StationSensorId = 128, SensorValue = "28.20" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7938891"), StationSensorId = 128, SensorValue = "59.16" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7973129"), StationSensorId = 128, SensorValue = "77.30" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.8261688"), StationSensorId = 128, SensorValue = "33.85" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.1921091"), StationSensorId = 129, SensorValue = "89.76" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.8266621"), StationSensorId = 129, SensorValue = "83.58" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.1310548"), StationSensorId = 129, SensorValue = "77.52" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.1931437"), StationSensorId = 129, SensorValue = "18.73" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.1885534"), StationSensorId = 129, SensorValue = "67.93" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.6165453"), StationSensorId = 129, SensorValue = "85.08" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6012887"), StationSensorId = 129, SensorValue = "87.14" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.8912721"), StationSensorId = 129, SensorValue = "13.25" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.4478214"), StationSensorId = 129, SensorValue = "40.16" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.3001714"), StationSensorId = 129, SensorValue = "86.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.2452393"), StationSensorId = 130, SensorValue = "75.33" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.9128166"), StationSensorId = 130, SensorValue = "18.89" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.1876648"), StationSensorId = 130, SensorValue = "57.96" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.2822383"), StationSensorId = 130, SensorValue = "62.17" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.2336692"), StationSensorId = 130, SensorValue = "17.09" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.6637601"), StationSensorId = 130, SensorValue = "71.84" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6437189"), StationSensorId = 130, SensorValue = "77.79" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.9368453"), StationSensorId = 130, SensorValue = "95.63" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.5028826"), StationSensorId = 130, SensorValue = "62.79" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.3891112"), StationSensorId = 130, SensorValue = "34.33" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:25.3169133"), StationSensorId = 131, SensorValue = "48.75" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.9591489"), StationSensorId = 131, SensorValue = "14.38" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.2349924"), StationSensorId = 131, SensorValue = "68.08" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.3486229"), StationSensorId = 131, SensorValue = "38.87" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.2873032"), StationSensorId = 131, SensorValue = "81.39" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.7013706"), StationSensorId = 131, SensorValue = "65.44" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.6830954"), StationSensorId = 131, SensorValue = "59.56" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:20.0076768"), StationSensorId = 131, SensorValue = "73.85" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.5613821"), StationSensorId = 131, SensorValue = "16.12" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.4653617"), StationSensorId = 131, SensorValue = "94.23" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:54.3010361"), StationSensorId = 132, SensorValue = "51.57" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:15.4210462"), StationSensorId = 132, SensorValue = "57.20" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.4611188"), StationSensorId = 132, SensorValue = "49.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.6890201"), StationSensorId = 133, SensorValue = "89.03" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.1201079"), StationSensorId = 133, SensorValue = "34.00" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.6456318"), StationSensorId = 133, SensorValue = "91.40" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.6300521"), StationSensorId = 133, SensorValue = "65.60" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.7951169"), StationSensorId = 133, SensorValue = "16.84" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.2387858"), StationSensorId = 133, SensorValue = "34.35" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.1650442"), StationSensorId = 133, SensorValue = "27.23" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.3376089"), StationSensorId = 133, SensorValue = "91.84" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:17.9639188"), StationSensorId = 133, SensorValue = "83.16" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:15.8010299"), StationSensorId = 133, SensorValue = "10.57" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9076656"), StationSensorId = 134, SensorValue = "34.83" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.3933865"), StationSensorId = 134, SensorValue = "27.67" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.8770293"), StationSensorId = 134, SensorValue = "77.78" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.8323009"), StationSensorId = 134, SensorValue = "27.47" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:37.9793387"), StationSensorId = 134, SensorValue = "43.82" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4182635"), StationSensorId = 134, SensorValue = "23.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.3831481"), StationSensorId = 134, SensorValue = "52.07" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6136872"), StationSensorId = 134, SensorValue = "43.35" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.1913433"), StationSensorId = 134, SensorValue = "56.55" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0068166"), StationSensorId = 134, SensorValue = "77.94" },
            new() { Timestamp = DateTime.Parse("2024-11-20T15:04:24.9591687"), StationSensorId = 135, SensorValue = "53.07" },
            new() { Timestamp = DateTime.Parse("2024-11-20T14:20:30.4508839"), StationSensorId = 135, SensorValue = "29.49" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:33:53.9292325"), StationSensorId = 135, SensorValue = "25.57" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:31:14.9072997"), StationSensorId = 135, SensorValue = "75.38" },
            new() { Timestamp = DateTime.Parse("2024-11-20T13:28:38.0293205"), StationSensorId = 135, SensorValue = "63.46" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:56:55.4622079"), StationSensorId = 135, SensorValue = "63.78" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:55:57.4300214"), StationSensorId = 135, SensorValue = "91.27" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:50:19.6764549"), StationSensorId = 135, SensorValue = "55.64" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:49:18.2576997"), StationSensorId = 135, SensorValue = "64.21" },
            new() { Timestamp = DateTime.Parse("2024-11-20T12:43:16.0732301"), StationSensorId = 135, SensorValue = "37.16" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3261125"), StationSensorId = 136, SensorValue = "63.57" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.7599821"), StationSensorId = 136, SensorValue = "94.59" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4277428"), StationSensorId = 136, SensorValue = "73.06" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5219294"), StationSensorId = 136, SensorValue = "95.41" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6349256"), StationSensorId = 136, SensorValue = "63.80" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6277492"), StationSensorId = 136, SensorValue = "80.14" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.6755409"), StationSensorId = 136, SensorValue = "64.94" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7140058"), StationSensorId = 136, SensorValue = "47.76" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7168344"), StationSensorId = 136, SensorValue = "63.21" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7389448"), StationSensorId = 136, SensorValue = "50.93" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3527933"), StationSensorId = 137, SensorValue = "51.80" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8093009"), StationSensorId = 137, SensorValue = "58.65" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4567759"), StationSensorId = 137, SensorValue = "82.37" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.5606172"), StationSensorId = 137, SensorValue = "36.89" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.6733627"), StationSensorId = 137, SensorValue = "92.10" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.6730973"), StationSensorId = 137, SensorValue = "97.39" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7194717"), StationSensorId = 137, SensorValue = "52.21" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7540378"), StationSensorId = 137, SensorValue = "89.99" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7599367"), StationSensorId = 137, SensorValue = "40.60" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.7795148"), StationSensorId = 137, SensorValue = "59.07" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:17.3806762"), StationSensorId = 138, SensorValue = "45.20" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:46:15.8359883"), StationSensorId = 138, SensorValue = "48.17" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:49.4858164"), StationSensorId = 138, SensorValue = "37.65" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:41.6072605"), StationSensorId = 138, SensorValue = "15.62" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:33.7089022"), StationSensorId = 138, SensorValue = "29.95" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:25.7088211"), StationSensorId = 138, SensorValue = "83.86" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:17.7592261"), StationSensorId = 138, SensorValue = "38.94" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:09.7938891"), StationSensorId = 138, SensorValue = "30.80" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:44:01.7973129"), StationSensorId = 138, SensorValue = "25.59" },
            new() { Timestamp = DateTime.Parse("2024-11-12T12:43:53.8261688"), StationSensorId = 138, SensorValue = "20.87" }
        );
    }

    public DbSet<Station> Stations { get; set; }
    public DbSet<Sensor> Sensors { get; set; }
    public DbSet<StationSensor> StationSensors { get; set; }
    public DbSet<Measurement> Measurements { get; set; }
}