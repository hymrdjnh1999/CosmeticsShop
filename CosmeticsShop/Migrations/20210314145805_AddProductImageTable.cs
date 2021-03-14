using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "6f432b91-3cad-4f79-87df-6e962e5ad694");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "3de2120f-2992-4c57-9afc-0462e22961e2");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1c134de-419a-419b-8074-68781616a948", "AQAAAAEAACcQAAAAELfIIRzvpGaKAf9ieUak5ynGM3016h1+tZAMqIJ+Iw57BktsIhg3pD8KEkO6SQzRfw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17ea1a88-b5fe-443f-8cc9-c95413952703", "AQAAAAEAACcQAAAAEMYDoKvGrNflaj9mt8ivnbyn7uJJN7Q5/cc11+DH/TQ+4Hg5wbmYBz3BwUGGBtTF0Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "afe3be17-8305-47d9-a205-de2ef61c33ca", "AQAAAAEAACcQAAAAED8GI0GwKV2IuGrS/eloRL52xkrvgkJT/p3Sow26AO32HKVSN142kjwf2enyaseHdw==" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "3cc27152-cf30-430d-a3ca-059236a34f65");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "1379cfed-0014-45da-9c59-d40311f2412b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49a7d2af-671a-4e7b-bbbc-2612672ed866", "AQAAAAEAACcQAAAAEPQEjcjtrJRaNRqWcxreHOd5fQP35SH/kp0ll9Dm0w5nFMMOVif9QylMJTw/KrCifw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab83c901-23cf-4215-9b3b-dc830f644580", "AQAAAAEAACcQAAAAEGGnySWyg5Zz71nNIgZdpIV1SaRvQnaEwZo9cftuDbdlDyoL2GCFvahEDfqyos+dzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31bd465b-ff61-4057-8b19-3b0e2bcd939a", "AQAAAAEAACcQAAAAEC3CwHgt9G8E8JlJIQdA/6lWUMt1cF6aDvfaAryoC7yXHFSg7pAG+YzDmm+PENtRHA==" });
        }
    }
}
