using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class updated_new_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(561) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(616) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(388) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(404) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(452) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(214) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(16) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9877) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9984) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9749) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9239) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9255) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9271) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9097) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9115) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9131) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8797) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8829) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8878) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8535) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8569) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8584) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8313) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8375) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8126) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8173) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8189) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8205) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8029) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8061) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7066) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7187) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6953) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6984) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6871) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6887) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6561) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6592) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6625) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6409) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6466) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6483) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6545) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6132) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6180) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6216) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6244) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5991) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6021) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6067) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5769) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5896) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5661) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5563) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5255) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5272) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5322) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5338) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5354) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5095) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5176) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5192) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5207) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4919) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4950) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4967) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5018) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5034) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4783) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4835) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4869) });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 26, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9154), "74.8963070246651" },
                    { 4, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9170), "98.81073352547747" },
                    { 13, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9185), "17.37888255443247" },
                    { 18, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9199), "26.700734335346603" },
                    { 1, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9214), "16.38549128304361" },
                    { 23, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9229), "77.69572675158884" },
                    { 6, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9244), "76.6627862708336" },
                    { 5, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9259), "85.45389337871411" },
                    { 2, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9274), "21.789823959983806" },
                    { 14, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9289), "59.02053638814605" },
                    { 14, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9303), "77.53271699856766" },
                    { 22, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9319), "27.22960350595628" },
                    { 7, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8830), "21.319585894502136" },
                    { 4, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8850), "85.07452635977785" },
                    { 1, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8869), "11.612827552125536" },
                    { 11, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8887), "70.47927142460634" },
                    { 11, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8906), "75.72954141452185" },
                    { 16, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8924), "86.83582366012742" },
                    { 15, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8942), "26.097772368812887" },
                    { 5, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8962), "25.065454211488554" },
                    { 21, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8981), "39.3160429557707" },
                    { 6, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9001), "54.1951969350283" },
                    { 25, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9049), "65.36190631653346" },
                    { 18, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9065), "40.59912500792974" },
                    { 13, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9080), "41.37398878518425" },
                    { 22, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9095), "97.72826529064982" },
                    { 6, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9110), "99.55657436964214" },
                    { 12, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9124), "51.15692116547323" },
                    { 21, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9139), "74.73772366268" },
                    { 5, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8600), "11.664611124052103" },
                    { 3, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8620), "95.32747013126954" },
                    { 13, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8638), "71.38034465894461" },
                    { 25, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8658), "97.61557576226255" },
                    { 1, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8677), "98.41828246527712" },
                    { 14, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8697), "65.55076454712807" },
                    { 6, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8715), "14.919189244061412" },
                    { 24, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8734), "72.69094439849022" },
                    { 9, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8753), "49.76112432058296" },
                    { 18, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8772), "41.915734924926866" },
                    { 11, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8792), "71.34540727554344" },
                    { 11, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8811), "57.331880434703855" },
                    { 8, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8351), "48.19756018428396" },
                    { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8370), "39.673385275747044" },
                    { 3, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8389), "97.01339754200605" },
                    { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8407), "80.6999961833288" },
                    { 1, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8426), "18.103256040326578" },
                    { 9, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8445), "48.141386508870326" },
                    { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8465), "38.90138917348247" },
                    { 12, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8484), "82.23327134082149" },
                    { 22, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8542), "26.249634170766328" },
                    { 10, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8563), "31.266940499522622" },
                    { 5, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8582), "59.01184384852518" },
                    { 15, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8070), "26.549815011327638" },
                    { 26, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8090), "44.50165447277919" },
                    { 8, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8108), "39.56723502006061" },
                    { 11, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8127), "89.7243063097803" },
                    { 14, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8146), "73.89283049007122" },
                    { 19, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8165), "96.90095036689249" },
                    { 17, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8185), "26.99457529130033" },
                    { 12, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8203), "67.00441742497532" },
                    { 25, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8221), "86.50152124531472" },
                    { 13, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8240), "26.76581841284818" },
                    { 11, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8258), "63.51905392732402" },
                    { 8, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8276), "95.36396684711919" },
                    { 10, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8296), "69.0488807744009" },
                    { 21, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8314), "29.814140777112936" },
                    { 10, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8333), "17.003428891394204" },
                    { 20, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7639), "29.825782956713564" },
                    { 25, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7657), "37.126268909750834" },
                    { 1, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7676), "34.747853701629396" },
                    { 14, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7695), "88.81119801449312" },
                    { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7714), "70.35560557835197" },
                    { 16, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7732), "60.03379140923221" },
                    { 2, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7751), "15.90118526290008" },
                    { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7769), "54.92725761793966" },
                    { 21, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7786), "77.90967751295993" },
                    { 8, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7806), "83.1509225750145" },
                    { 12, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7826), "55.40175239858178" },
                    { 10, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7844), "93.17620393241165" },
                    { 15, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7864), "80.19430811164516" },
                    { 10, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7883), "39.37478269872511" },
                    { 22, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7903), "88.87626300663686" },
                    { 23, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7922), "19.151842440590094" },
                    { 11, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7941), "39.71371018946631" },
                    { 26, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7959), "90.33553346676293" },
                    { 14, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7978), "69.47299508682549" },
                    { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8032), "66.86609365435164" },
                    { 11, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8051), "85.05207984526693" },
                    { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7318), "10.606930662403606" },
                    { 21, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7337), "62.61932592440773" },
                    { 23, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7357), "78.49689405735361" },
                    { 11, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7378), "30.22768547350087" },
                    { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7398), "53.166005576920014" },
                    { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7417), "38.83717569741421" },
                    { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7436), "56.27751232165721" },
                    { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7455), "71.15998553860416" },
                    { 7, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7474), "97.57227996039438" },
                    { 24, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7492), "99.67741085275436" },
                    { 8, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7510), "91.11155007931995" },
                    { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7546), "99.89627539167999" },
                    { 26, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7565), "73.51046197823119" },
                    { 6, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7583), "28.764876708918838" },
                    { 20, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7602), "64.9039993506175" },
                    { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7621), "44.78494055514475" },
                    { 26, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6952), "40.12627975144276" },
                    { 19, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6969), "23.528398485143896" },
                    { 19, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6988), "54.86997526303523" },
                    { 6, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7034), "76.75142759617592" },
                    { 27, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7052), "93.73885072816066" },
                    { 17, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7072), "54.251309535142525" },
                    { 13, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7091), "30.835184825419244" },
                    { 15, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7109), "51.019013892016275" },
                    { 25, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7128), "36.820071570341376" },
                    { 15, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7149), "88.98324517696336" },
                    { 2, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7175), "25.217294422878055" },
                    { 7, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7194), "90.075348833415" },
                    { 9, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7213), "56.426340638818345" },
                    { 13, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7240), "77.39342968438808" },
                    { 4, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7258), "30.40468947167664" },
                    { 17, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7278), "78.0665386038034" },
                    { 11, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7299), "80.74672970225285" },
                    { 26, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6687), "33.772551015120115" },
                    { 11, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6706), "32.86201522416074" },
                    { 6, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6725), "91.80447541017708" },
                    { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6744), "22.208617092444463" },
                    { 2, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6762), "36.86740439455131" },
                    { 7, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6780), "33.102118796965584" },
                    { 16, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6799), "23.585951012939006" },
                    { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6817), "87.66740551418245" },
                    { 19, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6837), "21.022700760711285" },
                    { 9, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6855), "16.10678801765406" },
                    { 15, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6876), "83.53364368566648" },
                    { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6896), "98.4005806037524" },
                    { 9, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6915), "79.06326589909523" },
                    { 27, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6933), "73.00430211724975" },
                    { 4, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6448), "59.22967585666646" },
                    { 22, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6467), "81.46672349025252" },
                    { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6486), "44.32604150517742" },
                    { 20, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6530), "43.88294156106397" },
                    { 18, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6552), "91.47099821935021" },
                    { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6570), "89.1935263174931" },
                    { 7, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6589), "25.768228205953108" },
                    { 3, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6608), "11.258254006137252" },
                    { 16, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6627), "57.31570362742468" },
                    { 4, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6646), "66.694303218232" },
                    { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6666), "46.88441466140653" },
                    { 9, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6242), "50.43194555509973" },
                    { 23, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6261), "48.482616807117324" },
                    { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6279), "31.8678635986376" },
                    { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6298), "88.79310076942757" },
                    { 17, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6316), "28.705300515007817" },
                    { 7, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6336), "11.037561386027603" },
                    { 15, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6355), "16.34232317667815" },
                    { 3, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6374), "41.46397565268828" },
                    { 23, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6393), "89.61851242598023" },
                    { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6411), "28.02662374579502" },
                    { 26, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6430), "13.833979743920453" },
                    { 19, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5953), "56.747680519065675" },
                    { 8, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5972), "54.12681966826386" },
                    { 18, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5992), "51.812153959786286" },
                    { 7, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6009), "72.03078965580417" },
                    { 9, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6054), "32.62526908140341" },
                    { 15, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6073), "22.67705029168821" },
                    { 1, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6092), "27.236477933020236" },
                    { 2, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6112), "47.10560419301972" },
                    { 20, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6130), "97.11328826923086" },
                    { 3, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6149), "85.16410091827841" },
                    { 21, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6168), "73.32499096504662" },
                    { 1, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6187), "49.35447835318032" },
                    { 27, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6205), "10.357248853500508" },
                    { 22, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6223), "54.667695331629105" },
                    { 13, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5642), "16.732788348090146" },
                    { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5660), "83.42814025085822" },
                    { 26, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5679), "30.340069070750836" },
                    { 6, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5698), "90.09576474527533" },
                    { 13, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5716), "88.40863074516682" },
                    { 17, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5765), "63.11531544897248" },
                    { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5785), "98.46158769337777" },
                    { 11, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5803), "91.98567039142728" },
                    { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5822), "88.54587758709748" },
                    { 10, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5842), "14.319645507791346" },
                    { 17, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5860), "11.791083203631187" },
                    { 1, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5878), "87.13162486762641" },
                    { 27, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5897), "15.400954813426209" },
                    { 1, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5915), "47.63398132989944" },
                    { 12, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5933), "81.16980860786875" },
                    { 19, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5382), "92.32421464819096" },
                    { 13, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5401), "51.19610614885082" },
                    { 19, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5419), "58.3848385793574" },
                    { 21, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5438), "29.01715881428142" },
                    { 24, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5456), "41.83484179369333" },
                    { 1, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5475), "85.88807679564769" },
                    { 27, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5492), "20.55770615973994" },
                    { 17, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5511), "69.27254478561599" },
                    { 9, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5530), "55.954644067626425" },
                    { 7, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5548), "91.44543691493847" },
                    { 20, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5566), "53.826208388069276" },
                    { 5, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5585), "30.984155167542607" },
                    { 6, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5604), "65.13998591005644" },
                    { 23, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5622), "87.07226770006272" },
                    { 20, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5070), "93.33536639670984" },
                    { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5089), "95.88592893796243" },
                    { 21, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5107), "84.13948202488477" },
                    { 26, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5126), "97.9941917189403" },
                    { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5144), "35.400599845738405" },
                    { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5162), "42.357330110587945" },
                    { 1, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5181), "33.38708141686686" },
                    { 16, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5200), "78.46227828914303" },
                    { 23, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5218), "25.5045191131983" },
                    { 25, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5237), "21.62321712116859" },
                    { 7, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5287), "46.50704441598414" },
                    { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5307), "38.05689725157441" },
                    { 16, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5327), "67.24548052791243" },
                    { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5346), "29.185676932177838" },
                    { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5364), "81.5548045887181" },
                    { 22, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4615), "19.655776366431017" },
                    { 9, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4634), "15.463642550528682" },
                    { 17, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4654), "63.49969520526059" },
                    { 19, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4673), "65.81472899875114" },
                    { 13, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4691), "37.664531220478395" },
                    { 4, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4710), "72.23541292466348" },
                    { 24, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4728), "44.153471099162005" },
                    { 14, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4746), "48.96135258107761" },
                    { 5, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4802), "46.62527643116238" },
                    { 13, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4821), "88.86252373902195" },
                    { 6, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4840), "24.411343597093083" },
                    { 20, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4859), "51.87647563152707" },
                    { 7, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4877), "19.789636898583574" },
                    { 27, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4897), "73.11268170058302" },
                    { 1, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4917), "31.291202323663775" },
                    { 21, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4936), "91.52599517029338" },
                    { 23, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4955), "77.49515350682897" },
                    { 17, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4974), "35.164351794729086" },
                    { 19, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4994), "58.447307610098356" },
                    { 16, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5013), "93.0043220783661" },
                    { 22, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5032), "93.78636269510007" },
                    { 11, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5051), "91.64107471198737" },
                    { 13, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4388), "78.673405141108" },
                    { 17, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4407), "16.626084724642016" },
                    { 8, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4426), "90.19959093895741" },
                    { 19, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4445), "97.25183103333647" },
                    { 24, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4463), "45.36870527205061" },
                    { 7, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4483), "85.86909177277477" },
                    { 22, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4502), "74.08838957136321" },
                    { 23, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4521), "33.71476539462999" },
                    { 27, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4540), "34.89220697945078" },
                    { 10, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4558), "65.03333758655324" },
                    { 2, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4577), "73.44227592316594" },
                    { 4, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4596), "38.01207437082627" },
                    { 7, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4139), "72.8062951839598" },
                    { 24, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4159), "74.81804883726433" },
                    { 13, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4179), "66.58014239453303" },
                    { 21, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4199), "91.54622495222556" },
                    { 21, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4217), "81.43942959856824" },
                    { 17, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4236), "86.13665568651625" },
                    { 2, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4297), "45.89490949735736" },
                    { 4, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4315), "49.817995088075946" },
                    { 18, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4333), "92.05340411139491" },
                    { 8, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4351), "28.358274667589537" },
                    { 26, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4370), "52.75181638141309" },
                    { 7, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3859), "16.312390074552383" },
                    { 2, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3878), "41.63663878738073" },
                    { 10, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3898), "99.5846645225992" },
                    { 11, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3917), "84.2588512316316" },
                    { 12, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3935), "20.502942425437865" },
                    { 17, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3954), "38.708204353948744" },
                    { 11, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3972), "27.89419659694162" },
                    { 24, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3992), "10.222202731958166" },
                    { 23, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4010), "83.17240074126615" },
                    { 24, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4028), "34.48023265554301" },
                    { 20, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4047), "85.62164660004353" },
                    { 21, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4066), "60.556613907963076" },
                    { 6, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4084), "59.52391832547781" },
                    { 14, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4103), "13.274190152859994" },
                    { 4, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4120), "51.236896216198105" },
                    { 19, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3562), "38.593820584239175" },
                    { 6, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3581), "21.243095639444977" },
                    { 5, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3600), "46.5415867905114" },
                    { 27, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3619), "55.64635226624574" },
                    { 25, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3639), "70.17389342296696" },
                    { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3657), "28.606182845922632" },
                    { 27, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3675), "65.10147835929" },
                    { 9, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3694), "16.60716426753693" },
                    { 24, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3712), "64.73458501692741" },
                    { 22, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3731), "52.32844338228634" },
                    { 6, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3748), "34.45651579712853" },
                    { 15, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3766), "18.465071684264675" },
                    { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3802), "88.79843337684646" },
                    { 14, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3821), "71.79382166741917" },
                    { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3840), "60.23192313449538" },
                    { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3331), "93.92978129588157" },
                    { 6, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3350), "81.24283342547182" },
                    { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3370), "40.20312277612119" },
                    { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3389), "56.509529168807205" },
                    { 8, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3409), "14.999701359879559" },
                    { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3428), "43.552018502327265" },
                    { 2, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3449), "62.047700279106394" },
                    { 20, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3468), "85.89186500159082" },
                    { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3486), "89.71606228239443" },
                    { 21, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3505), "85.11002063059279" },
                    { 10, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3525), "27.5525137569998" },
                    { 21, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3544), "96.94222562855333" },
                    { 21, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3019), "34.834551703760084" },
                    { 2, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3038), "52.79269896859576" },
                    { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3057), "94.10051608671847" },
                    { 6, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3076), "71.85643619877592" },
                    { 3, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3096), "34.90994199636496" },
                    { 7, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3115), "26.77216086065658" },
                    { 22, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3133), "20.87126479709282" },
                    { 12, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3152), "23.34893210587649" },
                    { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3171), "31.612511418276704" },
                    { 15, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3189), "50.02388450245809" },
                    { 24, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3208), "28.69179475859467" },
                    { 1, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3226), "15.17762051521917" },
                    { 13, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3244), "67.75111049015231" },
                    { 24, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3264), "37.367796417566424" },
                    { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3311), "52.35987364672212" },
                    { 16, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2741), "37.85451373796418" },
                    { 1, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2761), "90.62249661083037" },
                    { 14, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2780), "40.89562038341325" },
                    { 27, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2799), "60.279777501284585" },
                    { 25, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2819), "59.64265832952412" },
                    { 12, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2837), "64.27062734903689" },
                    { 15, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2857), "39.417821389574215" },
                    { 20, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2877), "58.853554683269685" },
                    { 21, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2923), "55.298729987359245" },
                    { 11, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2943), "14.65815406133547" },
                    { 5, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2962), "52.196742893055514" },
                    { 5, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2982), "79.92466106251153" },
                    { 8, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3001), "22.64946503590822" },
                    { 12, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2436), "21.982210705684167" },
                    { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2456), "28.657325909987122" },
                    { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2475), "67.35790121282176" },
                    { 26, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2494), "49.961044224275746" },
                    { 13, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2513), "45.18002242549042" },
                    { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2531), "49.25892707346458" },
                    { 22, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2550), "59.49649235899123" },
                    { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2569), "54.60177402378229" },
                    { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2588), "91.88011781822412" },
                    { 26, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2607), "54.36496123790637" },
                    { 9, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2625), "89.68306281894877" },
                    { 24, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2643), "17.30020804227845" },
                    { 10, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2663), "27.03068965098004" },
                    { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2682), "89.01174245834991" },
                    { 3, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2702), "19.59773114424366" },
                    { 3, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2721), "76.57700170347795" },
                    { 23, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2057), "90.70648938377717" },
                    { 9, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2077), "17.773684152927025" },
                    { 9, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2096), "38.17624873826874" },
                    { 15, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2115), "40.55578465105427" },
                    { 10, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2132), "65.8651829558392" },
                    { 23, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2151), "32.530305577458066" },
                    { 13, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2171), "30.614271603152893" },
                    { 11, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2189), "30.159979682978474" },
                    { 5, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2207), "76.03655923569283" },
                    { 26, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2226), "44.086459107342456" },
                    { 16, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2246), "79.2577146374582" },
                    { 15, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2295), "28.888503574852457" },
                    { 11, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2315), "12.272972370274536" },
                    { 26, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2333), "85.05387681645199" },
                    { 3, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2352), "78.9117117775786" },
                    { 16, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2370), "79.98720590050667" },
                    { 25, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2415), "41.34214204913715" },
                    { 20, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1687), "89.191325355767" },
                    { 17, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1705), "27.735874507171488" },
                    { 19, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1724), "76.0063461715914" },
                    { 26, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1742), "67.03341026295881" },
                    { 11, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1761), "28.684883615790387" },
                    { 2, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1780), "90.46015730772105" },
                    { 22, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1799), "32.68551372241458" },
                    { 3, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1817), "92.24638715467756" },
                    { 5, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1837), "28.692558079214635" },
                    { 7, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1856), "10.523923563063136" },
                    { 25, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1903), "80.92885722070214" },
                    { 18, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1923), "67.70465093589993" },
                    { 7, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1942), "23.851077089551367" },
                    { 26, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1961), "35.97189112757184" },
                    { 24, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1980), "90.91725678188602" },
                    { 8, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1998), "49.67841555556926" },
                    { 18, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2019), "59.60736899239281" },
                    { 3, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2038), "67.19152886734217" },
                    { 1, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1405), "19.09693648254136" },
                    { 12, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1454), "74.79399258816973" },
                    { 11, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1474), "53.27359790653605" },
                    { 13, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1494), "22.89895456355102" },
                    { 21, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1514), "39.14154608505928" },
                    { 23, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1533), "77.18296237312114" },
                    { 22, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1552), "66.55469380384432" },
                    { 19, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1572), "78.47886971653178" },
                    { 1, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1591), "25.128000174743818" },
                    { 22, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1609), "57.29025818976683" },
                    { 23, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1628), "88.51520716431364" },
                    { 15, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1648), "90.1019583104869" },
                    { 17, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1667), "93.32645855124828" },
                    { 12, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1176), "68.46927687954977" },
                    { 20, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1197), "77.46783184609535" },
                    { 20, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1216), "93.6713314145277" },
                    { 4, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1235), "56.65670970593268" },
                    { 18, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1253), "55.10774578076243" },
                    { 23, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1272), "80.2127228587216" },
                    { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1291), "71.76796269424608" },
                    { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1309), "67.18203450931058" },
                    { 4, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1329), "91.50109037962513" },
                    { 11, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1349), "53.88144691561271" },
                    { 27, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1368), "93.19950903131962" },
                    { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1386), "20.92479615997504" },
                    { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(901), "54.54857955552439" },
                    { 18, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(920), "51.21321187064644" },
                    { 24, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(979), "86.953935538883" },
                    { 23, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(999), "55.2511426923543" },
                    { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1019), "30.4741991856628" },
                    { 2, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1040), "77.65800474704706" },
                    { 20, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1060), "25.141268114246863" },
                    { 26, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1080), "73.11049009690308" },
                    { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1099), "35.28829832307301" },
                    { 24, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1117), "75.61866315398122" },
                    { 13, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1137), "94.04838869940112" },
                    { 9, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1157), "12.067777800869804" },
                    { 27, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(444), "69.3040601694316" },
                    { 8, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(531), "96.35281030780551" },
                    { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(553), "60.52373883836533" },
                    { 23, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(573), "77.84489417934478" },
                    { 16, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(593), "39.417358796537" },
                    { 15, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(613), "77.48848623143172" },
                    { 19, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(632), "36.12498983523367" },
                    { 2, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(652), "66.14627706902937" },
                    { 6, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(671), "68.45074979197986" },
                    { 9, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(691), "25.927497610929116" },
                    { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(710), "73.35455797916842" },
                    { 27, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(730), "60.28818260300824" },
                    { 6, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(749), "60.55083494522776" },
                    { 3, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(768), "46.972669336879804" },
                    { 23, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(787), "66.26237489498882" },
                    { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(807), "74.62459512406302" },
                    { 11, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(824), "86.26762420862656" },
                    { 20, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(845), "64.52276806501268" },
                    { 8, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(865), "88.35616585219576" },
                    { 3, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(882), "56.8771962360015" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9199) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9259) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9289) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 11, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8981) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9049) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 12, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 13, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8426) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8465) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8542) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8563) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 14, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8582) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8165) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8203) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 15, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7639) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7695) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7732) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 16, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7357) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7417) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 17, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6952) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7052) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7175) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7278) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 18, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(7299) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6799) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6896) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 19, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6486) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6552) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6589) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 20, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6242) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6279) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6316) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6355) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6393) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 21, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6009) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6130) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6187) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6205) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 22, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(6223) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5642) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5716) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5765) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5785) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5803) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 23, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5382) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5419) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5492) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 24, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5089) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5126) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5162) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5307) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5327) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5346) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 25, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5364) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4654) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4673) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4691) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4821) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4859) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4877) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4897) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5013) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 26, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4407) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 27, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4159) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4217) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4236) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 28, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4103) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 29, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3619) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3731) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3748) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3766) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3840) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3486) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 31, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3544) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3038) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3096) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3133) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 1, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2799) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2819) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2857) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2962) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 2, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2436) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2643) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 3, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2057) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2171) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2226) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2246) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2352) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 4, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2415) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1705) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1724) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1761) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1780) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1799) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1942) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 5, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1628) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 6, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1253) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1272) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 7, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(999) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1040) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1099) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1137) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 8, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(613) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(824) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(865) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 9, 16, 11, 29, 694, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 19, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(529), "62.651028920294564" },
                    { 2, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(545), "59.65057600064839" },
                    { 10, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(561), "77.47565790118045" },
                    { 16, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(616), "24.995693817139855" },
                    { 14, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(632), "67.69624361202925" },
                    { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(649), "58.31717930308847" },
                    { 19, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(665), "21.03998960003679" },
                    { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(679), "89.78284146597308" },
                    { 15, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(696), "85.1610799842621" },
                    { 27, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(711), "96.56451350569765" },
                    { 20, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(372), "49.213348562658986" },
                    { 22, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(388), "44.21475517011282" },
                    { 9, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(404), "45.569352533206775" },
                    { 15, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(420), "48.10233306109305" },
                    { 11, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(436), "30.771579181260385" },
                    { 16, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(452), "96.6859268136928" },
                    { 15, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(468), "36.625130734888074" },
                    { 2, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(483), "54.39899395350838" },
                    { 22, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(499), "85.81056381954882" },
                    { 18, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(514), "38.37507909035241" },
                    { 23, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(214), "15.114710781842913" },
                    { 24, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(229), "41.44490674195757" },
                    { 7, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(246), "75.86030155382237" },
                    { 15, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(261), "60.30876050056295" },
                    { 5, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(276), "10.582672592040518" },
                    { 4, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(291), "43.36251774610009" },
                    { 2, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(307), "52.47608994621498" },
                    { 22, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(322), "63.91148456863809" },
                    { 23, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(338), "32.781705281759415" },
                    { 12, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(355), "73.89747817821657" },
                    { 10, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc), "28.558141733491556" },
                    { 11, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(16), "49.399395119688386" },
                    { 19, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(32), "59.510243303929414" },
                    { 17, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(49), "47.59937462664373" },
                    { 4, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(64), "62.474183332847375" },
                    { 7, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(80), "78.50322190653188" },
                    { 16, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(97), "35.69184430370967" },
                    { 25, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(113), "32.83467667533424" },
                    { 24, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(180), "91.44248012743775" },
                    { 4, new DateTime(2024, 10, 14, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(198), "32.356038326655906" },
                    { 25, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9798), "34.78049498409659" },
                    { 13, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9814), "20.07058099582764" },
                    { 17, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9830), "68.4450657771807" },
                    { 22, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9846), "94.68620353844706" },
                    { 7, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9861), "82.2503588075565" },
                    { 20, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9877), "86.66871425779782" },
                    { 1, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9934), "34.54427116392431" },
                    { 6, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9952), "60.03084025934544" },
                    { 23, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9968), "48.68760782442486" },
                    { 8, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9984), "86.2263195014581" },
                    { 10, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9638), "37.9666738483153" },
                    { 16, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9652), "83.57864733721222" },
                    { 7, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9667), "78.47389722298466" },
                    { 4, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9683), "70.73537845037188" },
                    { 1, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9699), "42.11703034815371" },
                    { 18, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9716), "71.887664000823" },
                    { 27, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9733), "31.13326690354673" },
                    { 12, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9749), "59.82470678978229" },
                    { 21, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9765), "41.540481896307114" },
                    { 16, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9781), "26.60642763248674" },
                    { 27, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9465), "40.25503439638383" },
                    { 13, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9480), "21.193652808327194" },
                    { 10, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9512), "30.38526764695582" },
                    { 8, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9529), "35.8921132502325" },
                    { 24, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9544), "82.69317941938367" },
                    { 10, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9559), "25.02269258540045" },
                    { 15, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9576), "22.184782628180326" },
                    { 9, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9591), "84.15597320528641" },
                    { 9, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9606), "54.37191022800935" },
                    { 23, new DateTime(2024, 10, 17, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9622), "27.51773680985065" },
                    { 6, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9303), "57.56045315152356" },
                    { 4, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9318), "61.750953417824746" },
                    { 25, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9334), "11.345541750522262" },
                    { 22, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9351), "70.27921644253459" },
                    { 27, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9368), "26.229144953540295" },
                    { 20, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9384), "45.61240526665326" },
                    { 14, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9400), "45.60826306102056" },
                    { 12, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9416), "75.98300935072362" },
                    { 13, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9432), "49.03483976072431" },
                    { 7, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9449), "59.182526550858526" },
                    { 9, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9147), "62.79538015100176" },
                    { 3, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9163), "81.06541726083886" },
                    { 10, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9179), "28.490954814860604" },
                    { 27, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9194), "30.50550356078456" },
                    { 14, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9209), "74.8074582784867" },
                    { 3, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9224), "37.560634863077745" },
                    { 27, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9239), "76.06770450071645" },
                    { 26, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9255), "80.65710942707098" },
                    { 8, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9271), "44.0015867607523" },
                    { 7, new DateTime(2024, 10, 19, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9287), "75.07744474890134" },
                    { 27, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8959), "79.55825863484102" },
                    { 15, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8975), "82.92314281745047" },
                    { 6, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8992), "86.7279205988687" },
                    { 25, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9007), "24.531377330690873" },
                    { 7, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9023), "78.03527215947128" },
                    { 24, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9039), "75.49050979791329" },
                    { 19, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9056), "72.79639530431993" },
                    { 11, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9097), "54.656075991005444" },
                    { 19, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9115), "70.77278727811435" },
                    { 13, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9131), "18.34579662133541" },
                    { 25, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8797), "36.79083388018174" },
                    { 18, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8813), "39.27447552616674" },
                    { 9, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8829), "23.74860498111891" },
                    { 16, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8845), "12.101908501035586" },
                    { 4, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8860), "18.850939410011236" },
                    { 12, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8878), "18.725815641300237" },
                    { 19, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8894), "89.55647337619538" },
                    { 27, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8910), "87.7085516342856" },
                    { 27, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8927), "48.4453270890583" },
                    { 4, new DateTime(2024, 10, 21, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8943), "16.167539080674295" },
                    { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8615), "56.14602298469828" },
                    { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8630), "84.01642764845184" },
                    { 4, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8670), "93.82880920685028" },
                    { 14, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8687), "85.76519645520678" },
                    { 25, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8702), "83.22531221330964" },
                    { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8719), "24.84004140560761" },
                    { 7, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8735), "24.726200114171476" },
                    { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8750), "23.06561278985499" },
                    { 1, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8766), "39.506664214000466" },
                    { 5, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8781), "44.61909235120725" },
                    { 16, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8455), "75.36484616565627" },
                    { 13, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8471), "16.629257012351026" },
                    { 10, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8487), "17.608491330266645" },
                    { 26, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8503), "38.344817267576005" },
                    { 7, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8520), "42.44755861610854" },
                    { 25, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8535), "51.41494087388479" },
                    { 2, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8552), "54.96029877667283" },
                    { 6, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8569), "90.73250007303442" },
                    { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8584), "30.980623390339744" },
                    { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8600), "80.6923436203935" },
                    { 2, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8297), "27.01467995806037" },
                    { 27, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8313), "21.144391821491425" },
                    { 11, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8329), "88.98874600788501" },
                    { 17, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8345), "69.18212115666287" },
                    { 1, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8359), "93.1547950751211" },
                    { 4, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8375), "68.41999418808213" },
                    { 7, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8391), "57.685150298051106" },
                    { 15, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8408), "45.08871532419274" },
                    { 9, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8423), "35.476413195096356" },
                    { 25, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8439), "79.00340652095201" },
                    { 3, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8109), "45.37567530969709" },
                    { 2, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8126), "23.381472936747315" },
                    { 10, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8142), "70.19636026528255" },
                    { 25, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8157), "95.36681542081013" },
                    { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8173), "17.653277685647573" },
                    { 26, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8189), "93.29875667029746" },
                    { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8205), "75.29608433819128" },
                    { 9, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8247), "10.146291169340925" },
                    { 6, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8265), "90.70178906429005" },
                    { 5, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8280), "59.96397860660448" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7948), "55.43837605769154" },
                    { 10, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7964), "60.260671852597234" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7981), "76.75534848384792" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7997), "25.61671401317721" },
                    { 21, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8013), "15.473043966572536" },
                    { 17, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8029), "67.95162323993091" },
                    { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8045), "76.00841852616566" },
                    { 7, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8061), "16.946215666095824" },
                    { 12, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8077), "91.6320424633465" },
                    { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8094), "61.84844772700336" },
                    { 3, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7066), "35.1632332191584" },
                    { 20, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7082), "15.168960461978703" },
                    { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7098), "46.475172498568085" },
                    { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7139), "23.992976890380966" },
                    { 2, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7155), "72.70564507451752" },
                    { 9, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7171), "65.42092250017181" },
                    { 4, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7187), "18.04871871789186" },
                    { 8, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7203), "19.79659122507781" },
                    { 23, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7913), "16.55966532475557" },
                    { 7, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7931), "88.55476258823761" },
                    { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6903), "56.383136482841905" },
                    { 7, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6921), "68.30772206101418" },
                    { 11, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6938), "15.828526578454142" },
                    { 2, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6953), "65.40940056280637" },
                    { 21, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6969), "56.67329624517806" },
                    { 1, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6984), "91.52861602597297" },
                    { 26, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7001), "51.996897585048" },
                    { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7016), "45.48080675758225" },
                    { 24, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7032), "28.41964560940652" },
                    { 4, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7050), "96.16725579883075" },
                    { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6719), "74.12765085811915" },
                    { 8, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6735), "31.94727149314748" },
                    { 19, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6749), "96.93272369355616" },
                    { 24, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6765), "34.892035270111954" },
                    { 9, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6808), "73.40653591190411" },
                    { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6824), "19.057856764909133" },
                    { 17, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6840), "44.37785162214416" },
                    { 4, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6856), "65.87000984132952" },
                    { 8, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6871), "18.469986028876676" },
                    { 22, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6887), "95.67069846884944" },
                    { 27, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6561), "93.24283213874394" },
                    { 19, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6576), "56.774472291969325" },
                    { 3, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6592), "40.08550618301715" },
                    { 10, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6609), "49.95851834937776" },
                    { 20, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6625), "15.003145843280834" },
                    { 14, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6641), "15.439122805853398" },
                    { 27, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6657), "72.5111044432683" },
                    { 21, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6672), "22.390231181389975" },
                    { 11, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6687), "65.47058875898563" },
                    { 14, new DateTime(2024, 10, 30, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6702), "73.5392991938723" },
                    { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6381), "26.02348286649789" },
                    { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6409), "67.040133541302" },
                    { 14, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6431), "25.101497191122462" },
                    { 23, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6450), "19.43242560335628" },
                    { 15, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6466), "14.544661629016487" },
                    { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6483), "36.351025730430074" },
                    { 26, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6498), "16.126342182935392" },
                    { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6514), "27.552399501830735" },
                    { 15, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6529), "34.797386162421816" },
                    { 19, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6545), "48.03662472978803" },
                    { 7, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6116), "59.908005679115156" },
                    { 14, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6132), "70.41069000354821" },
                    { 24, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6148), "27.50325493525993" },
                    { 24, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6165), "47.085986014372345" },
                    { 11, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6180), "62.132156674344046" },
                    { 4, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6195), "79.8969814821805" },
                    { 19, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6216), "31.296205184091242" },
                    { 15, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6244), "97.63285009992411" },
                    { 11, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6271), "49.31171568002569" },
                    { 26, new DateTime(2024, 11, 1, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6349), "70.91404081771968" },
                    { 27, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5959), "93.18232351086169" },
                    { 11, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5975), "77.41257103393224" },
                    { 11, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5991), "32.15263172276279" },
                    { 20, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6005), "21.56701828429086" },
                    { 23, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6021), "78.25805195656564" },
                    { 21, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6036), "99.09072385635876" },
                    { 15, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6051), "51.81547937967833" },
                    { 18, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6067), "36.66909862050957" },
                    { 24, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6083), "42.60577986172976" },
                    { 8, new DateTime(2024, 11, 2, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6099), "61.93459432062001" },
                    { 21, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5738), "65.96052926572469" },
                    { 8, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5753), "33.074324839137084" },
                    { 1, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5769), "33.614274633946906" },
                    { 9, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5785), "98.24328027234378" },
                    { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5800), "50.62168199551486" },
                    { 13, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5878), "37.117447365466276" },
                    { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5896), "26.93865437482131" },
                    { 14, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5912), "73.06281829426607" },
                    { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5927), "44.54390956883962" },
                    { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5943), "11.601396830156192" },
                    { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5580), "10.719940463392566" },
                    { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5597), "54.52686399994367" },
                    { 1, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5613), "95.0985303354591" },
                    { 24, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5630), "39.0364607163208" },
                    { 17, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5645), "35.50644002141048" },
                    { 21, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5661), "75.05819389737549" },
                    { 25, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5676), "32.76401333248883" },
                    { 16, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5690), "90.64454897779532" },
                    { 18, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5706), "65.13297148464163" },
                    { 15, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5722), "36.667085875702895" },
                    { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5402), "71.07848155113138" },
                    { 8, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5417), "92.03295168704615" },
                    { 4, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5433), "76.35030366212087" },
                    { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5450), "38.150038408123784" },
                    { 22, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5483), "13.269162628956863" },
                    { 9, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5500), "79.55158273542206" },
                    { 25, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5515), "62.66501621805088" },
                    { 26, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5530), "90.01784515513422" },
                    { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5547), "85.76378461269069" },
                    { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5563), "63.7781118802839" },
                    { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5239), "92.53355839248302" },
                    { 5, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5255), "19.091446713673097" },
                    { 1, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5272), "31.43437050002258" },
                    { 24, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5290), "39.26587552778264" },
                    { 17, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5307), "31.61098179747783" },
                    { 22, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5322), "12.449396099189645" },
                    { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5338), "29.583269449704694" },
                    { 20, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5354), "38.95854487923017" },
                    { 14, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5372), "14.614053737653398" },
                    { 13, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5388), "44.98257157627227" },
                    { 11, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5076), "45.195621368765075" },
                    { 6, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5095), "63.087221126446735" },
                    { 14, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5110), "76.79057522353716" },
                    { 15, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5127), "92.76731892803718" },
                    { 4, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5143), "41.017778089438835" },
                    { 2, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5159), "31.716372693832227" },
                    { 5, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5176), "68.96872444353384" },
                    { 3, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5192), "56.132105679749486" },
                    { 22, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5207), "25.628438981031522" },
                    { 16, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5223), "77.67476843295418" },
                    { 20, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4886), "82.13780122093802" },
                    { 16, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4903), "82.16536428775674" },
                    { 7, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4919), "49.157096811266015" },
                    { 17, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4935), "87.88118666234614" },
                    { 1, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4950), "65.47101369061264" },
                    { 8, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4967), "85.07528888685749" },
                    { 2, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4984), "81.94982190086537" },
                    { 5, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5001), "91.979353411505" },
                    { 14, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5018), "87.60068465570268" },
                    { 11, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5034), "36.70463736748921" },
                    { 12, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4649), "61.22170190348797" },
                    { 9, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4731), "64.61237042502086" },
                    { 26, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4749), "30.759543224688898" },
                    { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4766), "87.17242382545079" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4783), "25.570806649660042" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4801), "90.31479629521628" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4818), "42.3174854016854" },
                    { 19, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4835), "96.58362329964419" },
                    { 15, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4851), "48.44756087241812" },
                    { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4869), "21.51940503606894" }
                });
        }
    }
}
