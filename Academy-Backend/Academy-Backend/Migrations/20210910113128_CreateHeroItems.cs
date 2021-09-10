using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy_Backend.Migrations
{
    public partial class CreateHeroItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Desc = table.Column<string>(maxLength: 150, nullable: true),
                    Image = table.Column<string>(maxLength: 200, nullable: true),
                    RedirectUrl = table.Column<string>(maxLength: 100, nullable: true),
                    RedirectUrlSecond = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heros");
        }
    }
}
