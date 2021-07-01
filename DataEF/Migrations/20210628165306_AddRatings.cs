using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Text;

namespace MusicApi.DataEF.Migrations
{
    public partial class AddRatings : Migration
    {
        private Random random = new Random();
        private DateTime now = new DateTime(2019, 2, 2);

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var ratingValues = new StringBuilder();
            var manyToManyValues = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                ratingValues.Append(@$"({random.Next(1, 100)}, {now.AddDays(random.Next(1, 90)).ToString("yyyy-mm-dd")}),");
                manyToManyValues.Append(@$"({i+1}, 1),");
            }

            migrationBuilder.Sql(@$" insert into Ratings(Value, RateDate) values {ratingValues.ToString().Substring(0, ratingValues.ToString().Length - 1)};");
            migrationBuilder.Sql(@$" insert into AlbumRatings(RatingId, AlbumId) values {manyToManyValues.ToString().Substring(0, manyToManyValues.Length - 1)};");

            ratingValues = new StringBuilder();
            manyToManyValues = new StringBuilder();
            for (int i = 0; i < 120; i++)
            {
                ratingValues.Append(@$"({random.Next(1, 100)}, {now.AddDays(random.Next(1, 90)).ToString("yyyy-mm-dd")}),");
                manyToManyValues.Append(@$"({i + 1 + 100}, {i / 10 + 1}),");
            }

            migrationBuilder.Sql(@$" insert into Ratings(Value, RateDate) values {ratingValues.ToString().Substring(0, ratingValues.ToString().Length - 1)};");
            migrationBuilder.Sql(@$" insert into SongRatings(RatingId, SongId) values {manyToManyValues.ToString().Substring(0, manyToManyValues.ToString().Length - 1)};");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from Ratings");
        }
    }
}
