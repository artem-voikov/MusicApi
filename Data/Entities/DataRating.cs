using System;

namespace MusicApi.Data.Entities
{
    public class DataRating
    {
        public int RatingId { get; set; }
        public int Value { get; set; }
        public DateTime RateDate { get; set; }
    }
}