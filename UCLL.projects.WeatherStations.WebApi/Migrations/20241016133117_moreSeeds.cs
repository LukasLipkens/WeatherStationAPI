using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherStationAPI.Migrations
{
    /// <inheritdoc />
    public partial class moreSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 15, 13, 22, 6, 192, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 15, 13, 22, 6, 192, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 16, 7, 22, 6, 192, DateTimeKind.Utc).AddTicks(6629) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 2, new DateTime(2024, 10, 16, 7, 22, 6, 192, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2072), 23.5 },
                    { 1, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2085), 22.5 },
                    { 2, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2082), 60.0 },
                    { 2, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2087), 58.0 },
                    { 1, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2089), 19.199999999999999 },
                    { 1, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2093), 18.199999999999999 },
                    { 2, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2091), 61.0 },
                    { 2, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2096), 57.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2085) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2082) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2087) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2089) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2091) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2096) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2072), 23.5 },
                    { 1, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2085), 22.5 },
                    { 2, 1, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2082), 60.0 },
                    { 2, 1, new DateTime(2024, 10, 15, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2087), 58.0 },
                    { 1, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2089), 19.199999999999999 },
                    { 1, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2093), 18.199999999999999 },
                    { 2, 2, new DateTime(2024, 10, 14, 13, 31, 17, 123, DateTimeKind.Utc).AddTicks(2091), 61.0 },
                    { 2, 2, new DateTime(2024, 10, 16, 7, 31, 17, 123, DateTimeKind.Utc).AddTicks(2096), 57.0 }
                });
        }
    }
}
