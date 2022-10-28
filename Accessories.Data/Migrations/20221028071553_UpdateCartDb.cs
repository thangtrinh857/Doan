using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateCartDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/ram.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1374), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/headphone.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/monitor.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1399), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/mouse1.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/keyboard.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1401), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "/image/home/mainboard.jpg", new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1402), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/Ram-Desktop-v-color.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/ram-adata.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1554), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/tai-nghe-corsair.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/tai-nghe-gaming.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1556), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/màn-hình-asus.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1557), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/màn-hình-acer-nitro.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1558), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/chuột-gaming-logitech-g502.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 28, 14, 15, 52, 742, DateTimeKind.Unspecified).AddTicks(1559), new TimeSpan(0, 7, 0, 0, 0)), "/image/product/chuột-gaming-logitech-g102.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/ram.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/headphone.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7302), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/monitor.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7303), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/mouse1.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7304), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/keyboard.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7305), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Cover", "CreatedDate" },
                values: new object[] { "image/home/mainboard.jpg", new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7306), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/Ram-Desktop-v-color.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7416), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/ram-adata.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/tai-nghe-corsair.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/tai-nghe-gaming.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/màn-hình-asus.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7422), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/màn-hình-acer-nitro.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7423), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/chuột-gaming-logitech-g502.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 27, 10, 56, 5, 971, DateTimeKind.Unspecified).AddTicks(7424), new TimeSpan(0, 7, 0, 0, 0)), "image/prouduct/chuột-gaming-logitech-g102.jpg" });
        }
    }
}
