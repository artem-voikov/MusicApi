using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApi.DataEF.Migrations
{
    public partial class AddAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
    insert into Albums(Name, Description, ReleaseDate, Licence, Review, Price,Image, Genre, DataArtistArtistId)
    values (
'DNA', 
'DNA is the ninth studio album (eighth in the US) by the Backstreet Boys. The album was first released in Japan on January 23, 2019, and everywhere else on January 25, 2019, through a collaboration with the groups own K-BAHN record label and RCA Records. The album features tracks written by Edei, Lauv, Andy Grammer, Stuart Crichton, Ryan Tedder and Shawn Mendes.[5] This is the group''s second album, after 2007''s Unbreakable, to neglect involvement from longtime producers and friends Max Martin and Kristian Lundin. It also serves as the follow-up to their eighth studio album (seventh in the US) In a World Like This (2013). It was preceded by the singles ""Don''t Go Breaking My Heart"", ""Chances"", ""No Place"", and is supported by the DNA World Tour, which is the band''s most expansive in 18 years.The tour began on May 11, 2019, in Lisbon, Portugal,[6] before visiting North America in July 2019.[7] The album is their first on one of Sony Music''s subsidiary companies since In a World Like This (2013), which was released independently through BMG.[8] It debuted at number one on the US Billboard 200, becoming the Backstreet Boys'' third number - one album there and the first since Black & Blue in 2000.',
'2019-01-23', 
'© 2018 K-Bahn, LLC & RCA Records, a division of Sony Music Entertainment',
'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut tristique, massa sed posuere sollicitudin, tellus purus imperdiet lorem, pretium faucibus dui quam nec tellus. Etiam a massa ut eros tincidunt rutrum. Morbi euismod sem lectus, non gravida dui tempus sed. Donec nec arcu bibendum, tincidunt nisi nec, sodales lectus. Aenean ullamcorper sit amet erat tristique sollicitudin. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Quisque lobortis porta dignissim. Suspendisse sollicitudin erat eget tellus tempor interdum. Fusce lacinia commodo urna, id sagittis diam condimentum sed. In semper feugiat metus, eu rhoncus tortor fringilla a. Pellentesque vel malesuada ligula. In efficitur vestibulum odio eget mollis',
11.99,
'Image',
'POP',
1
)
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from Albums");
        }
    }
}
