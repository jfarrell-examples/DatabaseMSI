using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseMsiTest.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherForecasts",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { new Guid("189a072c-2774-4181-bccf-142a063b6ec8"), new DateTime(2020, 7, 28, 22, 14, 11, 886, DateTimeKind.Local).AddTicks(4085), "Freezing", 10 },
                    { new Guid("6ff28f3a-fd45-4a5a-a82f-0b4e73c2127f"), new DateTime(2020, 7, 29, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9699), "Bracing", 20 },
                    { new Guid("7bfe2d43-048f-468e-8c69-2d8c96e3e0b6"), new DateTime(2020, 7, 30, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9766), "Chilly", 30 },
                    { new Guid("83526076-b3d6-4c5d-808f-d9620c8c90f4"), new DateTime(2020, 7, 31, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9784), "Cool", 40 },
                    { new Guid("e54d2ebe-ab19-463f-909e-2894cd2a15e1"), new DateTime(2020, 8, 1, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9800), "Mild", 50 },
                    { new Guid("91c7025f-f666-4d5e-b64e-b1053401e53f"), new DateTime(2020, 8, 2, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9816), "Warm", 60 },
                    { new Guid("a466c1f3-b6b2-4478-bf05-ac4df7dba1bc"), new DateTime(2020, 8, 3, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9831), "Balmy", 70 },
                    { new Guid("80d733e4-651d-45c4-99b8-1b537edac925"), new DateTime(2020, 8, 4, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9847), "Hot", 80 },
                    { new Guid("c8cdd6a4-6402-4ca7-9c11-17dc5e941793"), new DateTime(2020, 8, 5, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9863), "Sweltering", 90 },
                    { new Guid("16e7f670-840c-4758-a796-2927fa253cc3"), new DateTime(2020, 8, 6, 22, 14, 11, 889, DateTimeKind.Local).AddTicks(9878), "Scorching", 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("16e7f670-840c-4758-a796-2927fa253cc3"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("189a072c-2774-4181-bccf-142a063b6ec8"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("6ff28f3a-fd45-4a5a-a82f-0b4e73c2127f"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("7bfe2d43-048f-468e-8c69-2d8c96e3e0b6"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("80d733e4-651d-45c4-99b8-1b537edac925"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("83526076-b3d6-4c5d-808f-d9620c8c90f4"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("91c7025f-f666-4d5e-b64e-b1053401e53f"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("a466c1f3-b6b2-4478-bf05-ac4df7dba1bc"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("c8cdd6a4-6402-4ca7-9c11-17dc5e941793"));

            migrationBuilder.DeleteData(
                table: "WeatherForecasts",
                keyColumn: "Id",
                keyValue: new Guid("e54d2ebe-ab19-463f-909e-2894cd2a15e1"));
        }
    }
}
