using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class imageurlsproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"https://example.com/images/property1.jpg,https://example.com/images/property2.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"https://example.com/images/property3.jpg,https://example.com/images/property4.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"https://example.com/images/property5.jpg,https://example.com/images/property6.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"https://example.com/images/property7.jpg\",\"https://example.com/images/property8.jpg\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrls",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "https://example.com/images/property1.jpg,https://example.com/images/property2.jpg");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "https://example.com/images/property3.jpg,https://example.com/images/property4.jpg");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "https://example.com/images/property5.jpg,https://example.com/images/property6.jpg");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "https://example.com/images/property7.jpg,https://example.com/images/property8.jpg");
        }
    }
}
