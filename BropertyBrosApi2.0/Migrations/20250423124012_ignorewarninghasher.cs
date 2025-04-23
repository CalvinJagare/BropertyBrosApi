using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class ignorewarninghasher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "033e9cc7-adfa-4778-8dbd-c1f35d3007d5", null, "User", "User" },
                    { "b4567686-11f2-4baf-b915-305273cf5c19", null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "037b162f-ce2c-4297-8e99-6bf381d6cebe", 0, "b2c4e086-2d02-42e1-8c56-8b09d17328fd", "admin@brosapi.com", true, "System", "Admin", false, null, "ADMIN@BROSAPI.COM", "ADMIN@BROSAPI.COM", "AQAAAAIAAYagAAAAEBMvjY9ZY5q75lNVCmXJcQchth5mgXOATNq1SRnRQBDlCddlenzbPfPWz67Jww018g==", null, false, "d902e26e-992c-4ffe-98ef-9a2782325561", false, "admin@brosapi.com" },
                    { "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1", 0, "24b53655-4b5c-4709-8f0c-e3284dadc096", "user@brosapi.com", true, "System", "User", false, null, "USER@BROSAPI.COM", "USER@BROSAPI.COM", "AQAAAAIAAYagAAAAEBlfkspe1nB3bDHgMsG8/TojKwBM2SxIj/jI+mE9rSegCcuTPQraaHbxzAEzj46SeQ==", null, false, "3d824a1c-e36c-47c9-9d1e-aa144f59b525", false, "user@brosapi.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b4567686-11f2-4baf-b915-305273cf5c19", "037b162f-ce2c-4297-8e99-6bf381d6cebe" },
                    { "033e9cc7-adfa-4778-8dbd-c1f35d3007d5", "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b4567686-11f2-4baf-b915-305273cf5c19", "037b162f-ce2c-4297-8e99-6bf381d6cebe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "033e9cc7-adfa-4778-8dbd-c1f35d3007d5", "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "033e9cc7-adfa-4778-8dbd-c1f35d3007d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4567686-11f2-4baf-b915-305273cf5c19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "037b162f-ce2c-4297-8e99-6bf381d6cebe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1");
        }
    }
}
