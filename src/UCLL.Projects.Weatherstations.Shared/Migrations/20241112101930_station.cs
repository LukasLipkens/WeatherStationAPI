using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class station : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6803) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6873) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6932) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6665) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6259) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6289) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6303) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6318) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6362) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5956) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5986) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6082) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6097) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6141) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6156) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6201) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5763) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5807) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5867) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5583) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5206) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5246) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5278) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5355) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5416) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4937) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5027) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5042) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5057) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5086) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5102) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5131) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5191) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4862) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4572) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4608) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4213) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4227) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4257) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4272) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4346) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3915) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3975) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4062) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4092) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4137) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3585) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3706) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3721) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3761) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3777) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3808) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3852) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3868) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3484) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3513) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3541) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3571) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3257) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3302) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3013) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3059) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3119) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3135) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2768) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2783) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2814) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2843) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2477) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2492) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2266) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2385) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2431) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2025) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2145) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2176) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2221) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1767) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1798) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1829) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1890) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1567) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1369) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1429) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1504) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1257) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1271) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1315) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1330) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1047) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1077) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(456) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(502) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(517) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(645) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(140) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(286) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(378) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(440) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9998) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(77) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(93) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9692) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9843) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1523), "69.73608112471034" },
                    { 27, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1534), "89.91532717295046" },
                    { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1545), "43.98149097589277" },
                    { 16, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1557), "16.844489660201916" },
                    { 15, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1568), "15.495912041008104" },
                    { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1580), "13.75422543923759" },
                    { 25, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1590), "26.610808238645223" },
                    { 21, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1602), "83.12420777316161" },
                    { 24, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1613), "12.733979923906437" },
                    { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1624), "95.34225046065333" },
                    { 13, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1635), "28.67718152303181" },
                    { 1, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1645), "33.42745528198431" },
                    { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1656), "90.45729340035795" },
                    { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1667), "48.4393516938583" },
                    { 24, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1678), "25.65920792068241" },
                    { 1, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1370), "71.20391062998794" },
                    { 20, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1381), "26.122285868032368" },
                    { 9, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1391), "15.433923859662732" },
                    { 26, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1401), "46.59063849942113" },
                    { 2, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1412), "58.72729685953253" },
                    { 19, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1423), "61.6633908895923" },
                    { 18, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1459), "52.4019155415092" },
                    { 24, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1479), "34.96030244266534" },
                    { 26, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1490), "35.293402846092256" },
                    { 18, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1501), "63.66674223534712" },
                    { 6, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1512), "73.55413677566793" },
                    { 16, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1260), "31.07958094717425" },
                    { 13, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1270), "72.68244922405884" },
                    { 3, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1281), "34.10287342008912" },
                    { 9, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1293), "14.481927997397875" },
                    { 7, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1303), "60.43815905259605" },
                    { 9, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1314), "36.75975937152151" },
                    { 7, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1326), "31.20398103611551" },
                    { 26, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1337), "53.94867207780694" },
                    { 23, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1348), "89.76244653401501" },
                    { 26, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1359), "76.96144740539175" },
                    { 27, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1063), "91.9537606281956" },
                    { 1, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1073), "53.91130357305831" },
                    { 13, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1084), "70.92556812799246" },
                    { 23, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1096), "84.10301235717625" },
                    { 23, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1106), "10.479663987901032" },
                    { 17, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1157), "37.223335033116605" },
                    { 9, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1170), "60.20188280063701" },
                    { 18, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1182), "13.080243194934255" },
                    { 11, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1193), "70.88534379036386" },
                    { 6, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1205), "76.8184429832954" },
                    { 27, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1216), "13.015376365090141" },
                    { 22, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1227), "75.80741340660549" },
                    { 26, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1237), "67.86499223477293" },
                    { 18, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1248), "74.59044054534411" },
                    { 7, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(875), "94.52753722659337" },
                    { 20, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(886), "36.39549035554194" },
                    { 22, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(897), "17.925890847801707" },
                    { 7, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(908), "80.85180527805583" },
                    { 6, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(919), "65.55738768690861" },
                    { 20, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(931), "24.377813701834324" },
                    { 19, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(942), "44.557355583553395" },
                    { 10, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(954), "67.17804714305947" },
                    { 14, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(964), "70.72175441070813" },
                    { 1, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(975), "41.367128078518306" },
                    { 15, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(986), "47.53333680194252" },
                    { 21, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(997), "49.63724460687653" },
                    { 13, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1007), "80.18023423720406" },
                    { 1, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1019), "87.15409916783183" },
                    { 11, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1029), "13.601954640433673" },
                    { 16, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1041), "48.713463158870184" },
                    { 2, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1052), "85.26595337068053" },
                    { 22, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(692), "23.8678777601796" },
                    { 4, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(703), "80.61464365847911" },
                    { 1, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(715), "16.911208431398183" },
                    { 3, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(726), "19.66300871777147" },
                    { 27, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(736), "30.144503076810334" },
                    { 6, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(747), "95.93410151821621" },
                    { 6, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(759), "34.4224251510539" },
                    { 1, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(770), "25.35980997469008" },
                    { 12, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(781), "58.36387403161322" },
                    { 23, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(792), "82.65967489787437" },
                    { 18, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(803), "10.776198383692012" },
                    { 7, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(852), "38.14067750315262" },
                    { 26, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(863), "44.508926769622605" },
                    { 22, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(580), "29.34706889280425" },
                    { 20, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(592), "79.94575568945538" },
                    { 19, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(603), "71.9238665020273" },
                    { 4, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(614), "23.787389092735957" },
                    { 8, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(625), "60.27258447952755" },
                    { 8, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(636), "19.81225907382276" },
                    { 11, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(647), "18.105628993224705" },
                    { 2, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(658), "62.28728174002188" },
                    { 13, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(669), "34.44277246623384" },
                    { 24, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(680), "38.920299470369535" },
                    { 1, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(386), "32.884632491768066" },
                    { 19, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(396), "51.922611929656384" },
                    { 9, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(407), "35.41722120119304" },
                    { 2, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(419), "36.41675659543519" },
                    { 8, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(430), "65.28656969920857" },
                    { 10, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(441), "68.620227888492" },
                    { 16, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(453), "85.79490494162157" },
                    { 4, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(463), "64.32015310895044" },
                    { 12, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(474), "26.022005722190947" },
                    { 6, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(484), "60.593051137024375" },
                    { 10, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(536), "14.472426060532994" },
                    { 11, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(547), "31.768231238291346" },
                    { 18, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(559), "69.02495250147317" },
                    { 3, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(569), "38.135011482551185" },
                    { 16, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(264), "58.42858847916859" },
                    { 22, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(275), "80.41583807164733" },
                    { 27, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(285), "50.82197377030104" },
                    { 7, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(296), "43.762239396608464" },
                    { 25, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(307), "91.53146533133724" },
                    { 19, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(319), "23.193625587760824" },
                    { 25, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(330), "53.35178674285182" },
                    { 10, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(341), "76.3505295327678" },
                    { 23, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(352), "10.625446360376188" },
                    { 24, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(363), "31.530325341169466" },
                    { 15, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(374), "31.46817685201355" },
                    { 20, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(59), "76.84462175455425" },
                    { 26, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(69), "99.57249031118546" },
                    { 26, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(80), "50.61636734300285" },
                    { 24, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(91), "19.04599269944303" },
                    { 23, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(104), "64.68003916774668" },
                    { 11, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(115), "93.36120339091615" },
                    { 22, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(125), "53.15346595118399" },
                    { 8, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(137), "70.42972044826476" },
                    { 9, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(148), "38.708905107324554" },
                    { 1, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(159), "84.0145749220126" },
                    { 23, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(171), "42.72276014652827" },
                    { 2, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(218), "66.36914877483667" },
                    { 15, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(230), "58.34455069682893" },
                    { 10, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(242), "24.186510177309117" },
                    { 6, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(253), "52.06914482600059" },
                    { 3, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9927), "93.19010481352977" },
                    { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9939), "75.86287859349314" },
                    { 1, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9950), "58.701328232760105" },
                    { 15, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9961), "92.32149885342935" },
                    { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9972), "72.9789575570439" },
                    { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9984), "73.86503316269928" },
                    { 15, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9995), "69.35990869037244" },
                    { 19, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(5), "37.857217507563284" },
                    { 2, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(16), "74.08227426375828" },
                    { 2, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(27), "13.838905472061384" },
                    { 16, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(38), "62.5127835255862" },
                    { 19, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(48), "44.99988035335294" },
                    { 7, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9757), "59.50025739312463" },
                    { 6, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9769), "80.02602447692989" },
                    { 12, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9779), "91.43255767778834" },
                    { 16, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9790), "42.28201640401822" },
                    { 4, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9800), "64.31379895549043" },
                    { 27, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9811), "82.46601890497216" },
                    { 6, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9823), "69.28586875966651" },
                    { 25, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9834), "19.841284513293026" },
                    { 21, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9845), "90.6482175212125" },
                    { 27, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9856), "48.317349815534065" },
                    { 19, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9904), "65.91897931327028" },
                    { 20, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9916), "78.56543047186665" },
                    { 21, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9550), "78.69076433343602" },
                    { 24, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9560), "16.13138718294982" },
                    { 21, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9571), "30.721051772523655" },
                    { 16, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9582), "29.90705826292748" },
                    { 12, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9593), "54.86027052812152" },
                    { 13, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9603), "26.80729930978574" },
                    { 14, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9614), "29.853010589817497" },
                    { 27, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9678), "85.83031945836909" },
                    { 5, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9689), "39.061451083506995" },
                    { 18, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9700), "37.17124029245757" },
                    { 19, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9712), "57.18718454400592" },
                    { 2, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9723), "13.131342524546035" },
                    { 4, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9735), "48.47108452532749" },
                    { 26, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9747), "44.336003970784574" },
                    { 6, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9346), "76.53672497597361" },
                    { 9, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9406), "85.0153908742177" },
                    { 20, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9417), "55.402779852492586" },
                    { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9429), "51.36728422964685" },
                    { 21, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9441), "47.89215313571764" },
                    { 14, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9452), "59.088791056325896" },
                    { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9463), "85.54811962499244" },
                    { 24, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9474), "77.46980473826255" },
                    { 7, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9485), "96.54806906192997" },
                    { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9495), "94.48545746941579" },
                    { 23, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9507), "64.05503014538303" },
                    { 1, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9517), "15.200823116789431" },
                    { 25, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9528), "60.87921045233468" },
                    { 27, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9539), "80.46325324109539" },
                    { 9, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9203), "26.379200191572636" },
                    { 23, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9214), "75.5048052699511" },
                    { 17, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9224), "97.79823461071317" },
                    { 2, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9236), "92.41037678763232" },
                    { 25, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9247), "38.05568402336304" },
                    { 25, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9257), "28.3840337244694" },
                    { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9268), "96.15093709714995" },
                    { 19, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9279), "53.10857557926116" },
                    { 13, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9290), "86.80755100474946" },
                    { 17, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9302), "16.195457236219195" },
                    { 7, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9313), "23.19636365983733" },
                    { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9323), "39.5645337060553" },
                    { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9335), "61.87270948944674" },
                    { 16, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9014), "74.57952701544556" },
                    { 2, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9025), "54.29769802148109" },
                    { 22, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9036), "96.11765484637539" },
                    { 12, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9047), "74.98000786823631" },
                    { 4, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9058), "94.60184675768288" },
                    { 2, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9096), "76.19973626647555" },
                    { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9106), "39.82569874264564" },
                    { 23, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9118), "58.09273533230513" },
                    { 13, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9128), "82.62268292721537" },
                    { 7, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9140), "18.274979882977185" },
                    { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9150), "86.02551490322111" },
                    { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9160), "97.55699868228551" },
                    { 20, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9171), "34.02869285634965" },
                    { 17, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9181), "51.38416785288164" },
                    { 13, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9192), "43.80303669357209" },
                    { 9, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8858), "85.13790648255217" },
                    { 8, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8869), "53.08557465465417" },
                    { 12, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8881), "49.9482404258177" },
                    { 8, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8892), "88.24496524986805" },
                    { 25, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8903), "81.3337721576799" },
                    { 18, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8915), "48.97219649676356" },
                    { 21, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8926), "45.86494303624736" },
                    { 23, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8937), "40.544308680775714" },
                    { 22, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8948), "16.43839031901413" },
                    { 22, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8959), "79.57074496221759" },
                    { 2, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8970), "15.058967609192482" },
                    { 23, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8981), "73.9656085570843" },
                    { 11, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8992), "14.017208092491774" },
                    { 1, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9003), "82.47525081519846" },
                    { 22, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8629), "41.536620600176505" },
                    { 10, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8639), "22.275568085972672" },
                    { 15, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8651), "55.8296005617805" },
                    { 5, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8663), "79.29699305796937" },
                    { 10, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8673), "21.17119683349191" },
                    { 12, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8684), "53.13980267264232" },
                    { 23, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8695), "24.12334300645156" },
                    { 26, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8705), "67.54368211074429" },
                    { 4, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8718), "13.797006112330905" },
                    { 18, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8728), "51.52072563775506" },
                    { 24, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8740), "68.75469361399993" },
                    { 3, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8790), "38.66345549486658" },
                    { 1, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8802), "56.066919006715025" },
                    { 1, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8813), "15.849326574336452" },
                    { 14, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8825), "43.038982761057035" },
                    { 27, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8836), "40.263778010942204" },
                    { 4, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8847), "46.61351829688518" },
                    { 5, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8412), "33.89960535743278" },
                    { 21, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8423), "54.73671617606713" },
                    { 26, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8471), "30.631957924921903" },
                    { 9, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8483), "50.254673129298304" },
                    { 26, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8494), "57.56348667652394" },
                    { 11, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8505), "82.1411345363028" },
                    { 1, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8515), "85.05495156251345" },
                    { 14, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8527), "39.619461927213855" },
                    { 23, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8538), "90.07638198399371" },
                    { 22, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8550), "16.664899623490257" },
                    { 7, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8561), "69.71299045266807" },
                    { 16, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8573), "32.25720158764573" },
                    { 20, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8584), "14.388563502462562" },
                    { 24, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8595), "96.22916642310173" },
                    { 10, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8606), "99.91319384223651" },
                    { 7, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8617), "71.53719477620243" },
                    { 17, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8247), "25.291306794789417" },
                    { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8258), "48.00255188650149" },
                    { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8269), "44.088800054522906" },
                    { 25, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8280), "41.34710235712966" },
                    { 4, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8290), "89.50521954945465" },
                    { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8300), "90.66081794461424" },
                    { 1, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8311), "75.54703626631125" },
                    { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8323), "40.26109567596741" },
                    { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8334), "64.51127895420248" },
                    { 7, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8345), "69.22770530111652" },
                    { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8356), "75.92670362482633" },
                    { 3, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8368), "33.347846820971625" },
                    { 10, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8379), "38.09439592061424" },
                    { 12, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8389), "75.72814681464814" },
                    { 22, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8400), "38.54394618321534" },
                    { 20, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8091), "81.49386006523778" },
                    { 17, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8102), "29.93311089931655" },
                    { 22, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8113), "52.40536888926318" },
                    { 15, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8159), "26.704305885893493" },
                    { 27, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8170), "32.49837046130547" },
                    { 5, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8181), "59.18276255302101" },
                    { 26, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8192), "87.82313713090494" },
                    { 20, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8203), "72.20383982830936" },
                    { 27, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8214), "50.39516349061317" },
                    { 8, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8225), "80.65688353041196" },
                    { 19, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8236), "65.57750640503087" },
                    { 13, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7872), "39.45559006770495" },
                    { 25, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7924), "92.54514036965095" },
                    { 10, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7935), "68.43680568583692" },
                    { 23, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7946), "68.18992516565001" },
                    { 13, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7956), "40.93558814749004" },
                    { 15, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7968), "65.49624504115818" },
                    { 24, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7978), "13.494897159813519" },
                    { 17, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7991), "11.760671315918644" },
                    { 18, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8001), "15.467649521252707" },
                    { 17, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8013), "88.38625330136165" },
                    { 4, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8026), "61.75361715392268" },
                    { 3, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8038), "70.50271591857934" },
                    { 6, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8049), "73.58644821036853" },
                    { 7, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8060), "82.38774897152031" },
                    { 4, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8070), "71.82911083549942" },
                    { 22, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8081), "70.99747100808716" },
                    { 2, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7751), "17.795148466818" },
                    { 9, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7762), "87.70075507493239" },
                    { 23, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7774), "28.461565669778498" },
                    { 5, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7784), "98.28519219735637" },
                    { 7, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7795), "59.5472046798157" },
                    { 13, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7806), "14.959509606906677" },
                    { 16, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7817), "74.99085202535285" },
                    { 14, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7829), "90.46958815667338" },
                    { 12, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7841), "50.137052944608925" },
                    { 10, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7852), "26.66530754124649" },
                    { 22, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7862), "11.055020009308057" },
                    { 24, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7616), "74.40942447508426" },
                    { 9, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7628), "94.45163869324598" },
                    { 5, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7640), "30.340893751578633" },
                    { 18, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7651), "70.75828147515051" },
                    { 1, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7662), "73.72168710730081" },
                    { 3, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7673), "13.098410111272713" },
                    { 14, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7683), "90.10796255755882" },
                    { 23, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7695), "68.04435259354958" },
                    { 10, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7707), "11.267918103596745" },
                    { 12, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7718), "65.8482265581666" },
                    { 23, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7729), "69.78176318699182" },
                    { 8, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7740), "43.87405575209655" },
                    { 14, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7447), "22.19252286050202" },
                    { 10, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7459), "35.290701831532274" },
                    { 8, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7470), "67.73757811648922" },
                    { 25, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7481), "41.80312643719084" },
                    { 16, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7492), "29.36531694634099" },
                    { 20, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7503), "75.68195888683755" },
                    { 23, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7514), "43.23580617017909" },
                    { 1, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7524), "53.799771445856564" },
                    { 25, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7535), "38.85898458568788" },
                    { 22, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7545), "49.866263850804756" },
                    { 17, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7555), "83.4978646569627" },
                    { 17, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7605), "32.95642310856783" },
                    { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7196), "14.158744917148717" },
                    { 20, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7207), "29.96605156270579" },
                    { 3, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7219), "25.08179479891755" },
                    { 7, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7230), "95.07673169751946" },
                    { 17, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7293), "56.43496691623275" },
                    { 27, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7304), "72.74631602577207" },
                    { 17, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7315), "19.379372988355556" },
                    { 8, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7326), "82.66355363182991" },
                    { 5, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7337), "76.13095399742296" },
                    { 23, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7348), "45.60872238808773" },
                    { 20, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7359), "43.482454201500346" },
                    { 19, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7370), "16.275796674443917" },
                    { 19, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7382), "19.011782082184624" },
                    { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7393), "13.208571140348658" },
                    { 10, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7404), "95.35728198345511" },
                    { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7414), "76.08477062361582" },
                    { 6, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7425), "14.770937455714261" },
                    { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7436), "82.48561459762135" },
                    { 25, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6928), "25.381969125334734" },
                    { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6992), "81.32497592348108" },
                    { 15, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7004), "69.39594499156004" },
                    { 25, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7016), "28.522299729926658" },
                    { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7027), "27.910858655845562" },
                    { 3, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7039), "57.01288465980944" },
                    { 4, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7049), "15.660371527129122" },
                    { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7061), "76.88480878492473" },
                    { 27, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7072), "26.18821090846441" },
                    { 4, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7083), "18.82632893587884" },
                    { 13, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7094), "15.498467399683225" },
                    { 18, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7106), "42.42153024606444" },
                    { 11, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7117), "37.170229505649125" },
                    { 8, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7127), "67.5944788856848" },
                    { 2, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7139), "10.534172010017471" },
                    { 21, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7149), "47.1686088302967" },
                    { 7, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7160), "43.57139574952336" },
                    { 12, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7172), "16.313573533294267" },
                    { 8, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7184), "29.406971368610723" },
                    { 2, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6772), "44.17787533451539" },
                    { 10, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6784), "54.12019187845433" },
                    { 21, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6795), "65.99267859587388" },
                    { 6, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6806), "38.19972397686691" },
                    { 19, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6816), "68.05406655306416" },
                    { 17, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6828), "93.09382483391488" },
                    { 13, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6838), "39.31299027008673" },
                    { 8, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6849), "74.06351287605166" },
                    { 17, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6860), "21.412849602146515" },
                    { 1, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6871), "31.761464558310696" },
                    { 22, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6882), "45.803612440974305" },
                    { 21, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6893), "61.70789631136012" },
                    { 24, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6904), "74.03559080607045" },
                    { 2, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6916), "83.66549683136854" },
                    { 22, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6405), "71.45188094722465" },
                    { 16, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6416), "44.90786762495962" },
                    { 20, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6428), "19.849210389541113" },
                    { 3, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6439), "99.3640709331112" },
                    { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6451), "45.01667853301986" },
                    { 6, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6586), "56.28060112437696" },
                    { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6598), "32.69290483474658" },
                    { 22, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6610), "96.85887581093534" },
                    { 20, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6622), "86.45623959621223" },
                    { 13, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6633), "68.34951207462842" },
                    { 19, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6643), "94.38540905426855" },
                    { 12, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6654), "69.40081544118794" },
                    { 24, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6693), "97.50796372823562" },
                    { 15, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6705), "76.35829538639109" },
                    { 26, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6716), "55.17390898358161" },
                    { 5, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6727), "64.49860017535838" },
                    { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6738), "62.341138559832196" },
                    { 4, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6748), "49.77208162156332" },
                    { 13, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6760), "52.90052264034711" },
                    { 12, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6017), "75.7652867393023" },
                    { 25, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6204), "59.58708363359229" },
                    { 12, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6217), "78.20730610088306" },
                    { 15, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6274), "86.56782493431238" },
                    { 10, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6286), "67.7286817329711" },
                    { 16, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6299), "36.74236613341198" },
                    { 9, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6311), "57.263843629724946" },
                    { 23, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6322), "21.600990998029932" },
                    { 6, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6335), "77.32805042055764" },
                    { 10, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6348), "83.0104880293928" },
                    { 17, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6360), "77.85810195774324" },
                    { 2, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6372), "12.470879432941935" },
                    { 14, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6382), "65.68262135459543" },
                    { 25, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6393), "49.91432981414453" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1545) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1568) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1590) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1624) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1678) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1401) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 14, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1281) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1314) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1348) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 16, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(875) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 17, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(1052) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(715) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 18, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(863) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(636) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(658) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 19, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(386) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(396) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(407) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(419) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(441) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(453) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 20, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(319) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(363) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 21, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(374) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(69) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(91) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(125) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(159) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 22, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9927) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9995) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 23, 10, 19, 29, 641, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9757) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 24, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9593) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9723) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 26, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9236) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9247) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9257) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 27, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9014) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9025) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9128) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8858) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8915) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 29, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8639) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8695) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8718) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8728) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 30, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8505) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8561) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 31, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8269) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8356) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8368) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 1, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8159) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 2, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7872) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8060) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 3, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7795) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 4, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7862) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7628) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7662) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7729) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 5, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7481) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7503) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 6, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7315) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7326) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7382) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7404) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7425) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 7, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7027) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(7184) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6772) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6893) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 9, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6451) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6586) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6598) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6633) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6738) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 10, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6017) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6311) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6322) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6372) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6382) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 11, 10, 19, 29, 640, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 25, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6711), "51.482856230313494" },
                    { 14, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6727), "58.38966877079594" },
                    { 7, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6742), "58.254378489891245" },
                    { 6, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6757), "60.07460293351481" },
                    { 8, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6772), "78.53284002968478" },
                    { 17, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6787), "57.829031586450256" },
                    { 5, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6803), "16.850742411024598" },
                    { 16, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6818), "91.37966748361302" },
                    { 20, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6833), "21.918621244872615" },
                    { 10, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6873), "71.34013110766756" },
                    { 14, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6889), "79.59493967807819" },
                    { 3, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6903), "81.57618342746028" },
                    { 2, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6917), "90.7162802146456" },
                    { 25, new DateTime(2024, 10, 11, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6932), "36.307029846822395" },
                    { 20, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6546), "79.8148021792607" },
                    { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6561), "42.25534054770852" },
                    { 19, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6576), "65.9394294077397" },
                    { 5, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6592), "88.42389605313964" },
                    { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6607), "92.83691019579483" },
                    { 1, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6622), "15.13998107651592" },
                    { 12, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6637), "15.605295012383491" },
                    { 20, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6651), "68.86160721951534" },
                    { 11, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6665), "29.45087865434868" },
                    { 5, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6681), "87.32420623650115" },
                    { 14, new DateTime(2024, 10, 12, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6696), "97.51590032277275" },
                    { 27, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6229), "78.60188343627128" },
                    { 13, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6244), "62.75962163723535" },
                    { 20, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6259), "56.30454584522786" },
                    { 11, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6274), "54.60087978714109" },
                    { 13, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6289), "12.387688060667411" },
                    { 16, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6303), "69.57605566231845" },
                    { 16, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6318), "85.69733436465647" },
                    { 15, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6334), "49.09365719755387" },
                    { 25, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6349), "87.42519873584058" },
                    { 9, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6362), "86.32173254375871" },
                    { 19, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6377), "11.398332385385242" },
                    { 20, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6393), "94.97379022374442" },
                    { 22, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6408), "74.96708700880998" },
                    { 3, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6469), "43.38259550463389" },
                    { 24, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6486), "99.98014287957919" },
                    { 5, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6500), "54.08083985813129" },
                    { 3, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6515), "23.873334495992562" },
                    { 2, new DateTime(2024, 10, 13, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6531), "47.19785922729926" },
                    { 19, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5882), "93.07677660027296" },
                    { 9, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5896), "57.49073007597476" },
                    { 27, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5910), "82.92486314609788" },
                    { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5925), "51.8190989579955" },
                    { 21, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5941), "97.00941224035883" },
                    { 13, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5956), "71.9475783573098" },
                    { 21, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5971), "56.22673582636098" },
                    { 1, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5986), "21.66837972426412" },
                    { 23, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6049), "60.65291751296059" },
                    { 10, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6066), "69.17835965536827" },
                    { 5, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6082), "25.531092033090157" },
                    { 18, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6097), "40.30172547567021" },
                    { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6111), "57.94690071071139" },
                    { 20, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6126), "64.15095147685828" },
                    { 25, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6141), "17.864155331492448" },
                    { 8, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6156), "12.973402347118535" },
                    { 19, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6171), "76.22898483630667" },
                    { 27, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6186), "34.721276286020725" },
                    { 20, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6201), "74.8023212176926" },
                    { 17, new DateTime(2024, 10, 14, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(6215), "27.293563777946687" },
                    { 9, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5642), "38.667007004890095" },
                    { 1, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5658), "10.302068707112959" },
                    { 25, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5672), "30.975688235772655" },
                    { 13, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5687), "67.98963096074104" },
                    { 26, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5702), "19.39328346394398" },
                    { 13, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5718), "26.827893876534105" },
                    { 16, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5732), "71.75442562502658" },
                    { 26, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5747), "39.752938473878295" },
                    { 10, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5763), "36.38804796051831" },
                    { 4, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5778), "49.889186452060414" },
                    { 15, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5793), "95.51827875455072" },
                    { 12, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5807), "31.033133193972795" },
                    { 20, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5823), "57.255306569722364" },
                    { 4, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5838), "17.77554969764605" },
                    { 25, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5853), "52.01341247109408" },
                    { 7, new DateTime(2024, 10, 15, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5867), "55.48054229840591" },
                    { 26, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5477), "47.9041771682876" },
                    { 27, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5492), "88.2060070234498" },
                    { 21, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5507), "75.94285638705692" },
                    { 3, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5523), "63.087392678487426" },
                    { 20, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5538), "19.426961548596957" },
                    { 7, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5554), "22.160582869748275" },
                    { 12, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5569), "42.08771368569127" },
                    { 22, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5583), "65.23528626061297" },
                    { 14, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5599), "65.61106168470425" },
                    { 16, new DateTime(2024, 10, 16, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5613), "36.028041984853985" },
                    { 3, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5206), "72.85595425889329" },
                    { 9, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5246), "82.23658039456276" },
                    { 26, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5262), "45.9048650609068" },
                    { 10, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5278), "99.18378656909383" },
                    { 21, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5294), "53.570330573367364" },
                    { 25, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5310), "84.79227999327907" },
                    { 26, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5326), "49.39247205481801" },
                    { 4, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5340), "16.751977797583994" },
                    { 13, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5355), "87.984720423504" },
                    { 7, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5370), "85.78157236555154" },
                    { 20, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5385), "55.49538259373618" },
                    { 17, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5401), "28.12427615005834" },
                    { 10, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5416), "69.09484379604329" },
                    { 18, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5431), "48.19122467037947" },
                    { 15, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5447), "93.69334943295908" },
                    { 8, new DateTime(2024, 10, 17, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5462), "65.57287555118663" },
                    { 11, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4937), "90.2767673199155" },
                    { 4, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4952), "78.78499681792226" },
                    { 14, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4968), "72.33605522776881" },
                    { 19, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4982), "74.39389417962693" },
                    { 6, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4997), "74.68860299995725" },
                    { 13, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5012), "81.88357467272914" },
                    { 26, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5027), "46.160494298334484" },
                    { 16, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5042), "86.58381622217456" },
                    { 21, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5057), "62.18868394899581" },
                    { 8, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5072), "21.428809380440725" },
                    { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5086), "17.506938664954674" },
                    { 3, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5102), "72.85637481844282" },
                    { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5116), "28.62539115809344" },
                    { 11, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5131), "99.50094607891234" },
                    { 2, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5145), "57.4999956103636" },
                    { 20, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5161), "94.4070906517732" },
                    { 1, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5176), "17.126334863054865" },
                    { 17, new DateTime(2024, 10, 18, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(5191), "44.380927723873825" },
                    { 9, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4670), "42.82367494919132" },
                    { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4685), "14.266416247070822" },
                    { 27, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4700), "98.11114191794015" },
                    { 6, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4716), "23.45714757862606" },
                    { 4, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4730), "78.13944953157986" },
                    { 19, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4744), "81.2948693509174" },
                    { 10, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4760), "15.712008274947138" },
                    { 22, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4774), "45.81921701556659" },
                    { 16, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4862), "24.30618649138939" },
                    { 23, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4878), "35.72543515648101" },
                    { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4892), "86.25962714692339" },
                    { 5, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4907), "64.24566161147152" },
                    { 13, new DateTime(2024, 10, 19, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4922), "19.85717085100594" },
                    { 6, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4453), "35.69304826457682" },
                    { 6, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4467), "17.180270519673908" },
                    { 12, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4482), "78.599749062696" },
                    { 9, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4497), "87.43176059500364" },
                    { 1, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4511), "57.90172832724547" },
                    { 17, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4527), "50.01953253139473" },
                    { 10, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4541), "85.24137553217336" },
                    { 19, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4556), "64.2906616694016" },
                    { 16, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4572), "60.340213681188246" },
                    { 22, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4586), "70.23010705042905" },
                    { 24, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4608), "22.565508692208258" },
                    { 7, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4623), "54.984969475109565" },
                    { 25, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4639), "20.21663735683758" },
                    { 10, new DateTime(2024, 10, 20, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4655), "17.427018196974092" },
                    { 9, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4153), "24.556046521037498" },
                    { 24, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4169), "72.71522531154253" },
                    { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4184), "70.07969066828872" },
                    { 10, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4198), "37.993993569760235" },
                    { 27, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4213), "76.61965687311786" },
                    { 19, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4227), "83.32291299055082" },
                    { 24, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4242), "74.16524953890999" },
                    { 9, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4257), "91.4415828044938" },
                    { 22, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4272), "74.61943472986823" },
                    { 4, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4286), "49.1396030200437" },
                    { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4301), "11.894483245562554" },
                    { 17, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4316), "52.697745973584006" },
                    { 6, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4330), "40.01368643852595" },
                    { 16, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4346), "21.044562939623226" },
                    { 22, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4407), "15.58948599964634" },
                    { 3, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4422), "94.9176029287624" },
                    { 15, new DateTime(2024, 10, 21, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4437), "71.56106626901419" },
                    { 7, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3883), "15.370783510119153" },
                    { 11, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3899), "83.70210419506918" },
                    { 9, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3915), "75.43715374553565" },
                    { 5, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3930), "34.44784666733746" },
                    { 27, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3944), "44.022414494074" },
                    { 20, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3960), "41.45537048092089" },
                    { 10, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3975), "35.53034253317975" },
                    { 21, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3990), "16.120272886010575" },
                    { 23, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4047), "91.60184648918923" },
                    { 23, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4062), "29.2848698677678" },
                    { 4, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4077), "21.11335064443525" },
                    { 6, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4092), "50.44736160042608" },
                    { 22, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4106), "43.04613413663973" },
                    { 15, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4121), "90.07966241539894" },
                    { 26, new DateTime(2024, 10, 22, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(4137), "18.545598962719666" },
                    { 10, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3585), "95.95000683688617" },
                    { 27, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3602), "91.41068044703461" },
                    { 10, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3618), "86.06126278019005" },
                    { 6, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3632), "61.041136943756435" },
                    { 18, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3646), "92.62668578026094" },
                    { 5, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3662), "83.67112683745722" },
                    { 1, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3676), "35.74828168628009" },
                    { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3690), "14.725649215790895" },
                    { 24, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3706), "47.91391647564597" },
                    { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3721), "82.84390187173199" },
                    { 15, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3761), "82.28832347064963" },
                    { 11, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3777), "45.28945718200253" },
                    { 22, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3793), "43.46326518718306" },
                    { 13, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3808), "48.567618327271006" },
                    { 6, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3824), "92.80182673884542" },
                    { 16, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3838), "68.82449608456861" },
                    { 9, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3852), "54.02729416515923" },
                    { 23, new DateTime(2024, 10, 23, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3868), "20.411305199484026" },
                    { 14, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3410), "22.07972318871277" },
                    { 13, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3425), "88.41902493952423" },
                    { 23, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3440), "58.57348261747761" },
                    { 16, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3454), "18.395105603138486" },
                    { 17, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3470), "18.854772610216237" },
                    { 25, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3484), "58.20477084376662" },
                    { 1, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3498), "94.11402280188992" },
                    { 17, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3513), "47.408040458542104" },
                    { 23, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3527), "29.641174524317734" },
                    { 4, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3541), "62.74754778625017" },
                    { 1, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3556), "78.41834901220837" },
                    { 3, new DateTime(2024, 10, 24, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3571), "48.87392577127876" },
                    { 26, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3181), "44.43089830320633" },
                    { 12, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3196), "90.87407708711437" },
                    { 1, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3211), "90.63806329718359" },
                    { 9, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3227), "36.04054972587595" },
                    { 27, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3243), "13.945677661854766" },
                    { 1, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3257), "70.45251564763532" },
                    { 5, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3272), "55.55671428471959" },
                    { 18, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3287), "34.36789249834061" },
                    { 4, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3302), "33.07329490913462" },
                    { 6, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3365), "25.789376245536687" },
                    { 17, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3380), "84.65991015472106" },
                    { 16, new DateTime(2024, 10, 25, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3395), "26.910402155130097" },
                    { 20, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2984), "46.12163567474306" },
                    { 19, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2998), "27.14616973106408" },
                    { 16, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3013), "29.89452073783947" },
                    { 3, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3027), "66.8909323821429" },
                    { 26, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3044), "13.639675823680967" },
                    { 1, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3059), "85.25474880963706" },
                    { 6, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3073), "89.7207744978356" },
                    { 22, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3088), "43.28766446573788" },
                    { 15, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3104), "30.07601256040923" },
                    { 6, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3119), "91.7803494542534" },
                    { 23, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3135), "15.119552706083883" },
                    { 9, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3150), "44.425368411611686" },
                    { 4, new DateTime(2024, 10, 26, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(3166), "69.76011298002729" },
                    { 11, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2629), "40.721030134759275" },
                    { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2644), "83.75654995307232" },
                    { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2659), "34.296747184934716" },
                    { 17, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2674), "38.60738261561012" },
                    { 23, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2690), "85.13231003772471" },
                    { 12, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2705), "73.9458580867522" },
                    { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2721), "32.393485843797365" },
                    { 21, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2737), "37.60459258220922" },
                    { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2753), "38.86324920613052" },
                    { 22, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2768), "44.83242909937003" },
                    { 5, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2783), "18.204602431103332" },
                    { 24, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2798), "30.35921233855886" },
                    { 15, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2814), "38.29697375175661" },
                    { 6, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2828), "83.0861423566642" },
                    { 22, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2843), "91.71244193195855" },
                    { 25, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2858), "49.026196761002765" },
                    { 20, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2874), "49.273478744479064" },
                    { 7, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2937), "34.151786404126554" },
                    { 15, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2954), "49.59664020916092" },
                    { 24, new DateTime(2024, 10, 27, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2969), "61.45103938488449" },
                    { 26, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2462), "87.84834280768018" },
                    { 11, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2477), "21.556799764551112" },
                    { 6, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2492), "86.94898591897852" },
                    { 7, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2522), "63.898002781498064" },
                    { 2, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2538), "87.43344745749924" },
                    { 1, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2554), "38.76921631833274" },
                    { 27, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2569), "47.12321101985836" },
                    { 1, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2584), "22.98836956424669" },
                    { 27, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2598), "58.21899824943789" },
                    { 14, new DateTime(2024, 10, 28, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2613), "94.82246739856625" },
                    { 14, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2266), "21.50896260203671" },
                    { 11, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2281), "26.396971408357672" },
                    { 3, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2295), "72.93541825080527" },
                    { 27, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2310), "88.07716535477033" },
                    { 22, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2325), "97.97735090095007" },
                    { 11, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2340), "40.13163037114269" },
                    { 21, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2355), "99.46312389054782" },
                    { 7, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2370), "55.54369840375612" },
                    { 3, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2385), "45.14311936212584" },
                    { 9, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2400), "10.96168813601636" },
                    { 20, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2416), "73.11224716101682" },
                    { 23, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2431), "46.607141744092885" },
                    { 14, new DateTime(2024, 10, 29, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2447), "81.72621804230256" },
                    { 22, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1951), "82.08579607889263" },
                    { 24, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1965), "70.62872423547711" },
                    { 22, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1980), "40.2888594493937" },
                    { 1, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1995), "12.50723882086574" },
                    { 11, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2010), "32.578068019686775" },
                    { 7, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2025), "15.307348433599918" },
                    { 11, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2041), "88.59867409489515" },
                    { 1, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2128), "59.564483752912935" },
                    { 3, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2145), "83.69906695190907" },
                    { 9, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2160), "41.821997069266125" },
                    { 25, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2176), "71.43249156301695" },
                    { 12, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2191), "51.627902398780336" },
                    { 15, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2206), "11.949018002361889" },
                    { 7, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2221), "39.35168102938208" },
                    { 6, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2235), "79.64727451587072" },
                    { 27, new DateTime(2024, 10, 30, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(2250), "77.34217477673671" },
                    { 7, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1729), "79.04986047466116" },
                    { 11, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1767), "92.77618896692586" },
                    { 20, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1783), "64.1092212819168" },
                    { 16, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1798), "83.47435901728616" },
                    { 10, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1813), "76.25763998945767" },
                    { 7, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1829), "48.78193943913483" },
                    { 6, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1844), "17.590647986021303" },
                    { 15, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1861), "91.8604722228116" },
                    { 14, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1876), "71.0866655110423" },
                    { 16, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1890), "37.610591576608215" },
                    { 4, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1905), "32.02242281475374" },
                    { 23, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1920), "41.29760419152653" },
                    { 9, new DateTime(2024, 10, 31, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1936), "25.889614287419796" },
                    { 1, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1536), "81.16399852352598" },
                    { 10, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1551), "67.12753486121814" },
                    { 18, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1567), "47.587764721944104" },
                    { 12, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1582), "73.62756093116187" },
                    { 1, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1596), "50.93542039265163" },
                    { 23, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1611), "61.98434967078575" },
                    { 14, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1626), "96.07435759505972" },
                    { 3, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1641), "77.0087428485529" },
                    { 9, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1655), "73.7878608573593" },
                    { 5, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1670), "35.70268007575599" },
                    { 13, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1684), "64.73042772758365" },
                    { 21, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1699), "98.88038474149309" },
                    { 25, new DateTime(2024, 11, 1, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1714), "64.20665967293898" },
                    { 22, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1369), "89.29191751350062" },
                    { 13, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1385), "33.69697500163814" },
                    { 5, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1401), "62.9963259557055" },
                    { 24, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1415), "61.28179748109123" },
                    { 19, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1429), "96.64604593143972" },
                    { 27, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1444), "33.931015255625866" },
                    { 14, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1460), "87.59429545735576" },
                    { 5, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1475), "46.84769664210351" },
                    { 21, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1490), "18.48595393093867" },
                    { 11, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1504), "37.157415227633635" },
                    { 1, new DateTime(2024, 11, 2, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1520), "74.57238924946776" },
                    { 20, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1137), "87.00888779472594" },
                    { 7, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1152), "38.41078714653888" },
                    { 25, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1167), "26.04131751854462" },
                    { 21, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1182), "73.80462840426488" },
                    { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1197), "54.810602596364205" },
                    { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1212), "33.90508759483461" },
                    { 13, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1228), "18.325982808787355" },
                    { 26, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1243), "77.84494082676657" },
                    { 23, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1257), "84.71089644231449" },
                    { 21, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1271), "60.08656676699106" },
                    { 25, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1286), "90.81079986365694" },
                    { 27, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1301), "83.62193771276183" },
                    { 11, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1315), "50.57098046267478" },
                    { 4, new DateTime(2024, 11, 3, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1330), "95.5204828673197" },
                    { 12, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(904), "83.08889318454492" },
                    { 10, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(919), "78.4586926536175" },
                    { 19, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(933), "20.48778002432449" },
                    { 27, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(949), "36.86196079094058" },
                    { 27, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(987), "94.32524081663166" },
                    { 16, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1002), "81.056219319895" },
                    { 1, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1017), "50.38475091195656" },
                    { 26, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1032), "88.8060103898043" },
                    { 10, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1047), "23.860333214013984" },
                    { 16, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1062), "52.4317328483338" },
                    { 22, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1077), "70.90680264267137" },
                    { 20, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1092), "38.827890103666135" },
                    { 2, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1107), "75.52270359107678" },
                    { 4, new DateTime(2024, 11, 4, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(1122), "23.557101198097907" },
                    { 13, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(736), "61.48831020134508" },
                    { 2, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(750), "42.18937372078622" },
                    { 12, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(765), "37.76418968129963" },
                    { 16, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(781), "39.29959835265558" },
                    { 23, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(798), "22.165784100095042" },
                    { 16, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(813), "17.126152565246517" },
                    { 18, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(830), "21.699334239870126" },
                    { 18, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(845), "38.69679137137925" },
                    { 21, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(860), "34.99069515445584" },
                    { 1, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(875), "72.06160815158242" },
                    { 13, new DateTime(2024, 11, 5, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(889), "38.663063769537146" },
                    { 15, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(456), "56.25004889332505" },
                    { 14, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(471), "72.99035652515532" },
                    { 20, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(487), "79.34873048355047" },
                    { 2, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(502), "52.88001316422297" },
                    { 25, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(517), "23.62056030428218" },
                    { 20, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(531), "12.851995673465709" },
                    { 18, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(547), "62.91389616969784" },
                    { 27, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(562), "52.333660510776866" },
                    { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(576), "26.256674250449844" },
                    { 22, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(591), "82.91302620911776" },
                    { 24, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(629), "25.427798626718314" },
                    { 10, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(645), "39.13788868890366" },
                    { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(661), "71.9278963245516" },
                    { 19, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(676), "66.97343074896398" },
                    { 13, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(691), "33.18787424030883" },
                    { 22, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(705), "69.73451789477978" },
                    { 3, new DateTime(2024, 11, 6, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(721), "29.447964255048433" },
                    { 6, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(140), "17.560090960243823" },
                    { 22, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(156), "74.92913311186732" },
                    { 4, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(171), "93.71528560609539" },
                    { 15, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(255), "74.23985388385483" },
                    { 7, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(271), "71.67978730074836" },
                    { 7, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(286), "76.04503127364521" },
                    { 21, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(302), "14.309503800047432" },
                    { 11, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(318), "55.68838907299785" },
                    { 10, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(333), "77.65840345921721" },
                    { 26, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(348), "19.66252453250291" },
                    { 25, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(363), "89.79226842844736" },
                    { 26, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(378), "56.18987539203173" },
                    { 16, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(393), "16.011878398416854" },
                    { 17, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(409), "85.48298656588116" },
                    { 6, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(424), "11.905741875371255" },
                    { 12, new DateTime(2024, 11, 7, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(440), "45.768908784989954" },
                    { 5, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9950), "32.69385758372751" },
                    { 27, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9966), "85.80518950408245" },
                    { 13, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9982), "65.3692927837059" },
                    { 1, new DateTime(2024, 11, 8, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9998), "22.583220771232465" },
                    { 15, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(13), "36.22028287426522" },
                    { 8, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(28), "90.81392436469967" },
                    { 13, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(44), "52.84428459997821" },
                    { 19, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(60), "86.04318564002178" },
                    { 2, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(77), "31.83451559482392" },
                    { 14, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(93), "32.912356222900996" },
                    { 16, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(109), "31.971476360956412" },
                    { 23, new DateTime(2024, 11, 8, 18, 0, 55, 170, DateTimeKind.Utc).AddTicks(124), "53.4830312515757" },
                    { 16, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9610), "13.902101416346714" },
                    { 11, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9692), "65.71204276449936" },
                    { 4, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9710), "68.53732694828832" },
                    { 26, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9727), "87.99943380170707" },
                    { 27, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9744), "46.35797603309338" },
                    { 4, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9810), "39.406730718399615" },
                    { 17, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9827), "16.70423066041942" },
                    { 14, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9843), "47.32739178317227" },
                    { 25, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9857), "36.39728047809731" },
                    { 5, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9874), "30.61450935070478" },
                    { 2, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9889), "69.7819549953046" },
                    { 22, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9905), "68.5435135137704" },
                    { 8, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9920), "29.871267382682138" },
                    { 9, new DateTime(2024, 11, 9, 18, 0, 55, 169, DateTimeKind.Utc).AddTicks(9935), "52.28284344776233" }
                });
        }
    }
}
