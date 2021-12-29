using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class addedcardIdtoplayerclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 53);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CardId",
                table: "Players",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Cards_CardId",
                table: "Players",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Cards_CardId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_CardId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
