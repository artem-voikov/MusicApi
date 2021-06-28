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
            CreateMap<DataAlbum, Album>()
                .ForMember(d => d.Ratings, cfg => cfg.MapFrom(s => s.Ratings.Select(x => x.Rating)));
            CreateMap<DataArtist, Artist>();
            CreateMap<DataRating, Rating>();
            CreateMap<DataSong, Song>()
                .ForMember(d=>d.Ratings, cfg => cfg.MapFrom(s=>s.Ratings.Select(x=>x.Rating)));
        }
    }
}
