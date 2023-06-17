using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestCommentsToNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "0109e5b3-cdc8-4fb1-ac14-028f37d44dd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "e85fec89-6555-4a9f-b358-a4c320fafff0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bff3aed-05e0-4e66-b557-ca828efffa5f", "AQAAAAEAACcQAAAAEGPvxDtcy7b5mgWX4I4zOYEm3fPdXeJeaHffVflHFni1yyX7w70RaT671qVeFQD3oQ==", "19246131-ac8e-4326-8f61-17a915976e0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396534b3-f5a1-48bf-935c-8435edc817ba", "AQAAAAEAACcQAAAAECldI7QQG/87CXSIGYc0vmlakS70zzqL+tckflxsJpnEvNJ7D02YN56A17RxYOtsCw==", "91f42c92-1f3d-4255-8a75-27d28054b864" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "af8dbfef-4da1-4e35-9e00-abfbe05f3ce0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "ed2d57a5-fe11-4bb3-87b4-d181efb7a64f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed743e82-14d2-497d-adf3-d3494cec3de8", "AQAAAAEAACcQAAAAEDJeh9KRakRWqOFZxKuKfWb2/0nwOVopA/TFcJWY+XMyQECWB8IVSnUiqPhUluNuEw==", "6d4826f5-86e9-42f4-bedc-b62513755fdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2e0fb1a-0333-45dc-bc17-6ebe28e70993", "AQAAAAEAACcQAAAAEK+asku2U1lDneWh8tVY+J5vtjunb+Sb+x/vF1qCDylDQ063CsLNv0F/ZjxD0qupsA==", "4d0798a8-f889-46ed-bd94-f7fbc1ad8c53" });
        }
    }
}
