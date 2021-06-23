using System.Collections.Generic;

namespace Data.Entities
{
    public class DataArtist
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public List<DataAlbum> Albums { get; set; }
    }
}
