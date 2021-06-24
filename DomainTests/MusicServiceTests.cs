using Domain.Services;
using DomainTests.Builders;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DomainTests
{
    [TestFixture]
    class MusicServiceTests
    {
        private TestMusicServiceBuilder builder;
        private MusicService target;

        public MusicServiceTests()
        {
            builder = new TestMusicServiceBuilder();
        }

        [SetUp]
        public void Setup()
        {
            target = builder.Default().Build();
        }

        [Test]
        public async Task GetAlbum_ThrowNoError()
        {
            //Arrange
            target = builder
                .WithMusicRepository(albumName: "My test album")
                .Build();

            //Act
            var result = await target.GetAlbum(1);

            //Assert
            Assert.IsNotNull(result.Name);
        }

    }
}
