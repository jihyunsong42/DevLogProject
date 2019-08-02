using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devloggerWebAPI.Migrations
{
    public partial class devlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevLogs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevLogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DevLogs");
        }
    }
}
