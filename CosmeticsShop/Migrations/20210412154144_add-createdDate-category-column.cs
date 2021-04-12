using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class addcreatedDatecategorycolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOutstanding",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ForGender",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Categoires",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "072cf013-5349-4b69-8929-b0d3f91df4f6");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "1fc06b7e-5cd4-4204-83df-dcc964467a72");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1e9b185-569c-4397-8ded-0f62a26217a0", "AQAAAAEAACcQAAAAEAjmoeVtAYxkzjnTeJ0Fj4DRFeMtKf4HvZnRkm3zYrx5BJ65zk7ZX49vm4y5RaBleQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08b8a1e1-bb00-439a-9b85-40b50de65208", "AQAAAAEAACcQAAAAEJI6FeiqqyRKT2Cc0cSFZ4MnMfdXjsZhx/8P+jXGvwLRXlVkjIZJ3ADGTG3lxAOlSQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4496ffbc-2af9-4667-a270-75c66127a910", "AQAAAAEAACcQAAAAEFZF8bdJghXkch6LluWVYxtzpIenpAKF9QbmwuHrLRe4I/mL4McaXP3SwMIKKDSLFA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categoires");

            migrationBuilder.AlterColumn<int>(
                name: "ForGender",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsOutstanding",
                table: "Products",
                type: "bit",
                nullable: true);

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
    }
}
