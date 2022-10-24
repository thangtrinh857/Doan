using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Customers_CustomerId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProducts_Customers_CustomerEntityId",
                table: "CartProducts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_CartProducts_CustomerEntityId",
                table: "CartProducts");

            migrationBuilder.DropIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "CustomerEntityId",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Bills");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CartProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "CartProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CartProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "CartProducts");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CartProducts");

            migrationBuilder.AddColumn<int>(
                name: "CustomerEntityId",
                table: "CartProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Bills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_CustomerEntityId",
                table: "CartProducts",
                column: "CustomerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerId",
                table: "Bills",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Customers_CustomerId",
                table: "Bills",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProducts_Customers_CustomerEntityId",
                table: "CartProducts",
                column: "CustomerEntityId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
