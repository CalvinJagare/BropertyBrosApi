using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BropertyBrosApi2._0.Migrations
{
    /// <inheritdoc />
    public partial class i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealtorFirms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealtorFirms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealtorFirmId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Realtors_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realtors_RealtorFirms_RealtorFirmId",
                        column: x => x.RealtorFirmId,
                        principalTable: "RealtorFirms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealtorId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<int>(type: "int", nullable: false),
                    YearlyFee = table.Column<int>(type: "int", nullable: false),
                    LivingAreaKvm = table.Column<int>(type: "int", nullable: false),
                    AncillaryAreaKvm = table.Column<int>(type: "int", nullable: false),
                    LandAreaKvm = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    BuildYear = table.Column<int>(type: "int", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d940884-5d22-4f47-83ff-c9f5f8e6bb9b", null, "Realtor", null },
                    { "87ae444e-4797-4b07-8471-9e444e7ceaeb", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "064297ce-17ff-4e1b-a078-05e4d4e08944", 0, "21dd539d-4565-4ddd-8c10-e7fb21022b0f", "AppUser", "markus@bropertybros.se", false, false, null, null, null, "AQAAAAIAAYagAAAAEFESZGDeOYgFb1CIZbVL7jfdyPZa3/xeqo9Sh0ctAHbZm8yISvKUDb65IOZ4IcKW3g==", "0705712647", false, "02c42ac2-c5c5-4da5-8771-6d487c8f947e", false, "markus@bropertybros.se" },
                    { "91033ec6-e770-4b9c-ad6f-83ee80a01b26", 0, "21dd539d-4565-4ddd-8c10-e7fb21022b0f", "AppUser", "admin@admin.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFESZGDeOYgFb1CIZbVL7jfdyPZa3/xeqo9Sh0ctAHbZm8yISvKUDb65IOZ4IcKW3g==", "0123456789", false, "02c42ac2-c5c5-4da5-8771-6d487c8f947e", false, "admin@admin.com" },
                    { "96ce045a-44a7-4ec7-8816-1f4ffc127400", 0, "21dd539d-4565-4ddd-8c10-e7fb21022b0f", "AppUser", "erik@maklarkompaniet.se", false, false, null, null, null, "AQAAAAIAAYagAAAAEFESZGDeOYgFb1CIZbVL7jfdyPZa3/xeqo9Sh0ctAHbZm8yISvKUDb65IOZ4IcKW3g==", "0704455667", false, "02c42ac2-c5c5-4da5-8771-6d487c8f947e", false, "erik@maklarkompaniet.se" },
                    { "9d7fc5c7-e1ca-4b25-9859-dec2cc85e573", 0, "21dd539d-4565-4ddd-8c10-e7fb21022b0f", "AppUser", "sanna@bropertybros.se", false, false, null, null, null, "AQAAAAIAAYagAAAAEFESZGDeOYgFb1CIZbVL7jfdyPZa3/xeqo9Sh0ctAHbZm8yISvKUDb65IOZ4IcKW3g==", "0731234567", false, "02c42ac2-c5c5-4da5-8771-6d487c8f947e", false, "sanna@bropertybros.se" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Lägenhet" },
                    { 2, "Villa" },
                    { 3, "Radhus" },
                    { 4, "Bostadsrätt" },
                    { 5, "Hyresrätt" },
                    { 6, "Fritidshus" },
                    { 7, "Stuga" },
                    { 8, "Kollektivboende" },
                    { 9, "Studentboende" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName" },
                values: new object[,]
                {
                    { 1, "Stockholm" },
                    { 2, "Göteborg" },
                    { 3, "Malmö" },
                    { 4, "Uppsala" },
                    { 5, "Luleå" },
                    { 6, "Örebro" }
                });

            migrationBuilder.InsertData(
                table: "RealtorFirms",
                columns: new[] { "Id", "CompanyName", "Description", "LogoUrl", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, "Broperty Bros", "En modern mäklarfirma med fokus på teknik och AI.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2ZjXY0_53ngWuJweTB5_n6Ogvo3_FsHh3lw&s", "https://www.bostaden.umea.se" },
                    { 2, "Mäklarkompaniet", "Traditionellt kunnande, moderna lösningar.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfuELyshYBonAgRjJs86D0W7xPATcqIx48nw&s", "https://www.hudikhem.se" },
                    { 3, "Fastighetsmästarna", "Specialister på bostäder i hela Sverige.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnxZygU3x6zsKO3937icA5wDGg0UbijK1CxA&s", "https://heimstaden.com/se/" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d940884-5d22-4f47-83ff-c9f5f8e6bb9b", "064297ce-17ff-4e1b-a078-05e4d4e08944" },
                    { "87ae444e-4797-4b07-8471-9e444e7ceaeb", "91033ec6-e770-4b9c-ad6f-83ee80a01b26" },
                    { "2d940884-5d22-4f47-83ff-c9f5f8e6bb9b", "96ce045a-44a7-4ec7-8816-1f4ffc127400" },
                    { "2d940884-5d22-4f47-83ff-c9f5f8e6bb9b", "9d7fc5c7-e1ca-4b25-9859-dec2cc85e573" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "Id", "AppUserId", "FirstName", "LastName", "ProfileUrl", "RealtorFirmId" },
                values: new object[,]
                {
                    { 1, "064297ce-17ff-4e1b-a078-05e4d4e08944", "Marcus", "Friberg", "https://media.licdn.com/dms/image/v2/D4D03AQEYZfjOaaV_QA/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1719018397094?e=1750896000&v=beta&t=7Tc6mYQarQ62J6tfvYWlA5wLSLsxO-x5_eIlfPkYWIw", 1 },
                    { 2, "9d7fc5c7-e1ca-4b25-9859-dec2cc85e573", "Sanna", "Mäklarsson", "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg", 1 },
                    { 3, "96ce045a-44a7-4ec7-8816-1f4ffc127400", "Erik", "Fast", "https://newprofilepic.photo-cdn.net//assets/images/article/profile.jpg?90af0c8", 2 }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Address", "AncillaryAreaKvm", "BuildYear", "CategoryId", "CityId", "CreatedAt", "Description", "ImageUrls", "LandAreaKvm", "LivingAreaKvm", "MonthlyFee", "NumberOfRooms", "Price", "RealtorId", "YearlyFee" },
                values: new object[,]
                {
                    { 1, "Exempelgatan 12", 10, 2010, 4, 1, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Fin bostadsrätt i centrala Stockholm.", "[\"https://coralhomes.com.au/wp-content/uploads/Grange-258Q-Harmony-Lodge-Facade-2-1190x680.jpg\"]", 0, 85, 3500, 3, 4500000, 1, 42000 },
                    { 2, "Villavägen 7", 30, 1995, 2, 2, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Stor villa med trädgård och garage.", "[\"https://www.thehousedesigners.com/images/plans/01/JBZ/bulk/4382/2428-dusk-render.webp\"]", 500, 140, 0, 5, 6700000, 2, 12000 },
                    { 3, "Sommarvägen 3", 5, 2018, 1, 3, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Ljus och modern lägenhet nära havet.", "[\"https://images.unsplash.com/photo-1564013799919-ab600027ffc6?q=80\\u0026w=1170\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]", 0, 70, 2000, 2, 2800000, 2, 24000 },
                    { 4, "Stugvägen 1", 15, 1980, 7, 5, new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), "Mysig stuga i skogsmiljö.", "[\"https://static.schumacherhomes.com/umbraco/media/wvflutbh/image4.jpg?format=webp\",\"https://static.schumacherhomes.com/umbraco/media/ytthzjth/image3.jpg?format=webp\",\"https://static.schumacherhomes.com/umbraco/media/4r4pxnt5/image11.jpg?format=webp\"]", 1000, 45, 0, 2, 1600000, 3, 10000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CategoryId",
                table: "Properties",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CityId",
                table: "Properties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_RealtorId",
                table: "Properties",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_AppUserId",
                table: "Realtors",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Realtors_RealtorFirmId",
                table: "Realtors",
                column: "RealtorFirmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RealtorFirms");
        }
    }
}
