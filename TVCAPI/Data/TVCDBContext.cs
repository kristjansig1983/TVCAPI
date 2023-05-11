using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using TVCAPI.Models;

namespace TVCAPI.Data
{
    public class TVCDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Merch> Merches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TVCDB");
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Album a1 = new Album { AlbumId = 1, AlbumName = "The Vintage Caravan", AlbumYear = 2009, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg" };

            modelBuilder.Entity<Album>().HasData(a1);
        }
    }
}
