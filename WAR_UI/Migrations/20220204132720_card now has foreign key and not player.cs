using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WAR_UI.Migrations
{
    public partial class cardnowhasforeignkeyandnotplayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Outcome",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Playerid",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Playerid",
                table: "Cards",
                column: "Playerid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Players_Playerid",
                table: "Cards",
                column: "Playerid",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Players_Playerid",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_Playerid",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "Playerid",
                table: "Cards");

            migrationBuilder.AlterColumn<string>(
                name: "Outcome",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
