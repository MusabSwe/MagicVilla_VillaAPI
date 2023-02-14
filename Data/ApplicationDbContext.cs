using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    //DbContext is class in the EntityFrameworkCore package
    public class ApplicationDbContext : DbContext
    {
        // used to configure EF core with any .Net Application
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        // used to create the table
        // in the SQL Server and the name
        // will be villas as the name of attribute (field)
        // This linked to the EF Core to transl it
        // to the Relational DB
        //DbSet<Class_Name> used to create table
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(

                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                    ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                },
                  new Villa()
                  {
                      Id = 2,
                      Name = "Diamond Villa",
                      Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                      ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                      Occupancy = 5,
                      Rate = 200,
                      Sqft = 550,
                      Amenity = "",
                      CreatedDate = DateTime.Now,
                  },
                    new Villa()
                    {
                        Id = 3,
                        Name = "Diamond Pool Villa",
                        Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                        ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                        Occupancy = 5,
                        Rate = 200,
                        Sqft = 550,
                        Amenity = "",
                        CreatedDate = DateTime.Now,
                    },
                      new Villa()
                      {
                          Id = 4,
                          Name = "Royal Pool Villa",
                          Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                          ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                          Occupancy = 5,
                          Rate = 200,
                          Sqft = 550,
                          Amenity = "",
                          CreatedDate= DateTime.Now,
                      },
                        new Villa()
                        {
                            Id = 5,
                            Name = "Palace",
                            Details = "Fusce 11 lea, sda massa auctor sit amt, Donec ex, Fusce 11 lea, sda massa auctor sit amt, Donec ex",
                            ImageUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/04/a2/e8/3a/royal-villa.jpg?w=700&h=-1&s=1",
                            Occupancy = 5,
                            Rate = 200,
                            Sqft = 550,
                            Amenity = "",
                            CreatedDate = DateTime.Now,
                        }
                );
        }
    }
}
