﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetroRidesAPI.Data;

#nullable disable

namespace RetroRidesAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230806205730_CreatedProcduct_Motorcycle_and_Car_model")]
    partial class CreatedProcduct_Motorcycle_and_Car_model
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RetroRidesAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentRun")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EngineDisplacement")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearOfManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasDiscriminator<string>("ProductType").HasValue("Product");

                    b.UseTphMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentRun = 5621,
                            Description = "This is a sample product description.",
                            EngineDisplacement = 150,
                            ImageUrl = "sample-image-url-1.jpg",
                            Manufacturer = "Sample Manufacturer",
                            ModelName = "Sample Product 1",
                            Price = 1000L,
                            YearOfManufacture = new DateTime(2018, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3893)
                        },
                        new
                        {
                            Id = 2,
                            CurrentRun = 780,
                            Description = "This is another sample product description.",
                            EngineDisplacement = 250,
                            ImageUrl = "sample-image-url-2.jpg",
                            Manufacturer = "Another Manufacturer",
                            ModelName = "Sample Product 2",
                            Price = 1500L,
                            YearOfManufacture = new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(3901)
                        });
                });

            modelBuilder.Entity("RetroRidesAPI.Models.Car", b =>
                {
                    b.HasBaseType("RetroRidesAPI.Models.Product");

                    b.Property<bool>("AirConditioning")
                        .HasColumnType("bit");

                    b.Property<bool>("AlloyWheels")
                        .HasColumnType("bit");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EntertainmentSystem")
                        .HasColumnType("bit");

                    b.Property<bool>("NavigationSystem")
                        .HasColumnType("bit");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Products", t =>
                        {
                            t.Property("Transmission")
                                .HasColumnName("Car_Transmission");
                        });

                    b.HasDiscriminator().HasValue("Car");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            CurrentRun = 4000,
                            Description = "This is a sample car description.",
                            EngineDisplacement = 2000,
                            ImageUrl = "sample-car-image-1.jpg",
                            Manufacturer = "Car Manufacturer",
                            ModelName = "Sample Car 1",
                            Price = 20000L,
                            YearOfManufacture = new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4015),
                            AirConditioning = true,
                            AlloyWheels = true,
                            CarType = "Sedan",
                            DriveType = "Front-Wheel Drive",
                            EntertainmentSystem = true,
                            NavigationSystem = true,
                            SeatingCapacity = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 4,
                            CurrentRun = 50000,
                            Description = "This is another sample car description.",
                            EngineDisplacement = 1800,
                            ImageUrl = "sample-car-image-2.jpg",
                            Manufacturer = "Another Car Manufacturer",
                            ModelName = "Sample Car 2",
                            Price = 25000L,
                            YearOfManufacture = new DateTime(2022, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4021),
                            AirConditioning = true,
                            AlloyWheels = true,
                            CarType = "Hatchback",
                            DriveType = "Rear-Wheel Drive",
                            EntertainmentSystem = true,
                            NavigationSystem = false,
                            SeatingCapacity = 4,
                            Transmission = "Manual"
                        });
                });

            modelBuilder.Entity("RetroRidesAPI.Models.Motorcycle", b =>
                {
                    b.HasBaseType("RetroRidesAPI.Models.Product");

                    b.Property<bool>("ABS")
                        .HasColumnType("bit");

                    b.Property<bool>("BluetoothConnectivity")
                        .HasColumnType("bit");

                    b.Property<string>("BrakeSystem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Motorcycle");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CurrentRun = 12000,
                            Description = "This is a sample motorcycle description.",
                            EngineDisplacement = 1000,
                            ImageUrl = "sample-motorcycle-image-1.jpg",
                            Manufacturer = "Motorcycle Manufacturer",
                            ModelName = "Sample Motorcycle 1",
                            Price = 8000L,
                            YearOfManufacture = new DateTime(2020, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4041),
                            ABS = true,
                            BluetoothConnectivity = false,
                            BrakeSystem = "Disc",
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 6,
                            CurrentRun = 5000,
                            Description = "This is another sample motorcycle description.",
                            EngineDisplacement = 750,
                            ImageUrl = "sample-motorcycle-image-2.jpg",
                            Manufacturer = "Another Motorcycle Manufacturer",
                            ModelName = "Sample Motorcycle 2",
                            Price = 6000L,
                            YearOfManufacture = new DateTime(2021, 8, 6, 20, 57, 30, 322, DateTimeKind.Utc).AddTicks(4045),
                            ABS = false,
                            BluetoothConnectivity = true,
                            BrakeSystem = "Drum",
                            Transmission = "Manual"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
