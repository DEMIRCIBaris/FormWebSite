using Microsoft.EntityFrameworkCore.Migrations;

namespace FormWebSite.DataAccess.Migrations
{
    public partial class ProgramDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProgramName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramName",
                table: "AspNetUsers");
        }
    }
}
