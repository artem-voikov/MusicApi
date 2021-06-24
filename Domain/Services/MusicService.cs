using AutoMapper;
using Data.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class MusicService : IMusicService
    {
        private readonly IMapper mapper;
        private readonly IMusicRepository musicRepository;

        public MusicService(IMapper mapper, IMusicRepository musicRepository)
        {
            this.mapper = mapper;
            this.musicRepository = musicRepository;
        }

        public async Task<Album> GetAlbum(int id)
        {
            var dbAlbum = await musicRepository.GetAlbum(id);
            var album = mapper.Map<Album>(dbAlbum);

            return album;
        }

        public async Task<Artist> GetArtist(int id)
        {
            var dbArtist = await musicRepository.GetArtist(id);
            var artist = mapper.Map<Artist>(dbArtist);

            return artist;
        }

        public async Task<List<Song>> GetSongs(string template)
        {
            throw new NotImplementedException();
        }
    }
}
