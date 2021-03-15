using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class UpdateProductConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OriginalCountry",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ForGender",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "909798c2-5ca6-4b9f-a289-36611de58768");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "5e8e61dc-eb3c-4067-95d2-05b2bb8a7eb4");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fde776b-796e-42c8-a6c0-2a21569b506b", "AQAAAAEAACcQAAAAEA1vnYR4P5m6imi88fbB+uqi+6+V0sIYHqACieE/8mUTbiWOjZPt+K7ycWHGTIDD8A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de749130-df3e-45d6-9c64-a03014bf428a", "AQAAAAEAACcQAAAAEPkUNRsipcPRJH/8e7RMx+RUDWST8il2d7CTewdqRjrVpCDPVl5Qyy0tLB8fUX+MDQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae246d4c-7259-4009-a7b7-eab9f574a3f7", "AQAAAAEAACcQAAAAEB7ptQd84hOYN5DDZUQE6w3zo2TUlYH8Hhu7+gsqRwzsXCBLvmspS2r75qfduICguQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OriginalCountry",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ForGender",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
