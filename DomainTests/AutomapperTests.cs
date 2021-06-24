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