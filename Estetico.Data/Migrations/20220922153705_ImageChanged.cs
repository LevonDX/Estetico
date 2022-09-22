using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estetico.Data.Migrations
{
    public partial class ImageChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Estates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
