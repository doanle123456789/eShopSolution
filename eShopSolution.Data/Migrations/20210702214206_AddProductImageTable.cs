using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 1, 1, 13, 59, 60, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"),
                column: "ConcurrencyStamp",
                value: "ecdef059-eeea-478e-971c-4bcee716fb56");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17e438bc-9bb3-4756-b9eb-fa100cafea48", "AQAAAAEAACcQAAAAEBDwLth76i7ouP6DGqb1sfT6dbwn3tvP47XkrDe3xqkbfz9cQxKDhQai1XckYTho9A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 3, 4, 42, 5, 682, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 1, 13, 59, 60, DateTimeKind.Local).AddTicks(7936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"),
                column: "ConcurrencyStamp",
                value: "f4baf656-8607-49d4-a921-a589bd124540");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc754944-47d3-4a82-b37c-a5c38939a60a", "AQAAAAEAACcQAAAAEC09KIkqO2CdDfRni8bB7xmR1Nhd3MuWpbsFSjIh9sU3vgCk6JNzF0PKDQ6iPHT6+Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 1, 1, 13, 59, 95, DateTimeKind.Local).AddTicks(444));
        }
    }
}
