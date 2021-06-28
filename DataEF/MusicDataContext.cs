using Microsoft.EntityFrameworkCore;
using MusicApi.Data.Entities;
using System;

namespace DataEF
{
    public class MusicDataContext : DbContext
    {
        DbSet<DataAlbum> Albums { get; set; }
        DbSet<DataArtist> Artists { get; set; }
        DbSet<DataRating> Ratings { get; set; }
        DbSet<DataSong> Songs { get; set; }

        DbSet<DataSongRating> SongRatings { get; set; }
        DbSet<DataAlbumRating> AlbumRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataAlbum>()
                .HasKey(x => new { x.AlbumId });
            modelBuilder.Entity<DataArtist>()
                .HasKey(x => new { x.ArtistId });
            modelBuilder.Entity<DataRating>()
                .HasKey(x => new { x.RatingId });
            modelBuilder.Entity<DataSong>()
                .HasKey(x => new { x.SongId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@$"Data Source={Environment.CurrentDirectory}\musicData.db");
    }
}
