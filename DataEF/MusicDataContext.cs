using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEF
{
    public class MusicDataContext : DbContext
    {
        DbSet<DataAlbum> Albums { get; set; }
        DbSet<DataArtist> Artists { get; set; }
        DbSet<DataRating> Ratings { get; set; }
        DbSet<DataSong> Songs { get; set; }

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
            => options.UseSqlite(@$"Data Source={Environment.CurrentDirectory}\blogging.db");
    }
}
