﻿// <auto-generated />
using CarListApp.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarListApp.Api.Migrations
{
    [DbContext(typeof(CarListDbContext))]
    [Migration("20240201182251_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("CarListApp.Api.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Make = "Tundra",
                            Model = "Toyota",
                            Vin = "123456"
                        },
                        new
                        {
                            Id = 2,
                            Make = "Versa",
                            Model = "Nissan",
                            Vin = "123456"
                        },
                        new
                        {
                            Id = 3,
                            Make = "Civic",
                            Model = "Honda",
                            Vin = "123456"
                        },
                        new
                        {
                            Id = 4,
                            Make = "X1",
                            Model = "BMW",
                            Vin = "123456"
                        },
                        new
                        {
                            Id = 5,
                            Make = "C250",
                            Model = "Mercedes",
                            Vin = "123456"
                        },
                        new
                        {
                            Id = 6,
                            Make = "Fiesta",
                            Model = "Ford",
                            Vin = "123456"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
