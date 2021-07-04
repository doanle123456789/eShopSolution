using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"),
                column: "ConcurrencyStamp",
                value: "ca9400a7-bca1-4088-bbef-c5785ef339ae");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "960f1d35-5d11-4f68-95d6-438c2135c9aa", "AQAAAAEAACcQAAAAEJh7mHc36wwVxYtp6IL9+x3GtC5JvUBeagMc1qkgc6aKoDkvtBYyqLblWn8SvH6G6w==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 3, 15, 20, 3, 155, DateTimeKind.Local).AddTicks(1662));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

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
        }
    }
}
