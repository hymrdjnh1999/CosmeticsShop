using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CosmeticsShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banner",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d931d-a8fe-493c-88d1-2a8a9e1bb9b7"),
                column: "ConcurrencyStamp",
                value: "2d3f1eae-0dc6-410a-bf50-cf2a218d8aa8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "0bbc6d80-77e5-4a33-8561-7aa2c49821f8");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "b5481d54-c02b-4c06-ac10-4ab7062507e1");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "832e071d-96ef-41ad-b9e2-cbc9d0b19195", "AQAAAAEAACcQAAAAEA17WEhjSwii6H7mjFOciv6F5G0XrH9n4uiS5wkuSX7q7JKd+Ku5yfFgxF5OUOMIxA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5054521b-42d5-4784-a438-e19f88943de5", "AQAAAAEAACcQAAAAEMYCt33hQcXPOwUaY6rzacfxu6Nmg0qgg8pOEPqYDWwkX2Qk+MLhbV/G8sNCOtBEQA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6aaf012e-6da9-4dd7-b436-f6947c6b8c76", "AQAAAAEAACcQAAAAEM4VaOD+up8JVOGtHWxCd/Wh6+fyteqR04sCkn+2/QnEsx7DlJBzkcKiYoTeX9m91g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47fa8fe1-eb00-4e61-a11c-38a9404fe60a", "AQAAAAEAACcQAAAAEMDLE2jEUrhOl2q54k+Y60ar+hpVN5lzyO1tnmYa7/aBbG+w8FxsYvlwA80wlrIGCw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banner",
                columns: new[] { "Id", "DateCreated", "Description", "FileSize", "ImagePath", "IsDefault", "SortOrder" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "M", 0L, "", false, 0 });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8c6d931d-a8fe-493c-88d1-2a8a9e1bb9b7"),
                column: "ConcurrencyStamp",
                value: "665f2ee8-69d4-44ea-8673-1dbee9d1e05c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bd5b83d2-5c75-4f96-a63f-1eca425bdfe5"),
                column: "ConcurrencyStamp",
                value: "0953316d-f845-4158-a980-2d87b9f9635a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("efebfd93-b27d-4c91-8a71-74fd71944893"),
                column: "ConcurrencyStamp",
                value: "135f23e9-182f-4524-b24d-5be9aa93e8c8");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c856746-f8aa-4026-b854-f18da9787cf3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "815d1e53-48f5-4eee-8c9c-ffc596824ac1", "AQAAAAEAACcQAAAAEGxM70Uz2sIHM27chSvgQhtEcpd5LIuFBPt7vyUNAQQ9Hwb4msATkvlfFAdRlDW65A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33674f31-0bd2-43cd-9090-3f0d4bab1c58"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90964e12-cd4e-4652-815c-bb1a0cc3050c", "AQAAAAEAACcQAAAAEH6w9arqlhL+lQbKVM899zfCm5r20catUNnbMl0qK7cocQSdH3ftwmVP2FzLm+LRag==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94c14234-d9b7-4a8b-91c8-68b53378fe6b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6c98520-0c71-4418-9052-0dfe44a7540b", "AQAAAAEAACcQAAAAEHkKnXmGFFuPw2AmaFkuLhgPQ9E9a9jd+dXCCtdF0um/lvdQYhWuCtPUemXaXnRpJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d8b63b91-c360-4e3d-9b3a-2dce31f00cc4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb2678ee-d427-4f3b-8ee0-9dcd84f1153f", "AQAAAAEAACcQAAAAEFSjajmQ0SwmpT3Kvo1CIFAkzsXwbjK3Io8pw+nZ/QNiOQhz3F+YsK8Y+zvkTtiLwQ==" });
        }
    }
}
