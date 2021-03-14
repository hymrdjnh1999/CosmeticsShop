using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class addprocessImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "95aeb2cf-0f52-4ace-b63d-70537ee47c6a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "73ee175b-ea56-4c0b-b143-f2fd9d71dcf3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32d53a31-116d-42c7-a686-0ab5f937190c", "AQAAAAEAACcQAAAAEHq+VSDYXr+zGSJ3gbaqECtAVEO1XcEjagMbmPRU+4mw3+1ReTY1GMO/uXZ3PKJUZg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c56a1446-887d-46d1-be0c-f5e5a0047f54", "AQAAAAEAACcQAAAAEJeSwadcpFj/aB7nD88roni5BANJwpph/FqlS/WGT/wfKUfNlncyarwzJC1mCT4Amw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "288d8177-e603-4359-8082-8d07dbd6d2f0", "AQAAAAEAACcQAAAAEKqsvFhZKKxD2aXaOfRGwrooLZygMxoMClrpuxJzEtUyFLqA1wN/P7VTvPdHi0xB4g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
