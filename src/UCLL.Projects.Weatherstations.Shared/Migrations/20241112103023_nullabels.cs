using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class nullabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "longitude",
                table: "stations",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "latitude",
                table: "stations",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 24, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5174), "90.87712173988487" },
                    { 10, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5188), "30.36879773906003" },
                    { 2, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5203), "19.910866088305877" },
                    { 3, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5219), "61.151767234461865" },
                    { 22, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5233), "25.552449189095825" },
                    { 8, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5249), "88.32559705343982" },
                    { 18, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5264), "22.475614131187804" },
                    { 4, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5280), "36.31636691988813" },
                    { 17, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5294), "53.02361413077788" },
                    { 25, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5308), "80.22009404887797" },
                    { 5, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5374), "24.986860442411015" },
                    { 6, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5390), "94.03636741158599" },
                    { 12, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5405), "97.37259310706341" },
                    { 4, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4965), "92.06359483190178" },
                    { 14, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4980), "79.05064254826303" },
                    { 1, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4995), "85.3113063768412" },
                    { 9, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5010), "65.93934065617896" },
                    { 5, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5025), "34.17479904752731" },
                    { 7, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5040), "51.97132795127222" },
                    { 18, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5055), "58.04137840155078" },
                    { 8, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5070), "72.06197229989476" },
                    { 26, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5084), "14.654683804042072" },
                    { 7, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5099), "91.91213781488311" },
                    { 19, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5114), "44.97197899475309" },
                    { 20, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5129), "35.38650300305014" },
                    { 23, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5144), "77.20517535095603" },
                    { 13, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5158), "44.24260008160135" },
                    { 24, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4681), "67.32337627307545" },
                    { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4696), "58.57056794165889" },
                    { 26, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4710), "56.5717780356716" },
                    { 17, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4725), "27.78477879968556" },
                    { 17, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4740), "52.82202910160839" },
                    { 20, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4755), "18.28580899215081" },
                    { 23, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4770), "73.59186429441361" },
                    { 7, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4785), "61.61339546278178" },
                    { 27, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4799), "13.88729118698409" },
                    { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4813), "19.785985622533364" },
                    { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4828), "26.062027029581493" },
                    { 4, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4843), "77.11215502209598" },
                    { 1, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4858), "85.14769077054937" },
                    { 13, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4872), "86.56203954138894" },
                    { 24, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4887), "30.55311002158047" },
                    { 13, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4949), "33.56093815406802" },
                    { 21, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4207), "95.70883062486409" },
                    { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4222), "34.24235131801045" },
                    { 1, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4237), "34.41337545731173" },
                    { 9, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4252), "42.70597060379246" },
                    { 4, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4267), "31.17848702873819" },
                    { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4282), "77.11441396057174" },
                    { 6, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4296), "36.940117754619116" },
                    { 20, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4527), "37.58515621912869" },
                    { 1, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4543), "14.527018596046553" },
                    { 22, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4558), "99.16718355179306" },
                    { 2, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4573), "54.83887238120025" },
                    { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4589), "97.71241988318107" },
                    { 3, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4604), "63.53167368430289" },
                    { 5, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4620), "55.12245825046907" },
                    { 12, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4636), "56.63077412223171" },
                    { 2, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4650), "84.26801633959755" },
                    { 24, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4666), "96.11517118064535" },
                    { 20, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3953), "78.10862172724434" },
                    { 17, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3967), "32.42437596415925" },
                    { 10, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3981), "13.568745533550828" },
                    { 4, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3997), "71.30562117687668" },
                    { 9, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4011), "16.595179624825143" },
                    { 16, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4027), "18.662393449024723" },
                    { 14, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4042), "76.56063971671287" },
                    { 4, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4058), "14.516588053125254" },
                    { 3, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4073), "60.71267359146806" },
                    { 24, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4087), "84.06845260587825" },
                    { 6, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4102), "75.17957544747081" },
                    { 5, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4118), "45.99639973824852" },
                    { 13, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4133), "95.45197968633236" },
                    { 8, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4148), "58.977533150320376" },
                    { 2, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4163), "62.87569656565419" },
                    { 2, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4177), "74.79312959792848" },
                    { 7, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4192), "97.7314086812956" },
                    { 14, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3610), "36.7860535068978" },
                    { 10, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3626), "62.528337862883646" },
                    { 12, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3641), "91.5679911360965" },
                    { 6, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3656), "65.95622315017246" },
                    { 19, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3670), "11.519556348646661" },
                    { 5, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3685), "65.02166251988675" },
                    { 20, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3700), "85.54464858052883" },
                    { 8, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3715), "28.22438272560772" },
                    { 27, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3730), "33.99931913321715" },
                    { 14, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3743), "68.0484924080686" },
                    { 1, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3937), "53.76661068222434" },
                    { 24, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3283), "21.300771605504536" },
                    { 16, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3299), "50.559215781117885" },
                    { 5, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3314), "89.43531100196591" },
                    { 17, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3497), "72.09523311374042" },
                    { 25, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3521), "37.5624848948442" },
                    { 10, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3535), "92.84414589027486" },
                    { 21, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3550), "96.3759279377223" },
                    { 12, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3565), "12.537883995674274" },
                    { 9, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3580), "94.20090559660316" },
                    { 21, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3595), "81.55264570861931" },
                    { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2852), "16.756181839347764" },
                    { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2867), "22.570497654414822" },
                    { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2881), "19.019661957639364" },
                    { 15, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2897), "22.98031156417489" },
                    { 14, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2912), "16.56943658203986" },
                    { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2927), "25.912758979282778" },
                    { 17, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2942), "76.9466684909144" },
                    { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2957), "63.61754565608923" },
                    { 18, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2973), "61.35815853221646" },
                    { 5, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2988), "43.90171267288758" },
                    { 21, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3003), "34.60758517756798" },
                    { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3017), "20.736487982140055" },
                    { 9, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3033), "75.85926044523515" },
                    { 22, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3048), "78.79791042713605" },
                    { 26, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3062), "22.887907034610464" },
                    { 26, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3078), "47.38061633541995" },
                    { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3093), "24.75647737568309" },
                    { 17, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3108), "39.361519551333785" },
                    { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3222), "90.21180549751301" },
                    { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3238), "11.25757967275321" },
                    { 19, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3253), "60.38600553571212" },
                    { 2, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3268), "32.59514882062948" },
                    { 24, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2562), "38.15251909758091" },
                    { 25, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2577), "23.197341668368296" },
                    { 8, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2593), "41.87607117975763" },
                    { 1, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2608), "18.659908928465025" },
                    { 22, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2623), "68.4276517612586" },
                    { 1, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2745), "20.936242844880166" },
                    { 16, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2762), "19.748831816744186" },
                    { 17, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2778), "80.3194808898628" },
                    { 15, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2793), "63.73733912153017" },
                    { 26, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2807), "55.32633257094583" },
                    { 14, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2822), "45.119696424601116" },
                    { 14, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2837), "92.58711806362179" },
                    { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2325), "10.79022383488219" },
                    { 20, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2339), "45.38285605962758" },
                    { 7, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2354), "94.7336000951235" },
                    { 27, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2368), "48.49372573208247" },
                    { 10, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2383), "63.9223623236862" },
                    { 22, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2398), "81.95494888354968" },
                    { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2413), "81.22916089311633" },
                    { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2428), "28.08117315363047" },
                    { 4, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2443), "10.181031414952876" },
                    { 5, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2458), "90.22118671187174" },
                    { 23, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2473), "83.73540629127967" },
                    { 17, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2487), "70.0842589071644" },
                    { 13, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2502), "78.45510388965171" },
                    { 22, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2516), "56.727881259029324" },
                    { 23, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2532), "47.711959496758396" },
                    { 20, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2547), "17.676724684804892" },
                    { 8, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2050), "51.9208311804167" },
                    { 3, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2064), "69.60557774057057" },
                    { 26, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2078), "25.706694898851858" },
                    { 14, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2093), "95.53959368959516" },
                    { 19, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2108), "17.11032863597046" },
                    { 20, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2123), "45.43186611643232" },
                    { 8, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2137), "92.30676089211842" },
                    { 3, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2152), "84.66580922790381" },
                    { 15, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2166), "76.37466379802156" },
                    { 24, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2181), "57.917244324735876" },
                    { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2196), "50.14878602469896" },
                    { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2265), "82.34762480708474" },
                    { 12, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2281), "44.31863947100446" },
                    { 2, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2295), "91.67833993175978" },
                    { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2310), "66.26426656643648" },
                    { 4, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1779), "96.48823731305785" },
                    { 6, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1841), "11.468517373737816" },
                    { 8, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1858), "38.67238519983442" },
                    { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1873), "76.82588329242421" },
                    { 6, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1888), "68.98442401242028" },
                    { 15, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1903), "61.75612732438581" },
                    { 12, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1917), "81.32165457232587" },
                    { 11, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1932), "44.66856489761548" },
                    { 24, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1948), "27.556085197392115" },
                    { 10, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1963), "87.31619915962251" },
                    { 9, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1977), "92.16114242881683" },
                    { 18, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1992), "95.78614262416153" },
                    { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2007), "29.966810701114767" },
                    { 25, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2021), "62.2847856810114" },
                    { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2036), "52.41183750001645" },
                    { 24, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1453), "15.721207771646327" },
                    { 20, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1525), "35.64541372832285" },
                    { 23, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1541), "88.0079452069476" },
                    { 22, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1556), "88.35963724881523" },
                    { 14, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1570), "39.196671085228445" },
                    { 17, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1586), "77.10629086911509" },
                    { 3, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1601), "22.782406377483177" },
                    { 26, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1616), "97.95419609464868" },
                    { 6, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1630), "62.93669354808736" },
                    { 26, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1646), "52.751453213844705" },
                    { 1, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1662), "16.777348866996935" },
                    { 23, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1677), "47.971763407127526" },
                    { 13, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1692), "34.631524091571364" },
                    { 22, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1707), "77.8555775582409" },
                    { 5, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1721), "15.902031991899026" },
                    { 6, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1735), "72.63715816114296" },
                    { 4, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1750), "24.027177155948788" },
                    { 21, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1765), "81.24658288946961" },
                    { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1261), "17.29794710483398" },
                    { 15, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1276), "25.848783263265112" },
                    { 21, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1291), "99.60928449334597" },
                    { 18, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1305), "58.28029082233465" },
                    { 4, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1320), "43.849955055374664" },
                    { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1335), "52.55542085125718" },
                    { 10, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1350), "78.57242942870377" },
                    { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1366), "75.9641572615486" },
                    { 16, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1380), "23.412410434863133" },
                    { 4, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1395), "94.67792659314965" },
                    { 25, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1409), "45.33447972210258" },
                    { 24, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1424), "80.39054176894095" },
                    { 16, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1438), "82.06711399380418" },
                    { 11, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1001), "53.070618508230496" },
                    { 8, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1016), "64.82778037498053" },
                    { 20, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1031), "60.83433395854555" },
                    { 3, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1046), "56.48877200879639" },
                    { 17, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1060), "19.799313998994812" },
                    { 27, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1075), "39.721090396182085" },
                    { 1, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1090), "65.63257680709383" },
                    { 3, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1105), "95.90838259595667" },
                    { 16, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1119), "33.211716590713806" },
                    { 25, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1184), "50.47075318476277" },
                    { 18, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1200), "18.15316879898992" },
                    { 24, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1215), "28.61089176054933" },
                    { 26, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1230), "18.99027641094013" },
                    { 19, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1245), "34.54223248521143" },
                    { 1, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(760), "74.92500500975818" },
                    { 2, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(779), "29.62724308982732" },
                    { 8, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(793), "71.80846782163971" },
                    { 17, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(808), "91.07580836351234" },
                    { 2, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(823), "49.037389274164774" },
                    { 12, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(839), "85.23923911406672" },
                    { 13, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(853), "32.06788071086401" },
                    { 6, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(868), "16.419105044321856" },
                    { 19, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(883), "46.356540502357696" },
                    { 11, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(898), "37.146351071528045" },
                    { 12, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(912), "46.789585362353364" },
                    { 19, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(927), "28.80448810969783" },
                    { 15, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(941), "48.83624591402628" },
                    { 20, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(957), "61.2483695763865" },
                    { 1, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(971), "67.30666481874911" },
                    { 26, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(986), "50.11683264770126" },
                    { 24, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(534), "37.47723374195385" },
                    { 12, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(549), "65.24591884282609" },
                    { 27, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(564), "87.35467074696713" },
                    { 3, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(579), "76.86252594964768" },
                    { 22, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(594), "53.204465799787194" },
                    { 1, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(609), "30.525073490315513" },
                    { 16, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(624), "20.723107746689024" },
                    { 4, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(639), "64.85839903092423" },
                    { 17, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(654), "22.302023644616842" },
                    { 5, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(668), "71.4629653709384" },
                    { 21, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(683), "28.393253749895937" },
                    { 26, new DateTime(2024, 10, 30, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9853), "37.983330509840115" },
                    { 5, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(151), "77.53384558630955" },
                    { 10, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(167), "13.85528383818674" },
                    { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(181), "68.2249968892699" },
                    { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(195), "68.01842130821291" },
                    { 17, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(209), "62.17909290313999" },
                    { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(223), "91.57880357717741" },
                    { 8, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(237), "86.60458742743893" },
                    { 3, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(251), "45.00221395712047" },
                    { 25, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(341), "78.68497224809812" },
                    { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(356), "62.67710474985161" },
                    { 26, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(370), "16.73467836354384" },
                    { 1, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(384), "20.05887499748905" },
                    { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(398), "76.87249015959304" },
                    { 5, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(412), "92.96644704151461" },
                    { 8, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(427), "93.2981824490679" },
                    { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(442), "21.408791558210282" },
                    { 3, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(457), "15.769395957613131" },
                    { 23, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(472), "36.206026404405975" },
                    { 11, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(488), "51.19360136336513" },
                    { 24, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(504), "19.38557186621843" },
                    { 23, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(519), "59.52707314414742" },
                    { 22, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9652), "32.20242112144005" },
                    { 11, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9668), "38.91425272131771" },
                    { 1, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9683), "88.86369817769027" },
                    { 17, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9699), "11.825336360126137" },
                    { 24, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9714), "54.02675551086573" },
                    { 1, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9730), "13.171763480341609" },
                    { 12, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9746), "87.98815057636814" },
                    { 24, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9760), "56.396629461313495" },
                    { 25, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9777), "51.73891612925735" },
                    { 6, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9792), "25.588319535041787" },
                    { 12, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9808), "12.509546168972719" },
                    { 3, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9823), "25.537143179398925" },
                    { 9, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9838), "87.20599092751064" },
                    { 22, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7270), "93.43958574564141" },
                    { 6, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7285), "57.21350727468618" },
                    { 25, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7300), "20.55363219310226" },
                    { 22, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7316), "85.01614168414281" },
                    { 2, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7330), "80.07184064841269" },
                    { 6, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7345), "70.68123658786854" },
                    { 7, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7361), "79.70329042998664" },
                    { 5, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7375), "20.276208341064045" },
                    { 10, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7391), "20.754617140047753" },
                    { 18, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7407), "60.1895048224053" },
                    { 14, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7421), "74.02338336802221" },
                    { 17, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7436), "27.050122253077557" },
                    { 26, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7537), "70.04369234069057" },
                    { 27, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9629), "50.87413698370656" },
                    { 5, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7091), "36.96875418720625" },
                    { 4, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7105), "31.48660359341527" },
                    { 8, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7120), "47.5857075513203" },
                    { 23, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7135), "93.63206322199875" },
                    { 12, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7150), "54.82082438586037" },
                    { 7, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7165), "83.43526855150202" },
                    { 23, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7179), "29.282799091745794" },
                    { 8, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7194), "10.42384311951205" },
                    { 14, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7208), "14.436470425050839" },
                    { 4, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7223), "20.38441113523358" },
                    { 26, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7239), "58.812658494730805" },
                    { 6, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7255), "64.15087127904704" },
                    { 22, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6684), "60.38584033563922" },
                    { 10, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6699), "65.00314891994132" },
                    { 7, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6714), "19.352821500834352" },
                    { 2, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6730), "34.17883709421117" },
                    { 22, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6745), "72.70446889434727" },
                    { 8, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6761), "95.59808295543901" },
                    { 5, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6776), "13.475543272204977" },
                    { 6, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6791), "94.82954193684537" },
                    { 21, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6805), "76.63462491523987" },
                    { 14, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6821), "11.549080783554452" },
                    { 2, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6835), "31.514946074652844" },
                    { 19, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6850), "90.60308706353653" },
                    { 15, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6865), "84.71823985901254" },
                    { 17, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6880), "92.9042493849891" },
                    { 20, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6895), "93.54984260087708" },
                    { 26, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6910), "70.51943502215016" },
                    { 12, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7075), "58.46111320123916" },
                    { 17, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6240), "62.56746940128633" },
                    { 23, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6255), "96.49623549372336" },
                    { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6270), "26.895201943881208" },
                    { 27, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6285), "63.82144902075668" },
                    { 19, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6299), "63.51796832009843" },
                    { 18, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6314), "75.8456575846655" },
                    { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6329), "13.998259426433279" },
                    { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6344), "91.23467467552342" },
                    { 22, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6358), "89.86832070035715" },
                    { 10, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6374), "74.83287573050097" },
                    { 27, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6390), "18.620402041917906" },
                    { 19, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6405), "83.7740421132152" },
                    { 25, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6419), "43.54791256779204" },
                    { 15, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6434), "48.81697955134803" },
                    { 23, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6449), "14.457155722173908" },
                    { 24, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6464), "86.10894235002807" },
                    { 12, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6638), "24.332919603284587" },
                    { 26, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6654), "15.438596308057637" },
                    { 25, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6669), "71.57784680643479" },
                    { 26, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5938), "99.55295777129453" },
                    { 4, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5953), "94.91961441504068" },
                    { 6, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5968), "38.1709926172224" },
                    { 25, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5983), "36.20928029644176" },
                    { 7, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6101), "38.85631284294842" },
                    { 12, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6119), "39.7266154760714" },
                    { 10, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6134), "68.0535846022458" },
                    { 26, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6149), "47.228092365772156" },
                    { 24, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6164), "22.119383354972413" },
                    { 24, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6179), "26.344300974833736" },
                    { 14, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6194), "66.78609265830764" },
                    { 12, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6210), "85.02772815074304" },
                    { 10, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6225), "62.799884262324916" },
                    { 3, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5741), "78.1044750661968" },
                    { 15, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5757), "90.7732359278303" },
                    { 8, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5772), "35.12729210624666" },
                    { 3, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5787), "31.856679950721944" },
                    { 7, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5802), "70.29026852331039" },
                    { 25, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5817), "48.87035576364518" },
                    { 22, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5832), "41.43353557489916" },
                    { 5, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5847), "54.22553369285103" },
                    { 21, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5862), "70.89496191949918" },
                    { 24, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5877), "73.82459507013253" },
                    { 26, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5893), "60.79690357921712" },
                    { 25, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5908), "69.13647364390313" },
                    { 1, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5923), "54.166824171368894" },
                    { 9, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5326), "64.11560796956084" },
                    { 9, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5342), "11.19230071680813" },
                    { 6, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5357), "58.94329671655064" },
                    { 21, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5373), "44.635642403441224" },
                    { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5388), "76.49887914890718" },
                    { 22, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5402), "66.82418830745345" },
                    { 2, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5417), "55.79602353676157" },
                    { 24, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5431), "71.63904966271039" },
                    { 24, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5447), "51.71777797492395" },
                    { 7, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5618), "91.25254696570211" },
                    { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5635), "29.475494961433675" },
                    { 12, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5650), "94.02061292129424" },
                    { 26, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5667), "13.742718156487273" },
                    { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5681), "38.2194923278377" },
                    { 23, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5696), "44.54928271156262" },
                    { 3, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5711), "43.92094619068386" },
                    { 20, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5726), "51.404474196102704" },
                    { 24, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4913), "14.94047919833682" },
                    { 25, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4929), "41.319947579247426" },
                    { 15, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4945), "54.327758941570224" },
                    { 21, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4960), "19.750212086535747" },
                    { 20, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4974), "57.724276561393786" },
                    { 22, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5149), "29.101259431676137" },
                    { 3, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5164), "92.96670803044333" },
                    { 17, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5179), "54.49161879447126" },
                    { 2, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5193), "52.75587105458375" },
                    { 1, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5208), "39.29774183953511" },
                    { 16, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5223), "98.25062886083936" },
                    { 15, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5237), "96.0313904740273" },
                    { 21, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5252), "38.14812407441736" },
                    { 22, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5267), "56.81196290352766" },
                    { 9, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5282), "38.16545261550114" },
                    { 19, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5297), "20.912706564743125" },
                    { 23, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5311), "54.25204486332422" },
                    { 6, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4711), "44.62431295561365" },
                    { 27, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4729), "96.48985558820333" },
                    { 19, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4745), "35.59944492823956" },
                    { 15, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4762), "50.15562718871348" },
                    { 17, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4777), "20.396387923508296" },
                    { 19, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4792), "74.9881607212167" },
                    { 27, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4807), "62.088370118033986" },
                    { 7, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4823), "27.925330643446895" },
                    { 15, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4838), "19.382033938670887" },
                    { 24, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4853), "29.230225457091727" },
                    { 8, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4868), "89.08989204418121" },
                    { 11, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4883), "15.657092693382639" },
                    { 7, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4898), "41.783420064011324" },
                    { 9, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4292), "49.864227183542134" },
                    { 22, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4308), "24.408558636984466" },
                    { 4, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4323), "26.993150455719977" },
                    { 14, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4337), "20.634662352426886" },
                    { 8, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4353), "58.07631342914014" },
                    { 10, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4367), "35.58273467328863" },
                    { 11, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4382), "15.429411957608671" },
                    { 4, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4396), "80.61503765687912" },
                    { 16, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4410), "10.627342502220696" },
                    { 6, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4636), "63.608328779212385" },
                    { 17, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4651), "42.06397980695251" },
                    { 20, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4666), "75.40626769372734" },
                    { 2, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4682), "91.16201693444589" },
                    { 25, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4696), "78.22264933820406" },
                    { 1, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3572), "79.21444039366875" },
                    { 17, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3826), "34.69221435387882" },
                    { 15, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3844), "61.49637385104126" },
                    { 20, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3863), "30.832114596225452" },
                    { 3, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4066), "73.91627672421387" },
                    { 4, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4088), "20.043037429159348" },
                    { 13, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4104), "93.8535309197903" },
                    { 26, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4121), "67.09057176459862" },
                    { 1, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4136), "17.673077266350585" },
                    { 5, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4153), "14.655541759144747" },
                    { 4, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4169), "27.413177912168255" },
                    { 17, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4184), "77.46335026276884" },
                    { 13, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4199), "54.90589269749833" },
                    { 14, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4214), "13.468044604116947" },
                    { 22, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4228), "91.00900893681452" },
                    { 6, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4244), "78.25927581865358" },
                    { 8, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4260), "48.39751756067982" },
                    { 14, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4276), "79.14574571417118" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5249) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5390) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 13, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5025) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5055) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5084) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5099) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5114) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5129) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 14, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(5158) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4813) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4828) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4872) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 15, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4949) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4237) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4267) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4296) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4558) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4620) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 16, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3953) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4133) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 17, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(4192) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3700) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3743) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 18, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3535) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3580) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 19, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2852) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2881) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2897) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2957) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3003) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3048) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3062) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3222) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 20, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2623) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2745) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2762) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2822) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 21, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2339) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2368) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2398) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2487) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2532) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 22, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2064) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2078) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2108) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 23, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1903) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 24, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1453) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1541) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1556) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1586) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1601) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1646) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1662) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1677) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1692) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1707) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1750) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 25, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1261) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1276) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1424) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 26, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1438) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1016) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1031) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1075) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1105) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 27, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(779) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(912) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 28, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(986) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(534) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(609) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(624) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 10, 29, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(683) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 30, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(209) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(223) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(251) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(341) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(356) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(384) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(472) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 10, 30, 10, 30, 23, 118, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9714) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9808) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 10, 31, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7345) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7407) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7421) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7436) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 1, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(9629) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7179) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7239) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 2, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6714) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6730) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6761) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6895) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 3, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6255) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6285) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 18, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6314) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6374) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6405) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6449) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6464) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6638) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 4, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6669) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5983) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6119) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6134) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6210) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 5, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(6225) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5757) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5772) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5802) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5817) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5862) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 6, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5342) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5357) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5388) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5431) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 12, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 7, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4945) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5164) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5179) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5208) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 21, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5252) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5267) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5282) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5297) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 23, new DateTime(2024, 11, 8, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4777) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 19, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 27, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 24, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 7, new DateTime(2024, 11, 9, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 9, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4308) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 10, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 11, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4396) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 16, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4651) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 25, new DateTime(2024, 11, 10, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3572) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 15, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 20, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4088) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 26, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4121) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4136) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 5, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4169) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 17, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 13, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4214) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 22, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 6, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 8, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 14, new DateTime(2024, 11, 11, 10, 30, 23, 117, DateTimeKind.Utc).AddTicks(4276) });

            migrationBuilder.AlterColumn<double>(
                name: "longitude",
                table: "stations",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "latitude",
                table: "stations",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

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
    }
}
