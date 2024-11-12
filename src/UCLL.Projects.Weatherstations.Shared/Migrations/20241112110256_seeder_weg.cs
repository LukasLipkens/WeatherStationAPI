using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class seeder_weg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 1, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 2, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 3, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 5, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 11, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 1, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 2, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 4, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 6, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 12, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 1, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 2, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 3, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 7, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 8, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 14, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 1, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 3, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 6, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 7, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 10, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 1, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 2, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 4, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 5, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 9, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "sensor_id", "station_id" },
                keyValues: new object[] { 13, "5" });

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "sensors",
                columns: new[] { "id", "type", "Unit" },
                values: new object[,]
                {
                    { 1, "Temperature-DUMMY", "Celsius" },
                    { 2, "Humidity-DUMMY", "%" },
                    { 3, "Pressure-DUMMY", "hPa" },
                    { 4, "Wind Speed-DUMMY", "m/s" },
                    { 5, "Wind Direction-DUMMY", "Degrees" },
                    { 6, "Rainfall-DUMMY", "mm" },
                    { 7, "UV Index-DUMMY", "Index" },
                    { 8, "Soil Moisture-DUMMY", "%" },
                    { 9, "Solar Radiation-DUMMY", "W/m²" },
                    { 10, "CO2-DUMMY", "ppm" },
                    { 11, "NO2-DUMMY", "ppb" },
                    { 12, "O3-DUMMY", "ppb" },
                    { 13, "PM2.5-DUMMY", "µg/m³" },
                    { 14, "PM10-DUMMY", "µg/m³" }
                });

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "id", "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { "1", 3.7839999999999998, "Dummy weather station with random MAC addresses: 82:1A:7C:4F:B9:23", 34.052199999999999, -118.2437, "WSTATION_821A7C4FB923-DUMMY" },
                    { "2", 4.1529999999999996, "Dummy weather station with random MAC addresses: D3:5F:98:6B:4E:17", -22.9068, -43.172899999999998, "WSTATION_D35F986B4E17-DUMMY" },
                    { "3", null, "Dummy weather station with random MAC addresses: A4:3B:91:5D:C7:2A", 48.8566, 2.3521999999999998, "WSTATION_A43B915DC72A-DUMMY" },
                    { "4", 4.0309999999999997, "Dummy weather station with random MAC addresses: 1F:8E:5A:3C:79:61", 35.689500000000002, 139.6917, "WSTATION_1F8E5A3C7961-DUMMY" },
                    { "5", null, "Dummy weather station with random MAC addresses: 5B:9D:E6:22:F1:08", -33.8688, 151.20930000000001, "WSTATION_5B9DE622F108-DUMMY" }
                });

            migrationBuilder.InsertData(
                table: "station_sensors",
                columns: new[] { "sensor_id", "station_id", "id" },
                values: new object[,]
                {
                    { 1, "1", 1 },
                    { 2, "1", 2 },
                    { 3, "1", 3 },
                    { 5, "1", 4 },
                    { 11, "1", 23 },
                    { 1, "2", 5 },
                    { 2, "2", 6 },
                    { 4, "2", 7 },
                    { 6, "2", 8 },
                    { 12, "2", 24 },
                    { 1, "3", 9 },
                    { 2, "3", 10 },
                    { 3, "3", 11 },
                    { 7, "3", 12 },
                    { 8, "3", 13 },
                    { 14, "3", 25 },
                    { 1, "4", 14 },
                    { 3, "4", 15 },
                    { 6, "4", 16 },
                    { 7, "4", 26 },
                    { 10, "4", 17 },
                    { 1, "5", 18 },
                    { 2, "5", 19 },
                    { 4, "5", 27 },
                    { 5, "5", 20 },
                    { 9, "5", 21 },
                    { 13, "5", 22 }
                });

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
    }
}
