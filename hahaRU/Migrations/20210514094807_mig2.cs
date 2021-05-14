using Microsoft.EntityFrameworkCore.Migrations;

namespace hahaRU.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anecdots");

            migrationBuilder.DropTable(
                name: "FunnyWords");

            migrationBuilder.DropTable(
                name: "mems");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnecdotEnd",
                table: "AnecdotEnd");

            migrationBuilder.RenameTable(
                name: "AnecdotEnd",
                newName: "AnecdotEnds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnecdotEnds",
                table: "AnecdotEnds",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AnecdotTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnecdotTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikesCount = table.Column<int>(type: "int", nullable: false),
                    DislikesCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnecdotTexts");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnecdotEnds",
                table: "AnecdotEnds");

            migrationBuilder.RenameTable(
                name: "AnecdotEnds",
                newName: "AnecdotEnd");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnecdotEnd",
                table: "AnecdotEnd",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Anecdots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DislikesCount = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikesCount = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anecdots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FunnyWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DislikesCount = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LikesCount = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunnyWords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DislikesCount = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikesCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dislikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DislikesCount = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LikesCount = table.Column<int>(type: "int", nullable: false),
                    Src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });
        }
    }
}
