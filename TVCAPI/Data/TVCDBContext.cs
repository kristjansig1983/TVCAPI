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
            Album a2 = new Album { AlbumId = 2, AlbumName = "Voyage", AlbumYear = 2012, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Voyage/Voyage.jpg" };
            Album a3 = new Album { AlbumId = 3, AlbumName = "Arrival", AlbumYear = 2015, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Arrival/Arrival.jpg" };
            Album a4 = new Album { AlbumId = 4, AlbumName = "Gateways", AlbumYear = 2018, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg" };
            Album a5 = new Album { AlbumId = 5, AlbumName = "Monuments", AlbumYear = 2021, AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg" };

            modelBuilder.Entity<Album>().HasData(a1);
            modelBuilder.Entity<Album>().HasData(a2);
            modelBuilder.Entity<Album>().HasData(a3);
            modelBuilder.Entity<Album>().HasData(a4);
            modelBuilder.Entity<Album>().HasData(a5);

            //Songs for The Vintage Caravan Album
            Song S1 = new Song { SongId = 1, SongName = "Need a Woman", AlbumId = 1 };
            Song S2 = new Song { SongId = 2, SongName = "Corruption and Fraud", AlbumId = 1 };
            Song S3 = new Song { SongId = 3, SongName = "Sun-ray", AlbumId = 1 };
            Song S4 = new Song { SongId = 4, SongName = "Psychedelic Mushroom Man", AlbumId = 1 };
            Song S5 = new Song { SongId = 5, SongName = "Wild Child", AlbumId = 1 };
            Song S6 = new Song { SongId = 6, SongName = "Empty Space", AlbumId = 1 };
            Song S7 = new Song { SongId = 7, SongName = "Let's Get It on", AlbumId = 1 };
            Song S8 = new Song { SongId = 8, SongName = "Going Home", AlbumId = 1 };
            Song S9 = new Song { SongId = 9, SongName = "Black Swan", AlbumId = 1 };
            

            modelBuilder.Entity<Song>().HasData(S1);
            modelBuilder.Entity<Song>().HasData(S2);
            modelBuilder.Entity<Song>().HasData(S3);
            modelBuilder.Entity<Song>().HasData(S4);
            modelBuilder.Entity<Song>().HasData(S5);
            modelBuilder.Entity<Song>().HasData(S6);
            modelBuilder.Entity<Song>().HasData(S7);
            modelBuilder.Entity<Song>().HasData(S8);
            modelBuilder.Entity<Song>().HasData(S9);

            //Songs for Voyage
            Song S10 = new Song { SongId = 10, SongName = "Know Your Place", AlbumId = 2 };
            Song S11 = new Song { SongId = 11, SongName = "Craving", AlbumId = 2 };
            Song S12 = new Song { SongId = 12, SongName = "Let Me Be", AlbumId = 2 };
            Song S13 = new Song { SongId = 13, SongName = "Do You Remember", AlbumId = 2 };
            Song S14 = new Song { SongId = 14, SongName = "M.A.R.S.W.A.T.T.", AlbumId = 2 };
            Song S15 = new Song { SongId = 15, SongName = "Cocaine Sally", AlbumId = 2 };
            Song S16 = new Song { SongId = 16, SongName = "Winterland", AlbumId = 2 };
            Song S17 = new Song { SongId = 17, SongName = "Midnight Meditation", AlbumId = 2 };
            Song S18 = new Song { SongId = 18, SongName = "The Kings Voyage", AlbumId = 2 };

            modelBuilder.Entity<Song>().HasData(S10);
            modelBuilder.Entity<Song>().HasData(S11);
            modelBuilder.Entity<Song>().HasData(S12);
            modelBuilder.Entity<Song>().HasData(S13);
            modelBuilder.Entity<Song>().HasData(S14);
            modelBuilder.Entity<Song>().HasData(S15);
            modelBuilder.Entity<Song>().HasData(S16);
            modelBuilder.Entity<Song>().HasData(S17);
            modelBuilder.Entity<Song>().HasData(S18);

            //Songs for Arrival
            Song S19 = new Song { SongId = 19, SongName = "Last Day of Light", AlbumId = 3 };
            Song S20 = new Song { SongId = 20, SongName = "Monolith", AlbumId = 3 };
            Song S21 = new Song { SongId = 21, SongName = "Babylon", AlbumId = 3 };
            Song S22 = new Song { SongId = 22, SongName = "Eclipsed", AlbumId = 3 };
            Song S23 = new Song { SongId = 23, SongName = "Shaken Beliefs", AlbumId = 3 };
            Song S24 = new Song { SongId = 24, SongName = "Crazy Horses", AlbumId = 3 };
            Song S25 = new Song { SongId = 25, SongName = "Sandwalker", AlbumId = 3 };
            Song S26 = new Song { SongId = 26, SongName = "Innerverse", AlbumId = 3 };
            Song S27 = new Song { SongId = 27, SongName = "Carousel", AlbumId = 3 };
            Song S28 = new Song { SongId = 28, SongName = "Winter Queen", AlbumId = 3 };
            Song S29 = new Song { SongId = 29, SongName = "Say Hello", AlbumId = 3 };
            Song S30 = new Song { SongId = 30, SongName = "Five Months", AlbumId = 3 };

            modelBuilder.Entity<Song>().HasData(S19);
            modelBuilder.Entity<Song>().HasData(S20);
            modelBuilder.Entity<Song>().HasData(S21);
            modelBuilder.Entity<Song>().HasData(S22);
            modelBuilder.Entity<Song>().HasData(S23);
            modelBuilder.Entity<Song>().HasData(S24);
            modelBuilder.Entity<Song>().HasData(S25);
            modelBuilder.Entity<Song>().HasData(S26);
            modelBuilder.Entity<Song>().HasData(S27);
            modelBuilder.Entity<Song>().HasData(S28);
            modelBuilder.Entity<Song>().HasData(S29);
            modelBuilder.Entity<Song>().HasData(S30);

            //Songs for Gateways
            Song S31 = new Song { SongId = 31, SongName = "Set Your Sights", AlbumId = 4 };
            Song S32 = new Song { SongId = 32, SongName = "The Way", AlbumId = 4 };
            Song S33 = new Song { SongId = 33, SongName = "Reflections", AlbumId = 4 };
            Song S34 = new Song { SongId = 34, SongName = "On the Run", AlbumId = 4 };
            Song S35 = new Song { SongId = 35, SongName = "All This Time", AlbumId = 4 };
            Song S36 = new Song { SongId = 36, SongName = "Hidden Streams", AlbumId = 4 };
            Song S37 = new Song { SongId = 37, SongName = "Reset", AlbumId = 4 };
            Song S38 = new Song { SongId = 38, SongName = "Nebula", AlbumId = 4 };
            Song S39 = new Song { SongId = 39, SongName = "Farewell", AlbumId = 4 };
            Song S40 = new Song { SongId = 40, SongName = "Tune out", AlbumId = 4 };
            Song S41 = new Song { SongId = 41, SongName = "The Chain (Fleetwood Mac Cover)", AlbumId = 4 };

            modelBuilder.Entity<Song>().HasData(S31);
            modelBuilder.Entity<Song>().HasData(S32);
            modelBuilder.Entity<Song>().HasData(S33);
            modelBuilder.Entity<Song>().HasData(S34);
            modelBuilder.Entity<Song>().HasData(S35);
            modelBuilder.Entity<Song>().HasData(S36);
            modelBuilder.Entity<Song>().HasData(S37);
            modelBuilder.Entity<Song>().HasData(S38);
            modelBuilder.Entity<Song>().HasData(S39);
            modelBuilder.Entity<Song>().HasData(S40);
            modelBuilder.Entity<Song>().HasData(S41);

            //Songs for Monuments
            Song S42 = new Song { SongId = 42, SongName = "Whispers", AlbumId = 5 };
            Song S43 = new Song { SongId = 43, SongName = "Crystallized", AlbumId = 5 };
            Song S44 = new Song { SongId = 44, SongName = "Can’t get you off my mind", AlbumId = 5 };
            Song S45 = new Song { SongId = 45, SongName = "Dark times", AlbumId = 5 };
            Song S46 = new Song { SongId = 46, SongName = "This one’s for you", AlbumId = 5 };
            Song S47 = new Song { SongId = 47, SongName = "Forgotten", AlbumId = 5 };
            Song S48 = new Song { SongId = 48, SongName = "Sharp teeth", AlbumId = 5 };
            Song S49 = new Song { SongId = 49, SongName = "Hell", AlbumId = 5 };
            Song S50 = new Song { SongId = 50, SongName = "Torn in two", AlbumId = 5 };
            Song S51 = new Song { SongId = 51, SongName = "Said&Done", AlbumId = 5 };
            Song S52 = new Song { SongId = 52, SongName = "Clarity", AlbumId = 5 };

            modelBuilder.Entity<Song>().HasData(S42);
            modelBuilder.Entity<Song>().HasData(S43);
            modelBuilder.Entity<Song>().HasData(S44);
            modelBuilder.Entity<Song>().HasData(S45);
            modelBuilder.Entity<Song>().HasData(S46);
            modelBuilder.Entity<Song>().HasData(S47);
            modelBuilder.Entity<Song>().HasData(S48);
            modelBuilder.Entity<Song>().HasData(S49);
            modelBuilder.Entity<Song>().HasData(S50);
            modelBuilder.Entity<Song>().HasData(S51);
            modelBuilder.Entity<Song>().HasData(S52);

            Merch m1 = new Merch { MerchId = 1, MerchName = "Monuments Cover Long sleeve", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536" };
            Merch m2 = new Merch { MerchId = 2, MerchName = "Monoliths T-shirt", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Monolithbaseball_700x.jpg?v=1621620613" };
            Merch m3 = new Merch { MerchId = 3, MerchName = "Tank Top", MerchPrice = 3000, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/tanktop_700x.jpg?v=1621620627" };
            Merch m4 = new Merch { MerchId = 4, MerchName = "Blizzard Long sleeve", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/files/Longsleeve-The-Vintage-Caravan-Blizzard_700x.jpg?v=1682686660" };
            Merch m5 = new Merch { MerchId = 5, MerchName = "Gateways T-shirt", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/t-shirt-gateways_700x.jpg?v=1621620596" };
            Merch m6 = new Merch { MerchId = 6, MerchName = "Hidden Streams T-shirt", MerchPrice = 3500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Hidden-Streams_700x.jpg?v=1621620620" };
            Merch m7 = new Merch { MerchId = 7, MerchName = "Coaster", MerchPrice = 500, MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/1COASTER-TVC-Logo_700x.jpg?v=1621621585" };

            modelBuilder.Entity<Merch>().HasData(m1);
            modelBuilder.Entity<Merch>().HasData(m2);
            modelBuilder.Entity<Merch>().HasData(m3);
            modelBuilder.Entity<Merch>().HasData(m4);
            modelBuilder.Entity<Merch>().HasData(m5);
            modelBuilder.Entity<Merch>().HasData(m6);
            modelBuilder.Entity<Merch>().HasData(m7);
        }
    }
}
