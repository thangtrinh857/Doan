﻿// <auto-generated />
using System;
using Accessories.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Accessories.Data.Migrations
{
    [DbContext(typeof(AccessoriesDbContext))]
    [Migration("20221025155039_InitDatabase")]
    partial class InitDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Accessories.Domain.Models.BillEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Accessories.Domain.Models.CartProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BillEntityId")
                        .HasColumnType("int");

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BillEntityId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartProducts");
                });

            modelBuilder.Entity("Accessories.Domain.Models.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cover = "image/home/ram.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9716), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "Ram"
                        },
                        new
                        {
                            Id = 2,
                            Cover = "image/home/headphone.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "Headphone"
                        },
                        new
                        {
                            Id = 3,
                            Cover = "image/home/monitor.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9738), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "Monitor"
                        },
                        new
                        {
                            Id = 4,
                            Cover = "image/home/mouse1.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9739), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "Mouse"
                        },
                        new
                        {
                            Id = 5,
                            Cover = "image/home/keyboard.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9740), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "KeyBoard"
                        },
                        new
                        {
                            Id = 6,
                            Cover = "image/home/mainboard.jpg",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 7, 0, 0, 0)),
                            IsActive = true,
                            Type = "MainBoard"
                        });
                });

            modelBuilder.Entity("Accessories.Domain.Models.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BillEntityId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("BillEntityId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9901), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Loại RAM: DDR4Dung lượng RAM: 8 GB (1 thanh 8 GB)Tốc độ RAM: 3200 MHzĐóng gói: ThanhMàu LED: KhôngThương hiệu: V-colorXuất xứ: Đài LoanThời gian bảo hành (tháng): 60",
                            Image = "image/prouduct/Ram-Desktop-v-color.jpg",
                            IsActive = true,
                            Name = "RAM Desktop V-Color Skywalker Plus 8 GB - DDR4 - 3200 MHz - Purple",
                            Price = 799000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9903), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Loại RAM: DDR4: Dung lượngRAM: 8 GBTốc độ RAM: 3200 MHzĐóng gói: 1 ThanhMàu LED: RGBThương hiệu: AdataXuất xứ: Đài LoanThời gian bảo hành (tháng): 36",
                            Image = "image/prouduct/ram-adata.jpg",
                            IsActive = true,
                            Name = "RAM ADATA XPG Spectrix D41 RGB 8 GB-DDR4-3200 MHz",
                            Price = 859000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9905), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Thương hiệu: CORSAIRXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Kích thước: 160 x 100 x 205 mmTrọng lượng sản phẩm: 325 gChất liệu: NhựaĐộ dài dây: 1.8 mMàu sắc: Xanh lá",
                            Image = "image/prouduct/tai-nghe-corsair.jpg",
                            IsActive = true,
                            Name = "Tai nghe Corsair HS50 PRO Stereo",
                            Price = 1278000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Thương hiệu: RapooXuất xứ: Trung QuốcThời gian bảo hành (tháng): 24Trọng lượng sản phẩm: 340 gChất liệu: NhựaChất liệu: DaĐộ dài dây: 220 cmMàu sắc: Đen",
                            Image = "image/prouduct/tai-nghe-gaming.jpg",
                            IsActive = true,
                            Name = "Tai nghe gaming Rapoo VH160 có mic",
                            Price = 505000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9908), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Màn hình: Màn hình phẳng, 23.8 inch, 1920 x 1080 Pixels, FHD, 300 nits, Anti-glare LED-backlitTần số quét: 75 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 5msTiêu thụ năng lượng: 0.3 WCổng kết nối: 1 DisplayPort 1.2, 1 Jack 3.5 mm, 1 HDMI 1.4, 1 VGAĐầu ra âm thanh: LoaThương hiệu: AsusXuất xứ: Trung Quốc",
                            Image = "image/prouduct/màn-hình-asus.jpg",
                            IsActive = true,
                            Name = "Màn hình ASUS VA24DQ/23.8 inch/FHD (1920x1080)/75Hz",
                            Price = 3790000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9909), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Màn hình: 27 inch, 1920 x 1080 Pixels, FHD, 250 nits, IPSTần số quét: 165 HzGóc nhìn: 178°(Dọc) / 178°(Ngang)Thời gian phản hồi: 0.5msCổng kết nối: 1 DisplayPort, 2 HDMIĐầu ra âm thanh: HeadphoneThương hiệu: AcerXuất xứ: Trung Quốc",
                            Image = "image/prouduct/màn-hình-acer-nitro.jpg",
                            IsActive = true,
                            Name = "Màn hình Acer Nitro VG270 S/27inch/FHD (1920x1080)/165Hz",
                            Price = 5840000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9910), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	16000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12",
                            Image = "image/prouduct/chuột-gaming-logitech-g502.jpg",
                            IsActive = true,
                            Name = "Chuột Gaming Logitech G502 Hero High Performance",
                            Price = 1750000,
                            Unit = "đ"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 10, 25, 22, 50, 38, 855, DateTimeKind.Unspecified).AddTicks(9911), new TimeSpan(0, 7, 0, 0, 0)),
                            Description = "Loại chuột	Chuột Gaming\r\nKiểu kết nối	USB\r\nĐộ phân giải chuột	8000 dpi\r\nThương hiệu	Logitech\r\nXuất xứ	Trung Quốc\r\nThời gian bảo hành (tháng)	12",
                            Image = "image/prouduct/chuột-gaming-logitech-g102.jpg",
                            IsActive = true,
                            Name = "Chuột Gaming Logitech G102 Gen2 Lightsync",
                            Price = 700000,
                            Unit = "đ"
                        });
                });

            modelBuilder.Entity("Accessories.Domain.Models.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActived")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Accessories.Domain.Models.CartProduct", b =>
                {
                    b.HasOne("Accessories.Domain.Models.BillEntity", null)
                        .WithMany("CartProducts")
                        .HasForeignKey("BillEntityId");

                    b.HasOne("Accessories.Domain.Models.ProductEntity", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Accessories.Domain.Models.ProductEntity", b =>
                {
                    b.HasOne("Accessories.Domain.Models.BillEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("BillEntityId");

                    b.HasOne("Accessories.Domain.Models.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Accessories.Domain.Models.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Accessories.Domain.Models.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accessories.Domain.Models.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Accessories.Domain.Models.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Accessories.Domain.Models.BillEntity", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Accessories.Domain.Models.CategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Accessories.Domain.Models.ProductEntity", b =>
                {
                    b.Navigation("CartProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
