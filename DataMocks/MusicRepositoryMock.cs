using Data.Entities;
using Data.Interfaces;
using Moq.AutoMock;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataMocks
{
    public class MusicRepositoryMock : IMusicRepository
    {
        private AutoMocker mocker;

        public MusicRepositoryMock()
        {
            mocker = new AutoMocker();
        }

        public async Task<List<DataSong>> FindSongs(string template)
        {
            var result = new List<DataSong>();
            
            for (int i = 0; i < 10; i++)
                result.Add(mocker.CreateInstance<DataSong>());

            return result;
        }

        public async Task<DataAlbum> GetAlbum(int id)
            => mocker.CreateInstance<DataAlbum>();

        public async Task<DataArtist> GetArtist(int id)
            => mocker.CreateInstance<DataArtist>();
    }
}
