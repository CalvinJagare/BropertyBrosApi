using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class letsnotignoretheproblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "037b162f-ce2c-4297-8e99-6bf381d6cebe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ea67d1d-b452-4e7b-92b4-d53c483c46f6", "AQAAAAIAAYagAAAAEELG1BBPcWKdrKxGtCb1q5oM/YO5OjSOA52TiRV0I5k3LckvGTF311v7zKrjY98FPg==", "1f678042-0f5c-4dc2-8fad-9bca39414616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78f9bc1c-b523-4daf-acb1-626a9e888112", "AQAAAAIAAYagAAAAEF9pGLt+MQ6siKy87TCXW4gpBbOllcDBgqJK29dTi5B/D7MpDI3CzFUxEGK31munnA==", "5bc70d68-5f0c-4796-ba07-ebf3a73bfdcf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "037b162f-ce2c-4297-8e99-6bf381d6cebe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2c4e086-2d02-42e1-8c56-8b09d17328fd", "AQAAAAIAAYagAAAAEBMvjY9ZY5q75lNVCmXJcQchth5mgXOATNq1SRnRQBDlCddlenzbPfPWz67Jww018g==", "d902e26e-992c-4ffe-98ef-9a2782325561" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db90f6a9-26e7-4b5d-9f1b-620ce7998fd1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b53655-4b5c-4709-8f0c-e3284dadc096", "AQAAAAIAAYagAAAAEBlfkspe1nB3bDHgMsG8/TojKwBM2SxIj/jI+mE9rSegCcuTPQraaHbxzAEzj46SeQ==", "3d824a1c-e36c-47c9-9d1e-aa144f59b525" });
        }
    }
}
