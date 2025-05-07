using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class realtorlogin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RealtorId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RealtorId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da73186d-928a-4e7b-af8e-d69ebe4ea2c9",
                column: "RealtorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                column: "RealtorId",
                value: 0);
        }
    }
}
