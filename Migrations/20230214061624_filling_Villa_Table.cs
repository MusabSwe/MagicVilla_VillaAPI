using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class fillingVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1", "Diamond Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1", "Diamond Pool Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1", "Royal Pool Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1", "Palace", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
