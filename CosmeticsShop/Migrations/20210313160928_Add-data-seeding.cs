using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class Adddataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCollection",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "CosmeticsCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmeticsCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCosmeticsCollections",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CosmeticsCollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCosmeticsCollections", x => new { x.ProductId, x.CosmeticsCollectionId });
                    table.ForeignKey(
                        name: "FK_ProductInCosmeticsCollections_CosmeticsCollections_CosmeticsCollectionId",
                        column: x => x.CosmeticsCollectionId,
                        principalTable: "CosmeticsCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCosmeticsCollections_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CosmeticsCollections",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "MAN [EAU DE TOILETTE]" });

            migrationBuilder.InsertData(
                table: "CosmeticsCollections",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "ƯU ĐÃI NƯỚC HOA TRONG THÁNG 7 2020" });

            migrationBuilder.InsertData(
                table: "ProductInCosmeticsCollections",
                columns: new[] { "CosmeticsCollectionId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCosmeticsCollections_CosmeticsCollectionId",
                table: "ProductInCosmeticsCollections",
                column: "CosmeticsCollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInCosmeticsCollections");

            migrationBuilder.DropTable(
                name: "CosmeticsCollections");

            migrationBuilder.AddColumn<bool>(
                name: "IsCollection",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Products",
                type: "bit",
                nullable: true);
        }
    }
}
