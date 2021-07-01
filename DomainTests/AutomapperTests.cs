using AutoMapper;
using NUnit.Framework;

namespace DomainTests
{
    [TestFixture]
    public class AutomapperTests
    {
        private MapperConfiguration domainConfig;
        private MapperConfiguration representationConfig;
        private MapperConfiguration dataEfConfig;

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

            dataEfConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps("MusicApi.DataEF");
            });
        }

        [Test]
        public void DomainMapping_ConfigurationTest()
        {
            domainConfig.AssertConfigurationIsValid();
        }
        
        [Test]
        public void DataEfMapping_ConfigurationTest()
        {
            dataEfConfig.AssertConfigurationIsValid();
        }
        
        [Test]
        public void RepresentationMapping_ConfigurationTest()
        {
            representationConfig.AssertConfigurationIsValid();
        }
    }
}