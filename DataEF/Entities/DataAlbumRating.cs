using System.ComponentModel.DataAnnotations;

namespace MusicApi.Data.Entities
{
    public class DataAlbumRating
    {
        [Key]
        public int AlbumRatingId { get; set; }
        public int RatingId { get; set; }
        public DataRating Rating { get; set; }
        public int AlbumId { get; set; }
        public DataAlbum Album { get; set; }
    }
}
