using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class PeriodAddedInLeaveAllocationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "898d36bb-012e-437d-a8da-393abf1ce88e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "1b511627-1d51-447b-9556-6a501e920264");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f44941f-9b59-49df-84ba-c820f39b3dcc", "AQAAAAEAACcQAAAAEAS116uy2xcvt9nuTzgeQFZLEDon1VNTaCA/EO5Z/xCCESKugIacqiQH7x4mt/HhGA==", "c8d64884-4d7c-494a-ad12-faa310e5b6ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8be5609a-b15c-41d9-ad8d-5733e6fba536", "AQAAAAEAACcQAAAAEAqx+0a6biTFmmfkae83mgxBYoucxkbi05LqHTb3P4ktG4ecLXg/wTBtFC7185v3pw==", "5c8d49ad-3f5c-434b-a627-e791a37e57fa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0729cef-2b77-4b03-a1c8-53b1f057bb73", "AQAAAAEAACcQAAAAECZPjv/Ut6MGV33qcnCGWuUDzHTzUD9MZvKoQhYLDGuRwFYaLrJZb2G0rLxR4mIFNQ==", "1994e7a5-2590-4d84-a6a6-ef5c0dc9150e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21979ed0-9fbd-4b83-a1f5-4e8d6de22af6", "AQAAAAEAACcQAAAAED+qx9IqWyxK0mf2uQhMhutUcuUT0TpQgLGIzxXyCwLQ/F09eGgpz13G3U28SHdXmQ==", "070ec6fb-f1d7-40dd-8552-c699f43e6706" });
        }
    }
}
