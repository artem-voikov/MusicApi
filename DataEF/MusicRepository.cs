using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DataEF
{
    public class MusicRepository : IMusicRepository
    {
        public List<DataSong> FindSong(string template)
        {
            throw new NotImplementedException();
        }

        public DataAlbum GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public DataArtist GetArtist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
