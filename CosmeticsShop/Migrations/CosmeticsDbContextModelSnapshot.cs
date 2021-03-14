﻿// <auto-generated />
using System;
using CosmeticsShop.Data.EntityFrameWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CosmeticsShop.Data.Migrations
{
    [DbContext(typeof(CosmeticsDbContext))]
    partial class CosmeticsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CosmeticsShop.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");

                    b.HasData(
                        new
                        {
                            Key = "HomeTitle",
                            Value = "This is home page of Cosmetics Shop"
                        },
                        new
                        {
                            Key = "HomeKeyWord",
                            Value = "This is keyword of Cosmetics Shop"
                        },
                        new
                        {
                            Key = "HomeDescription",
                            Value = "This is description of Cosmetics Shop"
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsOutstanding")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2);

                    b.HasKey("Id");

                    b.ToTable("Categoires");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsOutstanding = true,
                            Name = "Nước Hoa",
                            SortOrder = 1,
                            Status = 2
                        },
                        new
                        {
                            Id = 2,
                            IsOutstanding = false,
                            Name = "Mercedes Benz",
                            ParentId = 1,
                            SortOrder = 2,
                            Status = 2
                        },
                        new
                        {
                            Id = 3,
                            IsOutstanding = false,
                            Name = "Gucci",
                            ParentId = 1,
                            SortOrder = 3,
                            Status = 2
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.CosmeticsCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CosmeticsCollections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "MAN [EAU DE TOILETTE]"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ƯU ĐÃI NƯỚC HOA TRONG THÁNG 7 2020"
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForGender")
                        .HasColumnType("int");

                    b.Property<bool>("IsOutstanding")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mercedes-Benz là hãng xe hơi danh tiếng lâu đời nhất của Đức được thành lập vào năm 1926 có trụ sở tại Stuttgart, và là một trong những hãng xe tiên phong trong việc giới thiệu nhiều công nghệ và những sáng kiến về độ an toàn cao. Hãng lần đầu tiên phát hành nước hoa vào năm 2012 và được chế tác tại Pháp để đáp ứng cho dân chơi xe hơi chuyên nghiệp.",
                            Details = " ✔️Mùi hương đặc trưng:- Hương đầu: quả Lê, hạt Ambrette- Hương giữa: Tuyết Tùng, Phong Lữ- Hương cuối: Rêu Sồi, Palisander",
                            ForGender = 1,
                            IsOutstanding = false,
                            Name = "Mercedes-Benz Man EDT",
                            OriginalCountry = "GERMANY",
                            OriginalPrice = 1200000m,
                            Price = 1200000m,
                            Stock = 100,
                            ViewCount = 0
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mùi hương hướng đến đối tượng phụ nữ từ 30 trở lên, mong muốn thể hiện sự quý phái và đằm thắm. Với những thành phần nguyên bản từ Bloom EDP cộng với Hoa Hồng và Hoa Quế.",
                            ForGender = 2,
                            IsOutstanding = false,
                            Name = "Gucci Bloom Nettare EDP",
                            OriginalCountry = "Ý",
                            OriginalPrice = 2150000m,
                            Price = 2150000m,
                            Stock = 100,
                            ViewCount = 0
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInCosmeticsCollection", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CosmeticsCollectionId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CosmeticsCollectionId");

                    b.HasIndex("CosmeticsCollectionId");

                    b.ToTable("ProductInCosmeticsCollections");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CosmeticsCollectionId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CosmeticsCollectionId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CosmeticsCollectionId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CosmeticsCollectionId = 2
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInProductPrivateProperty", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductPrivatePropertyId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "ProductPrivatePropertyId");

                    b.HasIndex("ProductPrivatePropertyId");

                    b.ToTable("ProductInProductPrivateProperties");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductPrivateProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductPrivateProperties");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsApplyForAll")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductIds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                            ConcurrencyStamp = "3cc27152-cf30-430d-a3ca-059236a34f65",
                            Description = "Administrator role",
                            Name = "Supper Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                            ConcurrencyStamp = "1379cfed-0014-45da-9c59-d40311f2412b",
                            Description = "Administrator role",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ExternalTransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "49a7d2af-671a-4e7b-bbbc-2612672ed866",
                            Dob = new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tiendinhdev99@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Voi Bé Nhỏ",
                            NormalizedEmail = "tiendinhdev99@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEPQEjcjtrJRaNRqWcxreHOd5fQP35SH/kp0ll9Dm0w5nFMMOVif9QylMJTw/KrCifw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "voibenho99"
                        },
                        new
                        {
                            Id = new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31bd465b-ff61-4057-8b19-3b0e2bcd939a",
                            Dob = new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Haianh@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Hải Anh",
                            NormalizedEmail = "Haianh@gmail.com",
                            NormalizedUserName = "haianhadmin",
                            PasswordHash = "AQAAAAEAACcQAAAAEC3CwHgt9G8E8JlJIQdA/6lWUMt1cF6aDvfaAryoC7yXHFSg7pAG+YzDmm+PENtRHA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "haianh"
                        },
                        new
                        {
                            Id = new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab83c901-23cf-4215-9b3b-dc830f644580",
                            Dob = new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Tranphuong18032001@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Name = "Thu Phương",
                            NormalizedEmail = "Tranphuong18032001@gmail.com",
                            NormalizedUserName = "tranphuongadmin",
                            PasswordHash = "AQAAAAEAACcQAAAAEGGnySWyg5Zz71nNIgZdpIV1SaRvQnaEwZo9cftuDbdlDyoL2GCFvahEDfqyos+dzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "tranphuong"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                            RoleId = new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5")
                        },
                        new
                        {
                            UserId = new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                            RoleId = new Guid("efebfd93-b27d-4c91-8a71-74fd71944893")
                        },
                        new
                        {
                            UserId = new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                            RoleId = new Guid("efebfd93-b27d-4c91-8a71-74fd71944893")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Cart", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CosmeticsShop.Data.Entities.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Order", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CosmeticsShop.Data.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInCategory", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.Category", "Category")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CosmeticsShop.Data.Entities.Product", "Product")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInCosmeticsCollection", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.CosmeticsCollection", "CosmeticsCollection")
                        .WithMany("ProductInCosmeticsCollections")
                        .HasForeignKey("CosmeticsCollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CosmeticsShop.Data.Entities.Product", "Product")
                        .WithMany("ProductInCosmeticsCollections")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CosmeticsCollection");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductInProductPrivateProperty", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.Product", "Product")
                        .WithMany("ProductInProductPrivateProperties")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CosmeticsShop.Data.Entities.ProductPrivateProperty", "ProductPrivateProperty")
                        .WithMany("productInProductPrivateProperties")
                        .HasForeignKey("ProductPrivatePropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductPrivateProperty");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Transaction", b =>
                {
                    b.HasOne("CosmeticsShop.Data.Entities.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Category", b =>
                {
                    b.Navigation("ProductInCategories");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.CosmeticsCollection", b =>
                {
                    b.Navigation("ProductInCosmeticsCollections");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductInCategories");

                    b.Navigation("ProductInCosmeticsCollections");

                    b.Navigation("ProductInProductPrivateProperties");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.ProductPrivateProperty", b =>
                {
                    b.Navigation("productInProductPrivateProperties");
                });

            modelBuilder.Entity("CosmeticsShop.Data.Entities.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
