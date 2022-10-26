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
                new CategoryEntity { Id = 1, Type = "Ram", Cover = "image/home/ram.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 2, Type = "Headphone", Cover = "image/home/headphone.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 3, Type = "Monitor", Cover = "image/home/monitor.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 4, Type = "Mouse", Cover = "image/home/mouse1.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 5, Type = "KeyBoard", Cover = "image/home/keyboard.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true },
                new CategoryEntity { Id = 6, Type = "MainBoard", Cover = "image/home/mainboard.jpg", CreatedDate = DateTimeOffset.Now, IsActive = true }
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
                    Image = "image/prouduct/Ram-Desktop-v-color.jpg",
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
                    Image = "image/prouduct/ram-adata.jpg",
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
                    Image = "image/prouduct/tai-nghe-corsair.jpg",
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
                    Image = "image/prouduct/tai-nghe-gaming.jpg",
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
                    Image = "image/prouduct/màn-hình-asus.jpg",
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
                    Image = "image/prouduct/màn-hình-acer-nitro.jpg",
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
                    Image = "image/prouduct/chuột-gaming-logitech-g502.jpg",
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
                    Image = "image/prouduct/chuột-gaming-logitech-g102.jpg",
                    Description = "Loại chuột\tChuột Gaming\r\nKiểu kết nối\tUSB\r\nĐộ phân giải chuột\t8000 dpi\r\nThương hiệu\tLogitech\r\nXuất xứ\tTrung Quốc\r\nThời gian bảo hành (tháng)\t12",
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
