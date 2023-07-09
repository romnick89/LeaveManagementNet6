using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedTotalLeaveDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalLeaveDays",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ded41be-32bb-4c34-af30-eca5f9ab9610",
                column: "ConcurrencyStamp",
                value: "8292cc20-9a9a-4632-9a1d-cc3dcb109f26");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbed41be-31de-4b31-af30-ace5f9cd9610",
                column: "ConcurrencyStamp",
                value: "9a73e657-0505-4b38-9f4c-ba077ccf2a4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ded52be-3217-4c34-af30-eca5f9cc9530",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eab89c8c-cd57-4cd2-a179-2bfe78c3e492", "AQAAAAEAACcQAAAAEODzqIo5s9hLhewL90+vwCxSp7rj+tLFYV6wU5JGxA5JJBy9NtvRLE57z3scbwge9A==", "3840437d-7985-4ca8-8aa2-15755217f11e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d64ea6b3-31c7-421b-ac84-585ae15f650d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f3a22b2-1219-49aa-8bae-f00acf2bd6fd", "AQAAAAEAACcQAAAAEObRFbMHb5AnTPacDx4qB+B/qCb1BtNWQ72LAOKBWs81AIHylaROWU+gBRaVlBAX+Q==", "b4108cbb-5679-45c6-bb72-0613b0a1ab86" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalLeaveDays",
                table: "LeaveRequests");

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
    }
}
