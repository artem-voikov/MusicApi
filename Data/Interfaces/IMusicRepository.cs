using Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IMusicRepository
    {
        Task<DataAlbum> GetAlbum(int id);
        Task<DataArtist> GetArtist(int id);
        Task<List<DataSong>> FindSongs(string template);
    }
}
