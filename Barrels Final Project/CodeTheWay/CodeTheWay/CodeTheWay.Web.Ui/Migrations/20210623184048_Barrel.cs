using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTheWay.Web.Ui.Migrations
{
    public partial class Barrel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barrels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Radius = table.Column<double>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Contents = table.Column<string>(nullable: true),
                    CurrentLocation = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barrels");
        }
    }
}
