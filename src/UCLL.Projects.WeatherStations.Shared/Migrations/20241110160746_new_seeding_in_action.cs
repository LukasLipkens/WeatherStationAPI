using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UCLL.Projects.WeatherStations.Shared.Migrations
{
    /// <inheritdoc />
    public partial class new_seeding_in_action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7845) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7856) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 1, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 2, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 3, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.DeleteData(
                table: "measurements",
                keyColumns: new[] { "station_sensor_id", "timestamp" },
                keyValues: new object[] { 4, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 3, 1, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 4, 2, "2" });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(545), "59.65057600064839" },
                    { 2, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(483), "54.39899395350838" },
                    { 2, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(307), "52.47608994621498" },
                    { 1, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9934), "34.54427116392431" },
                    { 1, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9699), "42.11703034815371" },
                    { 1, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8766), "39.506664214000466" },
                    { 2, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8552), "54.96029877667283" },
                    { 2, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8297), "27.01467995806037" },
                    { 1, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8359), "93.1547950751211" },
                    { 2, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8126), "23.381472936747315" },
                    { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8045), "76.00841852616566" },
                    { 1, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8094), "61.84844772700336" },
                    { 2, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7155), "72.70564507451752" },
                    { 2, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6953), "65.40940056280637" },
                    { 1, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6984), "91.52861602597297" },
                    { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6381), "26.02348286649789" },
                    { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6409), "67.040133541302" },
                    { 2, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6483), "36.351025730430074" },
                    { 1, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6514), "27.552399501830735" },
                    { 1, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5769), "33.614274633946906" },
                    { 1, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5613), "95.0985303354591" },
                    { 1, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5272), "31.43437050002258" },
                    { 2, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5159), "31.716372693832227" },
                    { 1, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4950), "65.47101369061264" },
                    { 2, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4984), "81.94982190086537" }
                });

            migrationBuilder.UpdateData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: "Temperature-DUMMY");

            migrationBuilder.UpdateData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: "Humidity-DUMMY");

            migrationBuilder.InsertData(
                table: "sensors",
                columns: new[] { "id", "type", "Unit" },
                values: new object[,]
                {
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
                table: "station_sensors",
                columns: new[] { "id", "sensor_id", "station_id" },
                values: new object[,]
                {
                    { 5, 1, "2" },
                    { 6, 2, "2" }
                });

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[] { 3.7839999999999998, "Dummy weather station with random MAC addresses: 82:1A:7C:4F:B9:23", 34.052199999999999, -118.2437, "WSTATION_821A7C4FB923-DUMMY" });

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[] { 4.1529999999999996, "Dummy weather station with random MAC addresses: D3:5F:98:6B:4E:17", -22.9068, -43.172899999999998, "WSTATION_D35F986B4E17-DUMMY" });

            migrationBuilder.InsertData(
                table: "stations",
                columns: new[] { "id", "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[,]
                {
                    { "3", null, "Dummy weather station with random MAC addresses: A4:3B:91:5D:C7:2A", 48.8566, 2.3521999999999998, "WSTATION_A43B915DC72A-DUMMY" },
                    { "4", 4.0309999999999997, "Dummy weather station with random MAC addresses: 1F:8E:5A:3C:79:61", 35.689500000000002, 139.6917, "WSTATION_1F8E5A3C7961-DUMMY" },
                    { "5", null, "Dummy weather station with random MAC addresses: 5B:9D:E6:22:F1:08", -33.8688, 151.20930000000001, "WSTATION_5B9DE622F108-DUMMY" }
                });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(276), "10.582672592040518" },
                    { 6, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9952), "60.03084025934544" },
                    { 6, new DateTime(2024, 10, 18, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9303), "57.56045315152356" },
                    { 6, new DateTime(2024, 10, 20, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8992), "86.7279205988687" },
                    { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8615), "56.14602298469828" },
                    { 6, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8750), "23.06561278985499" },
                    { 5, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8781), "44.61909235120725" },
                    { 6, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8569), "90.73250007303442" },
                    { 6, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8265), "90.70178906429005" },
                    { 5, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8280), "59.96397860660448" },
                    { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6719), "74.12765085811915" },
                    { 5, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6824), "19.057856764909133" },
                    { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5402), "71.07848155113138" },
                    { 6, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5547), "85.76378461269069" },
                    { 5, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5255), "19.091446713673097" },
                    { 6, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5095), "63.087221126446735" },
                    { 5, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5176), "68.96872444353384" },
                    { 5, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5001), "91.979353411505" },
                    { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4766), "87.17242382545079" },
                    { 6, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4869), "21.51940503606894" }
                });

            migrationBuilder.InsertData(
                table: "station_sensors",
                columns: new[] { "id", "sensor_id", "station_id" },
                values: new object[,]
                {
                    { 3, 3, "1" },
                    { 4, 5, "1" },
                    { 7, 4, "2" },
                    { 8, 6, "2" },
                    { 9, 1, "3" },
                    { 10, 2, "3" },
                    { 11, 3, "3" },
                    { 12, 7, "3" },
                    { 13, 8, "3" },
                    { 14, 1, "4" },
                    { 15, 3, "4" },
                    { 16, 6, "4" },
                    { 17, 10, "4" },
                    { 18, 1, "5" },
                    { 19, 2, "5" },
                    { 20, 5, "5" },
                    { 21, 9, "5" },
                    { 22, 13, "5" },
                    { 23, 11, "1" },
                    { 24, 12, "2" },
                    { 25, 14, "3" },
                    { 26, 7, "4" },
                    { 27, 4, "5" }
                });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 19, new DateTime(2024, 10, 11, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(529), "62.651028920294564" },
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
                    { 22, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(499), "85.81056381954882" },
                    { 18, new DateTime(2024, 10, 12, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(514), "38.37507909035241" },
                    { 23, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(214), "15.114710781842913" },
                    { 24, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(229), "41.44490674195757" },
                    { 7, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(246), "75.86030155382237" },
                    { 15, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(261), "60.30876050056295" },
                    { 4, new DateTime(2024, 10, 13, 16, 7, 45, 751, DateTimeKind.Utc).AddTicks(291), "43.36251774610009" },
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
                    { 23, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9968), "48.68760782442486" },
                    { 8, new DateTime(2024, 10, 15, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9984), "86.2263195014581" },
                    { 10, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9638), "37.9666738483153" },
                    { 16, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9652), "83.57864733721222" },
                    { 7, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9667), "78.47389722298466" },
                    { 4, new DateTime(2024, 10, 16, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(9683), "70.73537845037188" },
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
                    { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8630), "84.01642764845184" },
                    { 4, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8670), "93.82880920685028" },
                    { 14, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8687), "85.76519645520678" },
                    { 25, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8702), "83.22531221330964" },
                    { 11, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8719), "24.84004140560761" },
                    { 7, new DateTime(2024, 10, 22, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8735), "24.726200114171476" },
                    { 16, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8455), "75.36484616565627" },
                    { 13, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8471), "16.629257012351026" },
                    { 10, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8487), "17.608491330266645" },
                    { 26, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8503), "38.344817267576005" },
                    { 7, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8520), "42.44755861610854" },
                    { 25, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8535), "51.41494087388479" },
                    { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8584), "30.980623390339744" },
                    { 27, new DateTime(2024, 10, 23, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8600), "80.6923436203935" },
                    { 27, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8313), "21.144391821491425" },
                    { 11, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8329), "88.98874600788501" },
                    { 17, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8345), "69.18212115666287" },
                    { 4, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8375), "68.41999418808213" },
                    { 7, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8391), "57.685150298051106" },
                    { 15, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8408), "45.08871532419274" },
                    { 9, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8423), "35.476413195096356" },
                    { 25, new DateTime(2024, 10, 24, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8439), "79.00340652095201" },
                    { 3, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8109), "45.37567530969709" },
                    { 10, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8142), "70.19636026528255" },
                    { 25, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8157), "95.36681542081013" },
                    { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8173), "17.653277685647573" },
                    { 26, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8189), "93.29875667029746" },
                    { 7, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8205), "75.29608433819128" },
                    { 9, new DateTime(2024, 10, 25, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8247), "10.146291169340925" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7948), "55.43837605769154" },
                    { 10, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7964), "60.260671852597234" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7981), "76.75534848384792" },
                    { 25, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7997), "25.61671401317721" },
                    { 21, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8013), "15.473043966572536" },
                    { 17, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8029), "67.95162323993091" },
                    { 7, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8061), "16.946215666095824" },
                    { 12, new DateTime(2024, 10, 26, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(8077), "91.6320424633465" },
                    { 3, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7066), "35.1632332191584" },
                    { 20, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7082), "15.168960461978703" },
                    { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7098), "46.475172498568085" },
                    { 24, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7139), "23.992976890380966" },
                    { 9, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7171), "65.42092250017181" },
                    { 4, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7187), "18.04871871789186" },
                    { 8, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7203), "19.79659122507781" },
                    { 23, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7913), "16.55966532475557" },
                    { 7, new DateTime(2024, 10, 27, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7931), "88.55476258823761" },
                    { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6903), "56.383136482841905" },
                    { 7, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6921), "68.30772206101418" },
                    { 11, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6938), "15.828526578454142" },
                    { 21, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6969), "56.67329624517806" },
                    { 26, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7001), "51.996897585048" },
                    { 13, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7016), "45.48080675758225" },
                    { 24, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7032), "28.41964560940652" },
                    { 4, new DateTime(2024, 10, 28, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(7050), "96.16725579883075" },
                    { 8, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6735), "31.94727149314748" },
                    { 19, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6749), "96.93272369355616" },
                    { 24, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6765), "34.892035270111954" },
                    { 9, new DateTime(2024, 10, 29, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6808), "73.40653591190411" },
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
                    { 14, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6431), "25.101497191122462" },
                    { 23, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6450), "19.43242560335628" },
                    { 15, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6466), "14.544661629016487" },
                    { 26, new DateTime(2024, 10, 31, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(6498), "16.126342182935392" },
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
                    { 9, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5785), "98.24328027234378" },
                    { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5800), "50.62168199551486" },
                    { 13, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5878), "37.117447365466276" },
                    { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5896), "26.93865437482131" },
                    { 14, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5912), "73.06281829426607" },
                    { 11, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5927), "44.54390956883962" },
                    { 19, new DateTime(2024, 11, 3, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5943), "11.601396830156192" },
                    { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5580), "10.719940463392566" },
                    { 12, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5597), "54.52686399994367" },
                    { 24, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5630), "39.0364607163208" },
                    { 17, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5645), "35.50644002141048" },
                    { 21, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5661), "75.05819389737549" },
                    { 25, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5676), "32.76401333248883" },
                    { 16, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5690), "90.64454897779532" },
                    { 18, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5706), "65.13297148464163" },
                    { 15, new DateTime(2024, 11, 4, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5722), "36.667085875702895" },
                    { 8, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5417), "92.03295168704615" },
                    { 4, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5433), "76.35030366212087" },
                    { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5450), "38.150038408123784" },
                    { 22, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5483), "13.269162628956863" },
                    { 9, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5500), "79.55158273542206" },
                    { 25, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5515), "62.66501621805088" },
                    { 26, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5530), "90.01784515513422" },
                    { 10, new DateTime(2024, 11, 5, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5563), "63.7781118802839" },
                    { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5239), "92.53355839248302" },
                    { 24, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5290), "39.26587552778264" },
                    { 17, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5307), "31.61098179747783" },
                    { 22, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5322), "12.449396099189645" },
                    { 15, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5338), "29.583269449704694" },
                    { 20, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5354), "38.95854487923017" },
                    { 14, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5372), "14.614053737653398" },
                    { 13, new DateTime(2024, 11, 6, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5388), "44.98257157627227" },
                    { 11, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5076), "45.195621368765075" },
                    { 14, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5110), "76.79057522353716" },
                    { 15, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5127), "92.76731892803718" },
                    { 4, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5143), "41.017778089438835" },
                    { 3, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5192), "56.132105679749486" },
                    { 22, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5207), "25.628438981031522" },
                    { 16, new DateTime(2024, 11, 7, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5223), "77.67476843295418" },
                    { 20, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4886), "82.13780122093802" },
                    { 16, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4903), "82.16536428775674" },
                    { 7, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4919), "49.157096811266015" },
                    { 17, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4935), "87.88118666234614" },
                    { 8, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4967), "85.07528888685749" },
                    { 14, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5018), "87.60068465570268" },
                    { 11, new DateTime(2024, 11, 8, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(5034), "36.70463736748921" },
                    { 12, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4649), "61.22170190348797" },
                    { 9, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4731), "64.61237042502086" },
                    { 26, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4749), "30.759543224688898" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4783), "25.570806649660042" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4801), "90.31479629521628" },
                    { 18, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4818), "42.3174854016854" },
                    { 19, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4835), "96.58362329964419" },
                    { 15, new DateTime(2024, 11, 9, 16, 7, 45, 750, DateTimeKind.Utc).AddTicks(4851), "48.44756087241812" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 3, 3, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 4, 5, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 5, 1, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 6, 2, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 7, 4, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 8, 6, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 9, 1, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 10, 2, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 11, 3, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 12, 7, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 13, 8, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 14, 1, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 15, 3, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 16, 6, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 17, 10, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 18, 1, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 19, 2, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 20, 5, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 21, 9, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 22, 13, "5" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 23, 11, "1" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 24, 12, "2" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 25, 14, "3" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 26, 7, "4" });

            migrationBuilder.DeleteData(
                table: "station_sensors",
                keyColumns: new[] { "id", "sensor_id", "station_id" },
                keyValues: new object[] { 27, 4, "5" });

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
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "stations",
                keyColumn: "id",
                keyValue: "5");

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7845), "23.5" },
                    { 2, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7856), "60" },
                    { 1, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857), "22.5" },
                    { 2, new DateTime(2024, 11, 9, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7857), "58" }
                });

            migrationBuilder.UpdateData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 1,
                column: "type",
                value: "Temperature");

            migrationBuilder.UpdateData(
                table: "sensors",
                keyColumn: "id",
                keyValue: 2,
                column: "type",
                value: "Humidity");

            migrationBuilder.InsertData(
                table: "station_sensors",
                columns: new[] { "id", "sensor_id", "station_id" },
                values: new object[,]
                {
                    { 3, 1, "2" },
                    { 4, 2, "2" }
                });

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "id",
                keyValue: "1",
                columns: new[] { "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[] { null, "Weather station in New York", 40.712800000000001, -74.006, "Station A" });

            migrationBuilder.UpdateData(
                table: "stations",
                keyColumn: "id",
                keyValue: "2",
                columns: new[] { "battery_level", "description", "latitude", "longitude", "name" },
                values: new object[] { null, "Weather station in Los Angeles", 34.052199999999999, -118.2437, "Station B" });

            migrationBuilder.InsertData(
                table: "measurements",
                columns: new[] { "station_sensor_id", "timestamp", "sensor_value" },
                values: new object[,]
                {
                    { 3, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7858), "19.2" },
                    { 4, new DateTime(2024, 11, 8, 13, 51, 58, 505, DateTimeKind.Utc).AddTicks(7859), "61" },
                    { 3, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7860), "18.2" },
                    { 4, new DateTime(2024, 11, 10, 7, 51, 58, 505, DateTimeKind.Utc).AddTicks(7861), "57" }
                });
        }
    }
}
