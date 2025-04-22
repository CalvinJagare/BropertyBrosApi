using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class realtorfixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "ProfileUrl" },
                values: new object[] { "Marcus", "https://media.licdn.com/dms/image/v2/D4D03AQEYZfjOaaV_QA/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1719018397094?e=1750896000&v=beta&t=7Tc6mYQarQ62J6tfvYWlA5wLSLsxO-x5_eIlfPkYWIw" });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileUrl",
                value: "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileUrl",
                value: "https://newprofilepic.photo-cdn.net//assets/images/article/profile.jpg?90af0c8");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileUrl",
                value: "https://media.istockphoto.com/id/1682296067/photo/happy-studio-portrait-or-professional-man-real-estate-agent-or-asian-businessman-smile-for.jpg?s=612x612&w=0&k=20&c=9zbG2-9fl741fbTWw5fNgcEEe4ll-JegrGlQQ6m54rg=");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "ProfileUrl" },
                values: new object[] { "Markus", "https://example.com/profiles/markus.png" });

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProfileUrl",
                value: "https://example.com/profiles/sanna.png");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProfileUrl",
                value: "https://example.com/profiles/erik.png");

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProfileUrl",
                value: "https://example.com/profiles/anna.png");
        }
    }
}
