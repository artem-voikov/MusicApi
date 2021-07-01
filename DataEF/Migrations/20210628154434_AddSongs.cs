using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApi.DataEF.Migrations
{
    public partial class AddSongs : Migration
    {
        private const string genre = "POP";
        private const string artist = "Backstreet Boys";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"
    insert into Songs(Name, Artist, Time, Popularity, Price, Genre, DataAlbumAlbumId)
    values 
        ('Don''t Go Breaking My Heart', '{artist}', '00:03:36', 60, '1.29', '{genre}',1 ),
        ('Nobody Else', '{artist}', '00:03:38', 15, '1.29', '{genre}',1),
        ('Breathe', '{artist}', '00:03:06', 35, '1.29', '{genre}',1),
        ('New Love', '{artist}', '00:03:00', 30, '1.29', '{genre}',1),
        ('Passhionate', '{artist}', '00:03:43', 10, '1.29', '{genre}',1),
        ('Is It Just Me', '{artist}', '00:03:37', 18, '1.29', '{genre}',1),
        ('Chances', '{artist}', '00:02:53', 85, '1.29', '{genre}',1),
        ('No Place', '{artist}', '00:02:59', 100, '1.29', '{genre}',1),
        ('Chateau', '{artist}', '00:03:08', 10, '1.29', '{genre}',1),
        ('The Way It Was', '{artist}', '00:03:26', 20, '1.29', '{genre}',1),
        ('Just Like You Like It', '{artist}', '00:03:42', 30, '1.29', '{genre}',1),
        ('Ok', '{artist}', '00:02:31', 117, '1.29', '{genre}',1);
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from Songs");
        }
    }
}
