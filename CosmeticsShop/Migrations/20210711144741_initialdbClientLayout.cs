using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class initialdbClientLayout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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
                name: "ProductPrivateProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrivateProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ViewCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ForGender = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApplyForAll = table.Column<bool>(type: "bit", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProductIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCategoryIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancelReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExternalTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "ProductInCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCategories", x => new { x.CategoryId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Categoires_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categoires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "ProductInProductPrivateProperties",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductPrivatePropertyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInProductPrivateProperties", x => new { x.ProductId, x.ProductPrivatePropertyId });
                    table.ForeignKey(
                        name: "FK_ProductInProductPrivateProperties_ProductPrivateProperties_ProductPrivatePropertyId",
                        column: x => x.ProductPrivatePropertyId,
                        principalTable: "ProductPrivateProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInProductPrivateProperties_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCarts",
                columns: table => new
                {
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCarts", x => new { x.CartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCarts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "DateCreated", "Description", "FileSize", "ImagePath", "IsDefault", "IsOutstanding", "Name", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(8259), "Test Des", 12345L, "banner1.jpg", true, false, "test", 1, 2 },
                    { 2, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(9691), "Test Des", 12345L, "banner2.jpg", true, false, "test", 2, 2 },
                    { 3, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(9697), "Test Des", 12345L, "banner3.jpg", true, false, "test", 3, 2 },
                    { 4, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(9699), "Test Des", 12345L, "banner4.jpg", true, false, "test", 4, 2 },
                    { 5, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(9700), "Test Des", 12345L, "banner5.jpg", true, false, "test", 5, 2 },
                    { 6, new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(9702), "Test Des", 12345L, "banner6.jpg", true, false, "test", 6, 2 }
                });

            migrationBuilder.InsertData(
                table: "Categoires",
                columns: new[] { "Id", "CreatedDate", "IsOutstanding", "Name", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Montblanc", 1, 10, 2 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Coach", 1, 9, 2 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Burberry", 1, 8, 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Dolce&Gabbana", 1, 7, 2 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Bộ quà tặng cao cấp", null, 6, 2 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sản phẩm được yêu thích", null, 4, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sản phẩm mới", null, 3, 2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Gucci", 1, 2, 2 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Mercedes Benz", 1, 1, 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sản phẩm khuyến mại", null, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Avatar", "Dob", "Email", "Name", "Password", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), "Thọ Xuân - Thanh Hóa", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "minhanh@gmail.com", "Minh Anh", "AQAAAAEAACcQAAAAEPM2Yqe4w/BaIc6vyqM8lqu0x/cHmlGfyOkwi9VCWfhH5VoYop/z7gc4Y1sOuN4shw==", "0978563732", 2 },
                    { new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "dinhtrong@gmail.com", "Đình Trọng", "AQAAAAEAACcQAAAAEJ8ChVKeCYcwLy/U8UQwM/zP+9RCQWWuD875+RtYg7FtEyFPpAQFRTQuwtF9smkG6A==", "0985638888", 2 },
                    { new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), "Phúc Hòa - Tân Yên - Bắc Giang", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "congphuong@gmail.com", "Công Phượng", "AQAAAAEAACcQAAAAEAutfBuQsag68+al93mWvsykBNwAR1fOCkFSbUym6fVQ4PuNw9KnilCtnR8TBy/Shg==", "0987456321", 2 },
                    { new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), "Hoằng Hóa - Thanh Hóa", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangchung@gmail.com", "Hoàng Chung", "AQAAAAEAACcQAAAAEBJm/UAJHqaCR/UHScpjWxD8NOgfB9H0P3VklzZ+9T6TQHCM0CI/tSgV+4jYyVvGbw==", "0963258741", 2 },
                    { new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "xuantruong@gmail.com", "Xuân Trường", "AQAAAAEAACcQAAAAEM3Y5W4PoiD03gh80mNxyiJTTxLq93jQ5Tjhd66dmzmwEIoWT4X9QbXmwpd+cZZxFQ==", "0987546666", 2 },
                    { new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), "Chương Mỹ - Hà Nội", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "haianh@gmail.com", "Le Hai Anh", "AQAAAAEAACcQAAAAECMlIEMm92JVlMMrq+IlYQz2ANQoU2Bl+drvq9Fp5F4jLpz/bypVGQGY3ia0E894Fw==", "0358963245", 2 },
                    { new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), "Nguyễn Trãi - Thường Tín - Hà Nội", "", new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranphuong@gmail.com", "Tran Thu Phuong", "AQAAAAEAACcQAAAAEEvjJDPgOFeyWKYHzFuYvbvmMEmlmrlwHps5zfR8zWLeqSn6lyYH3g5h6GavpSXn6g==", "0378709602", 2 },
                    { new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), "8 Nghách 167 ngõ 521 Trương Định - Hoàng Mai - Hà Nội", "", new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "test1234@gmail.com", "Do tien dinh", "AQAAAAEAACcQAAAAEMXrI6aYidx1Q5DPAfN3mH8BPpXQKFTY0XQ9iyG2YXuasXbOx1hATvD+5mbVEchffQ==", "0984869201", 2 },
                    { new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), "8 Nghách 167 ngõ 521 Trương Định - Hoàng Mai - Hà Nội", "", new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "tiendinhdev99@gmail.com", "Voi Bé Nhỏ", "AQAAAAEAACcQAAAAEICWzUFpzYR9Dkj53KrNq/yM4/5lqUSzyzOR+2i5KmsLC4G2+olnThfWGAEHis0eRw==", "0984869201", 2 },
                    { new Guid("48347449-050f-4630-946a-cf41446d89c8"), "Đan Phượng - Hà Nội", "", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "vananh@gmail.com", "Tran Van Anh", "AQAAAAEAACcQAAAAENJ6yZ1oHb2IckgIuMGdshUF3DTurhQlCOVf5B0w8oX3gNgYfrYL590WRbk5v6i/mQ==", "0323456743", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "ForGender", "Name", "OriginalCountry", "OriginalPrice", "Price", "Stock", "status" },
                values: new object[,]
                {
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Bưởi, Bạch Đậu Khấu, Bạc Hà- Hương giữa: Oải Hương, Tuyết Tùng, Nhục Đậu Khấu- Hương cuối: Cỏ Vetiver hun khói, Quế, Hoắc Hương, Hổ Phách", 1, "Burberry Mr. Burberry EDP", "Pháp", 2190000m, 2190000m, 100, 2 },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Nhài- Hương giữa: Hoa Hồng Tẩm Mật, Quả Đào- Hương cuối: Hổ Phách, Hoắc Hương", 1, "Burberry My Burberry Black EDP", "Pháp", 4160000m, 4160000m, 100, 2 },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Hạnh nhân xanh- Hương giữa: Gỗ Tuyết Tùng- Hương cuối: Long Diên Hương, Rêu Sồi", 1, "Burberry Mr.Burberry Element EDT", "Pháp", 1980000m, 1980000m, 100, 2 },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hương nước hoa ngọt ngào và trẻ trung, tràn đầy sức sống của người phụ nữ hiện đại.Lấy cảm hứng từ thành phố London sôi động.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả mọng đỏ và tím (mâm xôi đỏ, đen…)- Hương giữa: Hoa Nhài, Hoa Violet- Hương cuối: Hổ Phách, Rêu Sồi, Vani, Xạ Hương, Hoắc Hương", 2, "Burberry Her EDP", "Pháp", 2030000m, 2030000m, 100, 2 },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mười sau năm kể từ khi ra mắt Light Blue, nhà chế tác Olivier Cresp viết nên một chương mới cho Light Bluevới Light Blue Eau Intense. Hơn cả một hương hoa, đó là tất cả thần thái tỏa ra từ người phụ nữ Địa Trung Hải xinh đẹp.", " ✔️Mùi hương đặc trưng:Nhóm hương: Fruity FloralMùi hương chính: Chanh, Táo Granny Smith, Cánh hoa nhài non, Hổ phách & Xạ hương", 2, "Dolce&Gabbana Combo Light Blue Intense EDP + Light Blue Pour Homme Intense EDP", "Pháp", 5060000m, 5060000m, 100, 1 },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Only One Intense được phỏng tác trên lớp nền hoa cỏ của The Only One,với kết hợp đối nghịch nhưng nhịp nhàng của hoa cam vàng và vanilla đen mềm mượt.Như người phụ nữ mà nó biểu trưng,nét đẹp mặn mà là thanh gương sắc bén mà không người đàn ông nào có thể chối từ.", " ✔️Mùi hương đặc trưng:Nhóm hương: Floriental SolarMùi hương chính: Hoa cam, Hoa trắng, Vanilla", 1, "Dolce&Gabbana Combo The Only One EDP Intense + The One For Men Intense EDP", "Pháp", 6720000m, 6720000m, 100, 2 },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The One For Men EDP là bức chân dung của một người đàn ông The One nam tính,mùi hương mang đến một trải nghiệm sâu lắng, nồng nàn,một tuyên bố mạnh mẽ cho ma lực cuốn hút không thể chối từ của người đàn ông The One.", " ✔️Mùi hương đặc trưng:Nhóm hương: Oriental SpicyMùi hương chính: Tinh chất bưởi, Ngò & Lá Húng, Gừng, Bạch đậu khấu, Thuốc lá & Nốt gỗ hổ phách ấm áp", 1, "Dolce&Gabbana The One For Men EDP", "Pháp", 2120000m, 2120000m, 100, 2 },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolce&Gabbana mang đến The Only One 2, chương thứ 2 trong câu chuyện về người phụ nữ The Only One.Mạnh mẽ, đôc đáo, đầy hấp lực, cô gái The Only Oneluôn là tâm điểm của mọi ánh nhìn bởi cô ấy biết mình muốn mình và sẽ làm gì để đạt được điều đó.", " ✔️Mùi hương đặc trưng:Nhóm hương: Floriental FruityMùi hương chính: Hoa hồng, Dâu đỏ, Vanilla, Hoắc hương & Đậu Tonka", 2, "Dolce&Gabbana The Only One 2 EDP (For Women)", "Pháp", 2590000m, 2590000m, 100, 2 },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa.Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu,về lực hút mãnh liệt kéo đôi tim lại gần nhau hơn không chỉ qua lời nói,mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu.", " ✔️Mùi hương đặc trưng:Nhóm hương: Fruity FloralMùi hương chính: Chanh Sicily, Táo Granny Smith, Dâu đỏ, Kem gelato dâu, Hoa Nhài, Xạ Hương & Tuyết Tùng", 2, "Dolce&Gabbana Light Blue Love Is Love EDT (For Women)", "Pháp", 2040000m, 2040000m, 100, 2 },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa.Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu,về lực hút mãnh liệt kéo đôi tim lại gần nhau hơn không chỉ qua lời nói,mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu.", " ✔️Mùi hương đặc trưng:Nhóm hương: Woody AromaticMùi hương chính: Chanh Sicily, Táo Granny Smith, Kem gelato táo, Tiêu Hồng, Hương Thảo, Xạ Hương & Gỗ Hổ Phách", 1, "Dolce&Gabbana Light Blue Pour Homme Love is Love EDT (For Men)", "Pháp", 1910000m, 1910000m, 100, 2 },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolce&Gabbana đem đến một biểu tượng nước hoa mới dành cho nam giới- K by Dolce&Gabbana EDT - mở ra một kỉ nguyên mới về chuẩn mực nam tính.Lấy hình tượng người đàn ông làm chủ sự nghiệplà điểm tựa của gia đình & là nguồn cảm hứng cho đồng đội,K by Dolce&Gabbana là biểu tượng cho một vị đế vương của cuộc sống hằng ngày!", " ✔️Mùi hương đặc trưng:Nhóm hương: Woody AromaticMùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Xô thơm, Gỗ Tuyết Tùng", 1, "Dolce&Gabbana K By Dolce&Gabbana EDT (For Men)", "Pháp", 1970000m, 1970000m, 100, 2 },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The One For Men Eau de Parfum Intense, đem đến sức hấp dẫn mãnh liệtbởi cách kết hợp những nguyên liệu đối lập một cách táo bạo.Nam tính mạnh mẽ, nhưng chân thực, trầm ấm, đó là mùi hương hoàn hảo của hai thái cực -sự ấm áp của hoa cam neroli và sự trầm lắng đầy bí ẩn của vanilla đen - đó là nghệ thuật chiaroscuro huyền thoại.", " ✔️Mùi hương đặc trưng:Nhóm hương: Oriental SpicyMùi hương chính: Hoa cam Địa Trung Hải, Lá bách quý, Ngò, Gỗ cashmere, Nốt hương da thuộc", 1, "Dolce&Gabbana The One For Men Intense EDP", "Pháp", 2220000m, 2220000m, 100, 2 },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Only One Intense được phỏng tác trên lớp nền hoa cỏ của The Only One,với kết hợp đối nghịch nhưng nhịp nhàng của hoa cam vàng và vanilla đen mềm mượt.Như người phụ nữ mà nó biểu trưng,nét đẹp mặn mà là thanh gương sắc bén mà không người đàn ông nào có thể chối từ.", " ✔️Mùi hương đặc trưng:Nhóm hương: Floriental SolarMùi hương chính: Hoa cam, Hoa trắng, Vanilla", 2, "Dolce&Gabbana The Only One EDP Intense (For Women)", "Pháp", 2720000m, 2720000m, 100, 2 },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Với thiết kế và màu sắc đặc trưng của vàng, 1 Million đại diện cho quyền lực, sự sang trọng và hào quang,đem lại những cảm giác rất riêng, rất đặc biệt và đầy dấu ấn cho người sử dụng.Dưới cái nhìn tổng thể, 1 Million mang cho mình tông hương trầm ấm nam tính đặc trưng của quế và các loại gia vị.Len lỏi vào từng chi tiết, ta dễ dàng bắt gặp hương ngọt nhẹ từ Bưởi và Quýt, nhen nhúm một ít thanh mát của Bạc hà.Nhanh chóng nhường chỗ cho sự cay trầm nồng nhiệt, Quế cùng Da thuộc lan tỏa khắp khứu giác,phác họa bức tranh ngày càng rõ nét về người nắm quyền, thao túng tất cả với cốt cách mạnh mẽ của mình.", null, 2, "Gift Set Paco Rabanne 1 Million EDT", "Pháp", 2450000m, 2450000m, 100, 1 },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lanvin - A Girl in Capri là một tinh chất rực rỡ đầy nắng của một chuyến du hành trên hòn đảo Capri xinh đẹp. Mùi hương là bức hoạ có màu xanh ngọc bích của biển Tyrrhenian dưới ánh nắng mặt trời,màu trắng của những mái nhà quý tộc thấp thoáng dưới tán lá xanh,màu vàng của nắng và những khu vườn cam bergamot màu mỡ.Bản chất của cam Bergamot mở ra hương thơm rạng rỡ, lạc quan mãnh liệt như những ngôi saorơi xuống trần gian làm tung toé những đốm sáng lấp lánh trên những con đường vắng lặng giữa trưa hè.", null, 2, "Gift Set Lanvin A Girl In Capri EDT", "Pháp", 2200000m, 2200000m, 100, 2 },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Có một số loại nước hoa sẽ chẳng bao giờ khiến bạn phải băn khoăn.Vì sao ư? Bởi vì chúng phản ánh tính cách mạnh mẽ và đem đến ánh hào quang độc đáo và không thể nhầm lẫncho người sử dụng. Giống như nước hoa Mercedes-Benz Man và phiên bản mới với bản chất mạnh mẽ của nó vậy.Người đàn ông ưa chuộng mùi nước hoa này chắc chắn là những người có sức lôi cuốn cao, có hấp lực để trở thành tâm điểm của mọi hoạt động, ngay tại nơi đông đúc nhất,dưới ánh đèn sân khấu và luôn thành công trong việc thu hút sự chú ý của bất cứ nơi nào họ đặt chân đến.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả Lê- Hương chính: Hoa Phong Lữ- Hương cuối: Rêu Sồi", 1, "Gift Set Mercedes-Benz Man Intense EDT", "Pháp", 2200000m, 2200000m, 100, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "ForGender", "Name", "OriginalCountry", "OriginalPrice", "Price", "Stock", "status" },
                values: new object[,]
                {
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woodyphảng phất cảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứngvới nắng gió khẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác:Mở đầu là sự thanh mát của Cam Đắng và Lê mọng nước, sau đến tầng hương giữa là Hoa Xương Rồnggiữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương", " ✔️Mùi hương đặc trưng:- Hương đầu: Bitter Orange- Hương chính: Hoa Dành Dành, hoa Xương Rồng- Hương cuối: Joshua Tree", 2, "Gift Set Coach Dreams EDP", "Pháp", 2800000m, 2800000m, 100, 2 },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Xuất hiện với ánh vàng lấp lánh đầy mê hoặc lòng người, Paco Rabanne Lady Millionliền để lại sự ấn tượng của mình bằng vẻ ngoài sang trọng, quý phái dành riêng cho nữ giới.", null, 2, "Gift Set Carolina Herrera 212 VIP Men EDT", "Pháp", 2950000m, 2950000m, 100, 2 },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Là mùi hương được tạo ra dành riêng cho thế hệ quý ông với tham vọng tái thiết lập đô thị,212 VIP Men xâm nhập vào chốn ồn ã với những nốt hương hiện đại mang cảm giác khó quên.Không cần phải phá bỏ các quy tắc, những quý ông 212 VIP Men sẽ đặt ra những luật chơi mới và khiến những người khác tuân theo.", " ✔️Mùi hương đặc trưng:- Hương đầu: Chanh vàng, Caviar, bạc hà- Hương chính: Gừng, vodka- Hương cuối: hổ phách, xạ hương, violet wood", 1, "Gift Set Carolina Herrera 212 VIP Men EDT", "Pháp", 2450000m, 2450000m, 100, 2 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Các nốt hương tương tự dòng LEGEND EDT Cam - Lài - Rêu nhưng được hoà quyện thêm các nốt hương mới Violet- Cây phong lữ - Gỗ", null, 1, "Gift Set Montblanc Legend EDP", "Pháp", 2350000m, 2350000m, 100, 2 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAD BOY là làn hương của sự đối ngẫu, đại diện cho cá tính, bản chất táo bạo của người đàn ông hiện đại.Một khi mạnh mẽ đi đôi với nhạy cảm, tự tin kèm điềm tĩnh Bad Boy chính là sự cân bằng hoàn hảokhi làm chủ được sự tương phản giúp mang mại những ưu điểm vượt trội.Bad Boy EDT được dựa trên cảm hứng về một “bad boy” chính hiệu, “không che giấu cái xấu lại trở thành một điều tốt”.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam Bergamot, Tiêu hồng và trắng- Hương chính: Tuyết Tùng & cây Xô thơm- Hương cuối: Đậu Tonka & Cacao", 1, "Gift Set Carolina Herrera Bad Boy EDT", "Pháp", 2850000m, 2850000m, 100, 2 },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Chanh, Gừng- Hương giữa: Hoa Mẫu Đơn, Hoa Hồng- Hương cuối: Xạ Hương, Hổ Phách", 2, "Burberry Her London Dream EDP", "Pháp", 2030000m, 2030000m, 100, 2 },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiếp nối câu chuyện về người đàn ông K by Dolce&Gabbana Eau de Toilette,được quay tại khung cảnh nên thơ xanh ngát của vùng đồi Tuscan,phiên bản K by Dolce&Gabbana Eau de Parfum mang lại một góc nhìn thân mật hơn về bậc đế vươngDolce&Gabbana, cùng gương mặt đại diện đầy nam tính Mariano Di Vaio.", " ✔️Mùi hương đặc trưng:Nhóm hương: Woody SpicyMùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Bạch đậu khấu, Xô thơm, Gỗ Agarmotha", 1, "Dolce&Gabbana K By Dolce&Gabbana EDP (For Men)", "Pháp", 2120000m, 2120000m, 100, 2 },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mùi hương mới nhất trong dòng My Burberry, được ví von như một khu vườn London trong một sáng sớm mùa xuân.Hương hoa cỏ cùng trái cây đan xen một cách trẻ trung và ngọt ngào.", " ✔️Mùi hương đặc trưng:- Hương đầu: Chanh, Lựu Đỏ- Hương giữa: Hoa Hồng, Táo Xanh- Hương cuối: Hoa Nhài, Tử Đằng Xanh", 2, "Burberry My Burberry Blush EDP", "Pháp", 2860000m, 2860000m, 100, 2 },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Dreams được lấy cảm hứng từ những chuyến viễn du xa xôi trên cung đường tràn ngập ánh nắngcủa miền Tây Hoa Kỳ với đầy ắp những ước vọng của những người trẻ.Một chuyến đi dài gợi lên cho bạn nhiều mong đợi với những xa lộ rộng mở và đong đầy kỷ niệm xuyên suốt từ đầu đến cuối hành trình", " ✔️Mùi hương đặc trưng:- Hương đầu: Bitter Orange- Hương giữa: Hoa Dành Dành, hoa Xương Rồng- Hương cuối: Joshua Tree", 2, "Gift Set Coach Dreams EDP", "Pháp", 2800000m, 2800000m, 100, 2 },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển,mùi hương hiện đại và phóng khoáng, nam tính.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam chanh, Bergamot, Bách Xù- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà- Hương cuối: Rêu Sồi, Hổ Phách", 1, "Burberry Mr. Burberry Indigo EDT", "Pháp", 2780000m, 2780000m, 100, 2 },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montblanc EMBLEM là một thiết kế thanh lịch và tinh tế. Màu đen đậm, sáng bóng mạnh mẽ,thủy tinh nặng, biểu tượng bao hàm sự sang trọng và tinh tế của Montblanc.Người đàn ông EMBLEM truyền tải một luồng khí mạnh mẽ thông qua sự hiện diện mạnh mẽ và sự quyến rũ tự nhiên của anh ta.Anh ấy chỉ một tay thể hiện sự sang trọng và tinh tế do Montblanc thể hiện.Sự hấp dẫn mang tính biểu tượng của anh ấy được phản ánh qua dấu vết khứu giácmà anh ấy để lại, đang phát triển trong một thời kỳ khó quên, tạo ấn tượng sâu sắc với mọi người.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cây xô thơm Clary, Bạch đậu khấu và Bưởi- Hương giữa: Lá Quế, Violet Frosted, Phong lữ- Hương cuối: Gỗ Quý, Cây hoắc hương, Đậu Tonka", 1, "Montblanc Emblem EDT (For Men)", "Pháp", 1360000m, 1360000m, 100, 1 },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montblanc Lady Emblem, hương thơm mới tinh tế, nữ tính và kiên quyết hiện đại dành cho phụ nữđược lấy cảm hứng từ viên kim cương của Montblanc,biểu tượng của tình yêu thuần khiết và vẻ đẹp. Phụ nữ Lady Emblem độc lập và hiện đại với tính linh hoạtđặc biệt khiến cô ấy trở thành người bạn đồng hành hoàn hảo cho đối tác Nam Emblem.Có một điều chắc chắn: không thể phủ nhận cô ấy rất nữ tính, tránh phô trương và sở hữuvẻ đẹp cùng phong cách thời trang riêng biệt. Một hương thơm rượu sake hoa hồng huyền bí,được tăng cường bởi gỗ đàn hương mịn như nhung mang đến tông màu hổ phách từ dưới lên trên. Một thần dược tuyệt hảo và đặc biệt dành cho phái nữ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Sake Accords, Pinnk Pepper, Bưởi- Hương giữa: Rose Essential, Jasmine Sambac, Pomegrenate- Hương cuối: Dầu đàn hương, Hổ phách, Xạ hương pha lê", 2, "Montblanc Lady Emblem EDP (Timeless Collection)", "Pháp", 1350000m, 1350000m, 100, 2 },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lady Emblem Elixir được tạo ra để dành cho người phụ nữ độc đáo, tinh tế và mạnh mẽ.Hương đầu của hoa hồng gấm hoa được khuếch tán bởi một làn sóng mật ong và gia vịthể hiện định nghĩa mới này về sự nữ tính. Lớp hương cuối cho thấy hương gỗ nồng nàn với cây hoắc hương và vani.Chai trang sức Lady Emblem Elixir được phủ một phần bằng kim loại vàng hồng quý giá, thể hiện một thế giới sang trọng và tinh tế.", " ✔️Mùi hương đặc trưng:- Hương đầu: Tiêu đen, Quả quýt, Vải thiều- Hương giữa: Hoa diên vĩ, Hoa hồng tuyệt đối, Hoa cam- Hương cuối: Vani, Gỗ đàn hương, Cây hoắc hương", 2, "Montblanc Lady Emblem Elixir EDP (For Women)", "Pháp", 1380000m, 1380000m, 100, 2 },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montblanc Legend EDT Một phiên bản đem lại xúc cảm dễ chịu so với dòng nước hoa Legendtrước đó nhưng vẫn thừa kế sự tao nhã và tinh tế vốn có - Montblanc Legend Spirit manvới thiết kế dáng chai kết hợp giữa màu trắng thanh khiết và chất liệu kim loại thép cường lựcđể tạo nên một chai nước hoa mang những nốt hương nam tính, tươi mới và mãnh liệt.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lavender, Bergamot- Hương giữa: Coumarin, Rêu sồi- Hương cuối: đậu Tonka", 1, "Montblanc Legend Spirit EDT", "Pháp", 1180000m, 1180000m, 100, 2 },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Với những ai là fan của Montblanc thì dễ dàng nhận ra thiết kế chai vượt thời gian, mang nét cổ điển nhưng nam tínhvà giữ nguyên ngôi sao 5 cánh là dấu ấn của Montblanc qua bao thập kỷ.Thủy tinh cường lực đen tuyền kết hợp cùng kim loại sáng bóng làm tăng hiệu ứng thị giác cũng như đem lại vẻ mạnh mẽ chắc chắn. Hình dáng Montblanc Legend được đánh cong uyển chuyển, cho thiện cảm mềm mại và tinh tế.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lavender, Bergamot- Hương giữa: Coumarin, Rêu sồi- Hương cuối: đậu Tonka", 1, "Montblanc Legend For Men EDT", "Pháp", 2200000m, 2200000m, 100, 2 },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2 dòng nước hoa Huyền Thoại đến từ thương hiệu Montblanc, mang đến sự Tự tin,Lịch lãm cùng với mùi hương cổ điển vượt thời gian. Phiên bản mini 4.5ml,vẫn là thiết kế mang phong cách sang trọng, nhưng được tinh tế thu nhỏ lại để có thể mang theo bên mình.", null, 1, "Montblanc Bộ Nước Hoa Mini 4 x 4.5ml", "Pháp", 950000m, 950000m, 100, 2 },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trong chương khứu giác thứ ba này, Maison Montblanc tiết lộ một khía cạnh lôi cuốn không kém,nhưng bí ẩn hơn ở quý ông phi thường này.Montblanc Legend Night phá vỡ tính hai mặt của mã đen và trắng của ngôi nhà,dọn đường cho màu hổ phách gợi nhớ đến gỗ, vật liệu đích thực cuối cùng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam Bergamot, Cây xô thơm- Hương giữa: Cỏ Vetiver, Hoa Oải Hương- Hương cuối: Vani, Gỗ hoắc hương", 1, "Montblanc Legend Night EDP", "Pháp", 1200000m, 1200000m, 100, 2 },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ở phiên bản  LEGEND EDP, những cảm xúc và mùi hương nguyên bản của LEGEND- những điều đã chinh phụchàng triệu người đàn ông trên thế giới vẫn được giữ nguyên nhưng nay đã trở nên mạnh mẽ hơn, nam tính hơn.", null, 1, "[NEW] Montblanc Legend EDP", "Pháp", 1700000m, 1700000m, 100, 2 },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Người phụ nữ SIGNATURE truyền cảm hứng cho mọi người, dùng sức mạnh của ngôn ngữ để thay đổi thế giới.Người phụ nữ đầy nhiệt huyết và tự tin, cô ấy tạo nên những thay đổi tích cực thông qua ngòi bút.Gợi nhắc đến những giá trị cốt lõi mang tính biểu tượng của Montblanc: Bình mực, franchise Montblanc Emblem và chiếc bút Montblanc Meisterstuck Solitaire Pen.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quýt, Lan Trắng, Mẫu Đơn - Hương giữa: Vanila, Mộc Lan, Hoàng Lan- Hương cuối: Benzoin, Musk, Hổ Phách", 1, "[NEW] Montblanc Signature EDP", "Pháp", 1380000m, 1380000m, 100, 2 },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Montblanc Explorer ngay từ những ngày đầu lên ý tưởng đã cho thấy nguyện vọng chinh phục không giới hạncác khách hàng của mình trên toàn thế giới.hư một nhà thám hiểm thực thụ, anh ta không để bản thân thỏa mãn quá lâu trên đỉnhmột ngọn núi mà ngay tức thì chọn cho mình một đỉnh cao mới thử thách là không giới hạn.Đây chính là câu chuyện đằng sau hương nước hoa mới từ Montblanc - Monblanc Explorer", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam bergamot italian - Hương giữa: Haitian vetiver - Hương cuối: Indonesian patchouli", 1, "Montblanc Explorer EDP", "Pháp", 1250000m, 1250000m, 100, 2 },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hương thơm sang trọng và ngọt ngào nhất trong dòng My Burberry,và cũng là phiên bản duy nhất có nồng độ tinh dầu cao nhất", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Nhài- Hương giữa: Hoa Hồng Tẩm Mật, Quả Đào- Hương cuối: Hổ Phách, Hoắc Hương", 2, "Burberry Combo My Burberry Black EDP + Mr. Burberry EDP", "Pháp", 7750000m, 7750000m, 100, 2 },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COACH MEN BLUE EDT là dòng nước hoa dành cho nam mới nhất từ Coach được lấy cảm hứng từ những chuyến road trip xuyên bang trứ danh ở Mỹ.Coach Men Blue EDT đem đến một mùi hương sôi nổi,Một mùi hương của sự tự do và niềm phấn khởi khi lướt đi trên những đại lộ dài hun hút nối liền các vùng đất mới.Dưới vòm trời xanh thẳm, bạn tận hưởng những làn gió mát vờn quanh,háo hức khám phá những điều bất ngờ của chuyến hành trình phía trước.", " ✔️Mùi hương đặc trưng:- Hương đầu: cam chanh, nho và các loại lá thơm- Hương giữa: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng- Hương cuối: gỗ tuyết tùng và hổ phách", 1, "Gift Set Coach Men Blue EDT", "Pháp", 2100000m, 2100000m, 100, 1 },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woody phảng phấtcảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứng với nắng giókhẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác: Mở đầu là sự thanh mát của Cam Đắng và Lê mọngnước, sau đến tầng hương giữa là Hoa Xương Rồng giữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương", " ✔️Mùi hương đặc trưng:- Hương đầu: Bitter Orange- Hương giữa: Hoa Dành Dành, hoa Xương Rồng- Hương cuối: Joshua Tree", 2, "[NEW] Coach Dreams EDP Body Lotion 150ml", "Pháp", 800000m, 800000m, 100, 2 },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Floral Blush là mùi hương của một người phụ nữ vui vẻ và lãng mạn,tự tin và phóng khoáng tận hưởng ánh nắng mặt trời, sống một cuộc sống nhiều niềm vui được phủ đầy sự lạc quan.", " ✔️Mùi hương đặc trưng:- Hương đầu: quả kỷ tử & một số trái mọng màu hồng- Hương giữa: hoa mẫu đơn- Hương cuối: gỗ trắng, hoa bông gòn", 2, "Coach New York Floral Blush EDP", "Pháp", 1100000m, 1100000m, 100, 2 },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp,lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.", " ✔️Mùi hương đặc trưng:- Hương đầu: tinh dầu tiêu đen, khóm- Hương giữa: Cashmeran, xô thơm- Hương cuối:  da vani, hoắc hương", 1, "Coach Men Platinum EDP", "Pháp", 1800000m, 1800000m, 100, 2 },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach For Men Eau De Toilette đưa bạn vào một hành trình của những khả năng vô tận,gợi lên cảm giác tự do đến từ năng lượng và sự tự phát của thành phố New York.Một hương thơm hiện đại kết hợp những nốt hương tươi mát,tràn đầy sức sống và sự gợi cảm ấm áp như làn da qua những nốt hương hổ phách, gỗ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lê Nashi xanh, Bergamot- Hương giữa: Bạch đậu khấu, Rau mùi- Hương cuối: Cỏ Vetiver, Da lộn, Long diên hương", 1, "Coach Men EDT", "Pháp", 2100000m, 2100000m, 100, 2 },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một hương thơm của sự tương phản, mở ra với quả mâm xôi tươi tắn, lấp lánh,rồi lách mình uyển chuyển nhường chỗ cho một bông hồng Thổ Nhĩ Kỳ sánh mịn,trước khi đi vào những nốt hương khô ráo của xạ hương và da lộn đầy gợi cảm.Mùi hương đặc trưng được tạo ra bởi hai nhà sáng chế nước hoa Anne Flipo và Juliette Karagueuzoglou.", " ✔️Mùi hương đặc trưng:- Hương đầu:  Lá Mâm xôi- Hương giữa: Hoa hồng Thổ Nhĩ Kỳ- Hương cuối: Da lộn Musks", 2, "Coach New York EDP (Timeless Collection)", "Pháp", 2550000m, 2550000m, 100, 2 },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Floral vẫn dựa trên cảm hứng về bông hoa Trà đặc trưng của thương hiệu.Bông hoa được tạo tác trên chất liệu da thuộc sang trọng,tông màu hồng nhẹ ấm áp mang đến cảm giác về một ngày nắng trong lành,cô gái Coach Floral dạo bước trên cánh đồng với những bông hoa dại đang nở tươi đưa mình trong gió.", " ✔️Mùi hương đặc trưng:- Hương đầu: Pineapple Sorbet,- Hương giữa: Bó hoa với Sambac Jasmine & Peony- Hương cuối: Crystal Musks", 2, "Coach Floral EDP", "Pháp", 1100000m, 1100000m, 100, 2 },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Được chế tác từ bàn tay tài hoa của Antoine Maisondieu - COACH DREAMS với họ hương Floral Woody phảng phấtcảm vị của những giấc mơ mùa hè, những cung đường dài bất tận cùng nhiều trạm dừng ngẫu hứng với nắng giókhẽ chạm vào da, tan chảy như thanh kẹo gòn làm đê mê khứu giác:Mở đầu là sự thanh mát của Cam Đắng và Lê mọng nước, sau đến tầng hương giữa là Hoa Xương Rồnggiữa sa mạc ngập nắng và rồi kết thúc rực rỡ cùng hương của Cây Joshua và Long Diên Hương", " ✔️Mùi hương đặc trưng:- Hương đầu: Bitter Orange- Hương giữa: Hoa Dành Dành, hoa Xương Rồng- Hương cuối: Joshua Tree", 1, "[NEW] Coach Dreams EDP 2020", "Pháp", 1300000m, 1300000m, 100, 2 },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COACH MEN BLUE EDT là dòng nước hoa dành cho nam mới nhất từ Coach được lấy cảm hứng từ những chuyến road trip xuyên bang trứ danh ở Mỹ.Một mùi hương của sự tự do và niềm phấn khởi khi lướt đi trên những đại lộ dài hun hút nối liền các vùng đất mới.Dưới vòm trời xanh thẳm, bạn tận hưởng những làn gió mát vờn quanh, háo hức khám phá những điều bất ngờ của chuyến hành trình phía trước.", " ✔️Mùi hương đặc trưng:- Hương đầu: cam chanh, nho và các loại lá thơm- Hương giữa: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng- Hương cuối: gỗ tuyết tùng và hổ phách", 1, "[NEW] Coach Men Blue EDT", "Pháp", 1550000m, 1550000m, 100, 2 },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển,mùi hương hiện đại và phóng khoáng, nam tính.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam chanh, Bergamot, Bách Xù- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà- Hương cuối: Rêu Sồi, Hổ Phách", 1, "Burberry Mr. Burberry Indigo EDT", "Pháp", 2780000m, 2780000m, 100, 1 },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mùi hương tươi mát, như một chuyến dã ngoại cuối tuần về những vùng ngoại ô dọc bờ biển,mùi hương hiện đại và phóng khoáng, nam tính.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam chanh, Bergamot, Bách Xù- Hương giữa: Violet, Xô thơm, Lá Trà, Bạc Hà- Hương cuối: Rêu Sồi, Hổ Phách", 1, "Burberry Mr. Burberry Indigo EDT", "Pháp", 2780000m, 2780000m, 100, 2 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urban Hero là sự gia nhập mới nhất từ Jimmy Choo cho dòng nước hoa nam.Bổ sung một hương thơm mới với cường độ và sự tương phản mạnh mẽ hơn những dòng trước đây để đề cao cương lĩnh của người đàn ông hiện đại.Một cái tôi nổi bật và không bị các định kiến xã hội gò bó, nghĩ như một nghệ sĩ và hành động như một người hùng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lemon Caviar, Black Pepper- Hương chính: Rosewood, Vetiver- Hương cuối: Grey Amber, Leather Accord", 1, "Gift Set Jimmy Choo Urban Hero EDP", "Pháp", 2380000m, 2380000m, 100, 2 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sự hòa quyện ngọt ngào của Lê, thơm ngậy của Vanilla cùng những nốt hương mêhoặc của Đậu Tonka đã tạo nên một La Belle Le Parfum đẹp tuyệt, say đắm lòng người", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả Lê- Hương chính: Đậu Tonka- Hương cuối: Vanilla", 2, "[NEW] Gift Set Jean Paul Gaultier La Belle Le Parfum EDP", "Pháp", 1387500m, 1387500m, 100, 2 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một hương thơm của sự tương phản, mở ra với quả mâm xôi tươi tắn, lấp lánh,rồi lách mình uyển chuyển nhường chỗ cho một bông hồng Thổ Nhĩ Kỳ sánh mịn,trước khi đi vào những nốt hương khô ráo của xạ hương và da lộn đầy gợi cảm.Mùi hương đặc trưng được tạo ra bởi hai nhà sáng chế nước hoa Anne Flipo và Juliette Karagueuzoglou.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lá Mâm xôi- Hương chính: Hoa hồng Thổ Nhĩ Kỳ- Hương cuối: Da lộn Musks", 2, "Coach Men Platinum EDP", "Pháp", 1785000m, 1785000m, 100, 2 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp,lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.", " ✔️Mùi hương đặc trưng:- Hương đầu: tinh dầu tiêu đen, khóm- Hương chính: Cashmeran, xô thơm- Hương cuối: da vani, hoắc hương", 1, "Gift Set Coach Men Platinum EDP", "Pháp", 1645000m, 1645000m, 100, 2 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAD BOY Le Parfum định nghĩa lại mùi hương mang tính biểu tượng của BAD BOYvới một công thức mới táo bạo hơn bao giờ hết. Không hối lỗi, chân thực và bí ẩn,mùi hương bất cần này thể hiện sự đa dạng trong tính cách của người đàn ông hiện đại.BAD BOY Le Parfum là minh chứng cho thấy các quy tắc được tạo ra để bị phá vỡ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Bưởi Chùm & Gai Dầu- Hương giữa: Xô Thơm & Phong Lữ- Hương cuối: Da & Cỏ Hương Bài", 1, "[New] Carolina Herrera Bad Boy Le Parfum EDP", "Pháp", 2360000m, 2360000m, 100, 2 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vui vẻ, tuyệt vời và không sợ hãi, Very Good Girl là một màn trình diễn mới của mùi hương Good Girl biểu tượng.Vẫn mang tầm nhìn của Carolina Herrera về sự đa dạng trong tính cách của người phụ nữ hiện đại,hương thơm mới của hoa hồng quyến rũ cùng thiết kế nóng bỏng sẽ khiến bạn không thể cưỡng lại", " ✔️Mùi hương đặc trưng:- Hương đầu: Nho Đỏ & Vải- Hương giữa: Hoa hồng & Hoa Lily- Hương cuối: Rượu Vanilla & Cỏ Hương Bài", 1, "[New] Carolina Herrera Very Good Girl EDP", "Pháp", 3000000m, 3000000m, 100, 2 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một dòng nước hoa đại diện cho sự khiêu khích, hiện thân của những dụ dỗ đắm chìm trong những thú vui tội lỗi.", " ✔️Mùi hương đặc trưng:- Hương đầu: Ngò thơm, Hoa Lavender- Hương giữa: Hoa cam, Hoa cam Neroli, Hương lục- Hương cuối: Cây hoắc hương, Gỗ tuyết tùng", 1, "Gucci Guilty Black Pour Homme EDT (For Men)", "Ý", 1930000m, 1930000m, 100, 1 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vẫn giữ nguyên thiết kế như dòng Gucci Flora, nước hoa Gucci Flora Gorgeous Gardeniaphiên bản giới hạn 2020 có màu tím lavender khá đặc biệt, đầy khiêu khích cho những ai vô tình chạm mắt.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả mọng đỏ, Quả lê.- Hương giữa: Hoa dành dành, Hoa sứ.- Hương cuối: Hoắc hương, Đường nâu.", 1, "Gucci Flora Gorgeous Gardenia EDT Limited Edition 2020", "Ý", 2420000m, 2420000m, 100, 2 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One Million Lucky eau de toilette dành cho nam giới. Một hương thơm gỗ, một trò chơi cảm giác xung quanh hạt phỉ gây nghiện.Nếm thử. Tiếp theo là một mạch tươi mát, ngon ngọt: một miếng bánh tart, mận xanh.Cam quýt hợp nhất. Rung động tối ưu: gỗ cực kỳ sôi động. Căng thẳng từ tuyết tùng.Một hương thơm gợi cảm với các nốt hương mạnh mẽ của cây hoắc hương và gỗ hổ phách.One Million Lucky: một hương thơm gây nghiện, một trải nghiệm thú vị!", " ✔️Mùi hương đặc trưng:- Hương đầu: cây phỉ.- Hương chính: mận xanh, bưởi, cam bergamot.- Hương cuối: tuyết tùng trắng, hoắc hương, gỗ hổ phách, vani.", 1, "Paco Rabanne 1 Million Lucky EDT (For Men)", "Pháp", 1387500m, 1387500m, 100, 1 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Nhài Sambac- Hương giữa: Hoa Huệ Tự Nhiên, Chiết Xuất Nụ Hoa Nhài Và Ngọc Lan Tây- Hương cuối: Gỗ Đàn Hương", 2, "[New] Gucci Bloom Profumo Di Fiori EDP", "Ý", 2910000m, 2910000m, 100, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "Description", "Details", "ForGender", "Name", "OriginalCountry", "OriginalPrice", "Price", "Stock", "status" },
                values: new object[,]
                {
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Nụ Hoa Nhài, Cây Leo Rangoon- Hương giữa: Hoa Huệ Ấn Độ- Hương cuối: Hoa hồng Damascena, Tuscan Orris", 2, "[New] Gucci Bloom Ambrosia Di Fiori EDP", "Ý", 2150000m, 2150000m, 100, 2 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phiên bản trẻ trung và nhẹ nhàng, đầy sức sống của Bloom. Mùi hương giữ nguyên các thành phần của Bloom EDP,kết hợp cùng với những thành phần như: Hoa hồng đá xanh và nụ lý chua đen.", " ✔️Mùi hương đặc trưng:- Nhóm hương: Hương Hoa Cỏ - Floral- Hương đầu: Lá Galbanum, Lá Lý Chua Đen- Hương giữa: Hoa Huệ Trắng, Hoa Nhài, Hoa Kim Ngân- Hương cuối: Xạ Hương, Gỗ Đàn Hương", 2, "Gucci Bloom Acqua Di Fiori EDT", "Ý", 2490000m, 2490000m, 100, 2 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dòng sản phẩm lấy cảm hứng từ họa tiết Flora in trên chiếc khăn choàng cổ nhà Gucci tặng cho công nương xứ Monaco - Grace Kelly. Một mùi hương nữ tính và sang trọng.", null, 2, "Gucci Flora By Gucci EDP", "Ý", 2670000m, 2670000m, 100, 2 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gucci Guilty Pour Home EDT được lấy cảm hứng từ nhân vật Casanova trong các tác phẩm văn học Ý. ", " ✔️Mùi hương đặc trưng:- Nhóm hương: Hương Gỗ Cay Nồng - Woody Spices- Hương đầu: Chanh Ý, Lavender- Hương giữa:  Hoa Cam- Hương cuối: Hoắc Hương, Tuyết Tùng, Vani", 2, "Gucci Guilty Pour Homme EDP", "Ý", 3100000m, 3100000m, 100, 2 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lấy cảm hứng từ đô thị phồn hoa New York với nguồn năng lượng tươi trẻ, đầy nhiệt huyết không bao giờ ngừng chuyển động,212 của nhà Carolina Herrera đại diện cho sự giao thoa hoàn hảo của nét đẹp của những giá trị xưa cũ cùng những điều mới lạ tân thời.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hương Gừng và Lê- Hương giữa: Hoa Phong Lữ và Lá Xô Thơm- Hương cuối: Hương Da Thuộc và Xạ Hương", 1, "[NEW] Carolina Herrera 212 Heroes EDT", "Pháp", 2050000m, 2050000m, 100, 2 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mùi hương hướng đến đối tượng phụ nữ từ 30 trở lên, mong muốn thể hiện sự quý phái và đằm thắm.Với những thành phần nguyên bản từ Bloom EDP cộng với Hoa Hồng và Hoa Quế.", null, 2, "Gucci Bloom Nettare EDP", "Ý", 2150000m, 2150000m, 100, 2 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Có một số loại nước hoa sẽ chẳng bao giờ khiến bạn phải băn khoăn.Vì sao ư? Bởi vì chúng phản ánh tính cách mạnh mẽ và đem đến ánh hào quang độc đáo và không thể nhầm lẫn cho người sử dụng.Giống như nước hoa Mercedes-Benz Man và phiên bản mới với bản chất mạnh mẽ của nó vậy.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả Lê- Heart giữa:  Hoa Phong Lữ- Hương cuối: Rêu Sồi", 1, "[NEW] Mercedes-Benz Man Intense EDT", "GERMANY", 1600000m, 1600000m, 100, 1 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sau thành công của Mercedes-Benz Select,thương hiệu mang tính biểu tượng hiện đang đề xuất một cách giải thích mới về loại nước hoa cổ điển này,trong một phiên bản dành cho ban đêm. Vẫn vượt thời gian nhưng nồng nàn hơn,quyến rũ hơn hương thơm ban đầu, Mercedes-Benz Select Night có Eau de Parfum: nồng độ cao hơn,có thể thể hiện rõ hơn bản sắc mạnh mẽ của mùi hương mới này.Nó thể hiện sự sang trọng và nam tính, với một chút gợi cảm, một sự kết hợp hoàn hảo cho một quý ông háo hức quyến rũ một cách dễ dàng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Bạch đậu khấu, Hoa oải hương- Heart giữa:  Tuyết tùng, Cam- Hương cuối: Gỗ đàn hương, Vani", 1, "Mercedes-Benz Select Night EDP", "GERMANY", 1700000m, 1700000m, 100, 2 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes-Benz là hãng xe hơi danh tiếng lâu đời nhất của Đức được thành lập vào năm 1926 có trụ sở tại Stuttgart,và là một trong những hãng xe tiên phong trong việc giới thiệu nhiều công nghệ và những sáng kiến về độ an toàn cao.Hãng lần đầu tiên phát hành nước hoa vào năm 2012 và được chế tác tại Pháp để đáp ứng cho dân chơi xe hơi chuyên nghiệp", " ✔️Mùi hương đặc trưng:- Hương đầu:  quýt, cam bergamot, tiêu hồng - Heart giữa:  lá violet, hoa nghệ tây, nốt hương màu xanh tươi mát- Hương cuối: hoắc hương, cỏ hương bài, trầm hương ", 1, "Mercedes-Benz Le Parfum For Men EDP", "GERMANY", 2800000m, 2800000m, 100, 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes-Benz Woman Eau de Toilette thuộc nhóm hương hoa cỏ xanh thơm mát dịu ngọt thích hợp mọi mùa trong năm, ban ngày lẫn ban đêm.Làn hương tinh tế lan tỏa dễ chịu ra xung quanh.Một hương thơm quyến rũ, sang trọng và đột phá thể hiện cá tính của người phụ nữ.", " ✔️Mùi hương đặc trưng:- Hương đầu:  Quýt vàng, Lý chua- Heart giữa: Dành Dành, Nhài Sabac, Linh Lan- Hương cuối: Gỗ Đàn Hương, Xạ Hương, Iris", 2, "Mercedes-Benz Women EDT", "GERMANY", 1200000m, 1200000m, 100, 2 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước hoa dành cho những chàng trai với đam mê dịch chuyển.Cú húych The Move là một bản trường ca cuộc sống. Với bối cảnh âm nhạc, câu chuyện kể về một chàng trai trẻđang trong công cuộc xuyên lòng đô thị và chiếm lấy nó cho riêng mình. Sự khát khao về cuộc sống được thể hiện rõ rệtqua mỗi bước đi và những bước nhảy, cả thế giới đang chuyển động và anh ấy cũng vậy.", " ✔️Mùi hương đặc trưng:- Hương đầu:   Bưởi chua, Hoa táo, Bạch đậu khấu- Heart giữa: Lá phong lữ, Hương muối biển- Hương cuối: Đậu Tonka, Amberwood", 1, "Gift Set Mercedes-Benz The Move EDT", "GERMANY", 2200000m, 2200000m, 100, 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sự thành công, tính ưa mạo hiểm và hoóc-môn adrenaline sẽ thúc đẩy họ tiến lên phía trước.Tôi muốn tạo ra một cái nhìn khác về chất nam tính. Thay vì tập trung vào các hương thơm tươi mới hơn,tôi muốn tăng liều lượng hương gỗ trong tầng đầu và cho vào thêm một vài điều ngạc nhiên khác ", " ✔️Mùi hương đặc trưng:- Hương đầu:  Quả Lê- Heart giữa: Hoa Phong Lữ- Hương cuối: Rêu Sồi", 1, "Gift Set Mercedes-Benz Man Intense EDT", "GERMANY", 2200000m, 2200000m, 100, 2 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Một hương thơm quyến rũ, sang trọng, hơn cả mong đợi được tạo ra để làm nổi bật và thể hiện cá tính của ngườiphụ nữ. Một câu chuyện tuyệt vời về sự nữ tính và tự cường, bao bọc cô ấy trong một hào quang thơm ngát.", " ✔️Mùi hương đặc trưng:- Hương đầu:  Gardenia- Heart giữa: Hoa Nhài- Hương cuối: Vanila", 2, "Gift Set Mercedes-Benz Woman EDP", "GERMANY", 2400000m, 2400000m, 100, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một phiên bản mini 20ml của Mercedes với thiết kế nhỏ gọn để có thể mang theo bên mình. Gồm các dòng sản phẩm:", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả bưởi, Bạch đậu khấu, Hoa táo- Heart giữa: Muối, Hương nước biển, Hoa phong lữ- Hương cuối: Đậu Tonka, Nhựa thơm cây tùng", 1, "[NEW] Mercedes-Benz On The Go", "GERMANY", 500000m, 500000m, 100, 2 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " Một hương thơm quyến rũ, sang trọng, hơn cả mong đợi được tạo ra để làm nổi bật và thể hiện cá tính của ngườiphụ nữ. Một câu chuyện tuyệt vời về sự nữ tính và tự cường, bao bọc cô ấy trong một hào quang thơm ngát.", " ✔️Mùi hương đặc trưng:- Hương đầu:  Gardenia- Heart giữa: Hoa Nhài- Hương cuối: Vanila", 2, "Mercedes-Benz Women EDP (New 2020)", "GERMANY", 1400000m, 1400000m, 100, 2 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes-Benz là hãng xe hơi danh tiếng lâu đời nhất của Đức được thành lập vào năm 1926 có trụ sở tại Stuttgart, và là một trong những hãng xe tiên phong trong việc giới thiệu nhiều công nghệ và những sáng kiến về độ an toàn cao. Hãng lần đầu tiên phát hành nước hoa vào năm 2012 và được chế tác tại Pháp để đáp ứng cho dân chơi xe hơi chuyên nghiệp.", " ✔️Mùi hương đặc trưng:- Hương đầu: quả Lê, hạt Ambrette- Hương giữa: Tuyết Tùng, Phong Lữ- Hương cuối: Rêu Sồi, Palisander", 1, "Mercedes-Benz Man EDT", "GERMANY", 1200000m, 1200000m, 100, 2 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lấy cảm hứng từ khu vườn hoa trắng ở những vùng nông thôn nước Ý, mùi hương chỉ có một tầng hương duy nhất với các thành phần: Hoa Sử Quân Tử - Hoa Huệ Tây - Nụ Hoa Nhài", null, 2, "Gucci Bloom EDP", "Ý", 2030000m, 2030000m, 100, 2 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I WANT CHOO mang đậm làn hương hoa cỏ phương Đông (Oriental Floral), một chút ngọt ngào xen lẫn một chút gợi cảm,rất sôi nổi nhưng cũng rất lắng đọng. I WANT CHOO mở đầu bằng những nốt hương Cam Đào tươi vui rực rỡ,sau đó nốt hương trung tâm – Red Spider Lilies (Hoa Loa Kèn Nhện Đỏ) và Hoa Nhài Sambac trỗi dậy nồng nàn gợi cảm và kết lại bằng hương Vani ngọt ngào lắng đọng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hương Quýt & Đào Nhung- Hương giữa: Hoa Huệ Nhện Đỏ & Hoa Nhài Sambac- Hương cuối: Vanilla, Benzoin", 1, "[NEW] Jimmy Choo I Want Choo EDP", "Pháp", 2150000m, 2150000m, 100, 2 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dòng sản phẩm lấy cảm hứng từ họa tiết Flora in trên chiếc khăn choàng cổ nhà Gucci tặng cho công nương xứ Monaco - Grace Kelly. Một mùi hương nữ tính và sang trọng.", null, 1, "Gucci Combo Flora By Gucci EDP + Guilty Pour Homme EDP", "Ý", 7140000m, 7140000m, 100, 2 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một câu chuyện tình yêu và những đóa hoa nở rộ - đầy tươi mới và quyến rũ,Love Story EDP với tầng hương trung tâm là một vườn hoa Nhài Leo xinh đẹp – loài hoa tượng trưng cho hạnh phúc,kết hợp cùng Hoa Cam trắng ngần thanh tao.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Cam Neroli- Hương giữa: Hoa Cam, Hoa Nhài Stephanotis- Hương cuối: Gỗ Tuyết Tùng", 2, "Chloe Love Story EDP", "Pháp", 1920000m, 1920000m, 100, 2 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khởi đầu tươi mát, sau đó lắng dần và chuyển sang hương gỗ để trở nên trầm ấm hơn. Coach Men Blue EDT đem đến một mùi hương sôi nổi, tràn đầy năng lượng để khám phá những giới hạn đang ở phía trước.", " ✔️Mùi hương đặc trưng:- Hương đầu: cam chanh, nho và các loại lá thơm- Hương chính: ozone accord (như mùi hương ta ngửi được sau những cơn mưa), tiêu đen và lá tuyết tùng- Hương cuối: gỗ tuyết tùng và hổ phách", 2, "Gift Set Coach Men Blue EDT", "Pháp", 1890000m, 1890000m, 100, 2 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Dreams được lấy cảm hứng từ những chuyến viễn du xa xôi trên cung đường tràn ngập ánh nắngcủa miền Tây Hoa Kỳ với đầy ắp những ước vọng của những người trẻ.Một chuyến đi dài gợi lên cho bạn nhiều mong đợi với những xa lộ rộng mở và đong đầy kỷ niệm xuyên suốt từ đầu đến cuối hành trình", " ✔️Mùi hương đặc trưng:- Hương đầu: Bitter Orange- Hương chính: Hoa Dành Dành, hoa Xương Rồng- Hương cuối: Joshua Tree", 2, "Holiday Gift Set Coach Dreams EDP", "Pháp", 2520000m, 2520000m, 100, 2 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Dreams Eau De Parfum là một loại nước hoa có điểm nhấn là sự tự do và phiêu lưu - giống như một chuyến du hành xuyên Mỹ. Coach Dreams sẽ đưa bạn vào một cuộc hành trình để sống với ước mơ của bạn!Hương thơm kết hợp giữa cam đắng rạng rỡ và lê ngon ngọt với sự ấm áp gợi cảm của cây dành dành, hoa xương rồng và Cây Joshua.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lê, Cam (đắng)- Hương chính: Hoa xương rồng, Cây dành dành- Hương cuối: Cây Joshua (Yucca), Ambroxan", 2, "Gift Set Coach Dreams", "Pháp", 2520000m, 2520000m, 100, 2 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Floral Blush là mùi hương của một người phụ nữ vui vẻ và lãng mạn,tự tin và phóng khoáng tận hưởng ánh nắng mặt trời, sống một cuộc sống nhiều niềm vui được phủ đầy sự lạc quan.", " ✔️Mùi hương đặc trưng:- Hương đầu: quả kỷ tử & một số trái mọng màu hồng- Hương chính: hoa mẫu đơn- Hương cuối: gỗ trắng, hoa bông gòn", 2, "Coach New York Floral Blush EDP", "Pháp", 990000m, 990000m, 100, 2 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chứa đựng sự nữ tính mềm mại nhưng xen lẫn đâu đó là tinh thần phiêu lưu phóng khoáng được truyền cảm hứngtừ những chân trời xa xôi và những cuộc tao ngộ bất ngờ đầy xúc xảm - Chloé Nomade Eau de Parfum là một nốt hương gỗ hòa quyện với nét rạng rỡ của những đóa hoa.Sự mãnh liêt của Rêu Sồi được cân bằng hoàn hảo bởi sự hiện diện ngọt ngào mê đắm của Mận Mirablle và Lan Nam Phi nở rộ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Mận Mirabelle- Hương giữa: Hoa Lan Nam Phi- Hương cuối: Rêu Sồi", 2, "Chloe Nomade EDP", "Pháp", 1920000m, 1920000m, 100, 2 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nước hoa EDP mới nhất dành cho phái mạnh, vừa năng động lại vừa ấm áp,lấy cảm hứng từ chuyến hành trình xuyên nước Mỹ để dừng chân tại New York.", " ✔️Mùi hương đặc trưng:- Hương đầu: tinh dầu tiêu đen, khóm- Hương chính: Cashmeran, xô thơm- Hương cuối:  da vani, hoắc hương", 1, "Coach Men Platinum EDP", "Pháp", 1260000m, 1260000m, 100, 2 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach For Men Eau De Toilette đưa bạn vào một hành trình của những khả năng vô tận,gợi lên cảm giác tự do đến từ năng lượng và sự tự phát của thành phố New York.Một hương thơm hiện đại kết hợp những nốt hương tươi mát,tràn đầy sức sống và sự gợi cảm ấm áp như làn da qua những nốt hương hổ phách, gỗ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lê Nashi xanh, Bergamot- Hương chính: Cardamom, Coriander- Hương cuối:  Vetiver, Suede, Ambergris", 1, "Coach Men EDT", "Pháp", 1470000m, 1470000m, 100, 2 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Le Male Parfums hứa hẹn sẽ đưa bạn vào một cuộc phiêu khứu giác đầy sự đối lập từ làm mất phương hướng đến bùng nổ và làm thỏa mãn các giác quan.Hương bạch đấu khấu mạnh mẽ ở tầng hương đầu, tầng hương giữa là sự kết hợp của hoa oải hương thanh mát và hương hoa diên vĩ. Phiên bản EDP khiến bạn đắm chìm trong nốt hương vani nồng nàn, mãnh liệt và gây nghiện. ", null, 1, "[NEW] Jean Paul Gautier Le Male Le Parfum EDP", "Pháp", 1980000m, 1980000m, 100, 1 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BAD BOY là làn hương của sự đối ngẫu, đại diện cho cá tính, bản chất táo bạo của người đàn ông hiện đại. Một khi mạnh mẽ đi đôi với nhạy cảm, tự tin kèm điềm tĩnh Bad Boychính là sự cân bằng hoàn hảo khi làm chủ được sự tương phản giúp mang mại những ưu điểm vượt trội.Bad Boy EDT được dựa trên cảm hứng về một “bad boy” chính hiệu, “không che giấu cái xấu lại trở thành một điều tốt”.", " ✔️Mùi hương đặc trưng:- Hương đầu: Cam Bergamot, Tiêu hồng và trắng- Hương chính: Tuyết Tùng & cây Xô thơm- Hương cuối: Đậu Tonka & Cacao", 1, "Carolina Herrera Bad Boy EDT", "Pháp", 2050000m, 2050000m, 100, 2 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1 Million Parfum vừa ra mắt trong tháng 8/2020 một lần nữa khẳng định và nâng tầm sự quyền lực và giàu có của gã đàn ông triệu đô nhà Paco Rabanne .Hương thơm độc đáo mạnh mẽ dành cho những người đàn ông không ngại chứng tỏ bản thân,dám trở nên khác biệt và luôn vượt lên trên tất cả.", " ✔️Mùi hương đặc trưng:- Hương Hoa: Hương hoa huệ kết hợp hương hổ phách- Hương Da Thuộc: Hương da thuộc được làm ấm cùng nhựa cây labdanum và resin", 1, "[NEW] Paco Rabanne 1 Million Parfum EDP For Men 2020", "Pháp", 2650000m, 2650000m, 100, 2 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coach Floral vẫn dựa trên cảm hứng về bông hoa Trà đặc trưng của thương hiệu.Bông hoa được tạo tác trên chất liệu da thuộc sang trọng, tông màu hồng nhẹ ấm áp mang đến cảm giác về một ngày nắng trong lành,cô gái Coach Floral dạo bước trên cánh đồng với những bông hoa dại đang nở tươi đưa mình trong gió.", " ✔️Mùi hương đặc trưng:- Hương đầu: Pineapple Sorbet- Hương chính: Bó hoa với Sambac Jasmine & Peony- Hương cuối:  Crystal Musks", 2, "Coach Floral EDP", "Pháp", 990000m, 990000m, 100, 2 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Với chủ điểm hương là Hoa hồng – biểu tượng kinh điển của nét nữ tính ,Signature của Chlóe đem đến một sự thân thuộc mà vẫn tràn đầy gợi cảm,một sáng tạo thơm mang tính trường tồn, vượt thời gian nhưng không hề kém đi những chấm phá hiện đại.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Mẫu Đơn- Hương giữa: Cánh Hoa Hồng, Hoa Mộc Lan- Hương cuối: Gỗ Tuyết Tùng, Long Diên Hương", 2, "Chloe Signature EDP", "Pháp", 1920000m, 1920000m, 100, 2 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Nụ Hoa Nhài, Cây Leo Rangoon- Hương giữa: Hoa Huệ Ấn Độ- Hương cuối: Hoa hồng Damascena, Tuscan Orris", 2, "[New] Gucci Bloom Ambrosia Di Fiori EDP", "Ý", 2150000m, 2150000m, 100, 2 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Một câu chuyện tình yêu và những đóa hoa nở rộ - đầy tươi mới và quyến rũ, Love Story EDP với tầng hương trung tâm là một vườn hoa Nhài Leo xinh đẹp – loài hoa tượng trưng cho hạnh phúc, kết hợp cùng Hoa Cam trắng ngần thanh tao.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Cam Neroli- Hương giữa: Hoa Cam, Hoa Nhài Stephanotis- Hương cuối: Gỗ Tuyết Tùng", 2, "Chloe Love Story EDP", "Pháp", 1920000m, 1920000m, 100, 2 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiếp nối câu chuyện về người đàn ông K by Dolce&Gabbana Eau de Toilette, được quay tại khung cảnh nên thơ xanh ngát của vùng đồi Tuscan,phiên bản K by Dolce&Gabbana Eau de Parfum mang lại một góc nhìn thân mật hơn về bậc đế vương Dolce&Gabbana,cùng gương mặt đại diện đầy nam tính Mariano Di Vaio.Trong thước phim, phóng trên chiếc mô tô phân khối lớn dọc theo đại lộ xanh ngát cây, anh toát lên vẻ nam tính mạnh mẽ và đầy lôi cuốn cùng phong thái tự tin đỉnh đạc của bậc đế vương trong cuộc sống hằng ngày!", " ✔️Mùi hương đặc trưng:Nhóm hương: Woody SpicyMùi hương chính: Cam đỏ, Chanh Sicily, Ớt Pimento, Bạch đậu khấu, Xô thơm, Gỗ Agarmotha", 1, "Dolce&Gabbana K By Dolce&Gabbana EDP (For Men)", "Pháp", 2120000m, 2120000m, 100, 2 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", " ✔️Mùi hương đặc trưng:- Hương đầu: Hoa Nhài Sambac- Hương giữa: Hoa Huệ Tự Nhiên, Chiết Xuất Nụ Hoa Nhài Và Ngọc Lan Tây- Hương cuối: Gỗ Đàn Hương", 1, "[New] Gucci Bloom Profumo Di Fiori EDP", "Pháp", 2190000m, 2190000m, 100, 1 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I WANT CHOO mang đậm làn hương hoa cỏ phương Đông (Oriental Floral),một chút ngọt ngào xen lẫn một chút gợi cảm, rất sôi nổi nhưng cũng rất lắng đọng.I WANT CHOO mở đầu bằng những nốt hương Cam Đào tươi vui rực rỡ,sau đó nốt hương trung tâm – Red Spider Lilies (Hoa Loa Kèn Nhện Đỏ) vàHoa Nhài Sambac trỗi dậy nồng nàn gợi cảm và kết lại bằng hương Vani ngọt ngào lắng đọng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Hương Quýt & Đào Nhung- Hương giữa: Hoa Huệ Nhện Đỏ & Hoa Nhài Sambac- Hương cuối: Vanilla, Benzoin", 2, "[NEW] Jimmy Choo I Want Choo EDP", "Pháp", 2150000m, 2150000m, 100, 2 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thiết kế màu xanh như hồ nước lấp loáng xanh mát, là nơi làm dịu mọi cơn khát và sự nóng bức. Khoác lên mình một chiếc áo kiêu xa lấp lánh bởi các tia nắng mặt trời chiếu rọi,hồ nước như một dải lụa mềm mại, điểm xuyến cho vẻ đẹp đầy cám dỗ của khu vườn địa đàng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Quả Lê- Hương giữa: Đậu Tonka- Hương cuối: Vanilla", 2, "[NEW] Jean Paul Gaultier La Belle Le Parfum EDP", "Pháp", 1800000m, 1800000m, 100, 2 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love is Love là một món đầy mật ngọt mà Dolce&Gabbana dành tặng cho tình yêu đôi lứa. Hương thơm Light Blue được làm mới với nguồn cảm hứng từ tình yêu, về lực hút mãnh liệt kéo đôi tim lại gần nhau hơn không chỉ qua lời nói, mà qua ánh nhìn, cử chỉ hay đơn giản chỉ là một dấu ấn định mệnh của tình yêu", " ✔️Mùi hương đặc trưng:Nhóm hương: Fruity FloralMùi hương chính: Chanh Sicily, Táo Granny Smith, Dâu đỏ, Kem gelato dâu, Hoa Nhài, Xạ Hương & Tuyết Tùng", 2, "Dolce&Gabbana Light Blue Love Is Love EDT (For Women)", "Pháp", 2040000m, 2040000m, 100, 2 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đắm mình trong hương thơm ấm áp đầy tinh tế của một vùng đất diệu kỳ chỉ tồn tại trong miền viễn tưỡng,Nomade Absolu vén màn tiết lộ một phiên bản mới mãnh liệt hơn được phát triển từ dòng Nomade nguyên bản.Được ra đời từ bàn tay tài hoa của Quentin Bisch – sáng tạo thơm Nomade Absolu tựa như một người phụ nữ độc lập và yêu sự tự do.", " ✔️Mùi hương đặc trưng:- Hương đầu: Mận Mirabelle- Hương giữa: Gỗ Đàn Hương Ấn Độ- Hương cuối: Rêu Sồi", 2, "Chloe Nomade Absolu de Parfum EDP", "Pháp", 2140000m, 2140000m, 100, 2 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chứa đựng sự nữ tính mềm mại nhưng xen lẫn đâu đó là tinh thần phiêu lưu phóng khoáng được truyền cảm hứng từ những chân trời xa xôivà những cuộc tao ngộ bất ngờ đầy xúc xảm - Chloé Nomade Eau de Parfum là một nốt hương gỗ hòa quyện với nét rạng rỡ của những đóa hoa.Sự mãnh liêt của Rêu Sồi được cân bằng hoàn hảo bởi sự hiện diện ngọt ngào mê đắm của Mận Mirablle và Lan Nam Phi nở rộ.", " ✔️Mùi hương đặc trưng:- Hương đầu: Mận Mirabelle- Hương giữa: Hoa Lan Nam Phi- Hương cuối: Rêu Sồi", 2, "Chloe Nomade EDP", "Pháp", 1920000m, 1920000m, 100, 2 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Urban Hero là sự gia nhập mới nhất từ Jimmy Choo cho dòng nước hoa nam.Bổ sung một hương thơm mới với cường độ và sự tương phản mạnh mẽ hơn những dòng trước đây để đề cao cương lĩnh của người đàn ông hiện đại.Một cái tôi nổi bật và không bị các định kiến xã hội gò bó, nghĩ như một nghệ sĩ và hành động như một người hùng.", " ✔️Mùi hương đặc trưng:- Hương đầu: Lemon Caviar, Black Pepper- Hương giữa: Rosewood, Vetiver- Hương cuối: Grey Amber, Leather Accord", 1, "Jimmy Choo Urban Hero EDP For Men", "Pháp", 1820000m, 1820000m, 100, 2 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), "c80c1f72-651a-4bd7-bc02-c8356a9cb852", "Manager role", "Manager", "Manager" },
                    { new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"), "220a6c5b-2c4f-4ac1-a87b-714b5af7e8df", "Staff role", "Staff", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "Image", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 6, null, "https://helpx.adobe.com/content/dam/help/en/photoshop/using/convert-color-image-black-white/jcr_content/main-pars/before_and_after/image-before/Landscape-Color.jpg", "Sixth Slide", 6, 2, "#" },
                    { 1, null, "https://www.gettyimages.pt/gi-resources/images/Homepage/Hero/PT/PT_hero_42_153645159.jpg", "First Slide", 1, 2, "#" },
                    { 2, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/212HEROES-Desktop_1560x600_40ae22ae-9303-4773-af47-796d63fff29d_1800x.jpg", "Second Slide", 2, 2, "#" },
                    { 3, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/JC-WebBanner-1560x600_1800x.jpg", "Third Slide", 3, 2, "#" },
                    { 4, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/LE_BELLE_LE_MALE_1560x600_7921449a-7a2c-4aba-b1cc-939576de9067_1800x.jpg", "Fourth Slide", 4, 2, "#" },
                    { 5, null, "https://cdn.shopify.com/s/files/1/0003/8718/6741/files/imgpsh_fullsize_anim_8_aa16529c-d632-45c7-89b0-35b1b5c81fee_1800x.jpg?v=1615517435", "Fiveth Slide", 5, 2, "#" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), new Guid("1c856746-f8aa-4026-b854-f18da9787cf3") },
                    { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4") },
                    { new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"), new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"), 0, "cd7c5a7b-7a77-4139-aa3b-ad50ebd2140c", new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tranphuong18032001@gmail.com", true, false, null, "Thu Phương", "Tranphuong18032001@gmail.com", "tranphuongmanager", "AQAAAAEAACcQAAAAEEBUaHrc8echflL1apfp/tSB0EXUNUHoePnG3DCtsGIW0ijmcbwtCDmFfOCeJB6fZw==", null, false, "", false, "tranphuong" },
                    { new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"), 0, "e852bf1e-fd0f-4b57-979c-0cf32f739556", new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "tiendinhdev99@gmail.com", true, false, null, "Voi Bé Nhỏ", "tiendinhdev99@gmail.com", "manager", "AQAAAAEAACcQAAAAEP8+kCxAZkxjY3OKA/Ff+E8mfuB7mh5AFWNDz7Sg4Vdtxo8vPgiGYjWgfoD+8GtmFA==", null, false, "", false, "voibenho99" },
                    { new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"), 0, "5229cbac-a177-4e08-95f5-7e229f491816", new DateTime(2001, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haianh@gmail.com", true, false, null, "Hải Anh", "Haianh@gmail.com", "haianhmanager", "AQAAAAEAACcQAAAAELCvbDnVFtizYmnAoe8CHRUp//5+uWAm7uo6GVSW0dVRr6uwBolFIyK4Th0axAZ0kA==", null, false, "", false, "haianh" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CancelReason", "CartId", "ClientId", "Note", "OrderDate", "Price", "ShipAddress", "ShipEmail", "ShipName", "ShipPhoneNumber", "Status" },
                values: new object[,]
                {
                    { 1, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1200000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 3 },
                    { 73, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 4160000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 72, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1980000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 5 },
                    { 71, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2030000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 3 },
                    { 70, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 5060000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 69, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 6720000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 68, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 2120000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 67, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 2590000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 66, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2040000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 65, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1910000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 64, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 1970000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 63, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 2120000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 1 },
                    { 62, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 2220000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 5 },
                    { 61, null, null, new Guid("ec888d8f-2c97-4d10-b9a5-e7dfab9a82b7"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2720000m, "Thọ Xuân - Thanh Hóa", "minhanh@gmail.com", "Minh Anh", "0978563732", 3 },
                    { 60, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 2450000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 59, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 2200000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 58, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 2200000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 57, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 2800000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 56, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2950000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 55, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2450000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 54, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2350000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 53, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 2850000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 1 },
                    { 74, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2190000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 75, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2030000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 76, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2860000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 77, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 7750000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 100, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 1360000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 99, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1350000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 98, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 1380000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 97, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 1180000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 96, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2200000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 95, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 950000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 94, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 1200000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 93, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 1700000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 1 },
                    { 92, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1380000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 5 },
                    { 91, null, null, new Guid("e2123170-2dbc-4e43-9477-d0be0f352d21"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1250000m, "Phường Phúc Lợi - Quận Long Biên - Hà Nội", "dinhtrong@gmail.com", "Đình Trọng", "0985638888", 3 },
                    { 52, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 2380000m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 5 },
                    { 90, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 2100000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 88, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 800000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 87, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 1100000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 86, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1800000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 85, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2100000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CancelReason", "CartId", "ClientId", "Note", "OrderDate", "Price", "ShipAddress", "ShipEmail", "ShipName", "ShipPhoneNumber", "Status" },
                values: new object[,]
                {
                    { 84, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2550000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 83, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 1100000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 82, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1300000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 5 },
                    { 81, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1550000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 3 },
                    { 80, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 2780000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 79, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2780000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 89, null, null, new Guid("79a378f7-34c1-4403-88bb-791d585df9aa"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 2800000m, "Phường Cầu Dền - Quận Hai Bà Trưng - Hà Nội", "xuantruong@gmail.com", "Xuân Trường", "0987546666", 1 },
                    { 51, null, null, new Guid("0199e987-8be3-4b1a-876d-a638d24cc910"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1387500m, "Hoằng Hóa - Thanh Hóa", "hoangchung@gmail.com", "Hoàng Chung", "0963258741", 3 },
                    { 78, null, null, new Guid("01940aef-917e-4f1f-8c06-38459dbcaa0c"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 2780000m, "Phúc Hòa - Tân Yên - Bắc Giang", "Congphuong@gmail.com", "Công Phượng", "0987456321", 1 },
                    { 49, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 1645000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 22, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 2360000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 21, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 3000000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 20, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 1930000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 19, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 2420000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 18, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 7140000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 17, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 2910000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 16, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2150000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 15, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2490000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 14, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2670000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 12, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 2150000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 5 },
                    { 11, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2030000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 3 },
                    { 10, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 1600000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 9, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 1700000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 8, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 2800000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 7, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 1200000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 6, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2200000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 5, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 5, 26, 11, 19, 12, 0, DateTimeKind.Utc), 2200000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 4, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2400000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 3, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 500000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 1 },
                    { 2, null, null, new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1400000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "tiendinhdev99@gmail.com", "Voi be nho", "0984869201", 5 },
                    { 50, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 1387500m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 23, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2050000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 24, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2150000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 13, null, null, new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 3100000m, "8 167/521 Truong Dinh - Hoang Mai - Hai Ba Trung - Ha Noi", "test1234@gmail.com", "Do Tien Dinh", "0984869201", 1 },
                    { 26, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1920000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 48, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1890000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 25, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1920000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 47, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 2520000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 46, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 2520000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 45, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 990000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 44, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 1785000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 },
                    { 43, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 1260000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CancelReason", "CartId", "ClientId", "Note", "OrderDate", "Price", "ShipAddress", "ShipEmail", "ShipName", "ShipPhoneNumber", "Status" },
                values: new object[,]
                {
                    { 42, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1470000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 5 },
                    { 40, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1980000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 39, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 2050000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 38, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 2650000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 37, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 1920000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 41, null, null, new Guid("48347449-050f-4630-946a-cf41446d89c8"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 990000m, "Đan Phượng - Hà Nội", "vananh@gmail.com", "Tran Van Anh", "0323456743", 3 },
                    { 36, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1920000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 35, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 21, 9, 12, 20, 0, DateTimeKind.Utc), 1920000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 34, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 5, 19, 10, 19, 20, 0, DateTimeKind.Utc), 2140000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 33, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 3, 19, 12, 14, 21, 0, DateTimeKind.Utc), 2040000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 32, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 24, 7, 41, 12, 0, DateTimeKind.Utc), 1820000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 1 },
                    { 31, null, null, new Guid("c12d5773-d956-4b10-a30e-ac80f459d411"), null, new DateTime(2021, 4, 21, 10, 19, 20, 0, DateTimeKind.Utc), 2150000m, "Chương Mỹ - Hà Nội", "haianh@gmail.com", "Le Hai Anh", "0358963245", 3 },
                    { 30, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 21, 12, 39, 26, 0, DateTimeKind.Utc), 2190000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 29, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 6, 2, 5, 42, 18, 0, DateTimeKind.Utc), 2120000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 28, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 4, 19, 12, 51, 32, 0, DateTimeKind.Utc), 1800000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 },
                    { 27, null, null, new Guid("599fab7f-0c58-412c-8de5-93cc9424c0fe"), null, new DateTime(2021, 6, 1, 7, 41, 12, 0, DateTimeKind.Utc), 2150000m, "Nguyễn Trãi - Thường Tín - Hà Nội", "tranphuong@gmail.com", "Tran Thu Phuong", "0378709602", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 41, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7226), 12345L, "41-Coach-Flora- EDP.jpg", true, 41, 41 },
                    { 80, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7283), 12345L, "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg", true, 80, 80 },
                    { 42, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7227), 12345L, "42-Coach-Men-EDT.jpg", true, 42, 42 },
                    { 43, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7228), 12345L, "43-Coach-Men-Platinum-EDP.jpg", true, 43, 43 },
                    { 79, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7282), 12345L, "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg", true, 79, 79 },
                    { 78, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7281), 12345L, "78-79-80-Burberry-Mr.Burberry-Indigo-EDT.jpg", true, 78, 78 },
                    { 47, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7234), 12345L, "47-Holiday-Gift-Set-Coach-Dreams-EDP.jpg", true, 47, 47 },
                    { 45, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7231), 12345L, "45-Coach-New-York-Floral-Blush-EDP.jpg", true, 45, 45 },
                    { 46, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7232), 12345L, "46-Gift-Set-Coach-Dreams.jpg", true, 46, 46 },
                    { 40, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7224), 12345L, "40-[NEW]-Jean-Paul-Gautier-Le-Male-Le-Parfum-EDP.jpg", true, 40, 40 },
                    { 44, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7230), 12345L, "44-Coach-Men-Platinum-EDP.jpg", true, 44, 44 },
                    { 81, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7285), 12345L, "81-Coach-Man-Blue.jpg", true, 81, 81 },
                    { 32, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7211), 12345L, "32-Jimmy-Choo-Urban-Hero-EDP-For-Men.jpg", true, 32, 32 },
                    { 38, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7221), 12345L, "38-[NEW]-Paco-Rabanne-1-Million-Parfum-EDP-For-Men-2020.jpg", true, 38, 38 },
                    { 82, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7286), 12345L, "82-Coach-Dreams-EDP.jpg", true, 82, 82 },
                    { 37, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7219), 12345L, "37-Chloe-Love-Story-EDP.jpg", true, 37, 37 },
                    { 36, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7218), 12345L, "36-Chloe-Signature-EDP.jpg", true, 36, 36 },
                    { 83, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7288), 12345L, "83-Coach-Floral-Edp.jpg", true, 83, 83 },
                    { 35, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7217), 12345L, "35-Chloe-Nomade-EDP.jpg", true, 35, 35 },
                    { 34, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7215), 12345L, "34-Chloe-Nomade-Absolu-de-Parfum-EDP.jpg", true, 34, 34 },
                    { 84, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7291), 12345L, "84-Coach-new-york-edp.jpg", true, 84, 84 },
                    { 33, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7213), 12345L, "33-Dolce&Gabbana-Light-Blue-Love-Is-Love-EDT-(For Women).jpg", true, 33, 33 },
                    { 85, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7292), 12345L, "85-COACH-Men-EDT.jpg", true, 85, 85 },
                    { 77, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7279), 12345L, "77-Burberry-Combo-My-Burberry-Black-EDP-Mr.Burberry-EDP.jpg", true, 77, 77 },
                    { 31, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7210), 12345L, "31-[NEW]-Jimmy-Choo-I-Want-Choo-EDP.jpg", true, 31, 31 },
                    { 39, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7223), 12345L, "39-Carolina-Herrera-Bad-Boy-EDT.jpg", true, 39, 39 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 48, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7235), 12345L, "48-Gift-Set-Coach-Men-Blue-EDT.jpg", true, 48, 48 },
                    { 64, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7261), 12345L, "64-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP.jpg", true, 64, 64 },
                    { 76, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7278), 12345L, "76-Burberry-My-Burberry-Blush-EDP.jpg", true, 76, 76 },
                    { 30, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7208), 12345L, "30-[New]-Gucci-Bloom-Profumo-Di-Fiori-EDP.jpg", true, 30, 30 },
                    { 66, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7263), 12345L, "66-Dolce&Gabbana-Light-Blue-Love-Is-Love-EDT.jpg", true, 66, 66 },
                    { 68, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7266), 12345L, "68-Dolce&Gabbana-The-One-For-Men-EDP.jpg", true, 68, 68 },
                    { 65, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7262), 12345L, "65-Dolce&Gabbana-Light-Blue-Pour-Homme-Love-is-Love-EDT.jpg", true, 65, 65 },
                    { 69, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7267), 12345L, "69-Dolce&Gabbana-Combo-The-Only-One-EDP-Intense-The-One-For-Men-Intense-EDP.jpg", true, 69, 69 },
                    { 63, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7257), 12345L, "63-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP.jpg", true, 63, 63 },
                    { 62, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7256), 12345L, "62-Dolce&Gabbana-The-One-For-Men-Intense-EDP.jpg", true, 62, 62 },
                    { 70, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7269), 12345L, "70-Dolce&Gabbana-Combo-Light-Blue-Intense-EDP-Light-Blue-Pour-Homme-Intense-EDP.jpg", true, 70, 70 },
                    { 61, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7254), 12345L, "61-Dolce&Gabbana-The-Only-One-EDP-Intense.jpg", true, 61, 61 },
                    { 60, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7253), 12345L, "60-Gift-Set-Paco-Rabanne-1-Million-EDT.jpg", true, 60, 60 },
                    { 71, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7271), 12345L, "71-Burberry-Her-EDP.jpg", true, 71, 71 },
                    { 59, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7252), 12345L, "59-Gift-Set-Lanvin-A-Girl-In-Capri-EDT.jpg", true, 59, 59 },
                    { 58, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7250), 12345L, "58-Gift-Set-Mercedes-Benz-Man-Intense-EDT.jpg", true, 58, 58 },
                    { 72, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7272), 12345L, "72.Burberry-Mr.Burberry-Element-EDT.jpg", true, 72, 72 },
                    { 57, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7248), 12345L, "57-Gift-Set-Coach-Dreams-EDP.jpg", true, 57, 57 },
                    { 56, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7247), 12345L, "56-Gift-Set-Coach-Dreams-EDP.jpg", true, 56, 56 },
                    { 73, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7273), 12345L, "73-Burberry-My-Burberry-Black-EDP.jpg", true, 73, 73 },
                    { 55, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7246), 12345L, "55-Gift-Set-Carolina-Herrera-212-VIP-Men-EDT.jpg", true, 55, 55 },
                    { 54, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7244), 12345L, "54-Gift-Set-Montblanc-Legend-EDP.jpg", true, 54, 54 },
                    { 74, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7275), 12345L, "74-Burberry-Mr. Burberry-EDP.jpg", true, 74, 74 },
                    { 53, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7242), 12345L, "53-Gift-Set-Carolina-Herrera-Bad-Boy-EDT.jpg", true, 53, 53 },
                    { 52, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7241), 12345L, "52-Gift-Set-Jimmy-Choo-Urban-Hero-EDP.jpg", true, 52, 52 },
                    { 75, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7277), 12345L, "75-Burberry-Her-London-Dream-EDP.jpg", true, 75, 75 },
                    { 51, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7239), 12345L, "51-[NEW]-Gift-Set-Jean-Paul-Gaultier-La-Belle-Le-Parfum-EDP.jpg", true, 51, 51 },
                    { 50, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7238), 12345L, "50-Paco-Rabanne-1-Million-Lucky-EDT-(For Men).jpg", true, 50, 50 },
                    { 49, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7236), 12345L, "49-Gift-Set-Coach-Men-Platinum-EDP.jpg", true, 49, 49 },
                    { 86, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7293), 12345L, "86-Coach-Men-Platinum-Edp.jpg", true, 86, 86 },
                    { 9, "Mercedes-Benz Select Night EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7168), 12345L, "9-Mercedes-Benz-Select-Night-EDP.jpg", true, 9, 9 },
                    { 93, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7304), 12345L, "93-Montblanc-Legend-EDP.jpg", true, 93, 93 },
                    { 17, "[New] Gucci Bloom Profumo Di Fiori EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7179), 12345L, "17-Gucci-Bloom-Profumo-Di-Fiori-EDP.jpg", true, 17, 17 },
                    { 92, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7302), 12345L, "92-Montblanc-Signature-EDP.jpg", true, 92, 92 },
                    { 16, "[New] Gucci Bloom Ambrosia Di Fiori EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7178), 12345L, "16-[New]-Gucci-Bloom-Ambrosia-Di-Fiori-EDP.jpg", true, 16, 16 },
                    { 15, "Gucci Bloom Acqua Di Fiori EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7177), 12345L, "15-Gucci-Bloom-Acqua-Di-Fiori-EDT.jpg", true, 15, 15 },
                    { 29, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7207), 12345L, "29-Dolce&Gabbana-K-By-Dolce&Gabbana-EDP-(For Men).jpg", true, 29, 29 },
                    { 14, "Gucci Flora By Gucci EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7175), 12345L, "14-Gucci-Flora-By-Gucci-EDP.jpg", true, 14, 14 },
                    { 13, "Gucci Guilty Pour Homme EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7174), 12345L, "13-Gucci-Guilty-Pour-Homme-EDP.jpg", true, 13, 13 },
                    { 94, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7305), 12345L, "94-Montblanc-Legend-Night-EDP.jpg", true, 94, 94 },
                    { 12, "Gucci Bloom Nettare EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7173), 12345L, "12-Gucci-Bloom-Nettare-EDP.jpg", true, 12, 12 },
                    { 11, "Gucci Bloom EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7171), 12345L, "11-Gucci-Bloom-EDP.jpg", true, 11, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "Caption", "DateCreated", "FileSize", "ImagePath", "IsDefault", "ProductId", "SortOrder" },
                values: new object[,]
                {
                    { 95, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7306), 12345L, "95-Montblanc-Bộ-Nước-Hoa-Mini.jpg", true, 95, 95 },
                    { 18, "Gucci Combo Flora By Gucci EDP + Guilty Pour Homme EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7181), 12345L, "18-Gucci-Combo-Flora-By-Gucci-EDP-Guilty-Pour-Homme-EDP.jpg", true, 18, 18 },
                    { 10, "[NEW] Mercedes-Benz Man Intense EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7170), 12345L, "10-[NEW]-Mercedes-Benz-Man-Intense-EDT.jpg", true, 10, 10 },
                    { 8, "Mercedes-Benz Le Parfum For Men EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7167), 12345L, "8-Mercedes-Benz-Le-Parfum-For-Men-EDP.jpg", true, 8, 8 },
                    { 7, "Mercedes-Benz Women EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7165), 12345L, "7-Mercedes-Benz-Women-EDT.jpg", true, 7, 7 },
                    { 97, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7309), 12345L, "97-Montblanc-Legend-Spirit-EDT.jpg", true, 97, 97 },
                    { 6, "Gift Set Mercedes-Benz The Move EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7163), 12345L, "6-Gift-Set-Mercedes-Benz-The-Move-EDT.jpg", true, 6, 6 },
                    { 5, "Gift Set Mercedes-Benz Man Intense EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7162), 12345L, "5-Gift-Set-Mercedes-Benz-Man-Intense-EDT.jpg", true, 5, 5 },
                    { 98, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7311), 12345L, "98-Montblanc-Lady-Emblem-Elixir-EDP.jpg", true, 98, 98 },
                    { 4, "Gift Set Mercedes-Benz Woman EDP", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7160), 12345L, "4-Gift-Set Mercedes-Benz-Woman-EDP.jpg", true, 4, 4 },
                    { 3, "[NEW] Mercedes-Benz On The Go", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7158), 12345L, "3-[NEW]-Mercedes-Benz-On-The-Go.jpg", true, 3, 3 },
                    { 99, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7312), 12345L, "99-montblanc-emblem-edp.jpg", true, 99, 99 },
                    { 2, "Mercedes Benz Women EDP (New 2020)", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7144), 12345L, "2-Mercedes-Benz-Women-EDP-(New 2020).jpg", true, 2, 2 },
                    { 1, "Mercedes Benz Man EDT", new DateTime(2021, 7, 11, 21, 47, 40, 967, DateTimeKind.Local).AddTicks(7062), 12345L, "1-Mercedes-Benz-Man-EDT.jpg", true, 1, 1 },
                    { 96, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7308), 12345L, "96-Montblanc-Legend-For-Men-EDT.jpg", true, 96, 96 },
                    { 91, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7301), 12345L, "91-Montblanc-Explorer-EDP.jpg", true, 91, 91 },
                    { 67, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7264), 12345L, "67-Dolce&Gabbana-The-Only-One-2-EDP.jpg", true, 67, 67 },
                    { 19, "Gucci Flora Gorgeous Gardenia EDT Limited Edition 2020", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7184), 12345L, "19-Gucci-Flora-Gorgeous-Gardenia-EDT-Limited-Edition-2020.jpg", true, 19, 19 },
                    { 25, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7201), 12345L, "25-Good-Girl-EDP.jpg", true, 25, 25 },
                    { 100, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7313), 12345L, "100-Montblanc-Emblem-EDT.jpg", true, 100, 100 },
                    { 23, "[NEW] Carolina Herrera 212 Heroes EDT", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7198), 12345L, "23-[NEW]-Jimmy-Choo-I-Want-Choo-EDP.jpg", true, 23, 23 },
                    { 89, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7298), 12345L, "89-coach-dream.jpg", true, 89, 89 },
                    { 22, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7196), 12345L, "22-[New]-Carolina-Herrera-Bad-Boy-Le-Parfum-EDP.jpg", true, 22, 22 },
                    { 26, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7202), 12345L, "26-Chloe-Love-Story-EDP.jpg", true, 26, 26 },
                    { 24, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7199), 12345L, "24-Chloe-Nomade-EDP.jpg", true, 24, 24 },
                    { 21, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7187), 12345L, "21-[New]-Carolina-Herrera-Very-Good-Girl-EDP.jpg", true, 21, 21 },
                    { 88, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7297), 12345L, "88-Coach-Dreams-EDP-Body-Lotion.jpg", true, 88, 88 },
                    { 27, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7203), 12345L, "27-[New]-Gucci-Bloom-Ambrosia-Di-Fiori-EDP.jpg", true, 27, 27 },
                    { 87, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7296), 12345L, "87-Coach-Floral-Blush-EDP.jpg", true, 87, 87 },
                    { 20, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7186), 12345L, "20-Gucci-Flora-Gorgeous-Gardenia-EDT-Limited-Edition-2020.jpg", true, 20, 20 },
                    { 28, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7205), 12345L, "28-[NEW]-Jean-Paul-Gaultier-La-Belle-Le-Parfum-EDP.jpg", true, 28, 28 },
                    { 90, "test", new DateTime(2021, 7, 11, 21, 47, 40, 968, DateTimeKind.Local).AddTicks(7300), 12345L, "90-Coach-Men-blue.jpg", true, 90, 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 10, 98 },
                    { 10, 96 },
                    { 9, 83 },
                    { 8, 71 },
                    { 10, 99 },
                    { 10, 97 },
                    { 7, 70 },
                    { 7, 68 },
                    { 9, 87 },
                    { 7, 69 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 9, 85 },
                    { 9, 84 },
                    { 10, 95 },
                    { 7, 67 },
                    { 10, 91 },
                    { 8, 78 },
                    { 9, 90 },
                    { 8, 80 },
                    { 8, 77 },
                    { 10, 92 },
                    { 8, 76 },
                    { 9, 89 },
                    { 10, 93 },
                    { 9, 81 },
                    { 8, 75 },
                    { 10, 94 },
                    { 8, 74 },
                    { 9, 82 },
                    { 9, 88 },
                    { 8, 73 },
                    { 8, 79 },
                    { 8, 72 },
                    { 9, 86 },
                    { 3, 25 },
                    { 7, 65 },
                    { 3, 30 },
                    { 3, 29 },
                    { 3, 28 },
                    { 3, 27 },
                    { 3, 26 },
                    { 3, 24 },
                    { 3, 23 },
                    { 3, 22 },
                    { 3, 21 },
                    { 2, 20 },
                    { 2, 19 },
                    { 2, 18 },
                    { 2, 17 },
                    { 2, 16 },
                    { 2, 15 },
                    { 2, 14 },
                    { 2, 13 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 2, 12 },
                    { 2, 11 },
                    { 1, 10 },
                    { 1, 9 },
                    { 1, 8 },
                    { 1, 7 },
                    { 1, 6 },
                    { 1, 5 },
                    { 1, 4 },
                    { 1, 3 },
                    { 1, 2 },
                    { 1, 1 },
                    { 4, 31 },
                    { 4, 32 },
                    { 4, 33 },
                    { 4, 34 },
                    { 7, 64 },
                    { 7, 63 },
                    { 7, 62 },
                    { 7, 61 },
                    { 6, 60 },
                    { 6, 59 },
                    { 6, 58 },
                    { 6, 57 },
                    { 6, 56 },
                    { 6, 55 },
                    { 6, 54 },
                    { 6, 53 },
                    { 6, 52 },
                    { 6, 51 },
                    { 7, 66 },
                    { 5, 50 },
                    { 5, 48 },
                    { 5, 47 },
                    { 5, 46 },
                    { 5, 45 },
                    { 5, 44 },
                    { 5, 43 },
                    { 5, 42 },
                    { 5, 41 },
                    { 4, 40 },
                    { 4, 39 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[,]
                {
                    { 4, 38 },
                    { 4, 37 },
                    { 4, 36 },
                    { 4, 35 },
                    { 5, 49 },
                    { 10, 100 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1200000m, 1 },
                    { 73, 73, 4160000m, 1 },
                    { 72, 72, 1980000m, 1 },
                    { 71, 71, 2030000m, 1 },
                    { 70, 70, 5060000m, 1 },
                    { 69, 69, 6720000m, 1 },
                    { 68, 68, 2120000m, 1 },
                    { 67, 67, 2590000m, 1 },
                    { 66, 66, 2040000m, 1 },
                    { 65, 65, 1910000m, 1 },
                    { 64, 64, 1970000m, 1 },
                    { 63, 63, 2120000m, 1 },
                    { 62, 62, 2220000m, 1 },
                    { 61, 61, 2720000m, 1 },
                    { 60, 60, 2450000m, 1 },
                    { 59, 59, 2200000m, 1 },
                    { 58, 58, 2200000m, 1 },
                    { 57, 57, 2800000m, 1 },
                    { 56, 56, 2950000m, 1 },
                    { 55, 55, 2450000m, 1 },
                    { 54, 54, 2350000m, 1 },
                    { 53, 53, 2850000m, 1 },
                    { 74, 74, 2190000m, 1 },
                    { 52, 52, 2380000m, 1 },
                    { 75, 75, 2030000m, 1 },
                    { 77, 77, 7750000m, 1 },
                    { 98, 98, 1380000m, 1 },
                    { 97, 97, 1180000m, 1 },
                    { 96, 96, 2200000m, 1 },
                    { 95, 95, 950000m, 1 },
                    { 94, 94, 1200000m, 1 },
                    { 93, 93, 1700000m, 1 },
                    { 92, 92, 1380000m, 1 },
                    { 91, 91, 1250000m, 1 },
                    { 90, 90, 2100000m, 1 },
                    { 89, 89, 2800000m, 1 },
                    { 88, 88, 800000m, 1 },
                    { 87, 87, 1100000m, 1 },
                    { 86, 86, 1800000m, 1 },
                    { 85, 85, 2550000m, 1 },
                    { 84, 84, 2550000m, 1 },
                    { 83, 83, 1100000m, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 82, 82, 1300000m, 1 },
                    { 81, 81, 1550000m, 1 },
                    { 80, 80, 2780000m, 1 },
                    { 79, 79, 2780000m, 1 },
                    { 78, 78, 2780000m, 1 },
                    { 76, 76, 2860000m, 1 },
                    { 51, 51, 1387500m, 1 },
                    { 50, 50, 1387500m, 1 },
                    { 49, 49, 1645000m, 1 },
                    { 22, 22, 2360000m, 1 },
                    { 21, 21, 3000000m, 1 },
                    { 20, 20, 1930000m, 1 },
                    { 19, 19, 2420000m, 1 },
                    { 18, 18, 7140000m, 1 },
                    { 17, 17, 2910000m, 1 },
                    { 16, 16, 2150000m, 1 },
                    { 15, 15, 2490000m, 1 },
                    { 14, 14, 2670000m, 1 },
                    { 13, 13, 3100000m, 1 },
                    { 12, 12, 2150000m, 1 },
                    { 11, 11, 2030000m, 1 },
                    { 10, 10, 1600000m, 1 },
                    { 9, 9, 1700000m, 1 },
                    { 8, 8, 2800000m, 1 },
                    { 7, 7, 1200000m, 1 },
                    { 6, 6, 2200000m, 1 },
                    { 5, 5, 2200000m, 1 },
                    { 4, 4, 2400000m, 1 },
                    { 3, 3, 500000m, 1 },
                    { 2, 2, 1400000m, 1 },
                    { 23, 23, 4100000m, 2 },
                    { 24, 24, 6450000m, 3 },
                    { 25, 25, 1920000m, 1 },
                    { 26, 26, 1920000m, 1 },
                    { 48, 48, 1890000m, 1 },
                    { 47, 47, 2520000m, 1 },
                    { 46, 46, 2520000m, 1 },
                    { 45, 45, 990000m, 1 },
                    { 44, 44, 1785000m, 1 },
                    { 43, 43, 1260000m, 1 },
                    { 42, 42, 1470000m, 1 },
                    { 41, 41, 990000m, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Price", "Quantity" },
                values: new object[,]
                {
                    { 40, 40, 1980000m, 1 },
                    { 39, 39, 2050000m, 1 },
                    { 99, 99, 1350000m, 1 },
                    { 38, 38, 2650000m, 1 },
                    { 36, 36, 1920000m, 1 },
                    { 35, 35, 1920000m, 1 },
                    { 34, 34, 2140000m, 1 },
                    { 33, 33, 2040000m, 1 },
                    { 32, 32, 1820000m, 1 },
                    { 31, 31, 2150000m, 1 },
                    { 30, 30, 2190000m, 1 },
                    { 29, 29, 2120000m, 1 },
                    { 28, 28, 3600000m, 2 },
                    { 27, 27, 2150000m, 1 },
                    { 37, 37, 1920000m, 1 },
                    { 100, 100, 1360000m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ClientId",
                table: "Carts",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCarts_ProductId",
                table: "ProductInCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCategories_ProductId",
                table: "ProductInCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCosmeticsCollections_CosmeticsCollectionId",
                table: "ProductInCosmeticsCollections",
                column: "CosmeticsCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInProductPrivateProperties_ProductPrivatePropertyId",
                table: "ProductInProductPrivateProperties",
                column: "ProductPrivatePropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ClientId",
                table: "Transactions",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductInCarts");

            migrationBuilder.DropTable(
                name: "ProductInCategories");

            migrationBuilder.DropTable(
                name: "ProductInCosmeticsCollections");

            migrationBuilder.DropTable(
                name: "ProductInProductPrivateProperties");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categoires");

            migrationBuilder.DropTable(
                name: "CosmeticsCollections");

            migrationBuilder.DropTable(
                name: "ProductPrivateProperties");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
