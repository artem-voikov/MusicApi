using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class DataSong
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public TimeSpan Time { get; set; }
        public int Popularity { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<DataRating> Ratings { get; set; }
    }
}