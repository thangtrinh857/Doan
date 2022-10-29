using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateDatabasecs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceOrigin",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5062), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5084), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5088), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5089), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5200), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5203), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5205), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5280), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5282), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5283), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5284), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 14, 45, 15, 17, DateTimeKind.Unspecified).AddTicks(5286), new TimeSpan(0, 7, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceOrigin",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2793), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2794), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2795), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2796), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2797), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2902), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2992), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 28, 23, 32, 40, 637, DateTimeKind.Unspecified).AddTicks(2996), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
