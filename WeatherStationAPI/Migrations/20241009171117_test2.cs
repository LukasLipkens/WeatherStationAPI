using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherStationAPI.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 8, 17, 8, 35, 312, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 8, 17, 8, 35, 312, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 9, 11, 8, 35, 312, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 8, 17, 11, 17, 622, DateTimeKind.Utc).AddTicks(7682), 23.5 },
                    { 2, 1, new DateTime(2024, 10, 8, 17, 11, 17, 622, DateTimeKind.Utc).AddTicks(7686), 60.0 },
                    { 1, 2, new DateTime(2024, 10, 9, 11, 11, 17, 622, DateTimeKind.Utc).AddTicks(7687), 18.199999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 8, 17, 11, 17, 622, DateTimeKind.Utc).AddTicks(7682) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 8, 17, 11, 17, 622, DateTimeKind.Utc).AddTicks(7686) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 9, 11, 11, 17, 622, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 8, 17, 8, 35, 312, DateTimeKind.Utc).AddTicks(7834), 23.5 },
                    { 2, 1, new DateTime(2024, 10, 8, 17, 8, 35, 312, DateTimeKind.Utc).AddTicks(7839), 60.0 },
                    { 1, 2, new DateTime(2024, 10, 9, 11, 8, 35, 312, DateTimeKind.Utc).AddTicks(7840), 18.199999999999999 }
                });
        }
    }
}
