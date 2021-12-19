using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class fixedpropertyspellingwhichthrewofffrontend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Loses",
                table: "Players",
                newName: "Losses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Losses",
                table: "Players",
                newName: "Loses");
        }
    }
}
