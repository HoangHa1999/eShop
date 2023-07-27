using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "20b2516f-e399-48bd-a386-5aacff40e530");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f23cf42-f4d8-4b0a-808d-ad191cd814e9", "AQAAAAEAACcQAAAAECN9elb+i7LNUX8PxUYf/ZO0qylVb7YkXbIGDwVpP1Db4duhWv2OaU3R4j7qmPcsrg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 27, 14, 23, 36, 164, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 27, 14, 23, 36, 165, DateTimeKind.Local).AddTicks(5360));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "f593e48d-fa43-40e9-a77d-ede90dad2de8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "890a36f9-32e0-46fa-9962-ddaf8e491093", "AQAAAAEAACcQAAAAEFcRRGWgjgmKlVJ4mVwlucqzaHQNwIyLoIzIxIFGUQNOzs6eYyC45M9g552LKhtfBQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 7, 27, 14, 21, 46, 67, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 27, 14, 21, 46, 68, DateTimeKind.Local).AddTicks(3761));
        }
    }
}
