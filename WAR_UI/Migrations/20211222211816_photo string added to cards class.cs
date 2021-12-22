using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class photostringaddedtocardsclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Cards");
        }
    }
}
