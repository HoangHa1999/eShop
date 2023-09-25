using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Data.Migrations
{
    public partial class HomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Url = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 200, nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.Id);
                });

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
                value: new DateTime(2023, 9, 21, 14, 17, 37, 586, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 9, 21, 14, 17, 37, 586, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.InsertData(
                table: "Slides",
                columns: new[] { "Id", "Description", "Image", "Name", "SortOrder", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", "/img/carousel-1.jpg", "Men-US Fashion", 1, 1, "#" },
                    { 2, "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", "/img/carousel-2.jpg", "Women-US Fashion", 2, 1, "#" },
                    { 3, "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", "/img/carousel-3.jpg", "Kids Fashion", 3, 1, "#" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d436756-3f1c-41f3-b59f-9b221bfd1083"),
                column: "ConcurrencyStamp",
                value: "928d0fed-ce2a-4d0b-bf05-b14be365ccf4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("7af97aee-9a3f-4008-ac98-3ce383de2ec0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "035e63a7-5a76-4ac2-bb03-e4b660852785", "AQAAAAEAACcQAAAAEPSqmNZwazR55QMGVlQ2p1mpwX2FhI4j5jJ+l8mDgxDmm8Hi9tseD5cRabZsdh5jOA==" });

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
                value: new DateTime(2023, 9, 21, 1, 14, 14, 520, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 9, 21, 1, 14, 14, 521, DateTimeKind.Local).AddTicks(5650));
        }
    }
}
