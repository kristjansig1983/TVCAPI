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
    [Migration("20230518132615_Added all songs to firs album")]
    partial class Addedallsongstofirsalbum
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
                            MerchImgUrl = "https://cdn.shopify.com/s/files/1/0506/9566/7910/products/T-SHIRT-TVC-Monuments-BLACK_600x.jpg?v=1621621536\r\n",
                            MerchName = "Monuments Cover Long sleeve",
                            MerchPrice = 3500
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
                            SongId = 1,
                            AlbumId = 1,
                            SongName = "Need a Woman"
                        },
                        new
                        {
                            SongId = 2,
                            AlbumId = 1,
                            SongName = "Corruption and Fraud"
                        },
                        new
                        {
                            SongId = 3,
                            AlbumId = 1,
                            SongName = "Sun-ray"
                        },
                        new
                        {
                            SongId = 4,
                            AlbumId = 1,
                            SongName = "Psychedelic Mushroom Man"
                        },
                        new
                        {
                            SongId = 5,
                            AlbumId = 1,
                            SongName = "Wild Child"
                        },
                        new
                        {
                            SongId = 6,
                            AlbumId = 1,
                            SongName = "Empty Space"
                        },
                        new
                        {
                            SongId = 7,
                            AlbumId = 1,
                            SongName = "Empty Space"
                        },
                        new
                        {
                            SongId = 8,
                            AlbumId = 1,
                            SongName = "Going Home"
                        },
                        new
                        {
                            SongId = 9,
                            AlbumId = 1,
                            SongName = "Black Swan"
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