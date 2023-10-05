using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class add_total : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1358d85e-96c7-4088-b888-33473944a7e4", "AQAAAAIAAYagAAAAEK1dDSFHe22bvrV9qWMjToc8TinqWNnNly+0OIc9uq247lzwrPIyVX87WzUd9mWlnA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 10, 4, 19, 2, 31, 652, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 10, 4, 19, 2, 31, 652, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "47318cc2-6ca8-462d-93fe-7e51bbeadee6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82845dd1-7815-4cf6-8835-b8e183657f24", "AQAAAAEAACcQAAAAEKn9anzuuBawSYhKBzJscMSkBcweStavqPUV6bxXcynbEeA4LeugIaAJT9WfNQIGog==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 21, 14, 17, 37, 586, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 9, 21, 14, 17, 37, 586, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AppUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
