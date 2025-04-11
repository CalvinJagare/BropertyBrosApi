using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class seedDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Lägenhet" },
                    { 2, "Villa" },
                    { 3, "Radhus" },
                    { 4, "Bostadsrätt" },
                    { 5, "Hyresrätt" },
                    { 6, "Fritidshus" },
                    { 7, "Stuga" },
                    { 8, "Kollektivboende" },
                    { 9, "Studentboende" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName" },
                values: new object[,]
                {
                    { 1, "Stockholm" },
                    { 2, "Göteborg" },
                    { 3, "Malmö" },
                    { 4, "Uppsala" },
                    { 5, "Luleå" },
                    { 6, "Örebro" }
                });

            migrationBuilder.InsertData(
                table: "RealtorFirms",
                columns: new[] { "Id", "CompanyName", "Description", "LogoUrl", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "Broperty Bros", "En modern mäklarfirma med fokus på teknik och AI.", "https://example.com/logos/bropertybros.png", "https://bropertybros.se" },
                    { 2, "Mäklarkompaniet", "Traditionellt kunnande, moderna lösningar.", "https://example.com/logos/maklarkompaniet.png", "https://maklarkompaniet.se" },
                    { 3, "Fastighetsmästarna", "Specialister på bostäder i hela Sverige.", "https://example.com/logos/fastighetsmastarna.png", "https://fastighetsmastarna.se" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "ProfileUrl", "RealtorFirmId" },
                values: new object[,]
                {
                    { 1, "markus@bropertybros.se", "Markus", "Friberg", "0705712647", "https://example.com/profiles/markus.png", 1 },
                    { 2, "sanna@bropertybros.se", "Sanna", "Mäklarsson", "0731234567", "https://example.com/profiles/sanna.png", 1 },
                    { 3, "erik@maklarkompaniet.se", "Erik", "Fast", "0704455667", "https://example.com/profiles/erik.png", 2 },
                    { 4, "anna@fastighetsmastarna.se", "Anna", "Sund", "0761122334", "https://example.com/profiles/anna.png", 3 },
                    { 5, "johan@maklarkompaniet.se", "Johan", "Bostad", "0723344556", "https://example.com/profiles/johan.png", 2 }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "AncillaryAreaKvm", "BuildYear", "CategoryId", "CityId", "CreatedAt", "Description", "ImageUrls", "LandAreaKvm", "LivingAreaKvm", "MonthlyFee", "NumberOfRooms", "Price", "RealtorId", "YearlyFee" },
                values: new object[,]
                {
                    { 1, "Exempelgatan 12", 10, 2010, 4, 1, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Fin bostadsrätt i centrala Stockholm.", "https://example.com/images/property1.jpg,https://example.com/images/property2.jpg", 0, 85, 3500, 3, 4500000, 1, 42000 },
                    { 2, "Villavägen 7", 30, 1995, 2, 2, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Stor villa med trädgård och garage.", "https://example.com/images/property3.jpg,https://example.com/images/property4.jpg", 500, 140, 0, 5, 6700000, 2, 12000 },
                    { 3, "Sommarvägen 3", 5, 2018, 1, 3, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Ljus och modern lägenhet nära havet.", "https://example.com/images/property5.jpg,https://example.com/images/property6.jpg", 0, 70, 2000, 2, 2800000, 3, 24000 },
                    { 4, "Stugvägen 1", 15, 1980, 7, 5, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Mysig stuga i skogsmiljö.", "https://example.com/images/property7.jpg,https://example.com/images/property8.jpg", 1000, 45, 0, 2, 1600000, 4, 10000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
