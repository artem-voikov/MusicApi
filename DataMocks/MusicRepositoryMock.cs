using Data.Entities;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataMocks
{
    public class MusicRepositoryMock : IMusicRepository
    {
        private const string genre = "POP";
        private const string artist = "Backstreet Boys";
        Random random;
        DataArtist dataArtist;
        DataAlbum dataAlbum;
        List<DataSong> dataSongs = new List<DataSong>();

        public MusicRepositoryMock()
        {
            random = new Random();
            dataSongs = new List<DataSong>
            { 
                CreateSong("Don't Go Breaking My Heart"),
                CreateSong("Nobody Else"),
                CreateSong("Breathe"),
                CreateSong("New Love"),
                CreateSong("Passhionate"),
                CreateSong("Is It Just Me"),
                CreateSong("Chances"),
                CreateSong("No Place"),
                CreateSong("Chateau"),
                CreateSong("The Way It Was"),
                CreateSong("Just Like You Like It"),
                CreateSong("Ok")
            };
            dataAlbum = new DataAlbum { Name = "DNA", Description = "Description text", Genre = genre, Songs = dataSongs, Price = 11.99m };
            dataArtist = new DataArtist { Albums = new List<DataAlbum> { dataAlbum }, Genre = genre, Name = artist };

        }

        private DataSong CreateSong(string name, double time = 320)
            => new DataSong
            {
                Artist = artist,
                Genre = genre,
                Popularity = random.Next(1, 100),
                Price = 1.29m,
                Time = TimeSpan.FromSeconds(time),
                Ratings = GetRatings().ToList(),
                SongId = dataSongs.Count + 1,
                Name = name
            };

        private IEnumerable<DataRating> GetRatings()
        {
            for (int i = 0; i < random.Next(5, 15); i++)
                yield return new DataRating
                {
                    RateDate = DateTime.Now.AddDays(random.Next(3, 5) * -1),
                    RatingId = i + 1,
                    Value = random.Next(1, 10)
                };
        }

        public Task<IEnumerable<DataSong>> FindSongs(string template)
            => Task.FromResult(dataSongs.Where(x => x.Name.ToLower().Contains(template.ToLower())));

        public Task<DataAlbum> GetAlbum(int id)
            => Task.FromResult(dataAlbum);

        public Task<DataArtist> GetArtist(int id)
            => Task.FromResult(dataArtist);
    }
}
