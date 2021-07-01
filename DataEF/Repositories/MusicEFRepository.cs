using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MusicApi.Data.Entities;
using MusicApi.Data.Interfaces;
using MusicApi.DataEF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEF.Repositories
{
    public class MusicEFRepository : IMusicRepository
    {
        private readonly IMapper mapper;
        private readonly DataEfContext context;

        public MusicEFRepository(IMapper mapper, DataEfContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public async Task<IEnumerable<DataSong>> FindSongs(string template)
        {
            var result = await (from s in context.Songs
                                where s.Name.Contains(template)
                                select s).ToListAsync();

            return result.Select(x => mapper.Map<DataSong>(x));
        }

        public async Task<DataAlbum> GetAlbum(int id)
        {
            var result = await context.Albums.FirstOrDefaultAsync(x => x.AlbumId == id);

            return mapper.Map<DataAlbum>(result);
        }

        public async Task<IEnumerable<DataSong>> GetAlbumSongs(int id)
        {
            var result = await context.Songs.Where(x => x.DataAlbumAlbumId == id).ToListAsync();

            return result.Select(x => mapper.Map<DataSong>(x));
        }

        public async Task<DataArtist> GetArtist(int id)
        {
            var result = await context.Artists.FirstOrDefaultAsync(x => x.ArtistId == id);

            return result;
        }

        public async Task<IEnumerable<DataAlbum>> GetArtistAlbums(int id)
        {
            var result = await context.Albums.Where(x => x.DataArtistArtistId == id).ToListAsync();

            return result.Select(x => mapper.Map<DataAlbum>(x));
        }
    }
}
