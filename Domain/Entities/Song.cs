using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public TimeSpan Time { get; set; }
        public string Popularity { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}