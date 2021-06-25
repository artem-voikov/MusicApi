using AutoMapper;
using NUnit.Framework;

namespace DomainTests
{
    [TestFixture]
    public class AutomapperTests
    {
        private MapperConfiguration config;

        public AutomapperTests()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps("Domain");
            });
        }

        [Test]
        public void ConfigurationTest()
        {
            config.AssertConfigurationIsValid();
        }
    }
}