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
                    LogoUrl = "https://example.com/logos/bropertybros.png",
                    WebsiteUrl = "https://bropertybros.se"
                },
                new RealtorFirm
                {
                    Id = 2,
                    CompanyName = "Mäklarkompaniet",
                    Description = "Traditionellt kunnande, moderna lösningar.",
                    LogoUrl = "https://example.com/logos/maklarkompaniet.png",
                    WebsiteUrl = "https://maklarkompaniet.se"
                },
                new RealtorFirm
                {
                    Id = 3,
                    CompanyName = "Fastighetsmästarna",
                    Description = "Specialister på bostäder i hela Sverige.",
                    LogoUrl = "https://example.com/logos/fastighetsmastarna.png",
                    WebsiteUrl = "https://fastighetsmastarna.se"
                }
            );

            // Realtors
            modelBuilder.Entity<Realtor>().HasData(
                new Realtor
                {
                    Id = 1,
                    FirstName = "Markus",
                    LastName = "Friberg",
                    PhoneNumber = "0705712647",
                    Email = "markus@bropertybros.se",
                    ProfileUrl = "https://example.com/profiles/markus.png",
                    RealtorFirmId = 1
                },
                new Realtor
                {
                    Id = 2,
                    FirstName = "Sanna",
                    LastName = "Mäklarsson",
                    PhoneNumber = "0731234567",
                    Email = "sanna@bropertybros.se",
                    ProfileUrl = "https://example.com/profiles/sanna.png",
                    RealtorFirmId = 1
                },
                new Realtor
                {
                    Id = 3,
                    FirstName = "Erik",
                    LastName = "Fast",
                    PhoneNumber = "0704455667",
                    Email = "erik@maklarkompaniet.se",
                    ProfileUrl = "https://example.com/profiles/erik.png",
                    RealtorFirmId = 2
                },
                new Realtor
                {
                    Id = 4,
                    FirstName = "Anna",
                    LastName = "Sund",
                    PhoneNumber = "0761122334",
                    Email = "anna@fastighetsmastarna.se",
                    ProfileUrl = "https://example.com/profiles/anna.png",
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
                    ImageUrls = new List<string>() { "https://example.com/images/property1.jpg,https://example.com/images/property2.jpg" },
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
                    ImageUrls = new List<string>() { "https://example.com/images/property3.jpg,https://example.com/images/property4.jpg" },
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
                    ImageUrls = new List<string>() { "https://example.com/images/property5.jpg,https://example.com/images/property6.jpg" },
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
                    ImageUrls = new List<string>() { "https://example.com/images/property7.jpg", "https://example.com/images/property8.jpg" },
                    CreatedAt = new DateTime(2024, 01, 01, 12, 00, 00, DateTimeKind.Utc),
                    RealtorId = 4,
                    CityId = 5,
                    CategoryId = 7
                }
            );
        }
    }        
}
