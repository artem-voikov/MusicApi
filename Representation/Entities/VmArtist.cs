using System.Collections.Generic;

namespace Domain.Entities
{
    public class VmArtist
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Genre { get; set; }
        public List<VmAlbum> Albums { get; set; }
    }
}
