﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApi.DataEF.Infrastructure;

namespace MusicApi.DataEF.Migrations
{
    [DbContext(typeof(DataEfContext))]
    [Migration("20210628154402_AddAlbums")]
    partial class AddAlbums
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MusicApi.Data.Entities.DataAlbum", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DataArtistArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Licence")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Review")
                        .HasColumnType("TEXT");

                    b.HasKey("AlbumId");

                    b.HasIndex("DataArtistArtistId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataAlbumRating", b =>
                {
                    b.Property<int>("AlbumRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlbumRating");

                    b.HasIndex("AlbumId");

                    b.HasIndex("RatingId");

                    b.ToTable("AlbumRatings");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataArtist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataRating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataSong", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DataAlbumAlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Popularity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("SongId");

                    b.HasIndex("DataAlbumAlbumId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataSongRating", b =>
                {
                    b.Property<int>("SongRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SongId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SongRatingId");

                    b.HasIndex("RatingId");

                    b.HasIndex("SongId");

                    b.ToTable("SongRatings");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataAlbum", b =>
                {
                    b.HasOne("MusicApi.Data.Entities.DataArtist", null)
                        .WithMany("Albums")
                        .HasForeignKey("DataArtistArtistId");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataAlbumRating", b =>
                {
                    b.HasOne("MusicApi.Data.Entities.DataAlbum", "Album")
                        .WithMany("Ratings")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Entities.DataRating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataSong", b =>
                {
                    b.HasOne("MusicApi.Data.Entities.DataAlbum", null)
                        .WithMany("Songs")
                        .HasForeignKey("DataAlbumAlbumId");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataSongRating", b =>
                {
                    b.HasOne("MusicApi.Data.Entities.DataRating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Entities.DataSong", "Song")
                        .WithMany("Ratings")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rating");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataAlbum", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataArtist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicApi.Data.Entities.DataSong", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
