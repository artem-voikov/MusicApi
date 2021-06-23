using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Album
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Song> Songs { get; set; }

        public List<Rating> Ratings { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Licence { get; set; }
        public string Review { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Genre { get; set; }
    }
}
