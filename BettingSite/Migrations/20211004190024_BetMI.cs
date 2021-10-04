using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSite.Migrations
{
    public partial class BetMI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Match_MatchID",
                table: "Bets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matchs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Matchs_MatchID",
                table: "Bets",
                column: "MatchID",
                principalTable: "Matchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Matchs_MatchID",
                table: "Bets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs");

            migrationBuilder.RenameTable(
                name: "Matchs",
                newName: "Match");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Match_MatchID",
                table: "Bets",
                column: "MatchID",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
