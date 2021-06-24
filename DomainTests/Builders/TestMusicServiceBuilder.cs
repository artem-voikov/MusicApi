using Data.Entities;
using Data.Interfaces;
using Domain.Services;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainTests.Builders
{
    class TestMusicServiceBuilder : BaseBuilder<MusicService>
    {
        public const string AlbumName = "DNA";
        public const string ArtistName = "Backstreet boys";
        public const string SongName1 = "Don't Go Breaking My Heart";
        public const string SongName2 = "Nobody Else";

        Mock<IMusicRepository> mockMusicRepository = new Mock<IMusicRepository>();

        public override MusicService Build()
            => new MusicService(mapper, mockMusicRepository.Object);

        public override BaseBuilder<MusicService> Default()
            => WithMusicRepository(AlbumName, ArtistName, SongName1, SongName2);

        public BaseBuilder<MusicService> WithMusicRepository(string albumName = AlbumName, string artistName = ArtistName, params string[] songNames)
        {
            var album = new DataAlbum
            {
                Name = albumName
            };
            var artist = new DataArtist
            {
                Name = artistName,
                Albums = new List<DataAlbum> { album }
            };
            var songs = songNames.Select(x => new DataSong { Name = x, Artist = artist.Name });
            album.Songs = songs.ToList();

            mockMusicRepository.Setup(x => x.GetAlbum(It.IsAny<int>())).Returns(Task.FromResult(album));
            mockMusicRepository.Setup(x => x.GetArtist(It.IsAny<int>())).Returns(Task.FromResult(artist));
            mockMusicRepository.Setup(x => x.FindSong(It.IsAny<string>())).Returns(Task.FromResult(songs.ToList()));
            return this;
        }
    }
}
