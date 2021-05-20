using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class addclients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Address", "Avatar", "Dob", "Name", "PhoneNumber", "Status" },
                values: new object[] { new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"), "8 Nghách 167 ngõ 521 Trương Định - Hoàng Mai - Hà Nội", "", new DateTime(1999, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voi Bé Nhỏ", "0984869201", 2 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d931d-a8fe-493c-88d1-2a8a9e1bb9b7"),
                column: "ConcurrencyStamp",
                value: "1d55f1a7-8bad-4b60-8c29-65ed46899e0e");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "4507ef99-385c-4476-ba68-b90870cc38ca");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "ec09579e-75c5-46d2-b6db-c9b994822440");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad80d4e0-dd10-40fd-b982-66736a6a208b", "AQAAAAEAACcQAAAAEH8b1iPh6K7ON1Nloyc2YIb4nubHUuc9PDnpoGedXUeS4ccuPuWvLaqzYVqdu3uWmg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b86e3f2b-5f97-44a5-b9a9-f63683c64d5f", "AQAAAAEAACcQAAAAEMYBoxeSeL6O8uXj5Ve5V5jI+36GaMlKlU8ITu7K+kxC4bpGYyZyWhJXN4Tz0SNAlQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a20ef3c-3d7f-453e-92d7-8919ffaf2df4", "AQAAAAEAACcQAAAAEBqXm2spbOAw/gGE8dD/o9iJlKh6FwetNdlt3SJZyfA3la11p6k/IkCmU9P17mPaww==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1217628f-6289-4f86-8597-bb9e2a6be451", "AQAAAAEAACcQAAAAECEeAC3PiQZMbQp6mi+VvWZ4S7FeXaCREyC8VZxncupJEv4pscWDpFhyu+qo4KhKgQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d931d-a8fe-493c-88d1-2a8a9e1bb9b7"),
                column: "ConcurrencyStamp",
                value: "390d375f-b7b7-4e5c-9728-9b2bfdd41336");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "e4b467bf-3951-44c9-8b2e-91a6ae905c44");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "4cc7a1a5-c9b9-4af4-9f70-529e19cb5b01");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c21f5ba-e878-4e6d-bed2-1be45e9700bf", "AQAAAAEAACcQAAAAEDpSgiwvT7VFYJiDFlU+cf45OCHrNkwmxWqiY58VRG5+0dXnyYeFdUcEywPZh2mbzQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f620168-34e8-4de9-82af-60331af2b2a8", "AQAAAAEAACcQAAAAEPsucka3mb9aw27qJjWBHXOFhEhuaYE43OoRVkEk0Z2pDKJN8IV/q6D6UYDn7wJ4CA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1ec46b3-8481-43f9-bb8f-8cf9ec4524bc", "AQAAAAEAACcQAAAAEB7NSV8CvO9JJo7camSdc5SngdrtrkufsH00MdPfYMj3Qi7RN2T793j+XVryt3bi0Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcc9fbb0-0ccd-4a4f-8bc6-b8fc43f19b4c", "AQAAAAEAACcQAAAAENGU/s2h/H6PU9g70t70VaHqX0MSyRaEglmrkvuTllVrgRIzl/+aENtOtySVm1/gaQ==" });
        }
    }
}
