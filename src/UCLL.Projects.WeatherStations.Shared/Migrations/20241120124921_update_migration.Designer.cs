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
    [Migration("20241120124921_update_migration")]
    partial class update_migration
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sensor_value");

                    b.HasKey("Timestamp", "StationSensorId")
                        .HasName("PK_Measurements_Timestamp_StationSensorId");

                    b.HasIndex("StationSensorId");

                    b.ToTable("measurements", (string)null);
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("type");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Unit");

                    b.HasKey("Id")
                        .HasName("PK_Sensors_Id");

                    b.ToTable("sensors", (string)null);
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.Station", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("id");

                    b.Property<double?>("BatteryLevel")
                        .HasColumnType("float")
                        .HasColumnName("battery_level");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("description");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float")
                        .HasColumnName("latitude");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float")
                        .HasColumnName("longitude");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK_Stations_Id");

                    b.ToTable("stations", (string)null);
                });

            modelBuilder.Entity("UCLL.Projects.WeatherStations.Shared.Data.Models.StationSensor", b =>
                {
                    b.Property<string>("StationId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("station_id");

                    b.Property<int>("SensorId")
                        .HasColumnType("int")
                        .HasColumnName("sensor_id");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("StationId", "SensorId")
                        .HasName("PK_StationSensors_StationId_SensorId");

                    b.HasIndex("SensorId");

                    b.ToTable("station_sensors", (string)null);
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
