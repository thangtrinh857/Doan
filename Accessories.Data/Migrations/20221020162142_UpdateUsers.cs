using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActived",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActived",
                table: "AspNetUsers");
        }
    }
}
