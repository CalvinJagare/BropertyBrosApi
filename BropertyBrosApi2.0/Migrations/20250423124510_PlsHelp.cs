using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class PlsHelp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da73186d-928a-4e7b-af8e-d69ebe4ea2c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c5ba60-0a1a-4c99-8646-41e8d3c350a9", "AQAAAAIAAYagAAAAELeUE3g9g6OTSqBTc9ton2GMurerIw4dCslq57D14LC8knhko3oWy/20+BxhAdO/UA==", "abe6397f-14eb-4a7a-979e-18f7cbffb787" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21dd539d-4565-4ddd-8c10-e7fb21022b0f", "AQAAAAIAAYagAAAAEBX1pIrj+1YNKaog05C+oOx9U5r/rvnyN4SvLNfSqUr1zL54+iXnda0ujBN9v6wdeQ==", "02c42ac2-c5c5-4da5-8771-6d487c8f947e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da73186d-928a-4e7b-af8e-d69ebe4ea2c9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fa5c752-55de-4da1-8121-cc6d494d0f42", "AQAAAAIAAYagAAAAEMD44C/ECfB4InaTr8tbuVS8nhQ48+4uLre1jAjq18+uhphFsgHND+Vjw4tTq/WvRA==", "c60084ed-6b05-4368-969f-8093c75cb237" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d41f3f2e-4d62-4aae-8cfa-23b785d6b980", "AQAAAAIAAYagAAAAEDYIFGqSdYXteV0eIG/KtXigZdmhqK9huHckimwtk3l0wY0LZ5YuqnUT2DY8nrG5Jw==", "caa715cb-0a88-4bdd-bff5-11258102fb24" });
        }
    }
}
