using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "2389b04c-a59c-4c61-87d8-837136457da0", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "eac62a86-8cf9-4183-b429-554a6d75f06b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a2f3f57f-0fec-443c-bbb0-3194e7edd630", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEAN07iABIx+S6CvvjCmMXDjYgnZcKjBPh9FDMG5yo0GpKsjBnGG0bwrlOcE3+COFjQ==", null, false, "d24b7bf8-3565-4e84-a836-5c67f6d3f21f", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 3, 23, 52, 23, 362, DateTimeKind.Local).AddTicks(6059), new DateTime(2021, 12, 3, 23, 52, 23, 363, DateTimeKind.Local).AddTicks(6609), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 3, 23, 52, 23, 363, DateTimeKind.Local).AddTicks(7870), new DateTime(2021, 12, 3, 23, 52, 23, 363, DateTimeKind.Local).AddTicks(7877), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 3, 23, 52, 23, 365, DateTimeKind.Local).AddTicks(5786), new DateTime(2021, 12, 3, 23, 52, 23, 365, DateTimeKind.Local).AddTicks(5802), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 3, 23, 52, 23, 365, DateTimeKind.Local).AddTicks(5806), new DateTime(2021, 12, 3, 23, 52, 23, 365, DateTimeKind.Local).AddTicks(5807), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1280), new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1291), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1296), new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1297), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1299), new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1301), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1302), new DateTime(2021, 12, 3, 23, 52, 23, 366, DateTimeKind.Local).AddTicks(1304), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
