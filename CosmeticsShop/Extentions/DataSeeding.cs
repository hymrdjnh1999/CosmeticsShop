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

            modelBuilder.Entity<Category>().HasData(

                 new Category
                 {
                     Id = 1,
                     IsOutstanding = false,
                     Name = "Mercedes Benz",
                     SortOrder = 1,
                     Status = Status.Active,
                     ParentId = 1,
                 },
                 new Category
                 {
                     Id = 2,
                     IsOutstanding = false,
                     Name = "Gucci",
                     SortOrder = 2,
                     Status = Status.Active,
                     ParentId = 1,
                 },

                 new Category
                 {
                     Id = 3,
                     IsOutstanding = true,
                     Name = "Sản phẩm mới",
                     SortOrder = 3,
                     Status = Status.Active
                 },
                 new Category
                 {
                     Id = 4,
                     IsOutstanding = true,
                     Name = "Sản phẩm được yêu thích",
                     SortOrder = 4,
                     Status = Status.Active
                 },
                 new Category
                 {
                     Id = 5,
                     IsOutstanding = true,
                     Name = "Sản phẩm khuyến mại",
                     SortOrder = 5,
                     Status = Status.Active
                 },
                 new Category
                 {
                     Id = 6,
                     IsOutstanding = true,
                     Name = "Bộ quà tặng cao cấp",
                     SortOrder = 6,
                     Status = Status.Active
                 },
                 new Category
                 {
                     Id = 7,
                     IsOutstanding = false,
                     Name = "Dolce&Gabbana",
                     SortOrder = 7,
                     Status = Status.Active,
                     ParentId = 1,
                 },
                 new Category
                 {
                     Id = 8,
                     IsOutstanding = false,
                     Name = "Burberry",
                     SortOrder = 8,
                     Status = Status.Active,
                     ParentId = 1,
                 },
                 new Category
                 {
                     Id = 9,
                     IsOutstanding = false,
                     Name = "Coach",
                     SortOrder = 9,
                     Status = Status.Active,
                     ParentId = 1,
                 },
                 new Category
                 {
                     Id = 10,
                     IsOutstanding = false,
                     Name = "Montblanc",
                     SortOrder = 10,
                     Status = Status.Active,
                     ParentId = 1,
                 }
            );
            modelBuilder.Entity<Product>().HasData(
                // Mercedes-Benz
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
                    status= Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Mercedes-Benz Women EDP (New 2020)",
                    Description = "" +
                " Một hương thơm quyến rũ, sang trọng, hơn cả mong đợi được tạo ra để làm nổi bật và thể hiện cá tính của người" +
                "phụ nữ. Một câu chuyện tuyệt vời về sự nữ tính và tự cường, bao bọc cô ấy trong một hào quang thơm ngát.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  Gardenia" +
                    "- Heart giữa: Hoa Nhài" +
                    "- Hương cuối: Vanila",
                    OriginalPrice = 1400000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1400000,
                    Id = 2,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Mercedes-Benz On The Go",
                    Description = "" +
                "Một phiên bản mini 20ml của Mercedes với thiết kế nhỏ gọn để có thể mang theo bên mình. Gồm các dòng sản phẩm:",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả bưởi, Bạch đậu khấu, Hoa táo" +
                    "- Heart giữa: Muối, Hương nước biển, Hoa phong lữ" +
                    "- Hương cuối: Đậu Tonka, Nhựa thơm cây tùng",
                    OriginalPrice = 500000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 500000,
                    Id = 3,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Mercedes-Benz Woman EDP",
                    Description = "" +
              " Một hương thơm quyến rũ, sang trọng, hơn cả mong đợi được tạo ra để làm nổi bật và thể hiện cá tính của người" +
                "phụ nữ. Một câu chuyện tuyệt vời về sự nữ tính và tự cường, bao bọc cô ấy trong một hào quang thơm ngát.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  Gardenia" +
                    "- Heart giữa: Hoa Nhài" +
                    "- Hương cuối: Vanila",
                    OriginalPrice = 2400000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2400000,
                    Id = 4,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Mercedes-Benz Man Intense EDT",
                    Description = "" +
              "Sự thành công, tính ưa mạo hiểm và hoóc-môn adrenaline sẽ thúc đẩy họ tiến lên phía trước." +
                "Tôi muốn tạo ra một cái nhìn khác về chất nam tính. Thay vì tập trung vào các hương thơm tươi mới hơn," +
                       "tôi muốn tăng liều lượng hương gỗ trong tầng đầu và cho vào thêm một vài điều ngạc nhiên khác ",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  Quả Lê" +
                    "- Heart giữa: Hoa Phong Lữ" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 2200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2200000,
                    Id = 5,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Mercedes-Benz The Move EDT",
                    Description = "" +
              "Nước hoa dành cho những chàng trai với đam mê dịch chuyển." +
                "Cú húych The Move là một bản trường ca cuộc sống. Với bối cảnh âm nhạc, câu chuyện kể về một chàng trai trẻ" +
                       "đang trong công cuộc xuyên lòng đô thị và chiếm lấy nó cho riêng mình. Sự khát khao về cuộc sống được thể hiện rõ rệt" +
                       "qua mỗi bước đi và những bước nhảy, cả thế giới đang chuyển động và anh ấy cũng vậy.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:   Bưởi chua, Hoa táo, Bạch đậu khấu" +
                    "- Heart giữa: Lá phong lữ, Hương muối biển" +
                    "- Hương cuối: Đậu Tonka, Amberwood",
                    OriginalPrice = 2200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2200000,
                    Id = 6,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Mercedes-Benz Women EDT",
                    Description = "" +
              "Mercedes-Benz Woman Eau de Toilette thuộc nhóm hương hoa cỏ xanh thơm mát dịu ngọt thích hợp mọi mùa trong năm, ban ngày lẫn ban đêm." +
                "Làn hương tinh tế lan tỏa dễ chịu ra xung quanh." +
                       "Một hương thơm quyến rũ, sang trọng và đột phá thể hiện cá tính của người phụ nữ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  Quýt vàng, Lý chua" +
                    "- Heart giữa: Dành Dành, Nhài Sabac, Linh Lan" +
                    "- Hương cuối: Gỗ Đàn Hương, Xạ Hương, Iris",
                    OriginalPrice = 1200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1200000,
                    Id = 7,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Mercedes-Benz Le Parfum For Men EDP",
                    Description = "" +
              "Mercedes-Benz là hãng xe hơi danh tiếng lâu đời nhất của Đức được thành lập vào năm 1926 có trụ sở tại Stuttgart," +
                "và là một trong những hãng xe tiên phong trong việc giới thiệu nhiều công nghệ và những sáng kiến về độ an toàn cao." +
                       "Hãng lần đầu tiên phát hành nước hoa vào năm 2012 và được chế tác tại Pháp để đáp ứng cho dân chơi xe hơi chuyên nghiệp",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  quýt, cam bergamot, tiêu hồng " +
                    "- Heart giữa:  lá violet, hoa nghệ tây, nốt hương màu xanh tươi mát" +
                    "- Hương cuối: hoắc hương, cỏ hương bài, trầm hương ",
                    OriginalPrice = 2800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2800000,
                    Id = 8,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Mercedes-Benz Select Night EDP",
                    Description = "" +
              "Sau thành công của Mercedes-Benz Select," +
                "thương hiệu mang tính biểu tượng hiện đang đề xuất một cách giải thích mới về loại nước hoa cổ điển này," +
                       "trong một phiên bản dành cho ban đêm. Vẫn vượt thời gian nhưng nồng nàn hơn," +
                       "quyến rũ hơn hương thơm ban đầu, Mercedes-Benz Select Night có Eau de Parfum: nồng độ cao hơn," +
                       "có thể thể hiện rõ hơn bản sắc mạnh mẽ của mùi hương mới này." +
                       "Nó thể hiện sự sang trọng và nam tính, với một chút gợi cảm, một sự kết hợp hoàn hảo cho một quý ông háo hức quyến rũ một cách dễ dàng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bạch đậu khấu, Hoa oải hương" +
                    "- Heart giữa:  Tuyết tùng, Cam" +
                    "- Hương cuối: Gỗ đàn hương, Vani",
                    OriginalPrice = 1700000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1700000,
                    Id = 9,
                    OriginalCountry = "GERMANY",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Mercedes-Benz Man Intense EDT",
                    Description = "" +
              "Có một số loại nước hoa sẽ chẳng bao giờ khiến bạn phải băn khoăn." +
                "Vì sao ư? Bởi vì chúng phản ánh tính cách mạnh mẽ và đem đến ánh hào quang độc đáo " +
                       "và không thể nhầm lẫn cho người sử dụng." +
                       "Giống như nước hoa Mercedes-Benz Man và phiên bản mới với bản chất mạnh mẽ của nó vậy.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả Lê" +
                    "- Heart giữa:  Hoa Phong Lữ" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 1600000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1600000,
                    Id = 10,
                    OriginalCountry = "GERMANY",
                    status = Status.InActive
                },

                // Gucci
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Bloom EDP",
                    Description = "Lấy cảm hứng từ khu vườn hoa trắng ở những vùng nông thôn nước Ý, " +
                    "mùi hương chỉ có một tầng hương duy nhất với các thành phần: Hoa Sử Quân Tử - Hoa Huệ Tây - Nụ Hoa Nhài",
                    OriginalPrice = 2030000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2030000,
                    Id = 11,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Bloom Nettare EDP",
                    Description = "Mùi hương hướng đến đối tượng phụ nữ từ 30 trở lên, mong muốn thể hiện sự quý phái và đằm thắm." +
                    "Với những thành phần nguyên bản từ Bloom EDP cộng với Hoa Hồng và Hoa Quế.",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 12,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Guilty Pour Homme EDP",
                    Description = "Gucci Guilty Pour Home EDT được lấy cảm hứng từ nhân vật Casanova trong các tác phẩm văn học Ý. ",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Nhóm hương: Hương Gỗ Cay Nồng - Woody Spices" +
                    "- Hương đầu: Chanh Ý, Lavender" +
                    "- Hương giữa:  Hoa Cam" +
                    "- Hương cuối: Hoắc Hương, Tuyết Tùng, Vani",
                    OriginalPrice = 3100000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 3100000,
                    Id = 13,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Flora By Gucci EDP",
                    Description = "Dòng sản phẩm lấy cảm hứng từ họa tiết Flora in trên chiếc khăn choàng cổ nhà Gucci " +
                    "tặng cho công nương xứ Monaco - Grace Kelly. Một mùi hương nữ tính và sang trọng.",
                    OriginalPrice = 2670000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2670000,
                    Id = 14,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gucci Bloom Acqua Di Fiori EDT",
                    Description = "Phiên bản trẻ trung và nhẹ nhàng, đầy sức sống của Bloom. Mùi hương giữ nguyên các thành phần của Bloom EDP," +
                    "kết hợp cùng với những thành phần như: Hoa hồng đá xanh và nụ lý chua đen.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Nhóm hương: Hương Hoa Cỏ - Floral" +
                    "- Hương đầu: Lá Galbanum, Lá Lý Chua Đen" +
                    "- Hương giữa: Hoa Huệ Trắng, Hoa Nhài, Hoa Kim Ngân" +
                    "- Hương cuối: Xạ Hương, Gỗ Đàn Hương",
                    OriginalPrice = 2490000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2490000,
                    Id = 15,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[New] Gucci Bloom Ambrosia Di Fiori EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Nụ Hoa Nhài, Cây Leo Rangoon" +
                    "- Hương giữa: Hoa Huệ Ấn Độ" +
                    "- Hương cuối: Hoa hồng Damascena, Tuscan Orris",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 16,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[New] Gucci Bloom Profumo Di Fiori EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Nhài Sambac" +
                    "- Hương giữa: Hoa Huệ Tự Nhiên, Chiết Xuất Nụ Hoa Nhài Và Ngọc Lan Tây" +
                    "- Hương cuối: Gỗ Đàn Hương",
                    OriginalPrice = 2910000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2910000,
                    Id = 17,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gucci Combo Flora By Gucci EDP + Guilty Pour Homme EDP",
                    Description = "Dòng sản phẩm lấy cảm hứng từ họa tiết Flora in trên chiếc khăn choàng cổ nhà Gucci " +
                    "tặng cho công nương xứ Monaco - Grace Kelly. Một mùi hương nữ tính và sang trọng.",
                    OriginalPrice = 7140000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 7140000,
                    Id = 18,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gucci Flora Gorgeous Gardenia EDT Limited Edition 2020",
                    Description = "Vẫn giữ nguyên thiết kế như dòng Gucci Flora, nước hoa Gucci Flora Gorgeous Gardenia" +
                    "phiên bản giới hạn 2020 có màu tím lavender khá đặc biệt, đầy khiêu khích cho những ai vô tình chạm mắt.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả mọng đỏ, Quả lê." +
                    "- Hương giữa: Hoa dành dành, Hoa sứ." +
                    "- Hương cuối: Hoắc hương, Đường nâu.",
                    OriginalPrice = 2420000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2420000,
                    Id = 19,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gucci Guilty Black Pour Homme EDT (For Men)",
                    Description = "Một dòng nước hoa đại diện cho sự khiêu khích, hiện thân của những dụ dỗ đắm chìm trong những thú vui tội lỗi.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Ngò thơm, Hoa Lavender" +
                    "- Hương giữa: Hoa cam, Hoa cam Neroli, Hương lục" +
                    "- Hương cuối: Cây hoắc hương, Gỗ tuyết tùng",
                    OriginalPrice = 1930000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1930000,
                    Id = 20,
                    OriginalCountry = "Ý",
                    status = Status.InActive
                },

                //Sản phẩm mới
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[New] Carolina Herrera Very Good Girl EDP",
                    Description = "Vui vẻ, tuyệt vời và không sợ hãi, Very Good Girl là một màn trình diễn mới của mùi hương Good Girl biểu tượng." +
                    "Vẫn mang tầm nhìn của Carolina Herrera về sự đa dạng trong tính cách của người phụ nữ hiện đại," +
                    "hương thơm mới của hoa hồng quyến rũ cùng thiết kế nóng bỏng sẽ khiến bạn không thể cưỡng lại",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Nho Đỏ & Vải" +
                    "- Hương giữa: Hoa hồng & Hoa Lily" +
                    "- Hương cuối: Rượu Vanilla & Cỏ Hương Bài",
                    OriginalPrice = 3000000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 3000000,
                    Id = 21,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[New] Carolina Herrera Bad Boy Le Parfum EDP",
                    Description = "BAD BOY Le Parfum định nghĩa lại mùi hương mang tính biểu tượng của BAD BOY" +
                    "với một công thức mới táo bạo hơn bao giờ hết. Không hối lỗi, chân thực và bí ẩn," +
                    "mùi hương bất cần này thể hiện sự đa dạng trong tính cách của người đàn ông hiện đại." +
                    "BAD BOY Le Parfum là minh chứng cho thấy các quy tắc được tạo ra để bị phá vỡ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bưởi Chùm & Gai Dầu" +
                    "- Hương giữa: Xô Thơm & Phong Lữ" +
                    "- Hương cuối: Da & Cỏ Hương Bài",
                    OriginalPrice = 2360000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2360000,
                    Id = 22,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Carolina Herrera 212 Heroes EDT",
                    Description = "Lấy cảm hứng từ đô thị phồn hoa New York với nguồn năng lượng tươi trẻ, đầy nhiệt huyết không bao giờ ngừng chuyển động," +
                    "212 của nhà Carolina Herrera đại diện cho sự giao thoa hoàn hảo của nét đẹp của những giá trị xưa cũ cùng những điều mới lạ tân thời.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hương Gừng và Lê" +
                    "- Hương giữa: Hoa Phong Lữ và Lá Xô Thơm" +
                    "- Hương cuối: Hương Da Thuộc và Xạ Hương",
                    OriginalPrice = 2050000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2050000,
                    Id = 23,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Jimmy Choo I Want Choo EDP",
                    Description = "I WANT CHOO mang đậm làn hương hoa cỏ phương Đông (Oriental Floral), một chút ngọt ngào xen lẫn một chút gợi cảm," +
                    "rất sôi nổi nhưng cũng rất lắng đọng. I WANT CHOO mở đầu bằng những nốt hương Cam Đào tươi vui rực rỡ," +
                    "sau đó nốt hương trung tâm – Red Spider Lilies (Hoa Loa Kèn Nhện Đỏ) và Hoa Nhài Sambac trỗi dậy nồng nàn gợi cảm và kết lại bằng hương Vani ngọt ngào lắng đọng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hương Quýt & Đào Nhung" +
                    "- Hương giữa: Hoa Huệ Nhện Đỏ & Hoa Nhài Sambac" +
                    "- Hương cuối: Vanilla, Benzoin",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 24,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Nomade EDP",
                    Description = "Chứa đựng sự nữ tính mềm mại nhưng xen lẫn đâu đó là tinh thần phiêu lưu phóng khoáng được truyền cảm hứng" +
                    "từ những chân trời xa xôi và những cuộc tao ngộ bất ngờ đầy xúc xảm - " +
                    "Chloé Nomade Eau de Parfum là một nốt hương gỗ hòa quyện với nét rạng rỡ của những đóa hoa." +
                    "Sự mãnh liêt của Rêu Sồi được cân bằng hoàn hảo bởi sự hiện diện ngọt ngào mê đắm của Mận Mirablle và Lan Nam Phi nở rộ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Mận Mirabelle" +
                    "- Hương giữa: Hoa Lan Nam Phi" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 1920000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1920000,
                    Id = 25,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Love Story EDP",
                    Description = "Một câu chuyện tình yêu và những đóa hoa nở rộ - đầy tươi mới và quyến rũ," +
                    "Love Story EDP với tầng hương trung tâm là một vườn hoa Nhài Leo xinh đẹp – loài hoa tượng trưng cho hạnh phúc," +
                    "kết hợp cùng Hoa Cam trắng ngần thanh tao.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Cam Neroli" +
                    "- Hương giữa: Hoa Cam, Hoa Nhài Stephanotis" +
                    "- Hương cuối: Gỗ Tuyết Tùng",
                    OriginalPrice = 1920000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1920000,
                    Id = 26,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[New] Gucci Bloom Ambrosia Di Fiori EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Nụ Hoa Nhài, Cây Leo Rangoon" +
                    "- Hương giữa: Hoa Huệ Ấn Độ" +
                    "- Hương cuối: Hoa hồng Damascena, Tuscan Orris",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 27,
                    OriginalCountry = "Ý",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[NEW] Jean Paul Gaultier La Belle Le Parfum EDP",
                    Description = "Thiết kế màu xanh như hồ nước lấp loáng xanh mát, là nơi làm dịu mọi cơn khát và sự nóng bức. " +
                    "Khoác lên mình một chiếc áo kiêu xa lấp lánh bởi các tia nắng mặt trời chiếu rọi," +
                    "hồ nước như một dải lụa mềm mại, điểm xuyến cho vẻ đẹp đầy cám dỗ của khu vườn địa đàng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả Lê" +
                    "- Hương giữa: Đậu Tonka" +
                    "- Hương cuối: Vanilla",
                    OriginalPrice = 1800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1800000,
                    Id = 28,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana K By Dolce&Gabbana EDP (For Men)",
                    Description = "Tiếp nối câu chuyện về người đàn ông K by Dolce&Gabbana Eau de Toilette," +
                    " được quay tại khung cảnh nên thơ xanh ngát của vùng đồi Tuscan," +
                    "phiên bản K by Dolce&Gabbana Eau de Parfum mang lại một góc nhìn thân mật hơn về bậc đế vương Dolce&Gabbana," +
                    "cùng gương mặt đại diện đầy nam tính Mariano Di Vaio." +
                    "Trong thước phim, phóng trên chiếc mô tô phân khối lớn dọc theo đại lộ xanh ngát cây," +
                    " anh toát lên vẻ nam tính mạnh mẽ và đầy lôi cuốn cùng phong thái tự tin đỉnh đạc của bậc đế vương trong cuộc sống hằng ngày!",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Woody Spicy" +
                    "Mùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Bạch đậu khấu, Xô thơm, Gỗ Agarmotha",
                    OriginalPrice = 2120000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2120000,
                    Id = 29,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[New] Gucci Bloom Profumo Di Fiori EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Nhài Sambac" +
                    "- Hương giữa: Hoa Huệ Tự Nhiên, Chiết Xuất Nụ Hoa Nhài Và Ngọc Lan Tây" +
                    "- Hương cuối: Gỗ Đàn Hương",
                    OriginalPrice = 2190000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2190000,
                    Id = 30,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                //Sản phẩm được yêu thích
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[NEW] Jimmy Choo I Want Choo EDP",
                    Description = "I WANT CHOO mang đậm làn hương hoa cỏ phương Đông (Oriental Floral)," +
                     "một chút ngọt ngào xen lẫn một chút gợi cảm, rất sôi nổi nhưng cũng rất lắng đọng." +
                     "I WANT CHOO mở đầu bằng những nốt hương Cam Đào tươi vui rực rỡ," +
                     "sau đó nốt hương trung tâm – Red Spider Lilies (Hoa Loa Kèn Nhện Đỏ) và" +
                     "Hoa Nhài Sambac trỗi dậy nồng nàn gợi cảm và kết lại bằng hương Vani ngọt ngào lắng đọng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hương Quýt & Đào Nhung" +
                    "- Hương giữa: Hoa Huệ Nhện Đỏ & Hoa Nhài Sambac" +
                    "- Hương cuối: Vanilla, Benzoin",
                    OriginalPrice = 2150000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2150000,
                    Id = 31,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Jimmy Choo Urban Hero EDP For Men",
                    Description = "Urban Hero là sự gia nhập mới nhất từ Jimmy Choo cho dòng nước hoa nam." +
                     "Bổ sung một hương thơm mới với cường độ và sự tương phản mạnh mẽ hơn những dòng trước đây để đề cao cương lĩnh của người đàn ông hiện đại." +
                     "Một cái tôi nổi bật và không bị các định kiến xã hội gò bó, nghĩ như một nghệ sĩ và hành động như một người hùng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lemon Caviar, Black Pepper" +
                    "- Hương giữa: Rosewood, Vetiver" +
                    "- Hương cuối: Grey Amber, Leather Accord",
                    OriginalPrice = 1820000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1820000,
                    Id = 32,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Dolce&Gabbana Light Blue Love Is Love EDT (For Women)",
                    Description = "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa. " +
                     "Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu, về lực hút mãnh liệt " +
                     "kéo đôi tim lại gần nhau hơn không chỉ qua lời nói, mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Fruity Floral" +
                    "Mùi hương chính: Chanh Sicily, Táo Granny Smith, Dâu đỏ, Kem gelato dâu, Hoa Nhài, Xạ Hương & Tuyết Tùng",
                    OriginalPrice = 2040000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2040000,
                    Id = 33,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Nomade Absolu de Parfum EDP",
                    Description = "Đắm mình trong hương thơm ấm áp đầy tinh tế của một vùng đất diệu kỳ chỉ tồn tại trong miền viễn tưỡng," +
                     "Nomade Absolu vén màn tiết lộ một phiên bản mới mãnh liệt hơn được phát triển từ dòng Nomade nguyên bản." +
                     "Được ra đời từ bàn tay tài hoa của Quentin Bisch – sáng tạo thơm Nomade Absolu tựa như một người phụ nữ độc lập và yêu sự tự do.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Mận Mirabelle" +
                    "- Hương giữa: Gỗ Đàn Hương Ấn Độ" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 2140000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2140000,
                    Id = 34,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Nomade EDP",
                    Description = "Chứa đựng sự nữ tính mềm mại nhưng xen lẫn đâu đó là tinh thần phiêu lưu phóng khoáng được truyền cảm hứng từ những chân trời xa xôi" +
                     "và những cuộc tao ngộ bất ngờ đầy xúc xảm - Chloé Nomade Eau de Parfum là một nốt hương gỗ hòa quyện với nét rạng rỡ của những đóa hoa." +
                     "Sự mãnh liêt của Rêu Sồi được cân bằng hoàn hảo bởi sự hiện diện ngọt ngào mê đắm của Mận Mirablle và Lan Nam Phi nở rộ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Mận Mirabelle" +
                    "- Hương giữa: Hoa Lan Nam Phi" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 1920000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1920000,
                    Id = 35,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Signature EDP",
                    Description = "Với chủ điểm hương là Hoa hồng – biểu tượng kinh điển của nét nữ tính ," +
                     "Signature của Chlóe đem đến một sự thân thuộc mà vẫn tràn đầy gợi cảm," +
                     "một sáng tạo thơm mang tính trường tồn, vượt thời gian nhưng không hề kém đi những chấm phá hiện đại.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Mẫu Đơn" +
                    "- Hương giữa: Cánh Hoa Hồng, Hoa Mộc Lan" +
                    "- Hương cuối: Gỗ Tuyết Tùng, Long Diên Hương",
                    OriginalPrice = 1920000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1920000,
                    Id = 36,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Chloe Love Story EDP",
                    Description = "Một câu chuyện tình yêu và những đóa hoa nở rộ - đầy tươi mới và quyến rũ, " +
                     "Love Story EDP với tầng hương trung tâm là một vườn hoa Nhài Leo xinh đẹp " +
                     "– loài hoa tượng trưng cho hạnh phúc, kết hợp cùng Hoa Cam trắng ngần thanh tao.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Cam Neroli" +
                    "- Hương giữa: Hoa Cam, Hoa Nhài Stephanotis" +
                    "- Hương cuối: Gỗ Tuyết Tùng",
                    OriginalPrice = 1920000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1920000,
                    Id = 37,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Paco Rabanne 1 Million Parfum EDP For Men 2020",
                    Description = "1 Million Parfum vừa ra mắt trong tháng 8/2020 một lần nữa khẳng định và nâng tầm sự quyền lực " +
                     "và giàu có của gã đàn ông triệu đô nhà Paco Rabanne ." +
                     "Hương thơm độc đáo mạnh mẽ dành cho những người đàn ông không ngại chứng tỏ bản thân," +
                     "dám trở nên khác biệt và luôn vượt lên trên tất cả.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương Hoa: Hương hoa huệ kết hợp hương hổ phách" +
                    "- Hương Da Thuộc: Hương da thuộc được làm ấm cùng nhựa cây labdanum và resin",
                    OriginalPrice = 2650000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2650000,
                    Id = 38,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Carolina Herrera Bad Boy EDT",
                    Description = "BAD BOY là làn hương của sự đối ngẫu, đại diện cho cá tính, bản chất táo bạo của người đàn ông hiện đại. " +
                     "Một khi mạnh mẽ đi đôi với nhạy cảm, tự tin kèm điềm tĩnh Bad Boy" +
                     "chính là sự cân bằng hoàn hảo khi làm chủ được sự tương phản giúp mang mại những ưu điểm vượt trội." +
                     "Bad Boy EDT được dựa trên cảm hứng về một “bad boy” chính hiệu, “không che giấu cái xấu lại trở thành một điều tốt”.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam Bergamot, Tiêu hồng và trắng" +
                    "- Hương chính: Tuyết Tùng & cây Xô thơm" +
                    "- Hương cuối: Đậu Tonka & Cacao",
                    OriginalPrice = 2050000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2050000,
                    Id = 39,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Jean Paul Gautier Le Male Le Parfum EDP",
                    Description = "Le Male Parfums hứa hẹn sẽ đưa bạn vào một cuộc phiêu khứu giác đầy sự đối lập từ làm mất phương hướng đến bùng nổ và làm thỏa mãn các giác quan." +
                     "Hương bạch đấu khấu mạnh mẽ ở tầng hương đầu, tầng hương giữa là sự kết hợp của hoa oải hương thanh mát " +
                     "và hương hoa diên vĩ. Phiên bản EDP khiến bạn đắm chìm trong nốt hương vani nồng nàn, mãnh liệt và gây nghiện. ",
                    OriginalPrice = 1980000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1980000,
                    Id = 40,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Sản phẩm khuyến mại
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach Floral EDP",
                    Description = "Coach Floral vẫn dựa trên cảm hứng về bông hoa Trà đặc trưng của thương hiệu." +
                     "Bông hoa được tạo tác trên chất liệu da thuộc sang trọng, tông màu hồng nhẹ ấm áp mang đến cảm giác về một ngày nắng trong lành," +
                     "cô gái Coach Floral dạo bước trên cánh đồng với những bông hoa dại đang nở tươi đưa mình trong gió.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Pineapple Sorbet" +
                    "- Hương chính: Bó hoa với Sambac Jasmine & Peony" +
                    "- Hương cuối:  Crystal Musks",
                    OriginalPrice = 990000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 990000,
                    Id = 41,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Coach Men EDT",
                    Description = "Coach For Men Eau De Toilette đưa bạn vào một hành trình của những khả năng vô tận," +
                     "gợi lên cảm giác tự do đến từ năng lượng và sự tự phát của thành phố New York." +
                     "Một hương thơm hiện đại kết hợp những nốt hương tươi mát," +
                     "tràn đầy sức sống và sự gợi cảm ấm áp như làn da qua những nốt hương hổ phách, gỗ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lê Nashi xanh, Bergamot" +
                    "- Hương chính: Cardamom, Coriander" +
                    "- Hương cuối:  Vetiver, Suede, Ambergris",
                    OriginalPrice = 1470000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1470000,
                    Id = 42,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Coach Men Platinum EDP",
                    Description = "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp," +
                     "lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: tinh dầu tiêu đen, khóm" +
                    "- Hương chính: Cashmeran, xô thơm" +
                    "- Hương cuối:  da vani, hoắc hương",
                    OriginalPrice = 1260000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1260000,
                    Id = 43,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach Men Platinum EDP",
                    Description = "Một hương thơm của sự tương phản, mở ra với quả mâm xôi tươi tắn, lấp lánh," +
                    "rồi lách mình uyển chuyển nhường chỗ cho một bông hồng Thổ Nhĩ Kỳ sánh mịn," +
                    "trước khi đi vào những nốt hương khô ráo của xạ hương và da lộn đầy gợi cảm." +
                    "Mùi hương đặc trưng được tạo ra bởi hai nhà sáng chế nước hoa Anne Flipo và Juliette Karagueuzoglou.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lá Mâm xôi" +
                    "- Hương chính: Hoa hồng Thổ Nhĩ Kỳ" +
                    "- Hương cuối: Da lộn Musks",
                    OriginalPrice = 1785000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1785000,
                    Id = 44,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach New York Floral Blush EDP",
                    Description = "Coach Floral Blush là mùi hương của một người phụ nữ vui vẻ và lãng mạn," +
                    "tự tin và phóng khoáng tận hưởng ánh nắng mặt trời, sống một cuộc sống nhiều niềm vui được phủ đầy sự lạc quan.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: quả kỷ tử & một số trái mọng màu hồng" +
                    "- Hương chính: hoa mẫu đơn" +
                    "- Hương cuối: gỗ trắng, hoa bông gòn",
                    OriginalPrice = 990000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 990000,
                    Id = 45,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Coach Dreams",
                    Description = "Coach Dreams Eau De Parfum là một loại nước hoa có điểm nhấn là sự tự do và phiêu lưu - giống như một chuyến du hành xuyên Mỹ. " +
                    "Coach Dreams sẽ đưa bạn vào một cuộc hành trình để sống với ước mơ của bạn!" +
                    "Hương thơm kết hợp giữa cam đắng rạng rỡ" +
                    " và lê ngon ngọt với sự ấm áp gợi cảm của cây dành dành, hoa xương rồng và Cây Joshua.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lê, Cam (đắng)" +
                    "- Hương chính: Hoa xương rồng, Cây dành dành" +
                    "- Hương cuối: Cây Joshua (Yucca), Ambroxan",
                    OriginalPrice = 2520000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2520000,
                    Id = 46,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Holiday Gift Set Coach Dreams EDP",
                    Description = "Coach Dreams được lấy cảm hứng từ những chuyến viễn du xa xôi trên cung đường tràn ngập ánh nắng" +
                    "của miền Tây Hoa Kỳ với đầy ắp những ước vọng của những người trẻ." +
                    "Một chuyến đi dài gợi lên cho bạn nhiều mong đợi với những xa lộ rộng mở và đong đầy kỷ niệm xuyên suốt từ đầu đến cuối hành trình",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bitter Orange" +
                    "- Hương chính: Hoa Dành Dành, hoa Xương Rồng" +
                    "- Hương cuối: Joshua Tree",
                    OriginalPrice = 2520000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2520000,
                    Id = 47,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Coach Men Blue EDT",
                    Description = "Khởi đầu tươi mát, sau đó lắng dần và chuyển sang hương gỗ để trở nên trầm ấm hơn. " +
                    "Coach Men Blue EDT đem đến một mùi hương sôi nổi, tràn đầy năng lượng để khám phá những giới hạn đang ở phía trước.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: cam chanh, nho và các loại lá thơm" +
                    "- Hương chính: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng" +
                    "- Hương cuối: gỗ tuyết tùng và hổ phách",
                    OriginalPrice = 1890000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1890000,
                    Id = 48,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Coach Men Platinum EDP",
                    Description = "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp," +
                    "lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: tinh dầu tiêu đen, khóm" +
                    "- Hương chính: Cashmeran, xô thơm" +
                    "- Hương cuối: da vani, hoắc hương",
                    OriginalPrice = 1645000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1645000,
                    Id = 49,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Paco Rabanne 1 Million Lucky EDT (For Men)",
                    Description = "One Million Lucky eau de toilette dành cho nam giới. Một hương thơm gỗ, một trò chơi cảm giác xung quanh hạt phỉ gây nghiện." +
                    "Nếm thử. Tiếp theo là một mạch tươi mát, ngon ngọt: một miếng bánh tart, mận xanh." +
                    "Cam quýt hợp nhất. Rung động tối ưu: gỗ cực kỳ sôi động. Căng thẳng từ tuyết tùng." +
                    "Một hương thơm gợi cảm với các nốt hương mạnh mẽ của cây hoắc hương và gỗ hổ phách." +
                    "One Million Lucky: một hương thơm gây nghiện, một trải nghiệm thú vị!",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: cây phỉ." +
                    "- Hương chính: mận xanh, bưởi, cam bergamot." +
                    "- Hương cuối: tuyết tùng trắng, hoắc hương, gỗ hổ phách, vani.",
                    OriginalPrice = 1387500,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1387500,
                    Id = 50,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Bộ quà tặng cao cấp
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[NEW] Gift Set Jean Paul Gaultier La Belle Le Parfum EDP",
                    Description = "Sự hòa quyện ngọt ngào của Lê, thơm ngậy của Vanilla cùng những nốt hương mê" +
                    "hoặc của Đậu Tonka đã tạo nên một La Belle Le Parfum đẹp tuyệt, say đắm lòng người",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả Lê" +
                    "- Hương chính: Đậu Tonka" +
                    "- Hương cuối: Vanilla",
                    OriginalPrice = 1387500,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1387500,
                    Id = 51,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Jimmy Choo Urban Hero EDP",
                    Description = "Urban Hero là sự gia nhập mới nhất từ Jimmy Choo cho dòng nước hoa nam." +
                    "Bổ sung một hương thơm mới với cường độ và sự tương phản mạnh mẽ hơn những dòng trước đây để đề cao cương lĩnh của người đàn ông hiện đại." +
                    "Một cái tôi nổi bật và không bị các định kiến xã hội gò bó, nghĩ như một nghệ sĩ và hành động như một người hùng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lemon Caviar, Black Pepper" +
                    "- Hương chính: Rosewood, Vetiver" +
                    "- Hương cuối: Grey Amber, Leather Accord",
                    OriginalPrice = 2380000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2380000,
                    Id = 52,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Carolina Herrera Bad Boy EDT",
                    Description = "BAD BOY là làn hương của sự đối ngẫu, đại diện cho cá tính, bản chất táo bạo của người đàn ông hiện đại." +
                    "Một khi mạnh mẽ đi đôi với nhạy cảm, tự tin kèm điềm tĩnh Bad Boy chính là sự cân bằng hoàn hảo" +
                    "khi làm chủ được sự tương phản giúp mang mại những ưu điểm vượt trội." +
                    "Bad Boy EDT được dựa trên cảm hứng về một “bad boy” chính hiệu, “không che giấu cái xấu lại trở thành một điều tốt”.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam Bergamot, Tiêu hồng và trắng" +
                    "- Hương chính: Tuyết Tùng & cây Xô thơm" +
                    "- Hương cuối: Đậu Tonka & Cacao",
                    OriginalPrice = 2850000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2850000,
                    Id = 53,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Montblanc Legend EDP",
                    Description = "Các nốt hương tương tự dòng LEGEND EDT Cam - Lài - Rêu nhưng được hoà quyện thêm các nốt hương mới Violet" +
                    "- Cây phong lữ - Gỗ",
                    OriginalPrice = 2350000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2350000,
                    Id = 54,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Carolina Herrera 212 VIP Men EDT",
                    Description = "Là mùi hương được tạo ra dành riêng cho thế hệ quý ông với tham vọng tái thiết lập đô thị," +
                    "212 VIP Men xâm nhập vào chốn ồn ã với những nốt hương hiện đại mang cảm giác khó quên." +
                    "Không cần phải phá bỏ các quy tắc, những quý ông 212 VIP Men sẽ đặt ra những luật chơi mới và khiến những người khác tuân theo.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Chanh vàng, Caviar, bạc hà" +
                    "- Hương chính: Gừng, vodka" +
                    "- Hương cuối: hổ phách, xạ hương, violet wood",
                    OriginalPrice = 2450000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2450000,
                    Id = 55,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Carolina Herrera 212 VIP Men EDT",
                    Description = "Xuất hiện với ánh vàng lấp lánh đầy mê hoặc lòng người, Paco Rabanne Lady Million" +
                    "liền để lại sự ấn tượng của mình bằng vẻ ngoài sang trọng, quý phái dành riêng cho nữ giới.",
                    OriginalPrice = 2950000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2950000,
                    Id = 56,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Coach Dreams EDP",
                    Description = "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woody" +
                    "phảng phất cảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứng" +
                    "với nắng gió khẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác:" +
                    "Mở đầu là sự thanh mát của Cam Đắng và Lê mọng nước, sau đến tầng hương giữa là Hoa Xương Rồng" +
                    "giữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bitter Orange" +
                    "- Hương chính: Hoa Dành Dành, hoa Xương Rồng" +
                    "- Hương cuối: Joshua Tree",
                    OriginalPrice = 2800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2800000,
                    Id = 57,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Mercedes-Benz Man Intense EDT",
                    Description = "Có một số loại nước hoa sẽ chẳng bao giờ khiến bạn phải băn khoăn." +
                    "Vì sao ư? Bởi vì chúng phản ánh tính cách mạnh mẽ và đem đến ánh hào quang độc đáo và không thể nhầm lẫn" +
                    "cho người sử dụng. Giống như nước hoa Mercedes-Benz Man và phiên bản mới với bản chất mạnh mẽ của nó vậy." +
                    "Người đàn ông ưa chuộng mùi nước hoa này chắc chắn là những người có sức lôi cuốn cao, " +
                    "có hấp lực để trở thành tâm điểm của mọi hoạt động, ngay tại nơi đông đúc nhất," +
                    "dưới ánh đèn sân khấu và luôn thành công trong việc thu hút sự chú ý của bất cứ nơi nào họ đặt chân đến.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả Lê" +
                    "- Hương chính: Hoa Phong Lữ" +
                    "- Hương cuối: Rêu Sồi",
                    OriginalPrice = 2200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2200000,
                    Id = 58,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Lanvin A Girl In Capri EDT",
                    Description = "Lanvin - A Girl in Capri là một tinh chất rực rỡ đầy nắng của một chuyến du hành trên hòn đảo Capri xinh đẹp. " +
                    "Mùi hương là bức hoạ có màu xanh ngọc bích của biển Tyrrhenian dưới ánh nắng mặt trời," +
                    "màu trắng của những mái nhà quý tộc thấp thoáng dưới tán lá xanh," +
                    "màu vàng của nắng và những khu vườn cam bergamot màu mỡ." +
                    "Bản chất của cam Bergamot mở ra hương thơm rạng rỡ, lạc quan mãnh liệt như những ngôi sao" +
                    "rơi xuống trần gian làm tung toé những đốm sáng lấp lánh trên những con đường vắng lặng giữa trưa hè.",
                    OriginalPrice = 2200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2200000,
                    Id = 59,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Paco Rabanne 1 Million EDT",
                    Description = "Với thiết kế và màu sắc đặc trưng của vàng, 1 Million đại diện cho quyền lực, sự sang trọng và hào quang," +
                    "đem lại những cảm giác rất riêng, rất đặc biệt và đầy dấu ấn cho người sử dụng." +
                    "Dưới cái nhìn tổng thể, 1 Million mang cho mình tông hương trầm ấm nam tính đặc trưng của quế và các loại gia vị." +
                    "Len lỏi vào từng chi tiết, ta dễ dàng bắt gặp hương ngọt nhẹ từ Bưởi và Quýt, nhen nhúm một ít thanh mát của Bạc hà." +
                    "Nhanh chóng nhường chỗ cho sự cay trầm nồng nhiệt, Quế cùng Da thuộc lan tỏa khắp khứu giác," +
                    "phác họa bức tranh ngày càng rõ nét về người nắm quyền, thao túng tất cả với cốt cách mạnh mẽ của mình.",
                    OriginalPrice = 2450000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2450000,
                    Id = 60,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Dolce&Gabbana
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Dolce&Gabbana The Only One EDP Intense (For Women)",
                    Description = "The Only One Intense được phỏng tác trên lớp nền hoa cỏ của The Only One," +
                    "với kết hợp đối nghịch nhưng nhịp nhàng của hoa cam vàng và vanilla đen mềm mượt." +
                    "Như người phụ nữ mà nó biểu trưng," +
                    "nét đẹp mặn mà là thanh gương sắc bén mà không người đàn ông nào có thể chối từ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Floriental Solar" +
                    "Mùi hương chính: Hoa cam, Hoa trắng, Vanilla",
                    OriginalPrice = 2720000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2720000,
                    Id = 61,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana The One For Men Intense EDP",
                    Description = "The One For Men Eau de Parfum Intense, đem đến sức hấp dẫn mãnh liệt" +
                    "bởi cách kết hợp những nguyên liệu đối lập một cách táo bạo." +
                    "Nam tính mạnh mẽ, nhưng chân thực, trầm ấm, đó là mùi hương hoàn hảo của hai thái cực -" +
                    "sự ấm áp của hoa cam neroli và sự trầm lắng đầy bí ẩn của vanilla đen - đó là nghệ thuật chiaroscuro huyền thoại.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Oriental Spicy" +
                    "Mùi hương chính: Hoa cam Địa Trung Hải, Lá bách quý, Ngò, Gỗ cashmere, Nốt hương da thuộc",
                    OriginalPrice = 2220000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2220000,
                    Id = 62,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana K By Dolce&Gabbana EDP (For Men)",
                    Description = "Tiếp nối câu chuyện về người đàn ông K by Dolce&Gabbana Eau de Toilette," +
                    "được quay tại khung cảnh nên thơ xanh ngát của vùng đồi Tuscan," +
                    "phiên bản K by Dolce&Gabbana Eau de Parfum mang lại một góc nhìn thân mật hơn về bậc đế vương" +
                    "Dolce&Gabbana, cùng gương mặt đại diện đầy nam tính Mariano Di Vaio.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Woody Spicy" +
                    "Mùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Bạch đậu khấu, Xô thơm, Gỗ Agarmotha",
                    OriginalPrice = 2120000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2120000,
                    Id = 63,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana K By Dolce&Gabbana EDT (For Men)",
                    Description = "Dolce&Gabbana đem đến một biểu tượng nước hoa mới dành cho nam giới" +
                    "- K by Dolce&Gabbana EDT - mở ra một kỉ nguyên mới về chuẩn mực nam tính." +
                    "Lấy hình tượng người đàn ông làm chủ sự nghiệp" +
                    "là điểm tựa của gia đình & là nguồn cảm hứng cho đồng đội," +
                    "K by Dolce&Gabbana là biểu tượng cho một vị đế vương của cuộc sống hằng ngày!",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Woody Aromatic" +
                    "Mùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Xô thơm, Gỗ Tuyết Tùng",
                    OriginalPrice = 1970000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1970000,
                    Id = 64,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana Light Blue Pour Homme Love is Love EDT (For Men)",
                    Description = "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa." +
                    "Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu," +
                    "về lực hút mãnh liệt kéo đôi tim lại gần nhau hơn không chỉ qua lời nói," +
                    "mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Woody Aromatic" +
                    "Mùi hương chính: Chanh Sicily, Táo Granny Smith, Kem gelato táo, Tiêu Hồng, Hương Thảo, Xạ Hương & Gỗ Hổ Phách",
                    OriginalPrice = 1910000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1910000,
                    Id = 65,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Dolce&Gabbana Light Blue Love Is Love EDT (For Women)",
                    Description = "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa." +
                    "Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu," +
                    "về lực hút mãnh liệt kéo đôi tim lại gần nhau hơn không chỉ qua lời nói," +
                    "mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Fruity Floral" +
                    "Mùi hương chính: Chanh Sicily, Táo Granny Smith, Dâu đỏ, Kem gelato dâu, Hoa Nhài, Xạ Hương & Tuyết Tùng",
                    OriginalPrice = 2040000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2040000,
                    Id = 66,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Dolce&Gabbana The Only One 2 EDP (For Women)",
                    Description = "Dolce&Gabbana mang đến The Only One 2, chương thứ 2 trong câu chuyện về người phụ nữ The Only One." +
                    "Mạnh mẽ, đôc đáo, đầy hấp lực, cô gái The Only One" +
                    "luôn là tâm điểm của mọi ánh nhìn bởi cô ấy biết mình muốn mình và sẽ làm gì để đạt được điều đó.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Floriental Fruity" +
                    "Mùi hương chính: Hoa hồng, Dâu đỏ, Vanilla, Hoắc hương & Đậu Tonka",
                    OriginalPrice = 2590000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2590000,
                    Id = 67,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana The One For Men EDP",
                    Description = "The One For Men EDP là bức chân dung của một người đàn ông The One nam tính," +
                    "mùi hương mang đến một trải nghiệm sâu lắng, nồng nàn," +
                    "một tuyên bố mạnh mẽ cho ma lực cuốn hút không thể chối từ của người đàn ông The One.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Oriental Spicy" +
                    "Mùi hương chính: Tinh chất bưởi, Ngò & Lá Húng, Gừng, Bạch đậu khấu, Thuốc lá & Nốt gỗ hổ phách ấm áp",
                    OriginalPrice = 2120000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2120000,
                    Id = 68,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Dolce&Gabbana Combo The Only One EDP Intense + The One For Men Intense EDP",
                    Description = "The Only One Intense được phỏng tác trên lớp nền hoa cỏ của The Only One," +
                    "với kết hợp đối nghịch nhưng nhịp nhàng của hoa cam vàng và vanilla đen mềm mượt." +
                    "Như người phụ nữ mà nó biểu trưng," +
                    "nét đẹp mặn mà là thanh gương sắc bén mà không người đàn ông nào có thể chối từ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Floriental Solar" +
                    "Mùi hương chính: Hoa cam, Hoa trắng, Vanilla",
                    OriginalPrice = 6720000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 6720000,
                    Id = 69,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Dolce&Gabbana Combo Light Blue Intense EDP + Light Blue Pour Homme Intense EDP",
                    Description = "Mười sau năm kể từ khi ra mắt Light Blue, nhà chế tác Olivier Cresp viết nên một chương mới cho Light Blue" +
                    "với Light Blue Eau Intense. Hơn cả một hương hoa, đó là tất cả thần thái tỏa ra từ người phụ nữ Địa Trung Hải xinh đẹp.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "Nhóm hương: Fruity Floral" +
                    "Mùi hương chính: Chanh, Táo Granny Smith, Cánh hoa nhài non, Hổ phách & Xạ hương",
                    OriginalPrice = 5060000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 5060000,
                    Id = 70,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Burberry
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Burberry Her EDP",
                    Description = "Hương nước hoa ngọt ngào và trẻ trung, tràn đầy sức sống của người phụ nữ hiện đại." +
                    "Lấy cảm hứng từ thành phố London sôi động.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quả mọng đỏ và tím (mâm xôi đỏ, đen…)" +
                    "- Hương giữa: Hoa Nhài, Hoa Violet" +
                    "- Hương cuối: Hổ Phách, Rêu Sồi, Vani, Xạ Hương, Hoắc Hương",
                    OriginalPrice = 2030000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2030000,
                    Id = 71,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry Mr.Burberry Element EDT",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hạnh nhân xanh" +
                    "- Hương giữa: Gỗ Tuyết Tùng" +
                    "- Hương cuối: Long Diên Hương, Rêu Sồi",
                    OriginalPrice = 1980000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1980000,
                    Id = 72,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry My Burberry Black EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Nhài" +
                    "- Hương giữa: Hoa Hồng Tẩm Mật, Quả Đào" +
                    "- Hương cuối: Hổ Phách, Hoắc Hương",
                    OriginalPrice = 4160000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 4160000,
                    Id = 73,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry Mr. Burberry EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bưởi, Bạch Đậu Khấu, Bạc Hà" +
                    "- Hương giữa: Oải Hương, Tuyết Tùng, Nhục Đậu Khấu" +
                    "- Hương cuối: Cỏ Vetiver hun khói, Quế, Hoắc Hương, Hổ Phách",
                    OriginalPrice = 2190000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2190000,
                    Id = 74,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Burberry Her London Dream EDP",
                    Description = "",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Chanh, Gừng" +
                    "- Hương giữa: Hoa Mẫu Đơn, Hoa Hồng" +
                    "- Hương cuối: Xạ Hương, Hổ Phách",
                    OriginalPrice = 2030000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2030000,
                    Id = 75,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Burberry My Burberry Blush EDP",
                    Description = "Mùi hương mới nhất trong dòng My Burberry, được ví von như một khu vườn London trong một sáng sớm mùa xuân." +
                    "Hương hoa cỏ cùng trái cây đan xen một cách trẻ trung và ngọt ngào.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Chanh, Lựu Đỏ" +
                    "- Hương giữa: Hoa Hồng, Táo Xanh" +
                    "- Hương cuối: Hoa Nhài, Tử Đằng Xanh",
                    OriginalPrice = 2860000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2860000,
                    Id = 76,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Burberry Combo My Burberry Black EDP + Mr. Burberry EDP",
                    Description = "Hương thơm sang trọng và ngọt ngào nhất trong dòng My Burberry," +
                    "và cũng là phiên bản duy nhất có nồng độ tinh dầu cao nhất",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Hoa Nhài" +
                    "- Hương giữa: Hoa Hồng Tẩm Mật, Quả Đào" +
                    "- Hương cuối: Hổ Phách, Hoắc Hương",
                    OriginalPrice = 7750000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 7750000,
                    Id = 77,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry Mr. Burberry Indigo EDT",
                    Description = "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển," +
                    "mùi hương hiện đại và phóng khoáng, nam tính.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam chanh, Bergamot, Bách Xù" +
                    "- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà" +
                    "- Hương cuối: Rêu Sồi, Hổ Phách",
                    OriginalPrice = 2780000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2780000,
                    Id = 78,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry Mr. Burberry Indigo EDT",
                    Description = "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển," +
                    "mùi hương hiện đại và phóng khoáng, nam tính.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam chanh, Bergamot, Bách Xù" +
                    "- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà" +
                    "- Hương cuối: Rêu Sồi, Hổ Phách",
                    OriginalPrice = 2780000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2780000,
                    Id = 79,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Burberry Mr. Burberry Indigo EDT",
                    Description = "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển," +
                    "mùi hương hiện đại và phóng khoáng, nam tính.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam chanh, Bergamot, Bách Xù" +
                    "- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà" +
                    "- Hương cuối: Rêu Sồi, Hổ Phách",
                    OriginalPrice = 2780000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2780000,
                    Id = 80,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Coach
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Coach Men Blue EDT",
                    Description = "COACH MEN BLUE EDT là dòng nước hoa dành cho nam mới nhất từ Coach được lấy cảm hứng từ những chuyến road trip xuyên bang trứ danh ở Mỹ." +
                    "Một mùi hương của sự tự do và niềm phấn khởi khi lướt đi trên những đại lộ dài hun hút nối liền các vùng đất mới." +
                    "Dưới vòm trời xanh thẳm, bạn tận hưởng những làn gió mát vờn quanh, háo hức khám phá những điều bất ngờ của chuyến hành trình phía trước.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: cam chanh, nho và các loại lá thơm" +
                    "- Hương giữa: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng" +
                    "- Hương cuối: gỗ tuyết tùng và hổ phách",
                    OriginalPrice = 1550000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1550000,
                    Id = 81,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Coach Dreams EDP 2020",
                    Description = "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woody phảng phất" +
                    "cảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứng với nắng gió" +
                    "khẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác:" +
                    "Mở đầu là sự thanh mát của Cam Đắng và Lê mọng nước, sau đến tầng hương giữa là Hoa Xương Rồng" +
                    "giữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bitter Orange" +
                    "- Hương giữa: Hoa Dành Dành, hoa Xương Rồng" +
                    "- Hương cuối: Joshua Tree",
                    OriginalPrice = 1300000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1300000,
                    Id = 82,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach Floral EDP",
                    Description = "Coach Floral vẫn dựa trên cảm hứng về bông hoa Trà đặc trưng của thương hiệu." +
                    "Bông hoa được tạo tác trên chất liệu da thuộc sang trọng," +
                    "tông màu hồng nhẹ ấm áp mang đến cảm giác về một ngày nắng trong lành," +
                    "cô gái Coach Floral dạo bước trên cánh đồng với những bông hoa dại đang nở tươi đưa mình trong gió.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Pineapple Sorbet," +
                    "- Hương giữa: Bó hoa với Sambac Jasmine & Peony" +
                    "- Hương cuối: Crystal Musks",
                    OriginalPrice = 1100000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1100000,
                    Id = 83,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach New York EDP (Timeless Collection)",
                    Description = "Một hương thơm của sự tương phản, mở ra với quả mâm xôi tươi tắn, lấp lánh," +
                    "rồi lách mình uyển chuyển nhường chỗ cho một bông hồng Thổ Nhĩ Kỳ sánh mịn," +
                    "trước khi đi vào những nốt hương khô ráo của xạ hương và da lộn đầy gợi cảm." +
                    "Mùi hương đặc trưng được tạo ra bởi hai nhà sáng chế nước hoa Anne Flipo và Juliette Karagueuzoglou.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu:  Lá Mâm xôi" +
                    "- Hương giữa: Hoa hồng Thổ Nhĩ Kỳ" +
                    "- Hương cuối: Da lộn Musks",
                    OriginalPrice = 2550000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2550000,
                    Id = 84,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Coach Men EDT",
                    Description = "Coach For Men Eau De Toilette đưa bạn vào một hành trình của những khả năng vô tận," +
                    "gợi lên cảm giác tự do đến từ năng lượng và sự tự phát của thành phố New York." +
                    "Một hương thơm hiện đại kết hợp những nốt hương tươi mát," +
                    "tràn đầy sức sống và sự gợi cảm ấm áp như làn da qua những nốt hương hổ phách, gỗ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lê Nashi xanh, Bergamot" +
                    "- Hương giữa: Bạch đậu khấu, Rau mùi" +
                    "- Hương cuối: Cỏ Vetiver, Da lộn, Long diên hương",
                    OriginalPrice = 2100000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2100000,
                    Id = 85,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Coach Men Platinum EDP",
                    Description = "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp," +
                    "lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: tinh dầu tiêu đen, khóm" +
                    "- Hương giữa: Cashmeran, xô thơm" +
                    "- Hương cuối:  da vani, hoắc hương",
                    OriginalPrice = 1800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1800000,
                    Id = 86,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Coach New York Floral Blush EDP",
                    Description = "Coach Floral Blush là mùi hương của một người phụ nữ vui vẻ và lãng mạn," +
                    "tự tin và phóng khoáng tận hưởng ánh nắng mặt trời, sống một cuộc sống nhiều niềm vui được phủ đầy sự lạc quan.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: quả kỷ tử & một số trái mọng màu hồng" +
                    "- Hương giữa: hoa mẫu đơn" +
                    "- Hương cuối: gỗ trắng, hoa bông gòn",
                    OriginalPrice = 1100000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1100000,
                    Id = 87,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "[NEW] Coach Dreams EDP Body Lotion 150ml",
                    Description = "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woody phảng phất" +
                    "cảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứng với nắng gió" +
                    "khẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác: Mở đầu là sự thanh mát của Cam Đắng và Lê mọng" +
                    "nước, sau đến tầng hương giữa là Hoa Xương Rồng giữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bitter Orange" +
                    "- Hương giữa: Hoa Dành Dành, hoa Xương Rồng" +
                    "- Hương cuối: Joshua Tree",
                    OriginalPrice = 800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 800000,
                    Id = 88,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Gift Set Coach Dreams EDP",
                    Description = "Coach Dreams được lấy cảm hứng từ những chuyến viễn du xa xôi trên cung đường tràn ngập ánh nắng" +
                    "của miền Tây Hoa Kỳ với đầy ắp những ước vọng của những người trẻ." +
                    "Một chuyến đi dài gợi lên cho bạn nhiều mong đợi với những xa lộ rộng mở và đong đầy kỷ niệm xuyên suốt từ đầu đến cuối hành trình",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Bitter Orange" +
                    "- Hương giữa: Hoa Dành Dành, hoa Xương Rồng" +
                    "- Hương cuối: Joshua Tree",
                    OriginalPrice = 2800000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2800000,
                    Id = 89,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Gift Set Coach Men Blue EDT",
                    Description = "COACH MEN BLUE EDT là dòng nước hoa dành cho nam mới nhất từ Coach được lấy cảm hứng từ những chuyến road trip xuyên bang trứ danh ở Mỹ." +
                    "Coach Men Blue EDT đem đến một mùi hương sôi nổi," +
                    "Một mùi hương của sự tự do và niềm phấn khởi khi lướt đi trên những đại lộ dài hun hút nối liền các vùng đất mới." +
                    "Dưới vòm trời xanh thẳm, bạn tận hưởng những làn gió mát vờn quanh," +
                    "háo hức khám phá những điều bất ngờ của chuyến hành trình phía trước.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: cam chanh, nho và các loại lá thơm" +
                    "- Hương giữa: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng" +
                    "- Hương cuối: gỗ tuyết tùng và hổ phách",
                    OriginalPrice = 2100000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2100000,
                    Id = 90,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                },

                // Montblanc
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Explorer EDP",
                    Description = "Montblanc Explorer ngay từ những ngày đầu lên ý tưởng đã cho thấy nguyện vọng chinh phục không giới hạn" +
                    "các khách hàng của mình trên toàn thế giới." +
                    "hư một nhà thám hiểm thực thụ, anh ta không để bản thân thỏa mãn quá lâu trên đỉnh" +
                    "một ngọn núi mà ngay tức thì chọn cho mình một đỉnh cao mới thử thách là không giới hạn." +
                    "Đây chính là câu chuyện đằng sau hương nước hoa mới từ Montblanc - Monblanc Explorer",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam bergamot italian " +
                    "- Hương giữa: Haitian vetiver " +
                    "- Hương cuối: Indonesian patchouli",
                    OriginalPrice = 1250000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1250000,
                    Id = 91,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Montblanc Signature EDP",
                    Description = "Người phụ nữ SIGNATURE truyền cảm hứng cho mọi người, dùng sức mạnh của ngôn ngữ để thay đổi thế giới." +
                    "Người phụ nữ đầy nhiệt huyết và tự tin, cô ấy tạo nên những thay đổi tích cực thông qua ngòi bút." +
                    "Gợi nhắc đến những giá trị cốt lõi mang tính biểu tượng của Montblanc: " +
                    "Bình mực, franchise Montblanc Emblem và chiếc bút Montblanc Meisterstuck Solitaire Pen.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Quýt, Lan Trắng, Mẫu Đơn " +
                    "- Hương giữa: Vanila, Mộc Lan, Hoàng Lan" +
                    "- Hương cuối: Benzoin, Musk, Hổ Phách",
                    OriginalPrice = 1380000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1380000,
                    Id = 92,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "[NEW] Montblanc Legend EDP",
                    Description = "Ở phiên bản  LEGEND EDP, những cảm xúc và mùi hương nguyên bản của LEGEND- những điều đã chinh phục" +
                    "hàng triệu người đàn ông trên thế giới vẫn được giữ nguyên nhưng nay đã trở nên mạnh mẽ hơn, nam tính hơn.",
                    OriginalPrice = 1700000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1700000,
                    Id = 93,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Legend Night EDP",
                    Description = "Trong chương khứu giác thứ ba này, Maison Montblanc tiết lộ một khía cạnh lôi cuốn không kém," +
                    "nhưng bí ẩn hơn ở quý ông phi thường này." +
                    "Montblanc Legend Night phá vỡ tính hai mặt của mã đen và trắng của ngôi nhà," +
                    "dọn đường cho màu hổ phách gợi nhớ đến gỗ, vật liệu đích thực cuối cùng.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cam Bergamot, Cây xô thơm" +
                    "- Hương giữa: Cỏ Vetiver, Hoa Oải Hương" +
                    "- Hương cuối: Vani, Gỗ hoắc hương",
                    OriginalPrice = 1200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1200000,
                    Id = 94,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Bộ Nước Hoa Mini 4 x 4.5ml",
                    Description = "2 dòng nước hoa Huyền Thoại đến từ thương hiệu Montblanc, mang đến sự Tự tin," +
                    "Lịch lãm cùng với mùi hương cổ điển vượt thời gian. Phiên bản mini 4.5ml," +
                    "vẫn là thiết kế mang phong cách sang trọng, nhưng được tinh tế thu nhỏ lại để có thể mang theo bên mình.",
                    OriginalPrice = 950000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 950000,
                    Id = 95,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Legend For Men EDT",
                    Description = "Với những ai là fan của Montblanc thì dễ dàng nhận ra thiết kế chai vượt thời gian, mang nét cổ điển nhưng nam tính" +
                    "và giữ nguyên ngôi sao 5 cánh là dấu ấn của Montblanc qua bao thập kỷ." +
                    "Thủy tinh cường lực đen tuyền kết hợp cùng kim loại sáng bóng làm tăng hiệu ứng thị giác " +
                    "cũng như đem lại vẻ mạnh mẽ chắc chắn. Hình dáng Montblanc Legend được đánh cong uyển chuyển, cho thiện cảm mềm mại và tinh tế.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lavender, Bergamot" +
                    "- Hương giữa: Coumarin, Rêu sồi" +
                    "- Hương cuối: đậu Tonka",
                    OriginalPrice = 2200000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 2200000,
                    Id = 96,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Legend Spirit EDT",
                    Description = "Montblanc Legend EDT Một phiên bản đem lại xúc cảm dễ chịu so với dòng nước hoa Legend" +
                    "trước đó nhưng vẫn thừa kế sự tao nhã và tinh tế vốn có - Montblanc Legend Spirit man" +
                    "với thiết kế dáng chai kết hợp giữa màu trắng thanh khiết và chất liệu kim loại thép cường lực" +
                    "để tạo nên một chai nước hoa mang những nốt hương nam tính, tươi mới và mãnh liệt.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Lavender, Bergamot" +
                    "- Hương giữa: Coumarin, Rêu sồi" +
                    "- Hương cuối: đậu Tonka",
                    OriginalPrice = 1180000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1180000,
                    Id = 97,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Montblanc Lady Emblem Elixir EDP (For Women)",
                    Description = "Lady Emblem Elixir được tạo ra để dành cho người phụ nữ độc đáo, tinh tế và mạnh mẽ." +
                    "Hương đầu của hoa hồng gấm hoa được khuếch tán bởi một làn sóng mật ong và gia vị" +
                    "thể hiện định nghĩa mới này về sự nữ tính. Lớp hương cuối cho thấy hương gỗ nồng nàn với cây hoắc hương và vani." +
                    "Chai trang sức Lady Emblem Elixir được phủ một phần bằng kim loại vàng hồng quý giá, thể hiện một thế giới sang trọng và tinh tế.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Tiêu đen, Quả quýt, Vải thiều" +
                    "- Hương giữa: Hoa diên vĩ, Hoa hồng tuyệt đối, Hoa cam" +
                    "- Hương cuối: Vani, Gỗ đàn hương, Cây hoắc hương",
                    OriginalPrice = 1380000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1380000,
                    Id = 98,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Female,
                    Name = "Montblanc Lady Emblem EDP (Timeless Collection)",
                    Description = "Montblanc Lady Emblem, hương thơm mới tinh tế, nữ tính và kiên quyết hiện đại dành cho phụ nữ" +
                    "được lấy cảm hứng từ viên kim cương của Montblanc," +
                    "biểu tượng của tình yêu thuần khiết và vẻ đẹp. Phụ nữ Lady Emblem độc lập và hiện đại với tính linh hoạt" +
                    "đặc biệt khiến cô ấy trở thành người bạn đồng hành hoàn hảo cho đối tác Nam Emblem." +
                    "Có một điều chắc chắn: không thể phủ nhận cô ấy rất nữ tính, tránh phô trương và sở hữu" +
                    "vẻ đẹp cùng phong cách thời trang riêng biệt. Một hương thơm rượu sake hoa hồng huyền bí," +
                    "được tăng cường bởi gỗ đàn hương mịn như nhung mang đến tông màu hổ phách từ dưới lên trên. " +
                    "Một thần dược tuyệt hảo và đặc biệt dành cho phái nữ.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Sake Accords, Pinnk Pepper, Bưởi" +
                    "- Hương giữa: Rose Essential, Jasmine Sambac, Pomegrenate" +
                    "- Hương cuối: Dầu đàn hương, Hổ phách, Xạ hương pha lê",
                    OriginalPrice = 1350000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1350000,
                    Id = 99,
                    OriginalCountry = "Pháp",
                    status = Status.Active
                },
                new Product
                {
                    ForGender = ForGender.Male,
                    Name = "Montblanc Emblem EDT (For Men)",
                    Description = "Montblanc EMBLEM là một thiết kế thanh lịch và tinh tế. Màu đen đậm, sáng bóng mạnh mẽ," +
                    "thủy tinh nặng, biểu tượng bao hàm sự sang trọng và tinh tế của Montblanc." +
                    "Người đàn ông EMBLEM truyền tải một luồng khí mạnh mẽ thông qua sự hiện diện mạnh mẽ và sự quyến rũ tự nhiên của anh ta." +
                    "Anh ấy chỉ một tay thể hiện sự sang trọng và tinh tế do Montblanc thể hiện." +
                    "Sự hấp dẫn mang tính biểu tượng của anh ấy được phản ánh qua dấu vết khứu giác" +
                    "mà anh ấy để lại, đang phát triển trong một thời kỳ khó quên, tạo ấn tượng sâu sắc với mọi người.",
                    Details = " ✔️Mùi hương đặc trưng:" +
                    "- Hương đầu: Cây xô thơm Clary, Bạch đậu khấu và Bưởi" +
                    "- Hương giữa: Lá Quế, Violet Frosted, Phong lữ" +
                    "- Hương cuối: Gỗ Quý, Cây hoắc hương, Đậu Tonka",
                    OriginalPrice = 1360000,
                    Stock = 100,
                    ViewCount = 0,
                    Price = 1360000,
                    Id = 100,
                    OriginalCountry = "Pháp",
                    status = Status.InActive
                }
            );
            modelBuilder.Entity<ProductImage>().HasData(
                // Product Mercedes Benz
                new ProductImage()
                {
                    Id = 1,
                    Caption = "Mercedes Benz Man EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "1-Mercedes-Benz-Man-EDT.jpg",
                    ProductId = 1,
                    IsDefault = true,
                    SortOrder = 1
                },
                new ProductImage()
                {
                    Id = 2,
                    Caption = "Mercedes Benz Women EDP (New 2020)",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "2-Mercedes-Benz-Women-EDP-(New 2020).jpg",
                    ProductId = 2,
                    IsDefault = true,
                    SortOrder = 2
                },
                new ProductImage()
                {
                    Id = 3,
                    Caption = "[NEW] Mercedes-Benz On The Go",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "3-[NEW]-Mercedes-Benz-On-The-Go.jpg",
                    ProductId = 3,
                    IsDefault = true,
                    SortOrder = 3
                },
                new ProductImage()
                {
                    Id = 4,
                    Caption = "Gift Set Mercedes-Benz Woman EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "4-Gift-Set Mercedes-Benz-Woman-EDP.jpg",
                    ProductId = 4,
                    IsDefault = true,
                    SortOrder = 4
                },
                new ProductImage()
                {
                    Id = 5,
                    Caption = "Gift Set Mercedes-Benz Man Intense EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "5-Gift-Set-Mercedes-Benz-Man-Intense-EDT.jpg",
                    ProductId = 5,
                    IsDefault = true,
                    SortOrder = 5
                },
                new ProductImage()
                {
                    Id = 6,
                    Caption = "Gift Set Mercedes-Benz The Move EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "6-Gift-Set-Mercedes-Benz-The-Move-EDT.jpg",
                    ProductId = 6,
                    IsDefault = true,
                    SortOrder = 6
                },
                new ProductImage()
                {
                    Id = 7,
                    Caption = "Mercedes-Benz Women EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "7-Mercedes-Benz-Women-EDT.jpg",
                    ProductId = 7,
                    IsDefault = true,
                    SortOrder = 7
                },
                new ProductImage()
                {
                    Id = 8,
                    Caption = "Mercedes-Benz Le Parfum For Men EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "8-Mercedes-Benz-Le-Parfum-For-Men-EDP.jpg",
                    ProductId = 8,
                    IsDefault = true,
                    SortOrder = 8
                },
                new ProductImage()
                {
                    Id = 9,
                    Caption = "Mercedes-Benz Select Night EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "9-Mercedes-Benz-Select-Night-EDP.jpg",
                    ProductId = 9,
                    IsDefault = true,
                    SortOrder = 9
                },
                new ProductImage()
                {
                    Id = 10,
                    Caption = "[NEW] Mercedes-Benz Man Intense EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "10-[NEW]-Mercedes-Benz-Man-Intense-EDT.jpg",
                    ProductId = 10,
                    IsDefault = true,
                    SortOrder = 10
                },
                // Gucci
                new ProductImage()
                {
                    Id = 11,
                    Caption = "Gucci Bloom EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "11-Gucci-Bloom-EDP.jpg",
                    ProductId = 11,
                    IsDefault = true,
                    SortOrder = 11
                },
                new ProductImage()
                {
                    Id = 12,
                    Caption = "Gucci Bloom Nettare EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "12-Gucci-Bloom-Nettare-EDP.jpg",
                    ProductId = 12,
                    IsDefault = true,
                    SortOrder = 12
                },
                new ProductImage()
                {
                    Id = 13,
                    Caption = "Gucci Guilty Pour Homme EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "13-Gucci-Guilty-Pour-Homme-EDP.jpg",
                    ProductId = 13,
                    IsDefault = true,
                    SortOrder = 13
                },
                new ProductImage()
                {
                    Id = 14,
                    Caption = "Gucci Flora By Gucci EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "14-Gucci-Flora-By-Gucci-EDP.jpg",
                    ProductId = 14,
                    IsDefault = true,
                    SortOrder = 14
                },
                new ProductImage()
                {
                    Id = 15,
                    Caption = "Gucci Bloom Acqua Di Fiori EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "15-Gucci-Bloom-Acqua-Di-Fiori-EDT.jpg",
                    ProductId = 15,
                    IsDefault = true,
                    SortOrder = 15
                },
                new ProductImage()
                {
                    Id = 16,
                    Caption = "[New] Gucci Bloom Ambrosia Di Fiori EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "16-[New]-Gucci-Bloom-Ambrosia-Di-Fiori-EDP.jpg",
                    ProductId = 16,
                    IsDefault = true,
                    SortOrder = 16
                },
                new ProductImage()
                {
                    Id = 17,
                    Caption = "[New] Gucci Bloom Profumo Di Fiori EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "17-Gucci-Bloom-Profumo-Di-Fiori-EDP.jpg",
                    ProductId = 17,
                    IsDefault = true,
                    SortOrder = 17
                },
                new ProductImage()
                {
                    Id = 18,
                    Caption = "Gucci Combo Flora By Gucci EDP + Guilty Pour Homme EDP",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "18-Gucci-Combo-Flora-By-Gucci-EDP-Guilty-Pour-Homme-EDP.jpg",
                    ProductId = 18,
                    IsDefault = true,
                    SortOrder = 18
                },
                new ProductImage()
                {
                    Id = 19,
                    Caption = "Gucci Flora Gorgeous Gardenia EDT Limited Edition 2020",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "19-Gucci-Flora-Gorgeous-Gardenia-EDT-Limited-Edition-2020.jpg",
                    ProductId = 19,
                    IsDefault = true,
                    SortOrder = 19
                },
                new ProductImage()
                {
                    Id = 20,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "20-Gucci-Flora-Gorgeous-Gardenia-EDT-Limited-Edition-2020.jpg",
                    ProductId = 20,
                    IsDefault = true,
                    SortOrder = 20
                },
                // Sản Phẩm Mới
                new ProductImage()
                {
                    Id = 21,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "21-[New]-Carolina-Herrera-Very-Good-Girl-EDP.jpg",
                    ProductId = 21,
                    IsDefault = true,
                    SortOrder = 21
                },
                new ProductImage()
                {
                    Id = 22,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "22-[New]-Carolina-Herrera-Bad-Boy-Le-Parfum-EDP.jpg",
                    ProductId = 22,
                    IsDefault = true,
                    SortOrder = 22
                },
                new ProductImage()
                {
                    Id = 23,
                    Caption = "[NEW] Carolina Herrera 212 Heroes EDT",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "23-[NEW]-Jimmy-Choo-I-Want-Choo-EDP.jpg",
                    ProductId = 23,
                    IsDefault = true,
                    SortOrder = 23
                },
                new ProductImage()
                {
                    Id = 24,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "24-Chloe-Nomade-EDP.jpg",
                    ProductId = 24,
                    IsDefault = true,
                    SortOrder = 24
                },
                new ProductImage()
                {
                    Id = 25,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "25-Good-Girl-EDP.jpg",
                    ProductId = 25,
                    IsDefault = true,
                    SortOrder = 25
                },
                new ProductImage()
                {
                    Id = 26,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "26-Chloe-Love-Story-EDP.jpg",
                    ProductId = 26,
                    IsDefault = true,
                    SortOrder = 26
                },
                new ProductImage()
                {
                    Id = 27,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "27-[New]-Gucci-Bloom-Ambrosia-Di-Fiori-EDP.jpg",
                    ProductId = 27,
                    IsDefault = true,
                    SortOrder = 27
                },
                new ProductImage()
                {
                    Id = 28,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "28-[NEW]-Jean-Paul-Gaultier-La-Belle-Le-Parfum-EDP.jpg",
                    ProductId = 28,
                    IsDefault = true,
                    SortOrder = 28
                },
                new ProductImage()
                {
                    Id = 29,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "29-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP-(For Men).jpg",
                    ProductId = 29,
                    IsDefault = true,
                    SortOrder = 29
                },
                new ProductImage()
                {
                    Id = 30,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "30-[New]-Gucci-Bloom-Profumo-Di-Fiori-EDP.jpg",
                    ProductId = 30,
                    IsDefault = true,
                    SortOrder = 30
                },
                //Sản Phẩm Mới
                new ProductImage()
                {
                    Id = 31,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "31-[NEW]-Jimmy-Choo-I-Want-Choo-EDP.jpg",
                    ProductId = 31,
                    IsDefault = true,
                    SortOrder = 31
                },
                new ProductImage()
                {
                    Id = 32,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "32-Jimmy-Choo-Urban-Hero-EDP-For-Men.jpg",
                    ProductId = 32,
                    IsDefault = true,
                    SortOrder = 32
                },
                new ProductImage()
                {
                    Id = 33,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "33-Dolce&Gabbana-Light-Blue-Love-Is-Love-EDT-(For Women).jpg",
                    ProductId = 33,
                    IsDefault = true,
                    SortOrder = 33
                },
                new ProductImage()
                {
                    Id = 34,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "34-Chloe-Nomade-Absolu-de-Parfum-EDP.jpg",
                    ProductId = 34,
                    IsDefault = true,
                    SortOrder = 34
                },
                new ProductImage()
                {
                    Id = 35,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "35-Chloe-Nomade-EDP.jpg",
                    ProductId = 35,
                    IsDefault = true,
                    SortOrder = 35
                },
                new ProductImage()
                {
                    Id = 36,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "36-Chloe-Signature-EDP.jpg",
                    ProductId = 36,
                    IsDefault = true,
                    SortOrder = 36
                },
                new ProductImage()
                {
                    Id = 37,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "37-Chloe-Love-Story-EDP.jpg",
                    ProductId = 37,
                    IsDefault = true,
                    SortOrder = 37
                },
                new ProductImage()
                {
                    Id = 38,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "38-[NEW]-Paco-Rabanne-1-Million-Parfum-EDP-For-Men-2020.jpg",
                    ProductId = 38,
                    IsDefault = true,
                    SortOrder = 38
                },
                new ProductImage()
                {
                    Id = 39,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "39-Carolina-Herrera-Bad-Boy-EDT.jpg",
                    ProductId = 39,
                    IsDefault = true,
                    SortOrder = 39
                },
                new ProductImage()
                {
                    Id = 40,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "40-[NEW]-Jean-Paul-Gautier-Le-Male-Le-Parfum-EDP.jpg",
                    ProductId = 40,
                    IsDefault = true,
                    SortOrder = 40
                },
                //Sản phẩm được yêu thích
                new ProductImage()
                {
                    Id = 41,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "41-Coach-Flora- EDP.jpg",
                    ProductId = 41,
                    IsDefault = true,
                    SortOrder = 41
                },
                new ProductImage()
                {
                    Id = 42,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "42-Coach-Men-EDT.jpg",
                    ProductId = 42,
                    IsDefault = true,
                    SortOrder = 42
                },
                new ProductImage()
                {
                    Id = 43,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "43-Coach-Men-Platinum-EDP.jpg",
                    ProductId = 43,
                    IsDefault = true,
                    SortOrder = 43
                },
                new ProductImage()
                {
                    Id = 44,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "44-Coach-Men-Platinum-EDP.jpg",
                    ProductId = 44,
                    IsDefault = true,
                    SortOrder = 44
                },
                new ProductImage()
                {
                    Id = 45,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "45-Coach-New-York-Floral-Blush-EDP.jpg",
                    ProductId = 45,
                    IsDefault = true,
                    SortOrder = 45
                },
                new ProductImage()
                {
                    Id = 46,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "46-Gift-Set-Coach-Dreams.jpg",
                    ProductId = 46,
                    IsDefault = true,
                    SortOrder = 46
                },
                new ProductImage()
                {
                    Id = 47,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "47-Holiday-Gift-Set-Coach-Dreams-EDP.jpg",
                    ProductId = 47,
                    IsDefault = true,
                    SortOrder = 47
                },
                new ProductImage()
                {
                    Id = 48,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "48-Gift-Set-Coach-Men-Blue-EDT.jpg",
                    ProductId = 48,
                    IsDefault = true,
                    SortOrder = 48
                },
                new ProductImage()
                {
                    Id = 49,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "49-Gift-Set-Coach-Men-Platinum-EDP.jpg",
                    ProductId = 49,
                    IsDefault = true,
                    SortOrder = 49
                },
                new ProductImage()
                {
                    Id = 50,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "50-Paco-Rabanne-1-Million-Lucky-EDT-(For Men).jpg",
                    ProductId = 50,
                    IsDefault = true,
                    SortOrder = 50
                },
                // Sản phẩm khuyến mại
                new ProductImage()
                {
                    Id = 51,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "51-[NEW]-Gift-Set-Jean-Paul-Gaultier-La-Belle-Le-Parfum-EDP.jpg",
                    ProductId = 51,
                    IsDefault = true,
                    SortOrder = 51
                },
                new ProductImage()
                {
                    Id = 52,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "52-Gift-Set-Jimmy-Choo-Urban-Hero-EDP.jpg",
                    ProductId = 52,
                    IsDefault = true,
                    SortOrder = 52
                },
                new ProductImage()
                {
                    Id = 53,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "53-Gift-Set-Carolina-Herrera-Bad-Boy-EDT.jpg",
                    ProductId = 53,
                    IsDefault = true,
                    SortOrder = 53
                },
                new ProductImage()
                {
                    Id = 54,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "54-Gift-Set-Montblanc-Legend-EDP.jpg",
                    ProductId = 54,
                    IsDefault = true,
                    SortOrder = 54
                },
                new ProductImage()
                {
                    Id = 55,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "55-Gift-Set-Carolina-Herrera-212-VIP-Men-EDT.jpg",
                    ProductId = 55,
                    IsDefault = true,
                    SortOrder = 55
                },
                new ProductImage()
                {
                    Id = 56,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "56-Gift-Set-Coach-Dreams-EDP.jpg",
                    ProductId = 56,
                    IsDefault = true,
                    SortOrder = 56
                },
                new ProductImage()
                {
                    Id = 57,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "57-Gift-Set-Coach-Dreams-EDP.jpg",
                    ProductId = 57,
                    IsDefault = true,
                    SortOrder = 57
                },
                new ProductImage()
                {
                    Id = 58,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "58-Gift-Set-Mercedes-Benz-Man-Intense-EDT.jpg",
                    ProductId = 58,
                    IsDefault = true,
                    SortOrder = 58
                },
                new ProductImage()
                {
                    Id = 59,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "59-Gift-Set-Lanvin-A-Girl-In-Capri-EDT.jpg",
                    ProductId = 59,
                    IsDefault = true,
                    SortOrder = 59
                },
                new ProductImage()
                {
                    Id = 60,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "60-Gift-Set-Paco-Rabanne-1-Million-EDT.jpg",
                    ProductId = 60,
                    IsDefault = true,
                    SortOrder = 60
                },
                //Bộ quà tặng cao cấp
                new ProductImage()
                {
                    Id = 61,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "61-Dolce&Gabbana-The-Only-One-EDP-Intense.jpg",
                    ProductId = 61,
                    IsDefault = true,
                    SortOrder = 61
                },
                new ProductImage()
                {
                    Id = 62,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "62-Dolce&Gabbana-The-One-For-Men-Intense-EDP.jpg",
                    ProductId = 62,
                    IsDefault = true,
                    SortOrder = 62
                },
                new ProductImage()
                {
                    Id = 63,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "63-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP.jpg",
                    ProductId = 63,
                    IsDefault = true,
                    SortOrder = 63
                },
                new ProductImage()
                {
                    Id = 64,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "64-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP.jpg",
                    ProductId = 64,
                    IsDefault = true,
                    SortOrder = 64
                },
                new ProductImage()
                {
                    Id = 65,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "65-Dolce&Gabbana-Light-Blue-Pour-Homme-Love-is-Love-EDT.jpg",
                    ProductId = 65,
                    IsDefault = true,
                    SortOrder = 65
                },
                new ProductImage()
                {
                    Id = 66,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "66-Dolce&Gabbana-Light-Blue-Love-Is-Love-EDT.jpg",
                    ProductId = 66,
                    IsDefault = true,
                    SortOrder = 66
                },
                new ProductImage()
                {
                    Id = 67,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "67-Dolce&Gabbana-The-Only-One-2-EDP.jpg",
                    ProductId = 67,
                    IsDefault = true,
                    SortOrder = 67
                },
                new ProductImage()
                {
                    Id = 68,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "68-Dolce&Gabbana-The-One-For-Men-EDP.jpg",
                    ProductId = 68,
                    IsDefault = true,
                    SortOrder = 68
                },
                new ProductImage()
                {
                    Id = 69,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "69-Dolce&Gabbana-Combo-The-Only-One-EDP-Intense-The-One-For-Men-Intense-EDP.jpg",
                    ProductId = 69,
                    IsDefault = true,
                    SortOrder = 69
                },
                new ProductImage()
                {
                    Id = 70,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "70-Dolce&Gabbana-Combo-Light-Blue-Intense-EDP-Light-Blue-Pour-Homme-Intense-EDP.jpg",
                    ProductId = 70,
                    IsDefault = true,
                    SortOrder = 70
                },
                // Burberry
                new ProductImage()
                {
                    Id = 71,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "71-Burberry-Her-EDP.jpg",
                    ProductId = 71,
                    IsDefault = true,
                    SortOrder = 71
                },
                new ProductImage()
                {
                    Id = 72,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "72.Burberry-Mr.Burberry-Element-EDT.jpg",
                    ProductId = 72,
                    IsDefault = true,
                    SortOrder = 72
                },
                new ProductImage()
                {
                    Id = 73,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "73-Burberry-My-Burberry-Black-EDP.jpg",
                    ProductId = 73,
                    IsDefault = true,
                    SortOrder = 73
                },
                new ProductImage()
                {
                    Id = 74,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "74-Burberry-Mr. Burberry-EDP.jpg",
                    ProductId = 74,
                    IsDefault = true,
                    SortOrder = 74
                },
                new ProductImage()
                {
                    Id = 75,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "75-Burberry-Her-London-Dream-EDP.jpg",
                    ProductId = 75,
                    IsDefault = true,
                    SortOrder = 75
                },
                new ProductImage()
                {
                    Id = 76,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "76-Burberry-My-Burberry-Blush-EDP.jpg",
                    ProductId = 76,
                    IsDefault = true,
                    SortOrder = 76
                },
                new ProductImage()
                {
                    Id = 77,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "77-Burberry-Combo-My-Burberry-Black-EDP-Mr.Burberry-EDP.jpg",
                    ProductId = 77,
                    IsDefault = true,
                    SortOrder = 77
                },
                new ProductImage()
                {
                    Id = 78,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg",
                    ProductId = 78,
                    IsDefault = true,
                    SortOrder = 78
                },
                new ProductImage()
                {
                    Id = 79,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg",
                    ProductId = 79,
                    IsDefault = true,
                    SortOrder = 79
                },
                new ProductImage()
                {
                    Id = 80,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg",
                    ProductId = 80,
                    IsDefault = true,
                    SortOrder = 80
                },
                // Coach
                new ProductImage()
                {
                    Id = 81,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "81-Coach-Man-Blue.jpg",
                    ProductId = 81,
                    IsDefault = true,
                    SortOrder = 81
                },
                new ProductImage()
                {
                    Id = 82,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "82-Coach-Dreams-EDP.jpg",
                    ProductId = 82,
                    IsDefault = true,
                    SortOrder = 82
                },
                new ProductImage()
                {
                    Id = 83,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "83-Coach-Floral-Edp.jpg",
                    ProductId = 83,
                    IsDefault = true,
                    SortOrder = 83
                },
                new ProductImage()
                {
                    Id = 84,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "84-Coach-new-york-edp.jpg",
                    ProductId = 84,
                    IsDefault = true,
                    SortOrder = 84
                },
                new ProductImage()
                {
                    Id = 85,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "85-COACH-Men-EDT.jpg",
                    ProductId = 85,
                    IsDefault = true,
                    SortOrder = 85
                },
                new ProductImage()
                {
                    Id = 86,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "86-Coach-Men-Platinum-Edp.jpg",
                    ProductId = 86,
                    IsDefault = true,
                    SortOrder = 86
                },
                new ProductImage()
                {
                    Id = 87,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "87-Coach-Floral-Blush-EDP.jpg",
                    ProductId = 87,
                    IsDefault = true,
                    SortOrder = 87
                },
                new ProductImage()
                {
                    Id = 88,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "88-Coach-Dreams-EDP-Body-Lotion.jpg",
                    ProductId = 88,
                    IsDefault = true,
                    SortOrder = 88
                },
                new ProductImage()
                {
                    Id = 89,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "89-coach-dream.jpg",
                    ProductId = 89,
                    IsDefault = true,
                    SortOrder = 89
                },
                new ProductImage()
                {
                    Id = 90,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "90-Coach-Men-blue.jpg",
                    ProductId = 90,
                    IsDefault = true,
                    SortOrder = 90
                },
                // Montblanc
                new ProductImage()
                {
                    Id = 91,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "91-Montblanc-Explorer-EDP.jpg",
                    ProductId = 91,
                    IsDefault = true,
                    SortOrder = 91
                },
                new ProductImage()
                {
                    Id = 92,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "92-Montblanc-Signature-EDP.jpg",
                    ProductId = 92,
                    IsDefault = true,
                    SortOrder = 92
                },
                new ProductImage()
                {
                    Id = 93,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "93-Montblanc-Legend-EDP.jpg",
                    ProductId = 93,
                    IsDefault = true,
                    SortOrder = 93
                },
                new ProductImage()
                {
                    Id = 94,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "94-Montblanc-Legend-Night-EDP.jpg",
                    ProductId = 94,
                    IsDefault = true,
                    SortOrder = 94
                },
                new ProductImage()
                {
                    Id = 95,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "95-Montblanc-Bộ-Nước-Hoa-Mini.jpg",
                    ProductId = 95,
                    IsDefault = true,
                    SortOrder = 95
                },
                new ProductImage()
                {
                    Id = 96,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "96-Montblanc-Legend-For-Men-EDT.jpg",
                    ProductId = 96,
                    IsDefault = true,
                    SortOrder = 96
                },
                new ProductImage()
                {
                    Id = 97,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "97-Montblanc-Legend-Spirit-EDT.jpg",
                    ProductId = 97,
                    IsDefault = true,
                    SortOrder = 97
                },
                new ProductImage()
                {
                    Id = 98,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "98-Montblanc-Lady-Emblem-Elixir-EDP.jpg",
                    ProductId = 98,
                    IsDefault = true,
                    SortOrder = 98
                },
                new ProductImage()
                {
                    Id = 99,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "99-montblanc-emblem-edp.jpg",
                    ProductId = 99,
                    IsDefault = true,
                    SortOrder = 99
                },
                new ProductImage()
                {
                    Id = 100,
                    Caption = "test",
                    DateCreated = DateTime.Now,
                    FileSize = 12345,
                    ImagePath = "100-Montblanc-Emblem-EDT.jpg",
                    ProductId = 100,
                    IsDefault = true,
                    SortOrder = 100
                }

                );
            modelBuilder.Entity<Banner>().HasData(
                new Banner()
                {
                    Id = 1,
                    Name = "test",
                    DateCreated = DateTime.Now,
                    Description = "Test Des",
                    FileSize = 12345,
                    ImagePath = "123123.jpg",
                    Status = Status.Active,
                    IsDefault = true,
                    SortOrder = 1
                });

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 1 },
                new ProductInCategory() { ProductId = 3, CategoryId = 1 },
                new ProductInCategory() { ProductId = 4, CategoryId = 1 },
                new ProductInCategory() { ProductId = 5, CategoryId = 1 },
                new ProductInCategory() { ProductId = 6, CategoryId = 1 },
                new ProductInCategory() { ProductId = 7, CategoryId = 1 },
                new ProductInCategory() { ProductId = 8, CategoryId = 1 },
                new ProductInCategory() { ProductId = 9, CategoryId = 1 },
                new ProductInCategory() { ProductId = 10, CategoryId = 1 },
                new ProductInCategory() { ProductId = 11, CategoryId = 2 },
                new ProductInCategory() { ProductId = 12, CategoryId = 2 },
                new ProductInCategory() { ProductId = 13, CategoryId = 2 },
                new ProductInCategory() { ProductId = 14, CategoryId = 2 },
                new ProductInCategory() { ProductId = 15, CategoryId = 2 },
                new ProductInCategory() { ProductId = 16, CategoryId = 2 },
                new ProductInCategory() { ProductId = 17, CategoryId = 2 },
                new ProductInCategory() { ProductId = 18, CategoryId = 2 },
                new ProductInCategory() { ProductId = 19, CategoryId = 2 },
                new ProductInCategory() { ProductId = 20, CategoryId = 2 },
                new ProductInCategory() { ProductId = 21, CategoryId = 3 },
                new ProductInCategory() { ProductId = 22, CategoryId = 3 },
                new ProductInCategory() { ProductId = 23, CategoryId = 3 },
                new ProductInCategory() { ProductId = 24, CategoryId = 3 },
                new ProductInCategory() { ProductId = 25, CategoryId = 3 },
                new ProductInCategory() { ProductId = 26, CategoryId = 3 },
                new ProductInCategory() { ProductId = 27, CategoryId = 3 },
                new ProductInCategory() { ProductId = 28, CategoryId = 3 },
                new ProductInCategory() { ProductId = 29, CategoryId = 3 },
                new ProductInCategory() { ProductId = 30, CategoryId = 3 },
                new ProductInCategory() { ProductId = 31, CategoryId = 4 },
                new ProductInCategory() { ProductId = 32, CategoryId = 4 },
                new ProductInCategory() { ProductId = 33, CategoryId = 4 },
                new ProductInCategory() { ProductId = 34, CategoryId = 4 },
                new ProductInCategory() { ProductId = 35, CategoryId = 4 },
                new ProductInCategory() { ProductId = 36, CategoryId = 4 },
                new ProductInCategory() { ProductId = 37, CategoryId = 4 },
                new ProductInCategory() { ProductId = 38, CategoryId = 4 },
                new ProductInCategory() { ProductId = 39, CategoryId = 4 },
                new ProductInCategory() { ProductId = 40, CategoryId = 4 },
                new ProductInCategory() { ProductId = 41, CategoryId = 5 },
                new ProductInCategory() { ProductId = 42, CategoryId = 5 },
                new ProductInCategory() { ProductId = 43, CategoryId = 5 },
                new ProductInCategory() { ProductId = 44, CategoryId = 5 },
                new ProductInCategory() { ProductId = 45, CategoryId = 5 },
                new ProductInCategory() { ProductId = 46, CategoryId = 5 },
                new ProductInCategory() { ProductId = 47, CategoryId = 5 },
                new ProductInCategory() { ProductId = 48, CategoryId = 5 },
                new ProductInCategory() { ProductId = 49, CategoryId = 5 },
                new ProductInCategory() { ProductId = 50, CategoryId = 5 },
                new ProductInCategory() { ProductId = 51, CategoryId = 6 },
                new ProductInCategory() { ProductId = 52, CategoryId = 6 },
                new ProductInCategory() { ProductId = 53, CategoryId = 6 },
                new ProductInCategory() { ProductId = 54, CategoryId = 6 },
                new ProductInCategory() { ProductId = 55, CategoryId = 6 },
                new ProductInCategory() { ProductId = 56, CategoryId = 6 },
                new ProductInCategory() { ProductId = 57, CategoryId = 6 },
                new ProductInCategory() { ProductId = 58, CategoryId = 6 },
                new ProductInCategory() { ProductId = 59, CategoryId = 6 },
                new ProductInCategory() { ProductId = 60, CategoryId = 6 },
                new ProductInCategory() { ProductId = 61, CategoryId = 7 },
                new ProductInCategory() { ProductId = 62, CategoryId = 7 },
                new ProductInCategory() { ProductId = 63, CategoryId = 7 },
                new ProductInCategory() { ProductId = 64, CategoryId = 7 },
                new ProductInCategory() { ProductId = 65, CategoryId = 7 },
                new ProductInCategory() { ProductId = 66, CategoryId = 7 },
                new ProductInCategory() { ProductId = 67, CategoryId = 7 },
                new ProductInCategory() { ProductId = 68, CategoryId = 7 },
                new ProductInCategory() { ProductId = 69, CategoryId = 7 },
                new ProductInCategory() { ProductId = 70, CategoryId = 7 },
                new ProductInCategory() { ProductId = 71, CategoryId = 8 },
                new ProductInCategory() { ProductId = 72, CategoryId = 8 },
                new ProductInCategory() { ProductId = 73, CategoryId = 8 },
                new ProductInCategory() { ProductId = 74, CategoryId = 8 },
                new ProductInCategory() { ProductId = 75, CategoryId = 8 },
                new ProductInCategory() { ProductId = 76, CategoryId = 8 },
                new ProductInCategory() { ProductId = 77, CategoryId = 8 },
                new ProductInCategory() { ProductId = 78, CategoryId = 8 },
                new ProductInCategory() { ProductId = 79, CategoryId = 8 },
                new ProductInCategory() { ProductId = 80, CategoryId = 8 },
                new ProductInCategory() { ProductId = 81, CategoryId = 9 },
                new ProductInCategory() { ProductId = 82, CategoryId = 9 },
                new ProductInCategory() { ProductId = 83, CategoryId = 9 },
                new ProductInCategory() { ProductId = 84, CategoryId = 9 },
                new ProductInCategory() { ProductId = 85, CategoryId = 9 },
                new ProductInCategory() { ProductId = 86, CategoryId = 9 },
                new ProductInCategory() { ProductId = 87, CategoryId = 9 },
                new ProductInCategory() { ProductId = 88, CategoryId = 9 },
                new ProductInCategory() { ProductId = 89, CategoryId = 9 },
                new ProductInCategory() { ProductId = 90, CategoryId = 9 },
                new ProductInCategory() { ProductId = 91, CategoryId = 10 },
                new ProductInCategory() { ProductId = 92, CategoryId = 10 },
                new ProductInCategory() { ProductId = 93, CategoryId = 10 },
                new ProductInCategory() { ProductId = 94, CategoryId = 10 },
                new ProductInCategory() { ProductId = 95, CategoryId = 10 },
                new ProductInCategory() { ProductId = 96, CategoryId = 10 },
                new ProductInCategory() { ProductId = 97, CategoryId = 10 },
                new ProductInCategory() { ProductId = 98, CategoryId = 10 },
                new ProductInCategory() { ProductId = 99, CategoryId = 10 },
                new ProductInCategory() { ProductId = 100, CategoryId = 10 }
            );

            const string ADMIN_ID = "1C856746-F8AA-4026-B854-F18DA9787CF3";
            const string HAIANH_ID = "D8B63B91-C360-4E3D-9B3A-2DCE31F00CC4";
            const string PHUONGID = "33674F31-0BD2-43CD-9090-3F0D4BAB1C58";
            const string TESTID = "94C14234-D9B7-4A8B-91C8-68B53378FE6B";
            const string ROLE_ID = "BD5B83D2-5C75-4F96-A63F-1ECA425BDFE5";
            const string ROLE_ID2 = "EFEBFD93-B27D-4C91-8A71-74FD71944893";

            const string clientID = "1D37E388-3C9D-490B-A0D1-93F20C4292B5";
            const string TEST1_ID = "599fab7f-0c58-412c-8de5-93cc9424c0fe";
            const string TEST2_ID = "c12d5773-d956-4b10-a30e-ac80f459d411";
            const string TEST3_ID = "48347449-050f-4630-946a-cf41446d89c8";
            const string TEST4_ID = "0199e987-8be3-4b1a-876d-a638d24cc910";
            const string TEST5_ID = "ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7";
            const string TEST6_ID = "01940aef-917e-4f1f-8c06-38459dbcaa0c";
            const string TEST7_ID = "79a378f7-34c1-4403-88bb-791d585df9aa";
            const string TEST8_ID = "e2123170-2dbc-4e43-9477-d0be0f352d21";
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
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff role"
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
                    PasswordHash = hasher.HashPassword(null, "Adolphin@123")
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
                    PasswordHash = hasher.HashPassword(null, "Adolphin@123")
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
                    RoleId = new Guid(ROLE_ID)
                },
                new IdentityUserRole<Guid>()
                {
                    UserId = new Guid(PHUONGID),
                    RoleId = new Guid(ROLE_ID2)
                });
            modelBuilder.Entity<Order>().HasData(
                // Client 1
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 1,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.Success,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1200000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 2,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1400000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 3,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 500000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 4,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2400000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 5,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 05, 26, 11, 19, 12, DateTimeKind.Utc),
                    Price = 2200000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 6,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2200000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 7,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1200000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 8,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 2800000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 9,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 1700000
                },
                new Order()
                {
                    ClientId = new Guid(clientID),
                    Id = 10,
                    ShipEmail = "tiendinhdev99@gmail.com",
                    ShipName = "Voi be nho",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 1600000
                },
                // Client 2
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 11,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.Success,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2030000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 12,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2150000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 13,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 3100000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 14,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2670000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 15,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2490000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 16,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2150000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 17,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2910000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 18,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 7140000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 19,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 2420000
                },
                new Order()
                {
                    ClientId = new Guid(TESTID),
                    Id = 20,
                    ShipEmail = "test1234@gmail.com",
                    ShipName = "Do Tien Dinh",
                    ShipPhoneNumber = "0984869201",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 1930000
                },
                // Client 3
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 21,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 3000000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 22,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2360000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 23,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2050000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 24,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2150000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 25,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1920000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 26,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1920000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 27,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2150000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 28,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 1800000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 29,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 2120000
                },
                new Order()
                {
                    ClientId = new Guid(TEST1_ID),
                    Id = 30,
                    ShipEmail = "tranphuong@gmail.com",
                    ShipName = "Tran Thu Phuong",
                    ShipPhoneNumber = "0378709602",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 2190000
                },
                // Client 4
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 31,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.Success,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2150000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 32,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1820000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 33,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 2040000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 34,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2140000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 35,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1920000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 36,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1920000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 37,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1920000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 38,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 2650000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 39,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 2050000
                },
                new Order()
                {
                    ClientId = new Guid(TEST2_ID),
                    Id = 40,
                    ShipEmail = "haianh@gmail.com",
                    ShipName = "Le Hai Anh",
                    ShipPhoneNumber = "0358963245",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Chương Mỹ - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1980000
                },
                // Client 5
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 41,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.Success,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 990000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 42,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1470000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 43,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 1260000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 44,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1785000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 45,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 990000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 46,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2520000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 47,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2520000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 48,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1890000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 49,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 1645000
                },
                new Order()
                {
                    ClientId = new Guid(TEST3_ID),
                    Id = 50,
                    ShipEmail = "vananh@gmail.com",
                    ShipName = "Tran Van Anh",
                    ShipPhoneNumber = "0323456743",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Đan Phượng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 1387500
                },
                // Client 6
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 51,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.Success,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1387500
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 52,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2380000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 53,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 2850000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 54,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2350000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 55,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2450000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 56,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2950000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 57,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2800000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 58,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 2200000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 59,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 2200000
                },
                new Order()
                {
                    ClientId = new Guid(TEST4_ID),
                    Id = 60,
                    ShipEmail = "hoangchung@gmail.com",
                    ShipName = "Hoàng Chung",
                    ShipPhoneNumber = "0963258741",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Hoằng Hóa - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 2450000
                },
                // Client 7
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 61,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.Success,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2720000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 62,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2220000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 63,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 2120000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 64,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1970000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 65,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1910000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 66,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2040000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 67,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 2590000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 68,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 2120000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 69,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 6720000
                },
                new Order()
                {
                    ClientId = new Guid(TEST5_ID),
                    Id = 70,
                    ShipEmail = "minhanh@gmail.com",
                    ShipName = "Minh Anh",
                    ShipPhoneNumber = "0978563732",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Thọ Xuân - Thanh Hóa",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 5060000
                },
                // Client 8
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 71,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.Success,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2030000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 72,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1980000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 73,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 4160000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 74,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2190000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 75,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2030000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 76,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2860000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 77,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 7750000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 78,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 2780000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 79,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2780000
                },
                new Order()
                {
                    ClientId = new Guid(TEST6_ID),
                    Id = 80,
                    ShipEmail = "Congphuong@gmail.com",
                    ShipName = "Công Phượng",
                    ShipPhoneNumber = "0987456321",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phúc Hòa - Tân Yên - Bắc Giang",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 2780000
                },
                // Client 9
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 81,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.Success,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1550000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 82,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1300000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 83,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 1100000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 84,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 2550000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 85,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2100000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 86,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 1800000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 87,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1100000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 88,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 19, 12, 51, 32, DateTimeKind.Utc),
                    Price = 800000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 89,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 2800000
                },
                new Order()
                {
                    ClientId = new Guid(TEST7_ID),
                    Id = 90,
                    ShipEmail = "xuantruong@gmail.com",
                    ShipName = "Xuân Trường",
                    ShipPhoneNumber = "0987546666",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 2100000
                },
                // Client 10
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 91,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.Success,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1250000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 92,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.Canceled,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 24, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1380000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 93,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 03, 19, 12, 14, 21, DateTimeKind.Utc),
                    Price = 1700000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 94,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 05, 19, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1200000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 95,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 950000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 96,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 09, 12, 20, DateTimeKind.Utc),
                    Price = 2200000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 97,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 01, 07, 41, 12, DateTimeKind.Utc),
                    Price = 1180000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 98,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 06, 02, 05, 42, 18, DateTimeKind.Utc),
                    Price = 1380000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 99,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 10, 19, 20, DateTimeKind.Utc),
                    Price = 1350000
                },
                new Order()
                {
                    ClientId = new Guid(TEST8_ID),
                    Id = 100,
                    ShipEmail = "dinhtrong@gmail.com",
                    ShipName = "Đình Trọng",
                    ShipPhoneNumber = "0985638888",
                    Status = OrderStatus.InProgress,
                    ShipAddress = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    OrderDate = new DateTime(2021, 04, 21, 12, 39, 26, DateTimeKind.Utc),
                    Price = 1360000
                }

                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail()
                {
                    OrderId = 1,
                    ProductId = 1,
                    Quantity = 1,
                    Price = 1200000
                },
                new OrderDetail()
                {
                    OrderId = 2,
                    ProductId = 2,
                    Quantity = 1,
                    Price = 1400000
                },
                new OrderDetail()
                {
                    OrderId = 3,
                    ProductId = 3,
                    Quantity = 1,
                    Price = 500000
                },
                new OrderDetail()
                {
                    OrderId = 4,
                    ProductId = 4,
                    Quantity = 1,
                    Price = 2400000
                },
                new OrderDetail()
                {
                    OrderId = 5,
                    ProductId = 5,
                    Quantity = 1,
                    Price = 2200000
                },
                new OrderDetail()
                {
                    OrderId = 6,
                    ProductId = 6,
                    Quantity = 1,
                    Price = 2200000
                },
                new OrderDetail()
                {
                    OrderId = 7,
                    ProductId = 7,
                    Quantity = 1,
                    Price = 1200000
                },
                new OrderDetail()
                {
                    OrderId = 8,
                    ProductId = 8,
                    Quantity = 1,
                    Price = 2800000
                },
                new OrderDetail()
                {
                    OrderId = 9,
                    ProductId = 9,
                    Quantity = 1,
                    Price = 1700000
                },
                new OrderDetail()
                {
                    OrderId = 10,
                    ProductId = 10,
                    Quantity = 1,
                    Price = 1600000
                },
                new OrderDetail()
                {
                    OrderId = 11,
                    ProductId = 11,
                    Quantity = 1,
                    Price = 2030000
                },
                new OrderDetail()
                {
                    OrderId = 12,
                    ProductId = 12,
                    Quantity = 1,
                    Price = 2150000
                },
                new OrderDetail()
                {
                    OrderId = 13,
                    ProductId = 13,
                    Quantity = 1,
                    Price = 3100000
                },
                new OrderDetail()
                {
                    OrderId = 14,
                    ProductId = 14,
                    Quantity = 1,
                    Price = 2670000
                },
                new OrderDetail()
                {
                    OrderId = 15,
                    ProductId = 15,
                    Quantity = 1,
                    Price = 2490000
                },
                new OrderDetail()
                {
                    OrderId = 16,
                    ProductId = 16,
                    Quantity = 1,
                    Price = 2150000
                },
                new OrderDetail()
                {
                    OrderId = 17,
                    ProductId = 17,
                    Quantity = 1,
                    Price = 2910000
                },
                new OrderDetail()
                {
                    OrderId = 18,
                    ProductId = 18,
                    Quantity = 1,
                    Price = 7140000
                },
                new OrderDetail()
                {
                    OrderId = 19,
                    ProductId = 19,
                    Quantity = 1,
                    Price = 2420000
                },
                new OrderDetail()
                {
                    OrderId = 20,
                    ProductId = 20,
                    Quantity = 1,
                    Price = 1930000
                },
                new OrderDetail()
                {
                    OrderId = 21,
                    ProductId = 21,
                    Quantity = 1,
                    Price = 3000000
                },
                new OrderDetail()
                {
                    OrderId = 22,
                    ProductId = 22,
                    Quantity = 1,
                    Price = 2360000
                },
                new OrderDetail()
                {
                    OrderId = 23,
                    ProductId = 23,
                    Quantity = 2,
                    Price = 4100000
                },
                new OrderDetail()
                {
                    OrderId = 24,
                    ProductId = 24,
                    Quantity = 3,
                    Price = 6450000
                },
                new OrderDetail()
                {
                    OrderId = 25,
                    ProductId = 25,
                    Quantity = 1,
                    Price = 1920000
                },
                new OrderDetail()
                {
                    OrderId = 26,
                    ProductId = 26,
                    Quantity = 1,
                    Price = 1920000
                },
                new OrderDetail()
                {
                    OrderId = 27,
                    ProductId = 27,
                    Quantity = 1,
                    Price = 2150000
                },
                new OrderDetail()
                {
                    OrderId = 28,
                    ProductId = 28,
                    Quantity = 2,
                    Price = 3600000
                },
                new OrderDetail()
                {
                    OrderId = 29,
                    ProductId = 29,
                    Quantity = 1,
                    Price = 2120000
                },
                new OrderDetail()
                {
                    OrderId = 30,
                    ProductId = 30,
                    Quantity = 1,
                    Price = 2190000
                },
                new OrderDetail()
                {
                    OrderId = 31,
                    ProductId = 31,
                    Quantity = 1,
                    Price = 2150000
                },
                new OrderDetail()
                {
                    OrderId = 32,
                    ProductId = 32,
                    Quantity = 1,
                    Price = 1820000
                },
                new OrderDetail()
                {
                    OrderId = 33,
                    ProductId = 33,
                    Quantity = 1,
                    Price = 2040000
                },
                new OrderDetail()
                {
                    OrderId = 34,
                    ProductId = 34,
                    Quantity = 1,
                    Price = 2140000
                },
                new OrderDetail()
                {
                    OrderId = 35,
                    ProductId = 35,
                    Quantity = 1,
                    Price = 1920000
                },
                new OrderDetail()
                {
                    OrderId = 36,
                    ProductId = 36,
                    Quantity = 1,
                    Price = 1920000
                },
                new OrderDetail()
                {
                    OrderId = 37,
                    ProductId = 37,
                    Quantity = 1,
                    Price = 1920000
                },
                new OrderDetail()
                {
                    OrderId = 38,
                    ProductId = 38,
                    Quantity = 1,
                    Price = 2650000
                },
                new OrderDetail()
                {
                    OrderId = 39,
                    ProductId = 39,
                    Quantity = 1,
                    Price = 2050000
                },
                new OrderDetail()
                {
                    OrderId = 40,
                    ProductId = 40,
                    Quantity = 1,
                    Price = 1980000
                },
                new OrderDetail()
                {
                    OrderId = 41,
                    ProductId = 41,
                    Quantity = 1,
                    Price = 990000
                },
                new OrderDetail()
                {
                    OrderId = 42,
                    ProductId = 42,
                    Quantity = 1,
                    Price = 1470000
                },
                new OrderDetail()
                {
                    OrderId = 43,
                    ProductId = 43,
                    Quantity = 1,
                    Price = 1260000
                },
                new OrderDetail()
                {
                    OrderId = 44,
                    ProductId = 44,
                    Quantity = 1,
                    Price = 1785000
                },
                new OrderDetail()
                {
                    OrderId = 45,
                    ProductId = 45,
                    Quantity = 1,
                    Price = 990000
                },
                new OrderDetail()
                {
                    OrderId = 46,
                    ProductId = 46,
                    Quantity = 1,
                    Price = 2520000
                },
                new OrderDetail()
                {
                    OrderId = 47,
                    ProductId = 47,
                    Quantity = 1,
                    Price = 2520000
                },
                new OrderDetail()
                {
                    OrderId = 48,
                    ProductId = 48,
                    Quantity = 1,
                    Price = 1890000
                },
                new OrderDetail()
                {
                    OrderId = 49,
                    ProductId = 49,
                    Quantity = 1,
                    Price = 1645000
                },
                new OrderDetail()
                {
                    OrderId = 50,
                    ProductId = 50,
                    Quantity = 1,
                    Price = 1387500
                },
                new OrderDetail()
                {
                    OrderId = 51,
                    ProductId = 51,
                    Quantity = 1,
                    Price = 1387500
                },
                new OrderDetail()
                {
                    OrderId = 52,
                    ProductId = 52,
                    Quantity = 1,
                    Price = 2380000
                },
                new OrderDetail()
                {
                    OrderId = 53,
                    ProductId = 53,
                    Quantity = 1,
                    Price = 2850000
                },
                new OrderDetail()
                {
                    OrderId = 54,
                    ProductId = 54,
                    Quantity = 1,
                    Price = 2350000
                },
                new OrderDetail()
                {
                    OrderId = 55,
                    ProductId = 55,
                    Quantity = 1,
                    Price = 2450000
                },
                new OrderDetail()
                {
                    OrderId = 56,
                    ProductId = 56,
                    Quantity = 1,
                    Price = 2950000
                },
                new OrderDetail()
                {
                    OrderId = 57,
                    ProductId = 57,
                    Quantity = 1,
                    Price = 2800000
                },
                new OrderDetail()
                {
                    OrderId = 58,
                    ProductId = 58,
                    Quantity = 1,
                    Price = 2200000
                },
                new OrderDetail()
                {
                    OrderId = 59,
                    ProductId = 59,
                    Quantity = 1,
                    Price = 2200000
                },
                new OrderDetail()
                {
                    OrderId = 60,
                    ProductId = 60,
                    Quantity = 1,
                    Price = 2450000
                },
                new OrderDetail()
                {
                    OrderId = 61,
                    ProductId = 61,
                    Quantity = 1,
                    Price = 2720000
                },
                new OrderDetail()
                {
                    OrderId = 62,
                    ProductId = 62,
                    Quantity = 1,
                    Price = 2220000
                },
                new OrderDetail()
                {
                    OrderId = 63,
                    ProductId = 63,
                    Quantity = 1,
                    Price = 2120000
                },
                new OrderDetail()
                {
                    OrderId = 64,
                    ProductId = 64,
                    Quantity = 1,
                    Price = 1970000
                },
                new OrderDetail()
                {
                    OrderId = 65,
                    ProductId = 65,
                    Quantity = 1,
                    Price = 1910000
                },
                new OrderDetail()
                {
                    OrderId = 66,
                    ProductId = 66,
                    Quantity = 1,
                    Price = 2040000
                },
                new OrderDetail()
                {
                    OrderId = 67,
                    ProductId = 67,
                    Quantity = 1,
                    Price = 2590000
                },
                new OrderDetail()
                {
                    OrderId = 68,
                    ProductId = 68,
                    Quantity = 1,
                    Price = 2120000
                },
                new OrderDetail()
                {
                    OrderId = 69,
                    ProductId = 69,
                    Quantity = 1,
                    Price = 6720000
                },
                new OrderDetail()
                {
                    OrderId = 70,
                    ProductId = 70,
                    Quantity = 1,
                    Price = 5060000
                },
                new OrderDetail()
                {
                    OrderId = 71,
                    ProductId = 71,
                    Quantity = 1,
                    Price = 2030000
                },
                new OrderDetail()
                {
                    OrderId = 72,
                    ProductId = 72,
                    Quantity = 1,
                    Price = 1980000
                },
                new OrderDetail()
                {
                    OrderId = 73,
                    ProductId = 73,
                    Quantity = 1,
                    Price = 4160000
                },
                new OrderDetail()
                {
                    OrderId = 74,
                    ProductId = 74,
                    Quantity = 1,
                    Price = 2190000
                },
                new OrderDetail()
                {
                    OrderId = 75,
                    ProductId = 75,
                    Quantity = 1,
                    Price = 2030000
                },
                new OrderDetail()
                {
                    OrderId = 76,
                    ProductId = 76,
                    Quantity = 1,
                    Price = 2860000
                },
                new OrderDetail()
                {
                    OrderId = 77,
                    ProductId = 77,
                    Quantity = 1,
                    Price = 7750000
                },
                new OrderDetail()
                {
                    OrderId = 78,
                    ProductId = 78,
                    Quantity = 1,
                    Price = 2780000
                },
                new OrderDetail()
                {
                    OrderId = 79,
                    ProductId = 79,
                    Quantity = 1,
                    Price = 2780000
                },
                new OrderDetail()
                {
                    OrderId = 80,
                    ProductId = 80,
                    Quantity = 1,
                    Price = 2780000
                },
                new OrderDetail()
                {
                    OrderId = 81,
                    ProductId = 81,
                    Quantity = 1,
                    Price = 1550000
                },
                new OrderDetail()
                {
                    OrderId = 82,
                    ProductId = 82,
                    Quantity = 1,
                    Price = 1300000
                },
                new OrderDetail()
                {
                    OrderId = 83,
                    ProductId = 83,
                    Quantity = 1,
                    Price = 1100000
                },
                new OrderDetail()
                {
                    OrderId = 84,
                    ProductId = 84,
                    Quantity = 1,
                    Price = 2550000
                },
                new OrderDetail()
                {
                    OrderId = 85,
                    ProductId = 85,
                    Quantity = 1,
                    Price = 2550000
                },
                new OrderDetail()
                {
                    OrderId = 86,
                    ProductId = 86,
                    Quantity = 1,
                    Price = 1800000
                },
                new OrderDetail()
                {
                    OrderId = 87,
                    ProductId = 87,
                    Quantity = 1,
                    Price = 1100000
                },
                new OrderDetail()
                {
                    OrderId = 88,
                    ProductId = 88,
                    Quantity = 1,
                    Price = 800000
                },
                new OrderDetail()
                {
                    OrderId = 89,
                    ProductId = 89,
                    Quantity = 1,
                    Price = 2800000
                },
                new OrderDetail()
                {
                    OrderId = 90,
                    ProductId = 90,
                    Quantity = 1,
                    Price = 2100000
                },
                new OrderDetail()
                {
                    OrderId = 91,
                    ProductId = 91,
                    Quantity = 1,
                    Price = 1250000
                },
                new OrderDetail()
                {
                    OrderId = 92,
                    ProductId = 92,
                    Quantity = 1,
                    Price = 1380000
                },
                new OrderDetail()
                {
                    OrderId = 93,
                    ProductId = 93,
                    Quantity = 1,
                    Price = 1700000
                },
                new OrderDetail()
                {
                    OrderId = 94,
                    ProductId = 94,
                    Quantity = 1,
                    Price = 1200000
                },
                new OrderDetail()
                {
                    OrderId = 95,
                    ProductId = 95,
                    Quantity = 1,
                    Price = 950000
                },
                new OrderDetail()
                {
                    OrderId = 96,
                    ProductId = 96,
                    Quantity = 1,
                    Price = 2200000
                },
                new OrderDetail()
                {
                    OrderId = 97,
                    ProductId = 97,
                    Quantity = 1,
                    Price = 1180000
                },
                new OrderDetail()
                {
                    OrderId = 98,
                    ProductId = 98,
                    Quantity = 1,
                    Price = 1380000
                },
                new OrderDetail()
                {
                    OrderId = 99,
                    ProductId = 99,
                    Quantity = 1,
                    Price = 1350000
                },
                new OrderDetail()
                {
                    OrderId = 100,
                    ProductId = 100,
                    Quantity = 1,
                    Price = 1360000
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

            var hasherClient = new PasswordHasher<Client>();
            modelBuilder.Entity<Client>().HasData(
                new Client()
                {
                    Id = new Guid(clientID),
                    Address = "8 Nghách 167 ngõ 521 Trương Định - Hoàng Mai - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(1999, 6, 21),
                    Name = "Voi Bé Nhỏ",
                    PhoneNumber = "0984869201",
                    Status = Status.Active,
                    Email = "tiendinhdev99@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TESTID),
                    Address = "8 Nghách 167 ngõ 521 Trương Định - Hoàng Mai - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(1999, 6, 21),
                    Name = "Do tien dinh",
                    PhoneNumber = "0984869201",
                    Status = Status.Active,
                    Email = "test1234@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST1_ID),
                    Address = "Nguyễn Trãi - Thường Tín - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(2001, 3, 18),
                    Name = "Tran Thu Phuong",
                    PhoneNumber = "0378709602",
                    Status = Status.Active,
                    Email = "tranphuong@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST2_ID),
                    Address = "Chương Mỹ - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Le Hai Anh",
                    PhoneNumber = "0358963245",
                    Status = Status.Active,
                    Email = "haianh@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST3_ID),
                    Address = "Đan Phượng - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Tran Van Anh",
                    PhoneNumber = "0323456743",
                    Status = Status.Active,
                    Email = "vananh@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST4_ID),
                    Address = "Hoằng Hóa - Thanh Hóa",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Hoàng Chung",
                    PhoneNumber = "0963258741",
                    Status = Status.Active,
                    Email = "hoangchung@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST5_ID),
                    Address = "Thọ Xuân - Thanh Hóa",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Minh Anh",
                    PhoneNumber = "0978563732",
                    Status = Status.Active,
                    Email = "minhanh@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST6_ID),
                    Address = "Phúc Hòa - Tân Yên - Bắc Giang",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Công Phượng",
                    PhoneNumber = "0987456321",
                    Status = Status.Active,
                    Email = "congphuong@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST7_ID),
                    Address = "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Xuân Trường",
                    PhoneNumber = "0987546666",
                    Status = Status.Active,
                    Email = "xuantruong@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                },
                new Client()
                {
                    Id = new Guid(TEST8_ID),
                    Address = "Phường Phúc Lợi - Quận Long Biên - Hà Nội",
                    Avatar = "",
                    Dob = new DateTime(2001, 7, 11),
                    Name = "Đình Trọng",
                    PhoneNumber = "0985638888",
                    Status = Status.Active,
                    Email = "dinhtrong@gmail.com",
                    Password = hasherClient.HashPassword(null, "Adolphin@123")
                }

                ); ;

        }
    }
}