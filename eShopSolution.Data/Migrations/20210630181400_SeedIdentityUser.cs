using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 1, 13, 59, 60, DateTimeKind.Local).AddTicks(7936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 1, 0, 17, 33, 251, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"), "f4baf656-8607-49d4-a921-a589bd124540", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"), new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06"), 0, "fc754944-47d3-4a82-b37c-a5c38939a60a", new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "doanngocle17012020@gmail.com", true, "Doan", "Le", false, null, "doanngocle17012020@gmail.com", "admin", "AQAAAAEAACcQAAAAEC09KIkqO2CdDfRni8bB7xmR1Nhd3MuWpbsFSjIh9sU3vgCk6JNzF0PKDQ6iPHT6+Q==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 1, 1, 13, 59, 95, DateTimeKind.Local).AddTicks(444));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6e6c2b46-7f8f-4b72-862f-9cd6dfd104c5"), new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1e6fdb7-ea7b-414f-95e6-e59ddb4b5d06"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 1, 0, 17, 33, 251, DateTimeKind.Local).AddTicks(4626),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 1, 1, 13, 59, 60, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 1, 0, 17, 33, 274, DateTimeKind.Local).AddTicks(3282));
        }
    }
}
