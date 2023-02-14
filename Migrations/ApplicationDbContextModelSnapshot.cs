﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaVillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 14, 9, 20, 9, 69, DateTimeKind.Local).AddTicks(2705),
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 14, 9, 20, 9, 69, DateTimeKind.Local).AddTicks(2717),
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Name = "Diamond Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 14, 9, 20, 9, 69, DateTimeKind.Local).AddTicks(2718),
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Name = "Diamond Pool Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 14, 9, 20, 9, 69, DateTimeKind.Local).AddTicks(2720),
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Name = "Royal Pool Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2023, 2, 14, 9, 20, 9, 69, DateTimeKind.Local).AddTicks(2721),
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Name = "Palace",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
