﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherStationAPI.Data;

#nullable disable

namespace WeatherStationAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WeatherStationAPI.Models.Measurement", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("StationId", "SensorId", "Timestamp");

                    b.HasIndex("SensorId");

                    b.ToTable("Measurements");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            SensorId = 1,
                            Timestamp = new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2072),
                            Value = 23.5
                        },
                        new
                        {
                            StationId = 1,
                            SensorId = 2,
                            Timestamp = new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2082),
                            Value = 60.0
                        },
                        new
                        {
                            StationId = 1,
                            SensorId = 1,
                            Timestamp = new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2085),
                            Value = 22.5
                        },
                        new
                        {
                            StationId = 1,
                            SensorId = 2,
                            Timestamp = new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2087),
                            Value = 58.0
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 1,
                            Timestamp = new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2089),
                            Value = 19.199999999999999
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 2,
                            Timestamp = new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2091),
                            Value = 61.0
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 1,
                            Timestamp = new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2093),
                            Value = 18.199999999999999
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 2,
                            Timestamp = new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2096),
                            Value = 57.0
                        });
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

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

            modelBuilder.Entity("WeatherStationAPI.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Weather station in New York",
                            Latitude = 40.712800000000001,
                            Longitude = -74.006,
                            Name = "Station A"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Weather station in Los Angeles",
                            Latitude = 34.052199999999999,
                            Longitude = -118.2437,
                            Name = "Station B"
                        });
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Station_Sensor", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.HasKey("StationId", "SensorId");

                    b.HasIndex("SensorId");

                    b.ToTable("Station_Sensors");

                    b.HasData(
                        new
                        {
                            StationId = 1,
                            SensorId = 1
                        },
                        new
                        {
                            StationId = 1,
                            SensorId = 2
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 1
                        },
                        new
                        {
                            StationId = 2,
                            SensorId = 2
                        });
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Measurement", b =>
                {
                    b.HasOne("WeatherStationAPI.Models.Sensor", null)
                        .WithMany("Measurements")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeatherStationAPI.Models.Station", null)
                        .WithMany("Measurements")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Station_Sensor", b =>
                {
                    b.HasOne("WeatherStationAPI.Models.Sensor", "Sensor")
                        .WithMany("Station_Sensors")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WeatherStationAPI.Models.Station", "Station")
                        .WithMany("Station_Sensors")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensor");

                    b.Navigation("Station");
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Sensor", b =>
                {
                    b.Navigation("Measurements");

                    b.Navigation("Station_Sensors");
                });

            modelBuilder.Entity("WeatherStationAPI.Models.Station", b =>
                {
                    b.Navigation("Measurements");

                    b.Navigation("Station_Sensors");
                });
#pragma warning restore 612, 618
        }
    }
}
