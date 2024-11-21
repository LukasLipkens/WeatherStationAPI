using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors_Id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stations",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_activity_timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    battery_level = table.Column<double>(type: "float", nullable: true),
                    latitude = table.Column<double>(type: "float", nullable: true),
                    longitude = table.Column<double>(type: "float", nullable: true),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    online_status = table.Column<int>(type: "int", nullable: false, computedColumnSql: "CASE WHEN last_activity_timestamp < DATEADD(MINUTE, -30, GETUTCDATE()) THEN 1 ELSE 0 END", stored: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations_Id", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "station_sensors",
                columns: table => new
                {
                    station_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sensor_id = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationSensors_StationId_SensorId", x => new { x.station_id, x.sensor_id });
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
                    sensor_value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_measurements_station_sensor_id",
                table: "measurements",
                column: "station_sensor_id");

            migrationBuilder.CreateIndex(
                name: "IX_station_sensors_sensor_id",
                table: "station_sensors",
                column: "sensor_id");
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
