using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class updatedthetablesandcontrollers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Loses",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Outcome",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Loses",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Outcome",
                table: "Players");
        }
    }
}
