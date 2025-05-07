using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class realtorlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Realtors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RealtorId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da73186d-928a-4e7b-af8e-d69ebe4ea2c9",
                column: "RealtorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                column: "RealtorId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Realtors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "e537ba2e-a85f-4c2e-bd43-2940963f7856");

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_UserId",
                table: "Realtors",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Realtors_AspNetUsers_UserId",
                table: "Realtors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Realtors_AspNetUsers_UserId",
                table: "Realtors");

            migrationBuilder.DropIndex(
                name: "IX_Realtors_UserId",
                table: "Realtors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Realtors");

            migrationBuilder.DropColumn(
                name: "RealtorId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "ProfileUrl", "RealtorFirmId" },
                values: new object[,]
                {
                    { 2, "sanna@bropertybros.se", "Sanna", "Mäklarsson", "0731234567", "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg", 1 },
                    { 3, "erik@maklarkompaniet.se", "Erik", "Fast", "0704455667", "https://newprofilepic.photo-cdn.net//assets/images/article/profile.jpg?90af0c8", 2 },
                    { 4, "anna@fastighetsmastarna.se", "Anna", "Sund", "0761122334", "https://media.istockphoto.com/id/1682296067/photo/happy-studio-portrait-or-professional-man-real-estate-agent-or-asian-businessman-smile-for.jpg?s=612x612&w=0&k=20&c=9zbG2-9fl741fbTWw5fNgcEEe4ll-JegrGlQQ6m54rg=", 3 },
                    { 5, "johan@maklarkompaniet.se", "Johan", "Bostad", "0723344556", "https://example.com/profiles/johan.png", 2 }
                });
        }
    }
}
