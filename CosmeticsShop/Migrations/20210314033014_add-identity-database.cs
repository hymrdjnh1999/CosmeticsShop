using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class addidentitydatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "3cc27152-cf30-430d-a3ca-059236a34f65");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"), "1379cfed-0014-45da-9c59-d40311f2412b", "Administrator role", "Admin", "Admin" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "127ae50a-87aa-46ce-b3c4-133eb88acc32");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3117e515-aca4-4ab1-a2bc-4450d661f99f", "AQAAAAEAACcQAAAAEBBUkXyhTi8R1uak6kG4lyYPQBeYavuNgaNP0vOfeN8+s4onp5U6KDqnphrfJH7afw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce211425-e712-4851-b919-fd207643d91d", "AQAAAAEAACcQAAAAEFIGlw6iIwgFuMBLlKI1bqJNZRMAjCZj1kLvLL/0M06PY+2aKgusEZeTJiwpYdZGUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14bd837b-bc86-4a31-8075-55de046b7caa", "AQAAAAEAACcQAAAAEKgTpx7Kb8tIdSd6+yTu6zKoWpFzsWBkTQCqgjEoVNZlk0VEyCVqrQLn0aI/5r8m9w==" });
        }
    }
}
