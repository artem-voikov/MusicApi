using System.Collections.Generic;

namespace Domain.Entities
{
    public class VmArtist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public List<VmAlbum> Albums { get; set; }
    }
}
