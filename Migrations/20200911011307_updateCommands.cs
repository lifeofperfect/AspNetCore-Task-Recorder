using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class updateCommands : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Commads",
                table: "Commads");

            migrationBuilder.RenameTable(
                name: "Commads",
                newName: "Commands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commands",
                table: "Commands",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Commands",
                table: "Commands");

            migrationBuilder.RenameTable(
                name: "Commands",
                newName: "Commads");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Commads",
                table: "Commads",
                column: "Id");
        }
    }
}
