using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataEF.Repositories
{
    public class MusicEFRepository : IMusicRepository
    {
        public async Task<IEnumerable<DataSong>> FindSongs(string template)
        {
            throw new NotImplementedException();
        }

        public async Task<DataAlbum> GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DataArtist> GetArtist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
