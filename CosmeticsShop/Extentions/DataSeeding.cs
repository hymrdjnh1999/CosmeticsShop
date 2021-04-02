using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Data.Extentions
{
    public static class DataSeeding
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig { Key = "HomeTitle", Value = "This is home page of Cosmetics Shop" },
                new AppConfig { Key = "HomeKeyWord", Value = "This is keyword of Cosmetics Shop" },
                new AppConfig { Key = "HomeDescription", Value = "This is description of Cosmetics Shop" }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    IsOutstanding = true,
                    Name = "Nước Hoa",
                    SortOrder = 1,
                    Status = Status.Active,
                    ParentId = null,

                },
                 new Category
                 {
                     Id = 2,
                     IsOutstanding = false,
                     Name = "Mercedes Benz",
                     SortOrder = 2,
                     Status = Status.Active,
                     ParentId = 1,

                 },
                 new Category
                 {
                     Id = 3,
                     IsOutstanding = false,
                     Name = "Gucci",
                     SortOrder = 3,
                     Status = Status.Active,
                     ParentId = 1,

                 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Mercedes-Benz Man EDT",
                    Description = "" +
                "Mercedes-Benz là hãng xe hơi danh tiếng lâu đời nhất của Đức được thành lập vào năm 1926 có trụ sở tại Stuttgart," +
                " và là một trong những hãng xe tiên phong trong việc giới thiệu nhiều công nghệ" +
                " và những sáng kiến về độ an toàn cao. Hãng lần đầu tiên phát hành nước hoa vào năm 2012 và được chế tác tại Pháp" +
                " để đáp ứng cho dân chơi xe hơi chuyên nghiệp.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: quả Lê, hạt Ambrette" +
                    "- Hương giữa: Tuyết Tùng, Phong Lữ" +
                    "- Hương cuối: Rêu Sồi, Palisander",
                    OriginalPrice = 1200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1200000,
                    Id = 1,
                    OriginalCountry = "GERMANY",
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Bloom Nettare EDP",
                    Description = "Mùi hương hướng đến đối tượng phụ nữ từ 30 trở lên, mong muốn thể hiện sự quý phái và đằm thắm." +
                    " Với những thành phần nguyên bản từ Bloom EDP cộng với Hoa Hồng và Hoa Quế.",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 2,
                    OriginalCountry = "Ý"
                }
            );

            modelBuilder.Entity<CosmeticsCollection>().HasData(
                new CosmeticsCollection()
                {
                    Id = 1,
                    Name = "MAN [EAU DE TOILETTE]"
                },
                new CosmeticsCollection()
                {
                    Id = 2,
                    Name = "ƯU ĐÃI NƯỚC HOA TRONG THÁNG 7 2020"
                }

                );

            modelBuilder.Entity<ProductInCosmeticsCollection>().HasData(
                new ProductInCosmeticsCollection()
                {
                    ProductId = 1,
                    CosmeticsCollectionId = 1
                },
                new ProductInCosmeticsCollection()
                {
                    ProductId = 2,
                    CosmeticsCollectionId = 1
                },
                new ProductInCosmeticsCollection()
                {
                    ProductId = 1,
                    CosmeticsCollectionId = 2
                },
                new ProductInCosmeticsCollection()
                {
                    ProductId = 2,
                    CosmeticsCollectionId = 2
                });

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 1 },
                new ProductInCategory() { ProductId = 1, CategoryId = 2 },
                new ProductInCategory() { ProductId = 2, CategoryId = 3 }
            );

            const string ADMIN_ID = "1C856746-F8AA-4026-B854-F18DA9787CF3";
            const string HAIANH_ID = "D8B63B91-C360-4E3D-9B3A-2DCE31F00CC4";
            const string PHUONGID = "33674F31-0BD2-43CD-9090-3F0D4BAB1C58";
            const string ROLE_ID = "BD5B83D2-5C75-4F96-A63F-1ECA425BDFE5";
            const string ROLE_ID2 = "EFEBFD93-B27D-4C91-8A71-74FD71944893";

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = new Guid(ROLE_ID),
                    Name = "Manager",
                    NormalizedName = "Manager",
                    Description = "Manager role"
                },
                new Role()
                {
                    Id = new Guid(ROLE_ID2),
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Description = "Customer role"
                });
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid(ADMIN_ID),
                    Email = "tiendinhdev99@gmail.com",
                    NormalizedEmail = "tiendinhdev99@gmail.com",
                    Dob = new DateTime(1999, 06, 21),
                    UserName = "voibenho99",
                    NormalizedUserName = "manager",
                    Name = "Voi Bé Nhỏ",
                    SecurityStamp = string.Empty,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "adolphin123")
                },
                new User()
                {
                    Id = new Guid(HAIANH_ID),
                    Email = "Haianh@gmail.com",
                    NormalizedEmail = "Haianh@gmail.com",
                    Dob = new DateTime(2001, 07, 11),
                    UserName = "haianh",
                    NormalizedUserName = "haianhmanager",
                    Name = "Hải Anh",
                    SecurityStamp = string.Empty,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd@123")
                },
                new User()
                {
                    Id = new Guid(PHUONGID),
                    Email = "Tranphuong18032001@gmail.com",
                    NormalizedEmail = "Tranphuong18032001@gmail.com",
                    Dob = new DateTime(2001, 03, 18),
                    UserName = "tranphuong",
                    NormalizedUserName = "tranphuongmanager",
                    Name = "Thu Phương",
                    SecurityStamp = string.Empty,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd@123")
                });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid(ADMIN_ID),
                    RoleId = new Guid(ROLE_ID)
                },
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid(HAIANH_ID),
                    RoleId = new Guid(ROLE_ID2)
                },
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid(PHUONGID),
                    RoleId = new Guid(ROLE_ID2)
                }
                );

            modelBuilder.Entity<Slider>().HasData(
               new Slider
               {
                   Id = 1,
                   Name = "First Slide",
                   SortOrder = 1,
                   Status = Status.Active,
                   Url = "#",
                   Image = "https://www.gettyimages.pt/gi-resources/images/Homepage/Hero/PT/PT_hero_42_153645159.jpg"
               },
                new Slider
                {
                    Id = 2,
                    Name = "Second Slide",
                    SortOrder = 2,
                    Status = Status.Active,
                    Url = "#",
                    Image = "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/212HEROES-Desktop_1560x600_40ae22ae-9303-4773-af47-796d63fff29d_1800x.jpg"
                },
                new Slider
                {
                    Id = 3,
                    Name = "Third Slide",
                    SortOrder = 3,
                    Status = Status.Active,
                    Url = "#",
                    Image = "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/JC-WebBanner-1560x600_1800x.jpg"
                },
                 new Slider
                 {
                     Id = 4,
                     Name = "Fourth Slide",
                     SortOrder = 4,
                     Status = Status.Active,
                     Url = "#",
                     Image = "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/LE_BELLE_LE_MALE_1560x600_7921449a-7a2c-4aba-b1cc-939576de9067_1800x.jpg"
                 },
                new Slider
                {
                    Id = 5,
                    Name = "Fiveth Slide",
                    SortOrder = 5,
                    Status = Status.Active,
                    Url = "#",
                    Image = "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/imgpsh_fullsize_anim_8_aa16529c-d632-45c7-89b0-35b1b5c81fee_1800x.jpg?v=1615517435"
                },
                new Slider
                {
                    Id = 6,
                    Name = "Sixth Slide",
                    SortOrder = 6,
                    Status = Status.Active,
                    Url = "#",
                    Image = "https://helpx.adobe.com/content/dam/help/en/photoshop/using/convert-color-image-black-white/jcr_content/main-pars/before_and_after/image-before/Landscape-Color.jpg"
                }
           );
        }
    }
}
