using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Vehicles",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Vehicles",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Models",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Models",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Makes",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Makes",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Customers",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Customers",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Colours",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Colours",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "DataUpdated",
                table: "Bookings",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "DataCreated",
                table: "Bookings",
                newName: "DateCreated");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "07a158e2-22e6-4936-a9fa-0c0b63286f59", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "0a0060f2-7d10-4f59-b997-7aebab7160bd", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4b4a64df-f9bb-490d-87cb-ae364f4fafaa", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEDHbWqkrD8jEyabIQfwa6BvUWklsR5NvuZH9//mvQFWSosbqrOZgJh5hZiLu0wF8Cw==", null, false, "a4978a01-3bf3-43fe-8bd1-0d2991eed5df", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 17, 34, 3, 93, DateTimeKind.Local).AddTicks(7927), new DateTime(2022, 12, 1, 17, 34, 3, 95, DateTimeKind.Local).AddTicks(682), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 17, 34, 3, 95, DateTimeKind.Local).AddTicks(1385), new DateTime(2022, 12, 1, 17, 34, 3, 95, DateTimeKind.Local).AddTicks(1389), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(2672), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(2680), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(2684), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(2685), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6103), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6107), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6109), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 12, 1, 17, 34, 3, 96, DateTimeKind.Local).AddTicks(6112), "Rav4", "System" }
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
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
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

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Vehicles",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Vehicles",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Models",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Models",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Makes",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Makes",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Customers",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Customers",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Colours",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Colours",
                newName: "DataCreated");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Bookings",
                newName: "DataUpdated");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Bookings",
                newName: "DataCreated");
        }
    }
}
