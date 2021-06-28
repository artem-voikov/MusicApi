using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicApi.DataEF.Migrations
{
    public partial class AddArtists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
    insert into Artists(Name,Category,Genre)
    values ('Backstreet Boys', 'POP', 'POP')
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
    delete from Artists
    where Name='Backstreet Boys'
");
        }
    }
}
