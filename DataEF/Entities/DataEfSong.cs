﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicApi.Data.Entities
{
    public class DataEfSong
    {
        [Key]
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public TimeSpan Time { get; set; }
        public int Popularity { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<DataSongRating> Ratings { get; set; }
    }
}