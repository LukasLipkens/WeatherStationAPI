using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sensors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors_Id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    battery_level = table.Column<double>(type: "float", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: false),
                    longitude = table.Column<double>(type: "float", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations_Id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "station_sensors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    station_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sensor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationSensors_Id_StationId_SensorId", x => new { x.id, x.station_id, x.sensor_id });
                    table.UniqueConstraint("AK_station_sensors_id", x => x.id);
                    table.ForeignKey(
                        name: "FK_StationSensors_SensorId",
                        column: x => x.sensor_id,
                        principalTable: "sensors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationSensors_StationId",
                        column: x => x.station_id,
                        principalTable: "stations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "measurements",
                columns: table => new
                {
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    station_sensor_id = table.Column<int>(type: "int", nullable: false),
                    sensor_value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements_Timestamp_StationSensorId", x => new { x.timestamp, x.station_sensor_id });
                    table.ForeignKey(
                        name: "FK_Measurements_StationSensorId",
                        column: x => x.station_sensor_id,
                        principalTable: "station_sensors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "sensors",
                columns: new[] { "id", "type", "Unit" },
                values: new object[,]
                {
                    { 1, "Temperature", "Celsius" },
                    { 2, "Humidity", "%" }
                });

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "id", "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { "1", null, "Weather station in New York", 40.712800000000001, -74.006, "Station A" },
                    { "2", null, "Weather station in Los Angeles", 34.052199999999999, -118.2437, "Station B" }
                });

            migrationBuilder.InsertData(
                table: "station_sensors",
                columns: new[] { "id", "sensor_id", "station_id" },
                values: new object[,]
                {
                    { 1, 1, "1" },
                    { 2, 2, "1" },
                    { 3, 1, "2" },
                    { 4, 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7845), "23.5" },
                    { 2, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7856), "60" },
                    { 3, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7858), "19.2" },
                    { 4, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7859), "61" },
                    { 1, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857), "22.5" },
                    { 2, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857), "58" },
                    { 3, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7860), "18.2" },
                    { 4, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7861), "57" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_measurements_station_sensor_id",
                table: "measurements",
                column: "station_sensor_id");

            migrationBuilder.CreateIndex(
                name: "IX_station_sensors_sensor_id",
                table: "station_sensors",
                column: "sensor_id");

            migrationBuilder.CreateIndex(
                name: "IX_station_sensors_station_id",
                table: "station_sensors",
                column: "station_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "measurements");

            migrationBuilder.DropTable(
                name: "station_sensors");

            migrationBuilder.DropTable(
                name: "sensors");

            migrationBuilder.DropTable(
                name: "stations");
        }
    }
}
