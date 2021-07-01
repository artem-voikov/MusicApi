using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IMusicService
    {
        Task<Album> GetAlbum(int id);
        Task<Artist> GetArtist(int id);
        Task<List<Song>> FindSongs(string template);
        Task<List<Song>> GetAlbumSongs(int id);
        Task<List<Album>> GetArtistAlbums(int id);
    }
}
