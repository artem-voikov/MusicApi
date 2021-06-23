using AutoMapper;
using Data.Entities;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
