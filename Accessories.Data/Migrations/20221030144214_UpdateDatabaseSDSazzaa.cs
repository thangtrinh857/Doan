using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class UpdateDatabaseSDSazzaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4640), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4658), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4660), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4661), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4663), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4797), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4Dung lượng RAM: 8 GB (1 thanh 8 GB)Tốc độ RAM: 3200 MHzĐóng gói: ThanhMàu LED: KhôngThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 60" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4801), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4: Dung lượngRAM: 8 GBTốc độ RAM: 3200 MHzĐóng gói: 1 ThanhMàu LED: RGBThương hiệu: AdataXuất xứ: Đài LoanThời gian bảo hành (tháng): 36" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4803), new TimeSpan(0, 7, 0, 0, 0)), "", "Thương hiệu: CORSAIRXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Kích thước: 160 x 100 x 205 mmTrọng lượng sản phẩm: 325 gChất liệu: NhựaĐộ dài dây: 1.8 mMàu sắc: Xanh lá" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 7, 0, 0, 0)), "", "Thương hiệu: RapooXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Trọng lượng sản phẩm: 340 gChất liệu: NhựaChất liệu: DaĐộ dài dây: 220 cmMàu sắc: Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4806), new TimeSpan(0, 7, 0, 0, 0)), "", "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 300 nits, Anti-glare LED-backlitTần số quét: 75 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 5msTiêu thụ năng lượng: 0.3 WCổng kết nối: 1 DisplayPort 1.2, 1 Jack 3.5 mm, 1 HDMI 1.4, 1 VGAĐầu ra âm thanh: LoaThương hiệu: AsusXuất xứ: Trung Quốc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4808), new TimeSpan(0, 7, 0, 0, 0)), "", "Màn hình: 27 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPSTần số quét: 165 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 0.5msCổng kết nối: 1 DisplayPort, 2 HDMIĐầu ra âm thanh: HeadphoneThương hiệu: AcerXuất xứ: Trung Quốc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4810), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	16000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4811), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	8000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4813), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 4000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4815), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4817), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 10000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12Màu sắc: Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4819), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột: Chuột không dâyKiểu kết nối: USBĐộ phân giải chuột: 1600 dpiThương hiệu: LogitechXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4822), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: AsusXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen, đỏ" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4823), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3000 MHzThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 24Màu LED: Không" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4825), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: KingstonXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4826), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: LexarXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, 7, 0, 0, 0)), "", "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3200 MHzThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: RGB" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4829), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4831), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4832), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4836), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 30, 21, 42, 14, 235, DateTimeKind.Unspecified).AddTicks(4838), new TimeSpan(0, 7, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6806), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8 GB (1 thanh 8 GB)Tốc độ RAM: 3200 MHzĐóng gói: ThanhMàu LED: KhôngThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 60", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6809), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4: Dung lượngRAM: 8 GBTốc độ RAM: 3200 MHzĐóng gói: 1 ThanhMàu LED: RGBThương hiệu: AdataXuất xứ: Đài LoanThời gian bảo hành (tháng): 36", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6811), new TimeSpan(0, 7, 0, 0, 0)), "Thương hiệu: CORSAIRXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Kích thước: 160 x 100 x 205 mmTrọng lượng sản phẩm: 325 gChất liệu: NhựaĐộ dài dây: 1.8 mMàu sắc: Xanh lá", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6813), new TimeSpan(0, 7, 0, 0, 0)), "Thương hiệu: RapooXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Trọng lượng sản phẩm: 340 gChất liệu: NhựaChất liệu: DaĐộ dài dây: 220 cmMàu sắc: Đen", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6815), new TimeSpan(0, 7, 0, 0, 0)), "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 300 nits, Anti-glare LED-backlitTần số quét: 75 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 5msTiêu thụ năng lượng: 0.3 WCổng kết nối: 1 DisplayPort 1.2, 1 Jack 3.5 mm, 1 HDMI 1.4, 1 VGAĐầu ra âm thanh: LoaThương hiệu: AsusXuất xứ: Trung Quốc", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6816), new TimeSpan(0, 7, 0, 0, 0)), "Màn hình: 27 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPSTần số quét: 165 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 0.5msCổng kết nối: 1 DisplayPort, 2 HDMIĐầu ra âm thanh: HeadphoneThương hiệu: AcerXuất xứ: Trung Quốc", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6817), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	16000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6819), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	8000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 4000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 10000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12Màu sắc: Đen", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột không dâyKiểu kết nối: USBĐộ phân giải chuột: 1600 dpiThương hiệu: LogitechXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: AsusXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen, đỏ", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6828), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3000 MHzThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 24Màu LED: Không", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6829), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: KingstonXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6830), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: LexarXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "Information" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 10, 30, 17, 37, 37, 618, DateTimeKind.Unspecified).AddTicks(6832), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3200 MHzThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: RGB", null });

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
    }
}
