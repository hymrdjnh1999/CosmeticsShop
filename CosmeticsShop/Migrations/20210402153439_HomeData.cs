using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsOutstanding",
                table: "Products",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsOutstanding",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsOutstanding",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "51b8f94b-ddbd-463e-9558-20e54c0b17f5");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "8a63b94a-c429-4d92-98c1-8538b620b39c");

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "Image", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 1, null, "https://www.gettyimages.pt/gi-resources/images/Homepage/Hero/PT/PT_hero_42_153645159.jpg", "First Slide", 1, 2, "#" },
                    { 2, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/212HEROES-Desktop_1560x600_40ae22ae-9303-4773-af47-796d63fff29d_1800x.jpg", "Second Slide", 2, 2, "#" },
                    { 3, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/JC-WebBanner-1560x600_1800x.jpg", "Third Slide", 3, 2, "#" },
                    { 4, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/LE_BELLE_LE_MALE_1560x600_7921449a-7a2c-4aba-b1cc-939576de9067_1800x.jpg", "Fourth Slide", 4, 2, "#" },
                    { 5, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/imgpsh_fullsize_anim_8_aa16529c-d632-45c7-89b0-35b1b5c81fee_1800x.jpg?v=1615517435", "Fiveth Slide", 5, 2, "#" },
                    { 6, null, "https://helpx.adobe.com/content/dam/help/en/photoshop/using/convert-color-image-black-white/jcr_content/main-pars/before_and_after/image-before/Landscape-Color.jpg", "Sixth Slide", 6, 2, "#" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22b82b07-eb1c-4a1f-b73f-4f9d2301bb96", "AQAAAAEAACcQAAAAEHaW+gwPtBJp9/QxT+2u5ZT6cSNld90Bwqme6STb1KuUBNuIqdbd0YbhhoHUHkusQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71f9d643-5b1a-4971-a587-c26f0afd8ab7", "AQAAAAEAACcQAAAAEBKZG9kmitgbEbdwQ/HdP4aMcf/7Qv7wtFG8XbSzQlfAFqwtwVQCf0VpuwdbadXtXw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06f78eec-6f9a-42c0-b67c-2b5e79a259a1", "AQAAAAEAACcQAAAAEO17DLOZP9u1PYkqGB/2Dc43Bii314GH7gU2aOo8G2Uz0zV9oUDFUc2oRQVtbJc/6w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.AlterColumn<bool>(
                name: "IsOutstanding",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsOutstanding",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsOutstanding",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "570caf57-342a-4f51-9e09-99dd6ebff9b3");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "81393339-f8a0-4ad4-9fbe-3035f1f17cdf");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecc7ac8b-2ee6-445e-9a8b-1f3aeaf46add", "AQAAAAEAACcQAAAAEPTpF7k+xuuDGnW/qtGw2ds1JpPTameECcR9OUF2FcN0/YkNBkc1CpreW1Gnj7opsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a2430c2-17f9-4216-ab58-bc41408f5c43", "AQAAAAEAACcQAAAAECRsmKtaJFUIg6+Rf9oegjAOrbtc3XHZZ+e67DTD+BPG8Sd7YpzmCrbDElskM0Ix1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb45fbbd-3214-4462-a853-4897def689a2", "AQAAAAEAACcQAAAAEAEg1EK+92A6m95Nhlv3mEt4uasjs5hLrcdussyQi0JnwibsTTq+LG3MAHNTA+yjrA==" });
        }
    }
}
