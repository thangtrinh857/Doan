using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateDatabaseSDSazza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6612), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6675), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6676), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6809), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram4.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/hp1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/hp3.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/moni1.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6816), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/moni2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/mouse2.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6828), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6833), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6836), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6838), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6839), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6841), new TimeSpan(0, 7, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6787), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(6818), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7008), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram4.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7015), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/hp1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7016), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/hp3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/moni1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/moni2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7020), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/mouse2.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7024), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7028), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7029), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7031), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7036), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7038), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7040), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7044), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 17, 33, 33, 468, DateTimeKind.Unspecified).AddTicks(7045), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
