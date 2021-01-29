using Microsoft.EntityFrameworkCore.Migrations;

namespace FormWebSite.DataAccess.Migrations
{
    public partial class aydinRizaPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "aydin",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "riza",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aydin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "riza",
                table: "AspNetUsers");
        }
    }
}
