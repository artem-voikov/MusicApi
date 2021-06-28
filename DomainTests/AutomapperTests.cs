using AutoMapper;
using NUnit.Framework;

namespace DomainTests
{
    [TestFixture]
    public class AutomapperTests
    {
        private MapperConfiguration domainConfig;
        private MapperConfiguration representationConfig;

        public AutomapperTests()
        {
            domainConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps("MusicApi.Domain");
            });

            representationConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps("MusicApi.Representation");
            });
        }

        [Test]
        public void DomainMapping_ConfigurationTest()
        {
            domainConfig.AssertConfigurationIsValid();
        }
        
        [Test]
        public void RepresentationMapping_ConfigurationTest()
        {
            domainConfig.AssertConfigurationIsValid();
        }
    }
}