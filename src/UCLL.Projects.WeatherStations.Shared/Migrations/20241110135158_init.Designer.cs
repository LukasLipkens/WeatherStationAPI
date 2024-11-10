﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCLL.Projects.WeatherStations.Shared.Data;

#nullable disable

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    [DbContext(typeof(WeatherstationsContext))]
    [Migration("20241110135158_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Measurement", b =>
                {
                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("timestamp");

                    b.Property<int>("StationSensorId")
                        .HasColumnType("int")
                        .HasColumnName("station_sensor_id");

                    b.Property<string>("SensorValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("sensor_value");

                    b.HasKey("Timestamp", "StationSensorId")
                        .HasName("PK_Measurements_Timestamp_StationSensorId");

                    b.HasIndex("StationSensorId");

                    b.ToTable("measurements", (string)null);

                    b.HasData(
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7845),
                            StationSensorId = 1,
                            SensorValue = "23.5"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7856),
                            StationSensorId = 2,
                            SensorValue = "60"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857),
                            StationSensorId = 1,
                            SensorValue = "22.5"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857),
                            StationSensorId = 2,
                            SensorValue = "58"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7858),
                            StationSensorId = 3,
                            SensorValue = "19.2"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7859),
                            StationSensorId = 4,
                            SensorValue = "61"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7860),
                            StationSensorId = 3,
                            SensorValue = "18.2"
                        },
                        new
                        {
                            Timestamp = new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7861),
                            StationSensorId = 4,
                            SensorValue = "57"
                        });
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("type");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Unit");

                    b.HasKey("Id")
                        .HasName("PK_Sensors_Id");

                    b.ToTable("sensors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Temperature",
                            Unit = "Celsius"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Humidity",
                            Unit = "%"
                        });
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Station", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.Property<double?>("BatteryLevel")
                        .HasColumnType("float")
                        .HasColumnName("battery_level");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<double>("Latitude")
                        .HasColumnType("float")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("float")
                        .HasColumnName("longitude");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK_Stations_Id");

                    b.ToTable("stations", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Description = "Weather station in New York",
                            Latitude = 40.712800000000001,
                            Longitude = -74.006,
                            Name = "Station A"
                        },
                        new
                        {
                            Id = "2",
                            Description = "Weather station in Los Angeles",
                            Latitude = 34.052199999999999,
                            Longitude = -118.2437,
                            Name = "Station B"
                        });
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.StationSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StationId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("station_id");

                    b.Property<int>("SensorId")
                        .HasColumnType("int")
                        .HasColumnName("sensor_id");

                    b.HasKey("Id", "StationId", "SensorId")
                        .HasName("PK_StationSensors_Id_StationId_SensorId");

                    b.HasIndex("SensorId");

                    b.HasIndex("StationId");

                    b.ToTable("station_sensors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StationId = "1",
                            SensorId = 1
                        },
                        new
                        {
                            Id = 2,
                            StationId = "1",
                            SensorId = 2
                        },
                        new
                        {
                            Id = 3,
                            StationId = "2",
                            SensorId = 1
                        },
                        new
                        {
                            Id = 4,
                            StationId = "2",
                            SensorId = 2
                        });
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Measurement", b =>
                {
                    b.HasOne("UCLL.Projects.WeatherStations.Shared.Data.Models.StationSensor", "StationSensor")
                        .WithMany("Measurements")
                        .HasForeignKey("StationSensorId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Measurements_StationSensorId");

                    b.Navigation("StationSensor");
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.StationSensor", b =>
                {
                    b.HasOne("UCLL.Projects.WeatherStations.Shared.Data.Models.Sensor", "Sensor")
                        .WithMany("StationSensors")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_StationSensors_SensorId");

                    b.HasOne("UCLL.Projects.WeatherStations.Shared.Data.Models.Station", "Station")
                        .WithMany("StationSensors")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_StationSensors_StationId");

                    b.Navigation("Sensor");

                    b.Navigation("Station");
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Sensor", b =>
                {
                    b.Navigation("StationSensors");
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Station", b =>
                {
                    b.Navigation("StationSensors");
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.StationSensor", b =>
                {
                    b.Navigation("Measurements");
                });
#pragma warning restore 612, 618
        }
    }
}
