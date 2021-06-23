using System.Collections.Generic;

namespace Domain.Entities
{
    public class Artist
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public List<Album> Albums { get; set; }
    }
}
