﻿using System;
using System.Collections.Generic;

namespace MusicApi.Data.Entities
{
    public class DataAlbum
    {
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<DataSong> Songs { get; set; }
        public IEnumerable<DataRating> Ratings { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Licence { get; set; }
        public string Review { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
    }
}
