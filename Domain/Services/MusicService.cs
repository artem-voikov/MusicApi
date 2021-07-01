using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MusicApi.Data.Entities;
using MusicApi.Data.Interfaces;
using System;
using System.Collections.Concurrent;
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

        public async Task<List<Song>> FindSongs(string template)
        {
            var dbSongs = new ConcurrentDictionary<string, DataSong>();
            var targets = template.Split(" ");
            
            targets
                //I've done it in this way for no reason. 
                //Just a matter of boredom
                .AsParallel().ForAll(async partOfTemplate =>
                {
                    var response = await musicRepository.FindSongs(partOfTemplate);
                    foreach (var song in response)
                        if(song.Name.Contains(partOfTemplate))
                            dbSongs.TryAdd(song.Name, song);
                });

            var songs = dbSongs
                .Select(x => mapper.Map<Song>(x.Value))
                .ToList();

            return songs;

        }

        public async Task<List<Song>> GetAlbumSongs(int id)
        {
            var dbSongs = await musicRepository.GetAlbumSongs(id);
            var result = dbSongs.Select(x => mapper.Map<Song>(x));

            return result.ToList();
        }

        public async Task<List<Album>> GetArtistAlbums(int id)
        {
            var dbSongs = await musicRepository.GetArtistAlbums(id);
            var result = dbSongs.Select(x => mapper.Map<Album>(x));

            return result.ToList();
        }
    }
}
