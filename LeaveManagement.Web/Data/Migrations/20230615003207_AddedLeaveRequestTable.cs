using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
