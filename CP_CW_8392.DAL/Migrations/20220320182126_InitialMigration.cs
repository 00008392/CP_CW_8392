using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CP_CW_8392.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Swipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPAdddress = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    SwipeDateTime = table.Column<DateTime>(nullable: false),
                    Direction = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swipes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Swipes");
        }
    }
}
