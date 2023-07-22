using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class SeedIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 23, 0, 17, 55, 29, DateTimeKind.Local).AddTicks(2550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 23, 0, 15, 47, 668, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "f5229b47-aa2c-494a-8c36-730afd8d896b");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "55759562-cf0a-4734-b798-cbf7b9c31dac", "AQAAAAEAACcQAAAAEMmFluCwE9dqLMn3cZZX3Z7BpAiqmt5pZcUhgBziyA/PQmDCBqmkB8OmwOtSnkanQQ==" });

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
                value: new DateTime(2023, 7, 23, 0, 17, 55, 40, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 23, 0, 17, 55, 40, DateTimeKind.Local).AddTicks(6320));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 23, 0, 15, 47, 668, DateTimeKind.Local).AddTicks(479),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 7, 23, 0, 17, 55, 29, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "b1789b42-8444-4feb-b6ca-88b671237eb3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bd2044d-f8fc-4d95-96ae-6cb36aedac85", "AQAAAAEAACcQAAAAEHo75MLnWLzEWgfnAapRyssxh+ANHCZhAYQWp75caS8bqlOZuKAeYB9IHFk7e/NgZw==" });

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
                value: new DateTime(2023, 7, 23, 0, 15, 47, 679, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 7, 23, 0, 15, 47, 680, DateTimeKind.Local).AddTicks(709));
        }
    }
}
