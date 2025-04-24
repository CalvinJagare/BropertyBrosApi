using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class SeededDeafultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0815e599-bd3f-40c2-86bc-823bcf0a70c8", null, "User", "User" },
                    { "90ad6ea8-a4e8-4323-af6f-2d1872e038f0", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d", 0, "3532d359-bc12-401c-a68e-df4b1e844847", "user@demoapi.com", true, "System", "User", false, null, "USER@DEMOAPI.COM", "USER@DEMOAPI.COM", "AQAAAAIAAYagAAAAEAK/FD45E8unqJGRDcrQwpSSVR6w+nYhItJbd+g/aDz7Na8/ASSRIOnjrBpSmTjBPQ==", null, false, "5c1724de-2a70-4c6e-8354-09a3d8a6e443", false, "user@demoapi.com" },
                    { "610effcf-b80c-4ef7-bf8e-e188c80e68c3", 0, "943a1e06-ac9e-48ea-922b-8bc9f2715399", "admin@demoapi.com", true, "System", "Admin", false, null, "ADMIN@DEMOAPI.COM", "ADMIN@DEMOAPI.COM", "AQAAAAIAAYagAAAAEOEs+HS34lxEpY+nyk5+zl9e9+i0hRo4rUC+zWIawRwNukcX3ErL4KmsneLZoJjLJA==", null, false, "3f5fda79-a46a-4449-9569-9f0a0b5c19bb", false, "admin@demoapi.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0815e599-bd3f-40c2-86bc-823bcf0a70c8", "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d" },
                    { "90ad6ea8-a4e8-4323-af6f-2d1872e038f0", "610effcf-b80c-4ef7-bf8e-e188c80e68c3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0815e599-bd3f-40c2-86bc-823bcf0a70c8", "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90ad6ea8-a4e8-4323-af6f-2d1872e038f0", "610effcf-b80c-4ef7-bf8e-e188c80e68c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0815e599-bd3f-40c2-86bc-823bcf0a70c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90ad6ea8-a4e8-4323-af6f-2d1872e038f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610effcf-b80c-4ef7-bf8e-e188c80e68c3");
        }
    }
}
