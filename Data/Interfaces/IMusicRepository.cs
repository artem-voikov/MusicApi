using Data.Entities;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IMusicRepository
    {
        DataAlbum GetAlbum(int id);
        DataArtist GetArtist(int id);
        List<DataSong> FindSong(string template);
    }
}
