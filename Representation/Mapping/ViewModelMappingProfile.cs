using AutoMapper;
using Domain.Entities;
using Domain.Services;

namespace MusicApi.Mapping
{
    public class ViewModelMappingProfile : Profile
    {
        public ViewModelMappingProfile()
        {
            var customFieldMapper = new CustomFieldMapperService(); //TODO: substitute with injection

            CreateMap<Album, VmAlbum>()
                .ForMember(d => d.Popularity, cfg => cfg.MapFrom(s => customFieldMapper.MapRatings(s.Ratings)))
                .ForMember(d => d.VotersCount, cfg => cfg.MapFrom(s => s.Ratings.Count));

            CreateMap<Artist, VmArtist>();
            CreateMap<Rating, VmRating>();
            CreateMap<Song, VmSong>()
                .ForMember(d => d.Popularity, cfg => cfg.MapFrom(s => customFieldMapper.MapRatings(s.Ratings)));
        }
    }
}
