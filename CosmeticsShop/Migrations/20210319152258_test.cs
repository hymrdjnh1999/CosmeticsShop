using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "cd3441e8-0349-4c78-a4fa-785fe0a8bf10");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "ca9eddff-bc93-4a4e-abd2-a62015ab4451");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7edba172-af46-44ac-a3fd-437a81205006", "AQAAAAEAACcQAAAAEHgI5k6PDoZ9OEhTIwwLDd4qVKpj1BMA5DXhZdDmaCtK4JGw72w9ilNZsysD6SO3cQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8fe2fa82-6aac-473a-889a-dfd3bdcff507", "AQAAAAEAACcQAAAAECXnOfgweEW2jGLgPhQmkFKEcLTs0K7L43hGOD8fbsBvbyBVQ7vLa4TGj8N9D9FHXA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "684e986c-0606-43c3-8536-728743807b65", "AQAAAAEAACcQAAAAEPWnHAf3zCh3DklIacSr7S1gJNxDVuUB0E87pgVWPnx9ax5ckiTLvJjHWsQobKN5hQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "0031e2bb-5ced-4e9a-b2a2-1589fc41ba60");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "420a1da9-2a27-42ee-83a7-520781142c1c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa57b8ba-9824-4418-bc10-6667b1aaecb7", "AQAAAAEAACcQAAAAEI5bc9VFRYL7cpJ4oa6SH9s/lR/pBsBZxYXkqEGaODYAtLQB7UoqFc9b8OMkOIhg2w==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd44ff93-7c09-40e5-8d1f-00eb90ac2644", "AQAAAAEAACcQAAAAEFFh//No9N9w7UpI19hC+DOPi4DIGba0O80k2paYJsDbY2CfpZ7fRYWaPrM/2JoPEQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5d4af9c4-b698-4ad3-b81b-ccb5607cc778", "AQAAAAEAACcQAAAAEGy9S0HzCpns1TuYOMysmnZIbqbzE5h+/rn1wZdPJ1SYwZikwTmn+rIc3cR5BX0bAA==" });
        }
    }
}
