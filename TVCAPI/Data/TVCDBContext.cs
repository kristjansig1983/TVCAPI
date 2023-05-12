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

            Song S1 = new Song { SongId = 1, SongName = "Need a Woman", AlbumId = 1 };

            modelBuilder.Entity<Song>().HasData(S1);

            Merch m1 = new Merch { MerchId = 1, MerchName = "Monuments Cover Long sleeve", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536\r\n" };

            modelBuilder.Entity<Merch>().HasData(m1);
        }
    }
}
