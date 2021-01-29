using Microsoft.EntityFrameworkCore.Migrations;

namespace FormWebSite.DataAccess.Migrations
{
    public partial class userPoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Book",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassroomTrainings",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Master",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OnTheJob",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Other",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OtherExplanation",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Book",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassroomTrainings",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Master",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OnTheJob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OtherExplanation",
                table: "AspNetUsers");
        }
    }
}
