using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateDatabaseSDS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResponseAPI",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponseAPI",
                table: "Bills");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(546), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(564), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(565), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(566), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(567), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(568), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(684), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/Ram-Desktop-v-color.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram-adata.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/tai-nghe-corsair.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/tai-nghe-gaming.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(692), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/màn-hình-asus.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/màn-hình-acer-nitro.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/chuột-gaming-logitech-g502.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(735), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
