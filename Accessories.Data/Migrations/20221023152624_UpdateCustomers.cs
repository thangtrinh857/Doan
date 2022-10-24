using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UsersId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_UsersId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UsersId",
                table: "Customers",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UsersId",
                table: "Customers",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
