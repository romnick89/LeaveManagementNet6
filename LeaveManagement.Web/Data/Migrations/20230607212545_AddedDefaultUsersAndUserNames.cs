using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "33805123-77b5-43fd-9839-ae15d7a8da2a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "1c1f079e-1660-4168-a2ee-b6af632da19b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a0729cef-2b77-4b03-a1c8-53b1f057bb73", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAECZPjv/Ut6MGV33qcnCGWuUDzHTzUD9MZvKoQhYLDGuRwFYaLrJZb2G0rLxR4mIFNQ==", "1994e7a5-2590-4d84-a6a6-ef5c0dc9150e", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "21979ed0-9fbd-4b83-a1f5-4e8d6de22af6", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAED+qx9IqWyxK0mf2uQhMhutUcuUT0TpQgLGIzxXyCwLQ/F09eGgpz13G3U28SHdXmQ==", "070ec6fb-f1d7-40dd-8552-c699f43e6706", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "de81b89d-c9b2-4de2-a391-1209fb2205c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "c43d26ac-62a4-4090-9268-3eee9ce5ebcc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3aa7f4b9-6e0e-49bf-a4a3-63e31132edef", false, null, "AQAAAAEAACcQAAAAEPBmPKYa1zjuiWWqbmHlxGUCboFPyeDoK9sLDVQmxmVznvtjAOnhgMrPoc9/eXuWLQ==", "2ab8e5c6-6e30-4321-8d90-cc2cafa953e6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "64f53310-3da8-4353-912b-74e4d015c781", false, null, "AQAAAAEAACcQAAAAEHMRJ1o2WYTGHgstR+9ZQ2EzQpf9Zq8A+BJ3g2LErQ8vnbVlMKIqoec8gMLFoL8fuQ==", "e8fbea7b-c924-481e-8602-4a15904ba2d2", null });
        }
    }
}
