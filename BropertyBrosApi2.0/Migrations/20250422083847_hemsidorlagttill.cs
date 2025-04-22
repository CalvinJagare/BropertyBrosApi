using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class hemsidorlagttill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 1,
                column: "WebsiteUrl",
                value: "https://www.bostaden.umea.se");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 2,
                column: "WebsiteUrl",
                value: "https://www.hudikhem.se");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 3,
                column: "WebsiteUrl",
                value: "https://heimstaden.com/se/");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 1,
                column: "WebsiteUrl",
                value: "https://bropertybros.se");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 2,
                column: "WebsiteUrl",
                value: "https://maklarkompaniet.se");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 3,
                column: "WebsiteUrl",
                value: "https://fastighetsmastarna.se");
        }
    }
}
