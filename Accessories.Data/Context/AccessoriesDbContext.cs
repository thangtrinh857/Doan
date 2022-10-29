using Accessories.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessories.Data.Context
{
    public class AccessoriesDbContext : IdentityDbContext<UserEntity>

    {
        public AccessoriesDbContext(DbContextOptions<AccessoriesDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, Type = "Ram", Cover = "/image/home/ram.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 2, Type = "Headphone", Cover = "/image/home/headphone.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 3, Type = "Monitor", Cover = "/image/home/monitor.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 4, Type = "Mouse", Cover = "/image/home/mouse1.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 5, Type = "KeyBoard", Cover = "/image/home/keyboard.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 6, Type = "MainBoard", Cover = "/image/home/mainboard.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true }
            );
            builder.Entity<ProductEntity>().HasData(
                new ProductEntity 
                { 
                    Id = 1, 
                    Name = "RAM Desktop V-Color Skywalker Plus 8 GB - DDR4 - 3200 MHz - Purple", 
                    Price = 799000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now, 
                    CategoryId = 1,
                    Image = "/image/product/Ram-Desktop-v-color.jpg",
                    Description = "Loại RAM: DDR4" +
                    "Dung lượng RAM: 8 GB (1 thanh 8 GB)" +
                    "Tốc độ RAM: 3200 MHz" +
                    "Đóng gói: Thanh" +
                    "Màu LED: Không" +
                    "Thương hiệu: V-color" +
                    "Xuất xứ: Đài Loan" +
                    "Thời gian bảo hành (tháng): 60",
                    IsActive = true 
                },
                new ProductEntity
                {
                    Id = 2,
                    Name = "RAM ADATA XPG Spectrix D41 RGB 8 GB-DDR4-3200 MHz",
                    Price = 859000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 1,
                    Image = "/image/product/ram-adata.jpg",
                    Description = "Loại RAM: " +
                    "DDR4: Dung lượng" +
                    "RAM: 8 GB" +
                    "Tốc độ RAM: 3200 MHz" +
                    "Đóng gói: 1 Thanh" +
                    "Màu LED: RGB" +
                    "Thương hiệu: Adata" +
                    "Xuất xứ: Đài Loan" +
                    "Thời gian bảo hành (tháng): 36",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 3,
                    Name = "Tai nghe Corsair HS50 PRO Stereo",
                    Price = 1278000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/tai-nghe-corsair.jpg",
                    Description = "Thương hiệu: CORSAIR" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 24" +
                    "Kích thước: 160 x 100 x 205 mm" +
                    "Trọng lượng sản phẩm: 325 g" +
                    "Chất liệu: Nhựa" +
                    "Độ dài dây: 1.8 m" +
                    "Màu sắc: Xanh lá",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 4,
                    Name = "Tai nghe gaming Rapoo VH160 có mic",
                    Price = 505000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/tai-nghe-gaming.jpg",
                    Description = "Thương hiệu: Rapoo" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 24" +
                    "Trọng lượng sản phẩm: 340 g" +
                    "Chất liệu: Nhựa" +
                    "Chất liệu: Da" +
                    "Độ dài dây: 220 cm" +
                    "Màu sắc: Đen",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 5,
                    Name = "Màn hình ASUS VA24DQ/23.8 inch/FHD (1920x1080)/75Hz",
                    Price = 3790000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 3,
                    Image = "/image/product/màn-hình-asus.jpg",
                    Description = "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 300 nits, Anti-glare LED-backlit" +
                    "Tần số quét: 75 Hz" +
                    "Góc nhìn: 178°(Dọc) / 178°(Ngang)" +
                    "Thời gian phản hồi: 5ms" +
                    "Tiêu thụ năng lượng: 0.3 W" +
                    "Cổng kết nối: 1 DisplayPort 1.2, 1 Jack 3.5 mm, 1 HDMI 1.4, 1 VGA" +
                    "Đầu ra âm thanh: Loa" +
                    "Thương hiệu: Asus" +
                    "Xuất xứ: Trung Quốc",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 6,
                    Name = "Màn hình Acer Nitro VG270 S/27inch/FHD (1920x1080)/165Hz",
                    Price = 5840000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 3,
                    Image = "/image/product/màn-hình-acer-nitro.jpg",
                    Description = "Màn hình: 27 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPS" +
                    "Tần số quét: 165 Hz" +
                    "Góc nhìn: 178°(Dọc) / 178°(Ngang)" +
                    "Thời gian phản hồi: 0.5ms" +
                    "Cổng kết nối: 1 DisplayPort, 2 HDMI" +
                    "Đầu ra âm thanh: Headphone" +
                    "Thương hiệu: Acer" +
                    "Xuất xứ: Trung Quốc",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 7,
                    Name = "Chuột Gaming Logitech G502 Hero High Performance",
                    Price = 1750000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/chuột-gaming-logitech-g502.jpg",
                    Description = "Loại chuột\tChuột Gaming\r\nKiểu kết nối\tUSB\r\nĐộ phân giải chuột\t16000 dpi\r\nThương hiệu\tLogitech\r\nXuất xứ\tTrung Quốc\r\nThời gian bảo hành (tháng)\t12",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 8,
                    Name = "Chuột Gaming Logitech G102 Gen2 Lightsync",
                    Price = 700000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/chuột-gaming-logitech-g102.jpg",
                    Description = "Loại chuột\tChuột Gaming\r\nKiểu kết nối\tUSB\r\nĐộ phân giải chuột\t8000 dpi\r\nThương hiệu\tLogitech\r\nXuất xứ\tTrung Quốc\r\nThời gian bảo hành (tháng)\t12",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 9,
                    Name = "Chuột Gaming Zadez GT-613M",
                    Price = 334000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/Mouse1.png",
                    Description = "Loại chuột: Chuột gaming" +
                    "Kiểu kết nối: USB" +
                    "Độ phân giải chuột: 4000 dpi" +
                    "Thương hiệu: Zadez" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 12",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 10,
                    Name = "Chuột gaming Corsair Harpoon RGB PRO",
                    Price = 449000,
                    PriceOrigin = 570000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/mouse2.png",
                    Description = "Loại chuột: Chuột gaming" +
                    "Kiểu kết nối: USB" +
                    "Độ phân giải chuột: 12000 dpi" +
                    "Thương hiệu: Corsair" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 24",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 11,
                    Name = "Chuột Gaming Zadez GT616M",
                    Price = 585000,
                    PriceOrigin = 700000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/mouse3.png",
                    Description = "Loại chuột: Chuột gaming" +
                    "Kiểu kết nối: USB" +
                    "Độ phân giải chuột: 10000 dpi" +
                    "Thương hiệu: Zadez" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 12" +
                    "Màu sắc: Đen",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 12,
                    Name = "Chuột Bluetooth Logitech M557",
                    Price = 620000,
                    PriceOrigin = 700000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/mouse4.png",
                    Description = "Loại chuột: Chuột không dây" +
                    "Kiểu kết nối: USB" +
                    "Độ phân giải chuột: 1600 dpi" +
                    "Thương hiệu: Logitech" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 24" +
                    "Màu sắc: Đen",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 13,
                    Name = "Chuột Gaming Asus CERBERUS ",
                    Price = 499000,
                    PriceOrigin = 600000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 4,
                    Image = "/image/product/mouse5.png",
                    Description = "Loại chuột: Chuột gaming" +
                    "Kiểu kết nối: USB" +
                    "Độ phân giải chuột: 12000 dpi" +
                    "Thương hiệu: Asus" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 24" +
                    "Màu sắc: Đen, đỏ",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 14,
                    Name = "RAM Desktop V-Color Skywalker Plus 8 GB - DDR4 - 3200 MHz - Purple",
                    Price = 799000,
                    PriceOrigin = 899000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 1,
                    Image = "/image/product/ram1.png",
                    Description = "Loại RAM: DDR4" +
                    "Dung lượng RAM: 8GB" +
                    "Tốc độ RAM: 3000 MHz" +
                    "Thương hiệu: V-color" +
                    "Xuất xứ: Đài Loan" +
                    "Thời gian bảo hành (tháng): 24" +
                    "Màu LED: Không",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 15,
                    Name = "RAM Kingston Fury 8 GB-DDR4-2666 MHz (KF426C16BB/8)",
                    Price = 849000,
                    PriceOrigin = 899000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 1,
                    Image = "/image/product/ram2.png",
                    Description = "Loại RAM: DDR4" +
                    "Dung lượng RAM: 8GB" +
                    "Tốc độ RAM: 2666 MHz" +
                    "Thương hiệu: Kingston" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 36" +
                    "Màu LED: Không",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 16,
                    Name = "RAM Lexar LD4AS008G-B2666GSSC 8 GB-DDR4-2666 MHz",
                    Price = 799000,
                    PriceOrigin = 999000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 1,
                    Image = "/image/product/ram3.png",
                    Description = "Loại RAM: DDR4" +
                    "Dung lượng RAM: 8GB" +
                    "Tốc độ RAM: 2666 MHz" +
                    "Thương hiệu: Lexar" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 36" +
                    "Màu LED: Không",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 17,
                    Name = "RAM CORSAIR Vengeance RGB RS 8 GB-DDR4-3200 MHz",
                    Price = 1099000,
                    PriceOrigin = 1299000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 1,
                    Image = "/image/product/ram4.png",
                    Description = "Loại RAM: DDR4" +
                    "Dung lượng RAM: 8GB" +
                    "Tốc độ RAM: 3200 MHz" +
                    "Thương hiệu: Corsair" +
                    "Xuất xứ: Trung Quốc" +
                    "Thời gian bảo hành (tháng): 36" +
                    "Màu LED: RGB",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 18,
                    Name = "Tai nghe HyperX Cloud Alpha",
                    Price = 2499000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/hp1.png",
                    Information = "Loại tai nghe: Tai nghe gaming, tai nghe chụp" +
                    "Xuất xứ: Mỹ"+
                    "Thương hiệu: HyperX",
                    Description = "Cảm giác đeo vô cùng tốt. Về cơ bản, HyperX Cloud Alpha thừa hưởng tới 90% thiết kế từ những thế hệ trước như HyperX Cloud 2 và HyperX Cloud Silver. Điều đó có nghĩa là người dùng sẽ tiếp tục có được cảm giác đeo vô cùng thoải mái và đặc trưng của dòng Cloud.",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 19,
                    Name = "Tai nghe HyperX Cloud Stinger Core - Gaming Headset (Black) - PC",
                    Price = 890000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/hp2.png",
                    Information = "Loại tai nghe: Tai nghe gaming, tai nghe chụp" +
                    "Xuất xứ: Mỹ" +
                    "Thương hiệu: HyperX"+
                    "Tính năng: Chống ồn",
                    Description = "Giống như mọi chiếc tai nghe gaming chơi game khác của HyperX, Cloud Stinger Core sẽ mang lại một trải nghiệm đeo vô cùng thoải mái cho người dùng trong thời gian dài. Thanh trượt của khung của tai nghe được làm từ thép cứng cáp và nó cho phép điều chỉnh để mang lại cảm giác vừa vặn cho bất kỳ kích thước đầu nào.",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 20,
                    Name = "Tai nghe không dây Corsair HS70 PRO SE Cream/CA-9011210-AP",
                    Price = 2850000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/hp3.png",
                    Information = "Loại tai nghe: Tai nghe gaming, tai nghe chụp" +
                    "Xuất xứ: Mỹ" +
                    "Thương hiệu: Corsair" +
                    "Tính năng: Chống ồn"+
                    "Kết nối: Bluetooth",
                    Description = "Tai nghe chơi game không dây Corsair HS70 PRO SE Cream được nâng cấp nhiều so với HS60 Pro khi đây là tai nghe không dây 2.4GHz cao cấp hơn với độ trễ thấp và dung lượng pin lớn. HS70 Pro SE Cream mang lại cả sự thoải mái và chất lượng với miếng đệm tai bằng mút hoạt tính, trình điều khiển âm thanh neodymium 50mm tùy chỉnh.",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 21,
                    Name = "Tai nghe choàng đầu có mic Gaming Soundmax AH335",
                    Price = 585000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 2,
                    Image = "/image/product/hp4.png",
                    Information = "Loại tai nghe: Tai nghe gaming, tai nghe chụp" +
                    "Xuất xứ: Trung Quốc" +
                    "Thương hiệu: SoundMax" +
                    "Tính năng: Extra Bass™, Tương thích hoàn hảo với nhiều thiết bị, Chơi game, Chống ồn, Tích hợp Micro, Mic đàm thoại" +
                    "Kết nối: 3,5 mm",
                    Description = "Không chỉ đẹp với thiết kế đèn LED RGB rực rỡ, tai nghe chơi game SoundMax AH-335 còn có kiểu dáng hiện đại, đeo lâu không mệt và chất âm đỉnh cao để cung cấp một không gian giải trí riêng cho mỗi game thủ.",
                    IsActive = true
                },
                new ProductEntity
                {
                    Id = 22,
                    Name = "Màn hình Dell P2422H/ 23.8 inch/ FHD (1920x1080) 60Hz",
                    Price = 5850000,
                    Unit = "đ",
                    CreatedDate = DateTimeOffset.Now,
                    CategoryId = 3,
                    Image = "/image/product/moni1.png",
                    Information = "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPS" +
                    "Xuất xứ: Trung Quốc" +
                    "Thương hiệu: Dell" +
                    "Tần số quét: 60 Hz"+
                    "Cổng kết nối: 4 USB 3.2 Gen 1, 1 VGA, 1 DisplayPort 1.2, 1 HDMI 1.4, 1 USB 3.0" +
                    "Góc nhìn: 178°(Dọc) / 178°(Ngang)",
                    Description = "Hãy mở ra tầm nhìn chuyên nghiệp trên bàn làm việc của bạn với sự hỗ trợ của màn hình Dell P2422H. Sản phẩm có kích cỡ hiển thị 23.8 inch, có thiết kế mang hơi hướng thời trang và thanh lịch, với công nghệ ComfortView Plus đem lại trải nghiệm thân thiện với mắt.",
                    IsActive = true
                },
                 new ProductEntity
                 {
                     Id = 23,
                     Name = "Màn hình Viewsonic VA2215-H/22 inch/FHD(1920 x 1080)/75Hz",
                     Price = 2390000,
                     Unit = "đ",
                     CreatedDate = DateTimeOffset.Now,
                     CategoryId = 3,
                     Image = "/image/product/moni2.png",
                     Information = "Màn hình: 21.5 inch, 1920 x 1080 Pixels, FHD, 250 nits, VA" +
                    "Xuất xứ: Trung Quốc" +
                    "Thương hiệu: Viewsonic" +
                    "Tần số quét: 75 Hz" +
                    "Cổng kết nối: HDMI, VGA" +
                    "Góc nhìn: 178°(Dọc) / 178°(Ngang)",
                     Description = "Nếu bạn đang kiếm tìm một mẫu màn hình 21.5 inch chất lượng tốt để dùng trong gia đình hoặc văn phòng, đừng bỏ qua sự lựa chọn ưu việt như Viewsonic VA2215-H. Sản phẩm được trang bị công nghệ Eyecare bảo vệ mắt, hỗ trợ chế độ tiêu thụ năng lượng thấp, ghi nhận tần số quét 75Hz và sử dụng cổng đầu vào HDMI cùng VGA.",
                     IsActive = true
                 }
            );
        }
        public DbSet<BillEntity> Bills { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
    }
}
