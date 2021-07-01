using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class VmSong
    {
        public int SongId { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Time { get; set; }
        public int Popularity { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}