using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class SeededRolesAndDefaultUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fb43755-efa6-428e-8f70-024d3294c7b6", null, "Admin", "ADMIN" },
                    { "bc472e9f-773c-4e71-a524-f37911680d76", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "da73186d-928a-4e7b-af8e-d69ebe4ea2c9", 0, "7fa5c752-55de-4da1-8121-cc6d494d0f42", "admin@broperty.com", true, "Chad", "Broperty", false, null, "ADMIN@BROPERTY.COM", "ADMIN@BROPERTY.COM", "AQAAAAIAAYagAAAAEMD44C/ECfB4InaTr8tbuVS8nhQ48+4uLre1jAjq18+uhphFsgHND+Vjw4tTq/WvRA==", null, false, "c60084ed-6b05-4368-969f-8093c75cb237", false, "admin@broperty.com" },
                    { "e537ba2e-a85f-4c2e-bd43-2940963f7856", 0, "d41f3f2e-4d62-4aae-8cfa-23b785d6b980", "user@broperty.com", true, "Emil", "Svensson", false, null, "USER@BROPERTY.COM", "USER@BROPERTY.COM", "AQAAAAIAAYagAAAAEDYIFGqSdYXteV0eIG/KtXigZdmhqK9huHckimwtk3l0wY0LZ5YuqnUT2DY8nrG5Jw==", null, false, "caa715cb-0a88-4bdd-bff5-11258102fb24", false, "user@broperty.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5fb43755-efa6-428e-8f70-024d3294c7b6", "da73186d-928a-4e7b-af8e-d69ebe4ea2c9" },
                    { "bc472e9f-773c-4e71-a524-f37911680d76", "e537ba2e-a85f-4c2e-bd43-2940963f7856" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fb43755-efa6-428e-8f70-024d3294c7b6", "da73186d-928a-4e7b-af8e-d69ebe4ea2c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc472e9f-773c-4e71-a524-f37911680d76", "e537ba2e-a85f-4c2e-bd43-2940963f7856" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fb43755-efa6-428e-8f70-024d3294c7b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc472e9f-773c-4e71-a524-f37911680d76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da73186d-928a-4e7b-af8e-d69ebe4ea2c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856");
        }
    }
}
