using Domain.Services;
using DomainTests.Builders;
using NUnit.Framework;
using System;
using System.Linq;
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
        public async Task GetAlbum_ThrowsNoError()
        {
            //Arrange
            target = builder
                .Default()
                .Build();

            //Act
            var result = await target.GetAlbum(1);

            //Assert
            Assert.IsNotNull(result.Name);
        }

        [TestCase(3, "aaa bbb")]
        [TestCase(2, "aaa")]
        [TestCase(2, "bbb ccc")]
        [TestCase(0, "ccc")]
        public async Task GetSong_TemplateWithSpace_LooksForTwoSongs(int count, string template)
        {
            target = builder
                .WithMusicRepository(songNames: new[] { "aaa", "aaa bbb", "bbb" })
                .Build();

            var result = await target.FindSongs(template);

            Assert.AreEqual(count, result.Count);
        }

        [TestCase(50000, 3, "aaa bbb")]
        public async Task GetSong_TemplateWithSpace_Performs(int count, int expectedCount, string template)
        {
            var names = Enumerable.Repeat(new[] { "aaa", "aaa bbb", "bbb" }, count).SelectMany(x => x).ToArray();
            target = builder
                .WithMusicRepository(songNames: names)
                .Build();

            var result = await target.FindSongs(template);

            Assert.AreEqual(expectedCount, result.Count);
        }
    }
}
