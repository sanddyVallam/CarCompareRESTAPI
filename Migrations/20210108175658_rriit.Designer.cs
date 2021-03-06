﻿// <auto-generated />
using CarCampareToolRESTAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarCampareToolRESTAPI.Migrations
{
    [DbContext(typeof(CarCompareContext))]
    [Migration("20210108175658_rriit")]
    partial class rriit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarCampareToolRESTAPI.Model.CarModelCommon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BestValue")
                        .HasColumnType("float");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FuelConsumption")
                        .HasColumnType("float");

                    b.Property<int>("HwMPG")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("TCCRating")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("CarModel");

                    b.HasData(
                        new
                        {
                            id = 1,
                            BestValue = 0.0,
                            Color = "Green",
                            FuelConsumption = 0.0,
                            HwMPG = 33,
                            Make = "Honda",
                            Model = "CRV ",
                            Price = 23845,
                            TCCRating = 8.0,
                            Year = 2016
                        },
                        new
                        {
                            id = 2,
                            BestValue = 0.0,
                            Color = "Red",
                            FuelConsumption = 0.0,
                            HwMPG = 32,
                            Make = "Ford ",
                            Model = "Escape ",
                            Price = 23590,
                            TCCRating = 7.7999999999999998,
                            Year = 2017
                        },
                        new
                        {
                            id = 3,
                            BestValue = 0.0,
                            Color = "Grey",
                            FuelConsumption = 0.0,
                            HwMPG = 27,
                            Make = "Hyundai ",
                            Model = "Sante Fe",
                            Price = 24950,
                            TCCRating = 8.0,
                            Year = 2016
                        },
                        new
                        {
                            id = 4,
                            BestValue = 0.0,
                            Color = "Red",
                            FuelConsumption = 0.0,
                            HwMPG = 35,
                            Make = "Mazda ",
                            Model = "CX-5",
                            Price = 21795,
                            TCCRating = 8.0,
                            Year = 2017
                        },
                        new
                        {
                            id = 5,
                            BestValue = 0.0,
                            Color = "Blue",
                            FuelConsumption = 0.0,
                            HwMPG = 32,
                            Make = "Subaru ",
                            Model = "Forester",
                            Price = 22395,
                            TCCRating = 8.4000000000000004,
                            Year = 2016
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
