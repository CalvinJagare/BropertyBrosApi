using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class abc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                columns: new[] { "Email", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "user1@broperty.com", "USER@1BROPERTY.COM", "USER1@BROPERTY.COM", "user1@broperty.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9c9da7da-4b24-459f-9e27-182c1e7b1d39", 0, "b85fdef9-583e-44fb-8e97-2d2997af08d6", "user4@broperty.com", true, "Leif", "Thorsson", false, null, "USER4@BROPERTY.COM", "USER4@BROPERTY.COM", "AQAAAAIAAYagAAAAEBX1pIrj+1YNKaog05C+oOx9U5r/rvnyN4SvLNfSqUr1zL54+iXnda0ujBN9v6wdeQ==", null, false, "77eab9a2-f47a-4e6f-bf92-d9db56cff596", false, "user4@broperty.com" },
                    { "f52522f4-0329-4037-a3c5-219abe6b80d5", 0, "9cb56f6a-a523-4735-9e30-5ef24036dcf4", "user2@broperty.com", true, "Adam", "Abrahamsson", false, null, "USER2@BROPERTY.COM", "USER2@BROPERTY.COM", "AQAAAAIAAYagAAAAEBX1pIrj+1YNKaog05C+oOx9U5r/rvnyN4SvLNfSqUr1zL54+iXnda0ujBN9v6wdeQ==", null, false, "26041623-1de5-4636-b59d-d15736238599", false, "user2@broperty.com" },
                    { "f8b4f95c-02fe-40cc-b73d-36c0f7ac786f", 0, "8a9fb63f-80cb-4908-bb9f-a5aad2e8db93", "user3@broperty.com", true, "Nina", "Tudorsson", false, null, "USER3@BROPERTY.COM", "USER3@BROPERTY.COM", "AQAAAAIAAYagAAAAEBX1pIrj+1YNKaog05C+oOx9U5r/rvnyN4SvLNfSqUr1zL54+iXnda0ujBN9v6wdeQ==", null, false, "308019e8-6f74-4a57-8722-0b1e407004a3", false, "user3@broperty.com" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "ProfileUrl", "RealtorFirmId", "UserId" },
                values: new object[,]
                {
                    { 2, "sanna@bropertybros.se", "Sanna", "Mäklarsson", "0731234567", "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg", 1, "f52522f4-0329-4037-a3c5-219abe6b80d5" },
                    { 3, "erik@maklarkompaniet.se", "Erik", "Fast", "0704455667", "https://newprofilepic.photo-cdn.net//assets/images/article/profile.jpg?90af0c8", 2, "f8b4f95c-02fe-40cc-b73d-36c0f7ac786f" },
                    { 4, "anna@fastighetsmastarna.se", "Anna", "Sund", "0761122334", "https://media.istockphoto.com/id/1682296067/photo/happy-studio-portrait-or-professional-man-real-estate-agent-or-asian-businessman-smile-for.jpg?s=612x612&w=0&k=20&c=9zbG2-9fl741fbTWw5fNgcEEe4ll-JegrGlQQ6m54rg=", 3, "9c9da7da-4b24-459f-9e27-182c1e7b1d39" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c9da7da-4b24-459f-9e27-182c1e7b1d39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52522f4-0329-4037-a3c5-219abe6b80d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b4f95c-02fe-40cc-b73d-36c0f7ac786f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e537ba2e-a85f-4c2e-bd43-2940963f7856",
                columns: new[] { "Email", "NormalizedEmail", "NormalizedUserName", "UserName" },
                values: new object[] { "user@broperty.com", "USER@BROPERTY.COM", "USER@BROPERTY.COM", "user@broperty.com" });
        }
    }
}
