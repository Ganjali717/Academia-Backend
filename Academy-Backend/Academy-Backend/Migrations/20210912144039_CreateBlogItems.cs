﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Academy_Backend.Migrations
{
    public partial class CreateBlogItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 100, nullable: true),
                    Item = table.Column<string>(maxLength: 100, nullable: true),
                    Desc = table.Column<string>(maxLength: 150, nullable: true),
                    Icon1 = table.Column<string>(maxLength: 100, nullable: true),
                    Icon2 = table.Column<string>(maxLength: 100, nullable: true),
                    Icon3 = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
