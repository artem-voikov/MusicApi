using System.ComponentModel.DataAnnotations;

namespace MusicApi.Data.Entities
{
    public class DataSongRating
    {
        [Key]
        public int SongRatingId { get; set; }
        public int RatingId { get; set; }
        public DataRating Rating { get; set; }
        public int SongId { get; set; }
        public DataSong Song { get; set; }
    }
}
