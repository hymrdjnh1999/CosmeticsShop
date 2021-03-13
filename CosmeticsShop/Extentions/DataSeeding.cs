using CosmeticsShop.Data.Entities;
using CosmeticsShop.Data.Enums;
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
        }
    }
}
