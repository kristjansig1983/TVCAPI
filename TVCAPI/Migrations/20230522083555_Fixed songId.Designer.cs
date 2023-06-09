﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TVCAPI.Data;

#nullable disable

namespace TVCAPI.Migrations
{
    [DbContext(typeof(TVCDBContext))]
    [Migration("20230522083555_Fixed songId")]
    partial class FixedsongId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TVCAPI.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<string>("AlbumCoverUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("AlbumYear")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            AlbumId = 1,
                            AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/The%20Vintage%20Caravan/The%20Vintage%20Caravan.jpg",
                            AlbumName = "The Vintage Caravan",
                            AlbumYear = 2009
                        },
                        new
                        {
                            AlbumId = 2,
                            AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Voyage/Voyage.jpg",
                            AlbumName = "Voyage",
                            AlbumYear = 2012
                        },
                        new
                        {
                            AlbumId = 3,
                            AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Arrival/Arrival.jpg",
                            AlbumName = "Arrival",
                            AlbumYear = 2015
                        },
                        new
                        {
                            AlbumId = 4,
                            AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg",
                            AlbumName = "Gateways",
                            AlbumYear = 2018
                        },
                        new
                        {
                            AlbumId = 5,
                            AlbumCoverUrl = "https://www.spirit-of-metal.com/les%20goupes/T/The%20Vintage%20Caravan/Gateways/Gateways_5124.jpg",
                            AlbumName = "Monuments",
                            AlbumYear = 2021
                        });
                });

            modelBuilder.Entity("TVCAPI.Models.Merch", b =>
                {
                    b.Property<int>("MerchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MerchId"));

                    b.Property<string>("MerchImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MerchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MerchPrice")
                        .HasColumnType("int");

                    b.HasKey("MerchId");

                    b.ToTable("Merches");

                    b.HasData(
                        new
                        {
                            MerchId = 1,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536",
                            MerchName = "Monuments Cover Long sleeve",
                            MerchPrice = 3500
                        },
                        new
                        {
                            MerchId = 2,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Monolithbaseball_700x.jpg?v=1621620613",
                            MerchName = "Monoliths T-shirt",
                            MerchPrice = 3500
                        },
                        new
                        {
                            MerchId = 3,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/tanktop_700x.jpg?v=1621620627",
                            MerchName = "Tank Top",
                            MerchPrice = 3000
                        },
                        new
                        {
                            MerchId = 4,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/files/Longsleeve-The-Vintage-Caravan-Blizzard_700x.jpg?v=1682686660",
                            MerchName = "Blizzard Long sleeve",
                            MerchPrice = 3500
                        },
                        new
                        {
                            MerchId = 5,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/t-shirt-gateways_700x.jpg?v=1621620596",
                            MerchName = "Gateways T-shirt",
                            MerchPrice = 3500
                        },
                        new
                        {
                            MerchId = 6,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/Hidden-Streams_700x.jpg?v=1621620620",
                            MerchName = "Hidden Streams T-shirt",
                            MerchPrice = 3500
                        },
                        new
                        {
                            MerchId = 7,
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/1COASTER-TVC-Logo_700x.jpg?v=1621621585",
                            MerchName = "Coaster",
                            MerchPrice = 500
                        });
                });

            modelBuilder.Entity("TVCAPI.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongId = 6,
                            AlbumId = 1,
                            SongName = "Need a Woman"
                        },
                        new
                        {
                            SongId = 7,
                            AlbumId = 1,
                            SongName = "Corruption and Fraud"
                        },
                        new
                        {
                            SongId = 8,
                            AlbumId = 1,
                            SongName = "Sun-ray"
                        },
                        new
                        {
                            SongId = 9,
                            AlbumId = 1,
                            SongName = "Psychedelic Mushroom Man"
                        },
                        new
                        {
                            SongId = 10,
                            AlbumId = 1,
                            SongName = "Wild Child"
                        },
                        new
                        {
                            SongId = 11,
                            AlbumId = 1,
                            SongName = "Empty Space"
                        },
                        new
                        {
                            SongId = 12,
                            AlbumId = 1,
                            SongName = "Let's Get It on"
                        },
                        new
                        {
                            SongId = 13,
                            AlbumId = 1,
                            SongName = "Going Home"
                        },
                        new
                        {
                            SongId = 14,
                            AlbumId = 1,
                            SongName = "Black Swan"
                        },
                        new
                        {
                            SongId = 15,
                            AlbumId = 2,
                            SongName = "Know Your Place"
                        },
                        new
                        {
                            SongId = 16,
                            AlbumId = 2,
                            SongName = "Craving"
                        },
                        new
                        {
                            SongId = 17,
                            AlbumId = 2,
                            SongName = "Let Me Be"
                        },
                        new
                        {
                            SongId = 18,
                            AlbumId = 2,
                            SongName = "Do You Remember"
                        },
                        new
                        {
                            SongId = 19,
                            AlbumId = 2,
                            SongName = "M.A.R.S.W.A.T.T."
                        },
                        new
                        {
                            SongId = 20,
                            AlbumId = 2,
                            SongName = "Cocaine Sally"
                        },
                        new
                        {
                            SongId = 21,
                            AlbumId = 2,
                            SongName = "Winterland"
                        },
                        new
                        {
                            SongId = 22,
                            AlbumId = 2,
                            SongName = "Midnight Meditation"
                        },
                        new
                        {
                            SongId = 23,
                            AlbumId = 2,
                            SongName = "The Kings Voyage"
                        },
                        new
                        {
                            SongId = 24,
                            AlbumId = 3,
                            SongName = "Last Day of Light"
                        },
                        new
                        {
                            SongId = 25,
                            AlbumId = 3,
                            SongName = "Monolith"
                        },
                        new
                        {
                            SongId = 26,
                            AlbumId = 3,
                            SongName = "Babylon"
                        },
                        new
                        {
                            SongId = 27,
                            AlbumId = 3,
                            SongName = "Eclipsed"
                        },
                        new
                        {
                            SongId = 28,
                            AlbumId = 3,
                            SongName = "Shaken Beliefs"
                        },
                        new
                        {
                            SongId = 29,
                            AlbumId = 3,
                            SongName = "Crazy Horses"
                        },
                        new
                        {
                            SongId = 30,
                            AlbumId = 3,
                            SongName = "Sandwalker"
                        },
                        new
                        {
                            SongId = 31,
                            AlbumId = 3,
                            SongName = "Innerverse"
                        },
                        new
                        {
                            SongId = 32,
                            AlbumId = 3,
                            SongName = "Carousel"
                        },
                        new
                        {
                            SongId = 33,
                            AlbumId = 3,
                            SongName = "Winter Queen"
                        },
                        new
                        {
                            SongId = 34,
                            AlbumId = 3,
                            SongName = "Say Hello"
                        },
                        new
                        {
                            SongId = 35,
                            AlbumId = 3,
                            SongName = "Five Months"
                        },
                        new
                        {
                            SongId = 36,
                            AlbumId = 4,
                            SongName = "Set Your Sights"
                        },
                        new
                        {
                            SongId = 37,
                            AlbumId = 4,
                            SongName = "The Way"
                        },
                        new
                        {
                            SongId = 38,
                            AlbumId = 4,
                            SongName = "Reflections"
                        },
                        new
                        {
                            SongId = 39,
                            AlbumId = 4,
                            SongName = "On the Run"
                        },
                        new
                        {
                            SongId = 40,
                            AlbumId = 4,
                            SongName = "All This Time"
                        },
                        new
                        {
                            SongId = 41,
                            AlbumId = 4,
                            SongName = "Hidden Streams"
                        },
                        new
                        {
                            SongId = 42,
                            AlbumId = 4,
                            SongName = "Reset"
                        },
                        new
                        {
                            SongId = 43,
                            AlbumId = 4,
                            SongName = "Nebula"
                        },
                        new
                        {
                            SongId = 44,
                            AlbumId = 4,
                            SongName = "Farewell"
                        },
                        new
                        {
                            SongId = 45,
                            AlbumId = 4,
                            SongName = "Tune out"
                        },
                        new
                        {
                            SongId = 46,
                            AlbumId = 4,
                            SongName = "The Chain (Fleetwood Mac Cover)"
                        },
                        new
                        {
                            SongId = 47,
                            AlbumId = 5,
                            SongName = "Whispers"
                        },
                        new
                        {
                            SongId = 48,
                            AlbumId = 5,
                            SongName = "Crystallized"
                        },
                        new
                        {
                            SongId = 49,
                            AlbumId = 5,
                            SongName = "Can’t get you off my mind"
                        },
                        new
                        {
                            SongId = 50,
                            AlbumId = 5,
                            SongName = "Dark times"
                        },
                        new
                        {
                            SongId = 52,
                            AlbumId = 5,
                            SongName = "This one’s for you"
                        },
                        new
                        {
                            SongId = 53,
                            AlbumId = 5,
                            SongName = "Forgotten"
                        },
                        new
                        {
                            SongId = 54,
                            AlbumId = 5,
                            SongName = "Sharp teeth"
                        },
                        new
                        {
                            SongId = 55,
                            AlbumId = 5,
                            SongName = "Hell"
                        },
                        new
                        {
                            SongId = 56,
                            AlbumId = 5,
                            SongName = "Torn in two"
                        },
                        new
                        {
                            SongId = 57,
                            AlbumId = 5,
                            SongName = "Said&Done"
                        },
                        new
                        {
                            SongId = 58,
                            AlbumId = 5,
                            SongName = "Clarity"
                        });
                });

            modelBuilder.Entity("TVCAPI.Models.Song", b =>
                {
                    b.HasOne("TVCAPI.Models.Album", null)
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TVCAPI.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
