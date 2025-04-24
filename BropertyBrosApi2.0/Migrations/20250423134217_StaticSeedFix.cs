using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class StaticSeedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640d592d-8e7c-4e01-96c9-0b83ddf44105", "AQAAAAIAAYagAAAAECjq5JBLqsB4nqMRn2k0LKZ4bwXZorJ4Mx9NNyRAQswVUiPXQFrZ5LJ8WkgQ6ziG1g==", "49e2bf44-8c4b-47d5-b492-7c8292a14493" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610effcf-b80c-4ef7-bf8e-e188c80e68c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d40f43ee-f99a-4e95-b2dd-28a3b01a3cfc", "AQAAAAIAAYagAAAAECjq5JBLqsB4nqMRn2k0LKZ4bwXZorJ4Mx9NNyRAQswVUiPXQFrZ5LJ8WkgQ6ziG1g==", "acaf61b8-56ac-4ccf-80aa-65bf2e82fefe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ef2201d-5544-4b52-9dff-eaf2edf5fb8d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3532d359-bc12-401c-a68e-df4b1e844847", "AQAAAAIAAYagAAAAEAK/FD45E8unqJGRDcrQwpSSVR6w+nYhItJbd+g/aDz7Na8/ASSRIOnjrBpSmTjBPQ==", "5c1724de-2a70-4c6e-8354-09a3d8a6e443" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "610effcf-b80c-4ef7-bf8e-e188c80e68c3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943a1e06-ac9e-48ea-922b-8bc9f2715399", "AQAAAAIAAYagAAAAEOEs+HS34lxEpY+nyk5+zl9e9+i0hRo4rUC+zWIawRwNukcX3ErL4KmsneLZoJjLJA==", "3f5fda79-a46a-4449-9569-9f0a0b5c19bb" });
        }
    }
}
