using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTests.Builders
{
    abstract class BaseBuilder<T>
        where T : class
    {
        private MapperConfiguration mapperConfiguration;
        protected IMapper mapper;

        protected BaseBuilder()
        {
            mapperConfiguration = new MapperConfiguration(cfg => cfg.AddMaps("MusicApi.Domain", "MusicApi.Representation"));
            mapper = new Mapper(mapperConfiguration);
        }

        public abstract T Build();

        public abstract BaseBuilder<T> Default();
    }
}
