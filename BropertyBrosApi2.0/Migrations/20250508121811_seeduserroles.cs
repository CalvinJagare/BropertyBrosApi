using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class seeduserroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bc472e9f-773c-4e71-a524-f37911680d76", "9c9da7da-4b24-459f-9e27-182c1e7b1d39" },
                    { "bc472e9f-773c-4e71-a524-f37911680d76", "f52522f4-0329-4037-a3c5-219abe6b80d5" },
                    { "bc472e9f-773c-4e71-a524-f37911680d76", "f8b4f95c-02fe-40cc-b73d-36c0f7ac786f" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                column: "NormalizedEmail",
                value: "USER1@BROPERTY.COM");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc472e9f-773c-4e71-a524-f37911680d76", "9c9da7da-4b24-459f-9e27-182c1e7b1d39" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc472e9f-773c-4e71-a524-f37911680d76", "f52522f4-0329-4037-a3c5-219abe6b80d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc472e9f-773c-4e71-a524-f37911680d76", "f8b4f95c-02fe-40cc-b73d-36c0f7ac786f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                column: "NormalizedEmail",
                value: "USER@1BROPERTY.COM");
        }
    }
}
