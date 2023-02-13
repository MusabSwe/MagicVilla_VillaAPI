using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    //DbContext is class in the EntityFrameworkCore package
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
                
        }
        // used to create the table
        // in the SQL Server and the name
        // will be villas as the name of attribute (field)
        // This linked to the EF Core to transl it
        // to the Relational DB
        public DbSet<Villa> Villas { get; set; }

    }
}
