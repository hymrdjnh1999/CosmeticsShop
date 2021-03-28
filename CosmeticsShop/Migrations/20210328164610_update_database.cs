using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class update_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"), new Guid("1c856746-f8aa-4026-b854-f18da9787cf3") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "f9cd7c94-1f45-4c9e-8807-d8d579be77c0");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), "4de5aa0b-c98a-41d2-9eda-94520df98054", "Supper Administrator role", "SupperAdmin", "SupperAdmin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), new Guid("1c856746-f8aa-4026-b854-f18da9787cf3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e8d34ec-acdc-41de-937c-332b060bf4e3", "AQAAAAEAACcQAAAAEJyRlu+KLy6ZxwZlZhQj3KjSejS+YU076oiWLmoVe9z96icyw/H/Xwnf9+j0KXYA1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92cd2e22-a448-4a27-899d-4ebe3978515e", "AQAAAAEAACcQAAAAEA8yUHLyoAnFpQyfnsa4Vbtl3kFWY49WRhCZ3xDtJWUf+mn/LfDuAEWFxLYHGzw+YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68e93100-14e1-4c35-afee-2d0c3678f837", "AQAAAAEAACcQAAAAEOcR0Y7wFBhhItGDE5ZutCzoel9WsykQtJ8BPLnpauTLxS6QxLct7mxKxaTtGmtrvg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"), new Guid("1c856746-f8aa-4026-b854-f18da9787cf3") });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "71935b9e-d551-448f-ba3c-9733ddd1ef61");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"), new Guid("1c856746-f8aa-4026-b854-f18da9787cf3") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "427359cc-e91b-4e9b-a1b6-71ca4bfe26dc", "AQAAAAEAACcQAAAAEFSkPHy0HdWU1mji0dJzy/tOveDIySo7P1pODVnXH+RKhTe/BaOLb2ZGr9C+ffTbvw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf860b62-f9fc-495a-8df8-ee9782961bc6", "AQAAAAEAACcQAAAAEDk0kAeUKg5y3Hn5cppVEMHCOj/UZSIkYAwyZvB4C7X8meVDpCeMw9ruw/4Hiv8gnQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c02ca85-97a9-4901-b9ea-8b2127c16de3", "AQAAAAEAACcQAAAAENmNofpIuHsacbVqnR3TeJ016klM8SssUlXgt48Fg9UiWDQ9ISgyCEo8h+v/FC5u/w==" });
        }
    }
}
