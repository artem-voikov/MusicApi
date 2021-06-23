using AutoMapper;
using AutoMapper.Execution;
using Domain;
using Domain.Mapping;
using NUnit.Framework;

namespace DomainTests
{
    public class Tests
    {
        private MapperConfiguration config;

        public Tests()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(IDomainMarker));
            });
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            config.AssertConfigurationIsValid();
        }
    }
}