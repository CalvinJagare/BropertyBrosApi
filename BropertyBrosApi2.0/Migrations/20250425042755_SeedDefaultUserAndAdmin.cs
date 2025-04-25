using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUserAndAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "066c0b50-0dc1-4ed8-8cb2-e3b22e8f5782", null, "Admin", "ADMIN" },
                    { "83cf5828-997c-4ca8-8384-7fb562d17900", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03e55603-8b93-4653-be93-c5ad8fafde7c", 0, "fa890856-18f1-48d7-94cd-5f092ee79a4a", "ApiUser", "user@user.com", true, "Frontend", "User", false, null, "USER@USER.COM", "USER@USER.COM", "AQAAAAIAAYagAAAAEDEVswFEYDaxzDvXcovL6L7i1ypBzHkb6/hIaMXSCqMJmKEtKaJ96kHlJ5cO1vApcw==", null, false, "5b62fd9d-46a9-418a-8f92-3bdb1f24f783", false, "user@user.com" },
                    { "0f654a33-93f1-494d-a833-b1e90c93d02e", 0, "30b08ca9-02a0-47db-8bb8-3a3258a64a00", "ApiUser", "admin@admin.com", true, "System", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAIAAYagAAAAEJUyKPjPFku0ZUDURlueib/er2CHsj2LI893okbF1x1OS/2vUeb4ShyeA4kxzQuKag==", null, false, "f07fcdb1-c8c9-44a0-8b50-665451986a0c", false, "admin@admin.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "83cf5828-997c-4ca8-8384-7fb562d17900", "03e55603-8b93-4653-be93-c5ad8fafde7c" },
                    { "066c0b50-0dc1-4ed8-8cb2-e3b22e8f5782", "0f654a33-93f1-494d-a833-b1e90c93d02e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83cf5828-997c-4ca8-8384-7fb562d17900", "03e55603-8b93-4653-be93-c5ad8fafde7c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "066c0b50-0dc1-4ed8-8cb2-e3b22e8f5782", "0f654a33-93f1-494d-a833-b1e90c93d02e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "066c0b50-0dc1-4ed8-8cb2-e3b22e8f5782");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83cf5828-997c-4ca8-8384-7fb562d17900");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03e55603-8b93-4653-be93-c5ad8fafde7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f654a33-93f1-494d-a833-b1e90c93d02e");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
