using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherStationAPI.Migrations
{
    /// <inheritdoc />
    public partial class PCLukas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 8, 12, 21, 53, 737, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 8, 12, 21, 53, 737, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 9, 6, 21, 53, 737, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 8, 15, 37, 44, 806, DateTimeKind.Utc).AddTicks(8088), 23.5 },
                    { 2, 1, new DateTime(2024, 10, 8, 15, 37, 44, 806, DateTimeKind.Utc).AddTicks(8093), 60.0 },
                    { 1, 2, new DateTime(2024, 10, 9, 9, 37, 44, 806, DateTimeKind.Utc).AddTicks(8094), 18.199999999999999 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 1, new DateTime(2024, 10, 8, 15, 37, 44, 806, DateTimeKind.Utc).AddTicks(8088) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 2, 1, new DateTime(2024, 10, 8, 15, 37, 44, 806, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.DeleteData(
                table: "Measurements",
                keyColumns: new[] { "SensorId", "StationId", "Timestamp" },
                keyValues: new object[] { 1, 2, new DateTime(2024, 10, 9, 9, 37, 44, 806, DateTimeKind.Utc).AddTicks(8094) });

            migrationBuilder.InsertData(
                table: "Measurements",
                columns: new[] { "SensorId", "StationId", "Timestamp", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 8, 12, 21, 53, 737, DateTimeKind.Utc).AddTicks(3148), 23.5 },
                    { 2, 1, new DateTime(2024, 10, 8, 12, 21, 53, 737, DateTimeKind.Utc).AddTicks(3158), 60.0 },
                    { 1, 2, new DateTime(2024, 10, 9, 6, 21, 53, 737, DateTimeKind.Utc).AddTicks(3161), 18.199999999999999 }
                });
        }
    }
}
