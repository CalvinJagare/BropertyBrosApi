using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class pictruesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrls",
                value: "[\"https://coralhomes.com.au/wp-content/uploads/Grange-258Q-Harmony-Lodge-Facade-2-1190x680.jpg\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrls",
                value: "[\"https://www.thehousedesigners.com/images/plans/01/JBZ/bulk/4382/2428-dusk-render.webp\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrls",
                value: "[\"https://images.unsplash.com/photo-1564013799919-ab600027ffc6?q=80\\u0026w=1170\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]");

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrls",
                value: "[\"https://static.schumacherhomes.com/umbraco/media/wvflutbh/image4.jpg?format=webp\",\"https://static.schumacherhomes.com/umbraco/media/ytthzjth/image3.jpg?format=webp\",\"https://static.schumacherhomes.com/umbraco/media/4r4pxnt5/image11.jpg?format=webp\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
