using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class removedwinsandlosses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Losses",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Losses",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
