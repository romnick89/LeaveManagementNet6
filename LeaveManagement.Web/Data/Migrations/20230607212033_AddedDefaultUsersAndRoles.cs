using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ded41be-32bb-4c34-af30-eca5f9ab9610", "de81b89d-c9b2-4de2-a391-1209fb2205c9", "Administrator", "ADMINISTRATOR" },
                    { "cbed41be-31de-4b31-af30-ace5f9cd9610", "c43d26ac-62a4-4090-9268-3eee9ce5ebcc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9ded52be-3217-4c34-af30-eca5f9cc9530", 0, "3aa7f4b9-6e0e-49bf-a4a3-63e31132edef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEPBmPKYa1zjuiWWqbmHlxGUCboFPyeDoK9sLDVQmxmVznvtjAOnhgMrPoc9/eXuWLQ==", null, false, "2ab8e5c6-6e30-4321-8d90-cc2cafa953e6", null, false, null },
                    { "d64ea6b3-31c7-421b-ac84-585ae15f650d", 0, "64f53310-3da8-4353-912b-74e4d015c781", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHMRJ1o2WYTGHgstR+9ZQ2EzQpf9Zq8A+BJ3g2LErQ8vnbVlMKIqoec8gMLFoL8fuQ==", null, false, "e8fbea7b-c924-481e-8602-4a15904ba2d2", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbed41be-31de-4b31-af30-ace5f9cd9610", "9ded52be-3217-4c34-af30-eca5f9cc9530" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9ded41be-32bb-4c34-af30-eca5f9ab9610", "d64ea6b3-31c7-421b-ac84-585ae15f650d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbed41be-31de-4b31-af30-ace5f9cd9610", "9ded52be-3217-4c34-af30-eca5f9cc9530" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9ded41be-32bb-4c34-af30-eca5f9ab9610", "d64ea6b3-31c7-421b-ac84-585ae15f650d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d");
        }
    }
}
