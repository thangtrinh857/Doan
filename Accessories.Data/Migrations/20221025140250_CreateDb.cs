using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsActive", "Type", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(3835), new TimeSpan(0, 7, 0, 0, 0)), true, "Ram", null, null },
                    { 2, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(3858), new TimeSpan(0, 7, 0, 0, 0)), true, "Headphone", null, null },
                    { 3, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(3859), new TimeSpan(0, 7, 0, 0, 0)), true, "Monitor", null, null },
                    { 4, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(3860), new TimeSpan(0, 7, 0, 0, 0)), true, "Mouse", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BillEntityId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "Image", "IsActive", "Name", "Price", "Unit", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4043), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8 GB (1 thanh 8 GB)Tốc độ RAM: 3200 MHzĐóng gói: ThanhMàu LED: KhôngThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 60", "image/prouduct/Ram-Desktop-v-color.jpg", true, "RAM Desktop V-Color Skywalker Plus 8 GB - DDR4 - 3200 MHz - Purple", 799000, "đ", null, null },
                    { 2, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4: Dung lượngRAM: 8 GBTốc độ RAM: 3200 MHzĐóng gói: 1 ThanhMàu LED: RGBThương hiệu: AdataXuất xứ: Đài LoanThời gian bảo hành (tháng): 36", "image/prouduct/ram-adata.jpg", true, "RAM ADATA XPG Spectrix D41 RGB 8 GB-DDR4-3200 MHz", 859000, "đ", null, null },
                    { 3, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4054), new TimeSpan(0, 7, 0, 0, 0)), "Thương hiệu: CORSAIRXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Kích thước: 160 x 100 x 205 mmTrọng lượng sản phẩm: 325 gChất liệu: NhựaĐộ dài dây: 1.8 mMàu sắc: Xanh lá", "image/prouduct/tai-nghe-corsair.jpg", true, "Tai nghe Corsair HS50 PRO Stereo", 1278000, "đ", null, null },
                    { 4, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 7, 0, 0, 0)), "Thương hiệu: RapooXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Trọng lượng sản phẩm: 340 gChất liệu: NhựaChất liệu: DaĐộ dài dây: 220 cmMàu sắc: Đen", "image/prouduct/tai-nghe-gaming.jpg", true, "Tai nghe gaming Rapoo VH160 có mic", 505000, "đ", null, null },
                    { 5, null, 3, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4058), new TimeSpan(0, 7, 0, 0, 0)), "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 300 nits, Anti-glare LED-backlitTần số quét: 75 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 5msTiêu thụ năng lượng: 0.3 WCổng kết nối: 1 DisplayPort 1.2, 1 Jack 3.5 mm, 1 HDMI 1.4, 1 VGAĐầu ra âm thanh: LoaThương hiệu: AsusXuất xứ: Trung Quốc", "image/prouduct/màn-hình-asus.jpg", true, "Màn hình ASUS VA24DQ/23.8 inch/FHD (1920x1080)/75Hz", 3790000, "đ", null, null },
                    { 6, null, 3, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 7, 0, 0, 0)), "Màn hình: 27 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPSTần số quét: 165 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 0.5msCổng kết nối: 1 DisplayPort, 2 HDMIĐầu ra âm thanh: HeadphoneThương hiệu: AcerXuất xứ: Trung Quốc", "image/prouduct/màn-hình-acer-nitro.jpg", true, "Màn hình Acer Nitro VG270 S/27inch/FHD (1920x1080)/165Hz", 5840000, "đ", null, null },
                    { 7, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4062), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	16000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12", "image/prouduct/chuột-gaming-logitech-g502.jpg", true, "Chuột Gaming Logitech G502 Hero High Performance", 1750000, "đ", null, null },
                    { 8, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 25, 21, 2, 50, 613, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	8000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12", "image/prouduct/chuột-gaming-logitech-g102.jpg", true, "Chuột Gaming Logitech G102 Gen2 Lightsync", 700000, "đ", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Products");
        }
    }
}
