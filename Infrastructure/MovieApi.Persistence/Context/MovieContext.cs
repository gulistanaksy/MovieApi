using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MovieApi.Persistence.Context
{
    public class MovieContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HCI1PTP; initial Catalog=ApiMovieDb; integrated Security=true");
        }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Review> Reviews { get; set; }
       public DbSet<Tag> Tags { get; set; }
       public DbSet<Cast> Casts { get; set; }

    }
}
