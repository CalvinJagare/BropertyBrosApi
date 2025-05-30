﻿// <auto-generated />
using System;
using BropertyBrosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BropertyBrosApi2._0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250418162038_update")]
    partial class update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BropertyBrosApi.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Lägenhet"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Villa"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Radhus"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Bostadsrätt"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Hyresrätt"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Fritidshus"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Stuga"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Kollektivboende"
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Studentboende"
                        });
                });

            modelBuilder.Entity("BropertyBrosApi.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Stockholm"
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Göteborg"
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Malmö"
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Uppsala"
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Luleå"
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Örebro"
                        });
                });

            modelBuilder.Entity("BropertyBrosApi.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AncillaryAreaKvm")
                        .HasColumnType("int");

                    b.Property<int>("BuildYear")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LandAreaKvm")
                        .HasColumnType("int");

                    b.Property<int>("LivingAreaKvm")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyFee")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("RealtorId")
                        .HasColumnType("int");

                    b.Property<int>("YearlyFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("RealtorId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Exempelgatan 12",
                            AncillaryAreaKvm = 10,
                            BuildYear = 2010,
                            CategoryId = 4,
                            CityId = 1,
                            CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Fin bostadsrätt i centrala Stockholm.",
                            ImageUrls = "[\"https://example.com/images/property1.jpg,https://example.com/images/property2.jpg\"]",
                            LandAreaKvm = 0,
                            LivingAreaKvm = 85,
                            MonthlyFee = 3500,
                            NumberOfRooms = 3,
                            Price = 4500000,
                            RealtorId = 1,
                            YearlyFee = 42000
                        },
                        new
                        {
                            Id = 2,
                            Address = "Villavägen 7",
                            AncillaryAreaKvm = 30,
                            BuildYear = 1995,
                            CategoryId = 2,
                            CityId = 2,
                            CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Stor villa med trädgård och garage.",
                            ImageUrls = "[\"https://example.com/images/property3.jpg,https://example.com/images/property4.jpg\"]",
                            LandAreaKvm = 500,
                            LivingAreaKvm = 140,
                            MonthlyFee = 0,
                            NumberOfRooms = 5,
                            Price = 6700000,
                            RealtorId = 2,
                            YearlyFee = 12000
                        },
                        new
                        {
                            Id = 3,
                            Address = "Sommarvägen 3",
                            AncillaryAreaKvm = 5,
                            BuildYear = 2018,
                            CategoryId = 1,
                            CityId = 3,
                            CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Ljus och modern lägenhet nära havet.",
                            ImageUrls = "[\"https://example.com/images/property5.jpg,https://example.com/images/property6.jpg\"]",
                            LandAreaKvm = 0,
                            LivingAreaKvm = 70,
                            MonthlyFee = 2000,
                            NumberOfRooms = 2,
                            Price = 2800000,
                            RealtorId = 3,
                            YearlyFee = 24000
                        },
                        new
                        {
                            Id = 4,
                            Address = "Stugvägen 1",
                            AncillaryAreaKvm = 15,
                            BuildYear = 1980,
                            CategoryId = 7,
                            CityId = 5,
                            CreatedAt = new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Mysig stuga i skogsmiljö.",
                            ImageUrls = "[\"https://example.com/images/property7.jpg\",\"https://example.com/images/property8.jpg\"]",
                            LandAreaKvm = 1000,
                            LivingAreaKvm = 45,
                            MonthlyFee = 0,
                            NumberOfRooms = 2,
                            Price = 1600000,
                            RealtorId = 4,
                            YearlyFee = 10000
                        });
                });

            modelBuilder.Entity("BropertyBrosApi.Models.Realtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RealtorFirmId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RealtorFirmId");

                    b.ToTable("Realtors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "markus@bropertybros.se",
                            FirstName = "Markus",
                            LastName = "Friberg",
                            PhoneNumber = "0705712647",
                            ProfileUrl = "https://example.com/profiles/markus.png",
                            RealtorFirmId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "sanna@bropertybros.se",
                            FirstName = "Sanna",
                            LastName = "Mäklarsson",
                            PhoneNumber = "0731234567",
                            ProfileUrl = "https://example.com/profiles/sanna.png",
                            RealtorFirmId = 1
                        },
                        new
                        {
                            Id = 3,
                            Email = "erik@maklarkompaniet.se",
                            FirstName = "Erik",
                            LastName = "Fast",
                            PhoneNumber = "0704455667",
                            ProfileUrl = "https://example.com/profiles/erik.png",
                            RealtorFirmId = 2
                        },
                        new
                        {
                            Id = 4,
                            Email = "anna@fastighetsmastarna.se",
                            FirstName = "Anna",
                            LastName = "Sund",
                            PhoneNumber = "0761122334",
                            ProfileUrl = "https://example.com/profiles/anna.png",
                            RealtorFirmId = 3
                        },
                        new
                        {
                            Id = 5,
                            Email = "johan@maklarkompaniet.se",
                            FirstName = "Johan",
                            LastName = "Bostad",
                            PhoneNumber = "0723344556",
                            ProfileUrl = "https://example.com/profiles/johan.png",
                            RealtorFirmId = 2
                        });
                });

            modelBuilder.Entity("BropertyBrosApi.Models.RealtorFirm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RealtorFirms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyName = "Broperty Bros",
                            Description = "En modern mäklarfirma med fokus på teknik och AI.",
                            LogoUrl = "https://example.com/logos/bropertybros.png",
                            WebsiteUrl = "https://bropertybros.se"
                        },
                        new
                        {
                            Id = 2,
                            CompanyName = "Mäklarkompaniet",
                            Description = "Traditionellt kunnande, moderna lösningar.",
                            LogoUrl = "https://example.com/logos/maklarkompaniet.png",
                            WebsiteUrl = "https://maklarkompaniet.se"
                        },
                        new
                        {
                            Id = 3,
                            CompanyName = "Fastighetsmästarna",
                            Description = "Specialister på bostäder i hela Sverige.",
                            LogoUrl = "https://example.com/logos/fastighetsmastarna.png",
                            WebsiteUrl = "https://fastighetsmastarna.se"
                        });
                });

            modelBuilder.Entity("BropertyBrosApi.Models.Property", b =>
                {
                    b.HasOne("BropertyBrosApi.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BropertyBrosApi.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BropertyBrosApi.Models.Realtor", "Realtor")
                        .WithMany("Properties")
                        .HasForeignKey("RealtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("Realtor");
                });

            modelBuilder.Entity("BropertyBrosApi.Models.Realtor", b =>
                {
                    b.HasOne("BropertyBrosApi.Models.RealtorFirm", "RealtorFirm")
                        .WithMany("Realtors")
                        .HasForeignKey("RealtorFirmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RealtorFirm");
                });

            modelBuilder.Entity("BropertyBrosApi.Models.Realtor", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("BropertyBrosApi.Models.RealtorFirm", b =>
                {
                    b.Navigation("Realtors");
                });
#pragma warning restore 612, 618
        }
    }
}
