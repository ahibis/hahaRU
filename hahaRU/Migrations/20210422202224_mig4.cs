using Microsoft.EntityFrameworkCore.Migrations;

namespace hahaRU.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgSrc",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgSrc",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");
        }
    }
}
