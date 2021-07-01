using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MusicApi.Data.Entities;
using System;

namespace MusicApi.DataEF.Infrastructure
{
    public class DataEfContext : DbContext
    {
        private readonly string connectionString;

        public DataEfContext()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("musicApi.DataEf.settings.json").Build();

            connectionString = configuration["connectionStrings:default"];
        }
        
        public DbSet<DataEfAlbum> Albums { get; set; }
        public DbSet<DataArtist> Artists { get; set; }
        public DbSet<DataRating> Ratings { get; set; }
        public DbSet<DataEfSong> Songs { get; set; }
        public DbSet<DataSongRating> SongRatings { get; set; }
        public DbSet<DataAlbumRating> AlbumRatings { get; set; }

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
            => options.UseSqlite(connectionString);
    }
}
