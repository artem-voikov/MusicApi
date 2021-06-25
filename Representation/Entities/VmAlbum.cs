using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class VmAlbum
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<VmSong> Songs { get; set; }

        public int Popularity { get; set; }
        public int VotersCount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Licence { get; set; }
        public string Review { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
    }
}
