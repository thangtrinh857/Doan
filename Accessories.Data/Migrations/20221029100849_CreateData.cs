using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accessories.Data.Migrations
{
    public partial class CreateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(684), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(687), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(689), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(690), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(692), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(693), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(694), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(734), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BillEntityId", "CategoryId", "CreatedBy", "CreatedDate", "Description", "Image", "Information", "IsActive", "Name", "Price", "PriceOrigin", "Unit", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 9, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(735), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 4000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12", "/image/product/Mouse1.png", null, true, "Chuột Gaming Zadez GT-613M", 334000, null, "đ", null, null },
                    { 10, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24", "/image/product/mouse2.png", null, true, "Chuột gaming Corsair Harpoon RGB PRO", 449000, 570000, "đ", null, null },
                    { 11, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 10000 dpiThương hiệu: ZadezXuất xứ: Trung QuốcThời gian bảo hành (tháng): 12Màu sắc: Đen", "/image/product/mouse3.png", null, true, "Chuột Gaming Zadez GT616M", 585000, 700000, "đ", null, null },
                    { 12, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột không dâyKiểu kết nối: USBĐộ phân giải chuột: 1600 dpiThương hiệu: LogitechXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen", "/image/product/mouse4.png", null, true, "Chuột Bluetooth Logitech M557", 620000, 700000, "đ", null, null },
                    { 13, null, 4, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(740), new TimeSpan(0, 7, 0, 0, 0)), "Loại chuột: Chuột gamingKiểu kết nối: USBĐộ phân giải chuột: 12000 dpiThương hiệu: AsusXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Màu sắc: Đen, đỏ", "/image/product/mouse5.png", null, true, "Chuột Gaming Asus CERBERUS ", 499000, 600000, "đ", null, null },
                    { 14, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3000 MHzThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 24Màu LED: Không", "/image/product/ram1.png", null, true, "RAM Desktop V-Color Skywalker Plus 8 GB - DDR4 - 3200 MHz - Purple", 799000, 899000, "đ", null, null },
                    { 15, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(742), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: KingstonXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không", "/image/product/ram2.png", null, true, "RAM Kingston Fury 8 GB-DDR4-2666 MHz (KF426C16BB/8)", 849000, 899000, "đ", null, null },
                    { 16, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(743), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 2666 MHzThương hiệu: LexarXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: Không", "/image/product/ram3.png", null, true, "RAM Lexar LD4AS008G-B2666GSSC 8 GB-DDR4-2666 MHz", 799000, 999000, "đ", null, null },
                    { 17, null, 1, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(746), new TimeSpan(0, 7, 0, 0, 0)), "Loại RAM: DDR4Dung lượng RAM: 8GBTốc độ RAM: 3200 MHzThương hiệu: CorsairXuất xứ: Trung QuốcThời gian bảo hành (tháng): 36Màu LED: RGB", "/image/product/ram4.png", null, true, "RAM CORSAIR Vengeance RGB RS 8 GB-DDR4-3200 MHz", 1099000, 1299000, "đ", null, null },
                    { 18, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 7, 0, 0, 0)), "Cảm giác đeo vô cùng tốt. Về cơ bản, HyperX Cloud Alpha thừa hưởng tới 90% thiết kế từ những thế hệ trước như HyperX Cloud 2 và HyperX Cloud Silver. Điều đó có nghĩa là người dùng sẽ tiếp tục có được cảm giác đeo vô cùng thoải mái và đặc trưng của dòng Cloud.", "/image/product/hp1.png", "Loại tai nghe: Tai nghe gaming, tai nghe chụpXuất xứ: MỹThương hiệu: HyperX", true, "Tai nghe HyperX Cloud Alpha", 2499000, null, "đ", null, null },
                    { 19, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 7, 0, 0, 0)), "Giống như mọi chiếc tai nghe gaming chơi game khác của HyperX, Cloud Stinger Core sẽ mang lại một trải nghiệm đeo vô cùng thoải mái cho người dùng trong thời gian dài. Thanh trượt của khung của tai nghe được làm từ thép cứng cáp và nó cho phép điều chỉnh để mang lại cảm giác vừa vặn cho bất kỳ kích thước đầu nào.", "/image/product/hp2.png", "Loại tai nghe: Tai nghe gaming, tai nghe chụpXuất xứ: MỹThương hiệu: HyperXTính năng: Chống ồn", true, "Tai nghe HyperX Cloud Stinger Core - Gaming Headset (Black) - PC", 890000, null, "đ", null, null },
                    { 20, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(749), new TimeSpan(0, 7, 0, 0, 0)), "Tai nghe chơi game không dây Corsair HS70 PRO SE Cream được nâng cấp nhiều so với HS60 Pro khi đây là tai nghe không dây 2.4GHz cao cấp hơn với độ trễ thấp và dung lượng pin lớn. HS70 Pro SE Cream mang lại cả sự thoải mái và chất lượng với miếng đệm tai bằng mút hoạt tính, trình điều khiển âm thanh neodymium 50mm tùy chỉnh.", "/image/product/hp3.png", "Loại tai nghe: Tai nghe gaming, tai nghe chụpXuất xứ: MỹThương hiệu: CorsairTính năng: Chống ồnKết nối: Bluetooth", true, "Tai nghe không dây Corsair HS70 PRO SE Cream/CA-9011210-AP", 2850000, null, "đ", null, null },
                    { 21, null, 2, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(750), new TimeSpan(0, 7, 0, 0, 0)), "Không chỉ đẹp với thiết kế đèn LED RGB rực rỡ, tai nghe chơi game SoundMax AH-335 còn có kiểu dáng hiện đại, đeo lâu không mệt và chất âm đỉnh cao để cung cấp một không gian giải trí riêng cho mỗi game thủ.", "/image/product/hp4.png", "Loại tai nghe: Tai nghe gaming, tai nghe chụpXuất xứ: Trung QuốcThương hiệu: SoundMaxTính năng: Extra Bass™, Tương thích hoàn hảo với nhiều thiết bị, Chơi game, Chống ồn, Tích hợp Micro, Mic đàm thoạiKết nối: 3,5 mm", true, "Tai nghe choàng đầu có mic Gaming Soundmax AH335", 585000, null, "đ", null, null },
                    { 22, null, 3, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(752), new TimeSpan(0, 7, 0, 0, 0)), "Hãy mở ra tầm nhìn chuyên nghiệp trên bàn làm việc của bạn với sự hỗ trợ của màn hình Dell P2422H. Sản phẩm có kích cỡ hiển thị 23.8 inch, có thiết kế mang hơi hướng thời trang và thanh lịch, với công nghệ ComfortView Plus đem lại trải nghiệm thân thiện với mắt.", "/image/product/moni1.png", "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPSXuất xứ: Trung QuốcThương hiệu: DellTần số quét: 60 HzCổng kết nối: 4 USB 3.2 Gen 1, 1 VGA, 1 DisplayPort 1.2, 1 HDMI 1.4, 1 USB 3.0Góc nhìn: 178°(Dọc) / 178°(Ngang)", true, "Màn hình Dell P2422H/ 23.8 inch/ FHD (1920x1080) 60Hz", 5850000, null, "đ", null, null },
                    { 23, null, 3, null, new DateTimeOffset(new DateTime(2022, 10, 29, 17, 8, 48, 720, DateTimeKind.Unspecified).AddTicks(753), new TimeSpan(0, 7, 0, 0, 0)), "Nếu bạn đang kiếm tìm một mẫu màn hình 21.5 inch chất lượng tốt để dùng trong gia đình hoặc văn phòng, đừng bỏ qua sự lựa chọn ưu việt như Viewsonic VA2215-H. Sản phẩm được trang bị công nghệ Eyecare bảo vệ mắt, hỗ trợ chế độ tiêu thụ năng lượng thấp, ghi nhận tần số quét 75Hz và sử dụng cổng đầu vào HDMI cùng VGA.", "/image/product/moni2.png", "Màn hình: 21.5 inch, 1920 x 1080 Pixels, FHD, 250 nits, VAXuất xứ: Trung QuốcThương hiệu: ViewsonicTần số quét: 75 HzCổng kết nối: HDMI, VGAGóc nhìn: 178°(Dọc) / 178°(Ngang)", true, "Màn hình Viewsonic VA2215-H/22 inch/FHD(1920 x 1080)/75Hz", 2390000, null, "đ", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

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
    }
}
