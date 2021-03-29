using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class updaterolename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "570caf57-342a-4f51-9e09-99dd6ebff9b3", "Manager role", "Manager", "Manager" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "81393339-f8a0-4ad4-9fbe-3035f1f17cdf", "Customer role", "Customer", "Customer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "ecc7ac8b-2ee6-445e-9a8b-1f3aeaf46add", "manager", "AQAAAAEAACcQAAAAEPTpF7k+xuuDGnW/qtGw2ds1JpPTameECcR9OUF2FcN0/YkNBkc1CpreW1Gnj7opsw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "1a2430c2-17f9-4216-ab58-bc41408f5c43", "tranphuongmanager", "AQAAAAEAACcQAAAAECRsmKtaJFUIg6+Rf9oegjAOrbtc3XHZZ+e67DTD+BPG8Sd7YpzmCrbDElskM0Ix1w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "cb45fbbd-3214-4462-a853-4897def689a2", "haianhmanager", "AQAAAAEAACcQAAAAEAEg1EK+92A6m95Nhlv3mEt4uasjs5hLrcdussyQi0JnwibsTTq+LG3MAHNTA+yjrA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "4de5aa0b-c98a-41d2-9eda-94520df98054", "Supper Administrator role", "SupperAdmin", "SupperAdmin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                columns: new[] { "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "f9cd7c94-1f45-4c9e-8807-d8d579be77c0", "Administrator role", "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "2e8d34ec-acdc-41de-937c-332b060bf4e3", "admin", "AQAAAAEAACcQAAAAEJyRlu+KLy6ZxwZlZhQj3KjSejS+YU076oiWLmoVe9z96icyw/H/Xwnf9+j0KXYA1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "92cd2e22-a448-4a27-899d-4ebe3978515e", "tranphuongadmin", "AQAAAAEAACcQAAAAEA8yUHLyoAnFpQyfnsa4Vbtl3kFWY49WRhCZ3xDtJWUf+mn/LfDuAEWFxLYHGzw+YQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "68e93100-14e1-4c35-afee-2d0c3678f837", "haianhadmin", "AQAAAAEAACcQAAAAEOcR0Y7wFBhhItGDE5ZutCzoel9WsykQtJ8BPLnpauTLxS6QxLct7mxKxaTtGmtrvg==" });
        }
    }
}
