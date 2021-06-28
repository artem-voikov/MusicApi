using MusicApi.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicApi.Data.Interfaces
{
    public interface IMusicRepository
    {
        Task<DataAlbum> GetAlbum(int id);
        Task<DataArtist> GetArtist(int id);
        Task<IEnumerable<DataSong>> FindSongs(string template);
    }
}
