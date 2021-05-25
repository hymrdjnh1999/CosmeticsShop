using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    IsOutstanding = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEG0pFIc1MYwF9JU2qYAtE6DPX6D4M+OXwPziSsjN6+i5NPoL5VPfmJbQzJ+kELDDYQ==");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEMtquH6kvjt3x7kNdax+oEB+4waXbM7vcJiW2eTSNVirKIrCzIjjTop+7T+wVkywYg==");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "f232f462-4b0f-4dc6-9d92-063f6225f741");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "442ba90f-443c-4e39-b2ee-7edf46f0a3e0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bd3d883-4841-480a-9fcc-a7acedffaf3e", "AQAAAAEAACcQAAAAEL6Z3rjvsZHKqXmwG+E4yFPEq1VZgTYDUzLb1C05h039sYgKifPG3vnkvu7OR2iCbA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b258a6e-6d53-44c7-8ae2-93a7b857fb37", "AQAAAAEAACcQAAAAEAk1TJjSFeHC3dgD3JARuiY30KrrL8QfsFwirBP61d3nCy9kmcwq7poWgdLAUgPlkA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3998b63d-4a60-44db-8325-32610c647b54", "AQAAAAEAACcQAAAAEANCSl2lxsfzgcwDEFqgfXrumORdNRtZ4Qq+QCIqQik4lsrMg9Otj5MmlVM6kSRxMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("1d37e388-3c9d-490b-a0d1-93f20c4292b5"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEAKOl9bU+uX1XszoT50wla/2ITqC07GpG0k5e890WiRd2XZbh+nee/uTHBHKnMKJSA==");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                column: "Password",
                value: "AQAAAAEAACcQAAAAEHJcCQujbiXJr4bDtv0/lA8bJQhFAHualsCoVEYBrKahM8onMQ7psFngYehqAic2rw==");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "87c300be-526e-4b65-97a7-9c38177482ae");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "916ccfd5-913c-4c46-b311-84e983b95b61");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d268db21-ede6-4c86-b9e3-4a12f42d9d42", "AQAAAAEAACcQAAAAEG/UNqj8wLz1xnlhsYXH5bH9H9E2kDELabv/SpWAhlpRwX8ZA2mf6QZieysDlZEWaQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c9d80984-8c84-44e0-8f1d-27b58494dd69", "AQAAAAEAACcQAAAAEAKXp7O6A0s1JDmfH7Yms9qKDQX9MnVoMH9vZPMk4DhVx36bn+kONbekGkoBAqkHiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6273ad1-ca15-4aca-a5be-4029d59fe4bf", "AQAAAAEAACcQAAAAEEJW8BkCehMhF5WcAa3tBFZcYVgMRNmjFFouH0GfMxELa+U6ypOhNxdZcQlQqcC4ew==" });
        }
    }
}
