using AutoMapper;
using Domain.Entities;
using MusicApi.Data.Entities;
using System.Linq;

namespace Domain.Mapping
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<DataAlbum, Album>();
            CreateMap<DataArtist, Artist>();
            CreateMap<DataRating, Rating>();
            CreateMap<DataSong, Song>();
        }
    }
}
