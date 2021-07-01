using AutoMapper;
using MusicApi.Data.Entities;
using System.Linq;

namespace MusicApi.DataEF.Mapping
{
    public class DataEfMappingProfile : Profile
    {
        public DataEfMappingProfile()
        {
            CreateMap<DataEfAlbum, DataAlbum>()
                .ForMember(d => d.Ratings, cfg => cfg.MapFrom(s => s.Ratings.Select(x=>x.Rating)));
            CreateMap<DataEfSong, DataSong>()
                .ForMember(d => d.Ratings, cfg => cfg.MapFrom(s => s.Ratings.Select(x => x.Rating)));
        }
    }
}
