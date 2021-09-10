using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy_Backend.Migrations
{
    public partial class CreateCourceItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Logo = table.Column<string>(maxLength: 100, nullable: true),
                    Desc = table.Column<string>(maxLength: 100, nullable: true),
                    Price = table.Column<string>(maxLength: 100, nullable: true),
                    Teacher = table.Column<string>(maxLength: 100, nullable: true),
                    Stars = table.Column<string>(maxLength: 100, nullable: true),
                    LectureTime = table.Column<string>(maxLength: 100, nullable: true),
                    RedirectUrl = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cource", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cource");
        }
    }
}
