using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class morepictures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2ZjXY0_53ngWuJweTB5_n6Ogvo3_FsHh3lw&s");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfuELyshYBonAgRjJs86D0W7xPATcqIx48nw&s");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnxZygU3x6zsKO3937icA5wDGg0UbijK1CxA&s");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 1,
                column: "LogoUrl",
                value: "https://example.com/logos/bropertybros.png");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 2,
                column: "LogoUrl",
                value: "https://example.com/logos/maklarkompaniet.png");

            migrationBuilder.UpdateData(
                table: "RealtorFirms",
                keyColumn: "Id",
                keyValue: 3,
                column: "LogoUrl",
                value: "https://example.com/logos/fastighetsmastarna.png");
        }
    }
}
