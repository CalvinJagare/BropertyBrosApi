using BropertyBrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BropertyBrosApi.Data
{
    //Author: Calvin, Daniel, Emil
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<RealtorFirm> RealtorFirms { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

        //Author: Calvin
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Categories 
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Lägenhet" },
                new Category { Id = 2, CategoryName = "Villa" },
                new Category { Id = 3, CategoryName = "Radhus" },
                new Category { Id = 4, CategoryName = "Bostadsrätt" },
                new Category { Id = 5, CategoryName = "Hyresrätt" },
                new Category { Id = 6, CategoryName = "Fritidshus" },
                new Category { Id = 7, CategoryName = "Stuga" },
                new Category { Id = 8, CategoryName = "Kollektivboende" },
                new Category { Id = 9, CategoryName = "Studentboende" }
            );

            // Cities
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, CityName = "Stockholm" },
                new City { Id = 2, CityName = "Göteborg" },
                new City { Id = 3, CityName = "Malmö" },
                new City { Id = 4, CityName = "Uppsala" },
                new City { Id = 5, CityName = "Luleå" },
                new City { Id = 6, CityName = "Örebro" }
            );

            // Realtor Firms
            modelBuilder.Entity<RealtorFirm>().HasData(
                new RealtorFirm
                {
                    Id = 1,
                    CompanyName = "Broperty Bros",
                    Description = "En modern mäklarfirma med fokus på teknik och AI.",
                    LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR2ZjXY0_53ngWuJweTB5_n6Ogvo3_FsHh3lw&s",
                    WebsiteUrl = "https://www.bostaden.umea.se"
                },
                new RealtorFirm
                {
                    Id = 2,
                    CompanyName = "Mäklarkompaniet",
                    Description = "Traditionellt kunnande, moderna lösningar.",
                    LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQfuELyshYBonAgRjJs86D0W7xPATcqIx48nw&s",
                    WebsiteUrl = "https://www.hudikhem.se"
                },
                new RealtorFirm
                {
                    Id = 3,
                    CompanyName = "Fastighetsmästarna",
                    Description = "Specialister på bostäder i hela Sverige.",
                    LogoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSnxZygU3x6zsKO3937icA5wDGg0UbijK1CxA&s",
                    WebsiteUrl = "https://heimstaden.com/se/"
                }
            );

            // Realtors
            modelBuilder.Entity<Realtor>().HasData(
                new Realtor
                {
                    Id = 1,
                    FirstName = "Marcus",
                    LastName = "Friberg",
                    PhoneNumber = "0705712647",
                    Email = "markus@bropertybros.se",
                    ProfileUrl = "https://media.licdn.com/dms/image/v2/D4D03AQEYZfjOaaV_QA/profile-displayphoto-shrink_800_800/profile-displayphoto-shrink_800_800/0/1719018397094?e=1750896000&v=beta&t=7Tc6mYQarQ62J6tfvYWlA5wLSLsxO-x5_eIlfPkYWIw",
                    RealtorFirmId = 1
                },
                new Realtor
                {
                    Id = 2,
                    FirstName = "Sanna",
                    LastName = "Mäklarsson",
                    PhoneNumber = "0731234567",
                    Email = "sanna@bropertybros.se",
                    ProfileUrl = "https://images.ctfassets.net/h6goo9gw1hh6/2sNZtFAWOdP1lmQ33VwRN3/24e953b920a9cd0ff2e1d587742a2472/1-intro-photo-final.jpg?w=1200&h=992&fl=progressive&q=70&fm=jpg",
                    RealtorFirmId = 1
                },
                new Realtor
                {
                    Id = 3,
                    FirstName = "Erik",
                    LastName = "Fast",
                    PhoneNumber = "0704455667",
                    Email = "erik@maklarkompaniet.se",
                    ProfileUrl = "https://newprofilepic.photo-cdn.net//assets/images/article/profile.jpg?90af0c8",
                    RealtorFirmId = 2
                },
                new Realtor
                {
                    Id = 4,
                    FirstName = "Anna",
                    LastName = "Sund",
                    PhoneNumber = "0761122334",
                    Email = "anna@fastighetsmastarna.se",
                    ProfileUrl = "https://media.istockphoto.com/id/1682296067/photo/happy-studio-portrait-or-professional-man-real-estate-agent-or-asian-businessman-smile-for.jpg?s=612x612&w=0&k=20&c=9zbG2-9fl741fbTWw5fNgcEEe4ll-JegrGlQQ6m54rg=",
                    RealtorFirmId = 3
                },
                new Realtor
                {
                    Id = 5,
                    FirstName = "Johan",
                    LastName = "Bostad",
                    PhoneNumber = "0723344556",
                    Email = "johan@maklarkompaniet.se",
                    ProfileUrl = "https://example.com/profiles/johan.png",
                    RealtorFirmId = 2
                }
            );

            // Properties
            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    Id = 1,
                    Address = "Exempelgatan 12",
                    Price = 4500000,
                    MonthlyFee = 3500,
                    YearlyFee = 42000,
                    LivingAreaKvm = 85,
                    AncillaryAreaKvm = 10,
                    LandAreaKvm = 0,
                    Description = "Fin bostadsrätt i centrala Stockholm.",
                    NumberOfRooms = 3,
                    BuildYear = 2010,
                    ImageUrls = new List<string>() {"https://coralhomes.com.au/wp-content/uploads/Grange-258Q-Harmony-Lodge-Facade-2-1190x680.jpg"},
                    CreatedAt = new DateTime(2024, 01, 01, 12, 00, 00, DateTimeKind.Utc),
                    RealtorId = 1,
                    CityId = 1,
                    CategoryId = 4
                },
                new Property
                {
                    Id = 2,
                    Address = "Villavägen 7",
                    Price = 6700000,
                    MonthlyFee = 0,
                    YearlyFee = 12000,
                    LivingAreaKvm = 140,
                    AncillaryAreaKvm = 30,
                    LandAreaKvm = 500,
                    Description = "Stor villa med trädgård och garage.",
                    NumberOfRooms = 5,
                    BuildYear = 1995,
                    ImageUrls = new List<string>() { "https://www.thehousedesigners.com/images/plans/01/JBZ/bulk/4382/2428-dusk-render.webp" },
                    CreatedAt = new DateTime(2024, 01, 01, 12, 00, 00, DateTimeKind.Utc),
                    RealtorId = 2,
                    CityId = 2,
                    CategoryId = 2
                },
                new Property
                {
                    Id = 3,
                    Address = "Sommarvägen 3",
                    Price = 2800000,
                    MonthlyFee = 2000,
                    YearlyFee = 24000,
                    LivingAreaKvm = 70,
                    AncillaryAreaKvm = 5,
                    LandAreaKvm = 0,
                    Description = "Ljus och modern lägenhet nära havet.",
                    NumberOfRooms = 2,
                    BuildYear = 2018,
                    ImageUrls = new List<string>() { "https://images.unsplash.com/photo-1564013799919-ab600027ffc6?q=80\u0026w=1170\u0026auto=format\u0026fit=crop\u0026ixlib=rb-4.0.3\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" },
                    CreatedAt = new DateTime(2024, 01, 01, 12, 00, 00, DateTimeKind.Utc),
                    RealtorId = 3,
                    CityId = 3,
                    CategoryId = 1
                },
                new Property
                {
                    Id = 4,
                    Address = "Stugvägen 1",
                    Price = 1600000,
                    MonthlyFee = 0,
                    YearlyFee = 10000,
                    LivingAreaKvm = 45,
                    AncillaryAreaKvm = 15,
                    LandAreaKvm = 1000,
                    Description = "Mysig stuga i skogsmiljö.",
                    NumberOfRooms = 2,
                    BuildYear = 1980,
                    ImageUrls = new List<string>() { "https://static.schumacherhomes.com/umbraco/media/wvflutbh/image4.jpg?format=webp", "https://static.schumacherhomes.com/umbraco/media/ytthzjth/image3.jpg?format=webp", "https://static.schumacherhomes.com/umbraco/media/4r4pxnt5/image11.jpg?format=webp" },
                    CreatedAt = new DateTime(2024, 01, 01, 12, 00, 00, DateTimeKind.Utc),
                    RealtorId = 4,
                    CityId = 5,
                    CategoryId = 7
                }
            );
        }
    }        
}
