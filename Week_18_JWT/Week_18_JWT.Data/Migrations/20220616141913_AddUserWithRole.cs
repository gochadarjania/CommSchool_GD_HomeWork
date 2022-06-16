using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week_18_JWT.Data.Migrations
{
    public partial class AddUserWithRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserWithRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWithRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    WorkExperince = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUserWithRole",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UserWithRolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUserWithRole", x => new { x.RolesId, x.UserWithRolesId });
                    table.ForeignKey(
                        name: "FK_RoleUserWithRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUserWithRole_UserWithRoles_UserWithRolesId",
                        column: x => x.UserWithRolesId,
                        principalTable: "UserWithRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HomeNumber" },
                values: new object[,]
                {
                    { 1, "Tbilisi", "Georgia", "55223366" },
                    { 2, "Khutaisi", "Georgia", "55223366" },
                    { 3, "Batumi", "Georgia", "55223366" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "SuperAdmin" },
                    { 2, "Admin" },
                    { 3, "ReportsAdmin" }
                });

            migrationBuilder.InsertData(
                table: "UserWithRoles",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "Test First 1", "Test Last 1", "test123", "test123" },
                    { 2, "Test First 2", "Test Last 2", "test123", "test123" },
                    { 3, "Test First 3", "Test Last 3", "test123", "test123" },
                    { 4, "Test First 4", "Test Last 4", "test123", "test123" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 3, 1, new DateTime(2022, 6, 16, 18, 19, 13, 81, DateTimeKind.Local).AddTicks(3976), "TestName1", "Junior Developer", "TestLastName1", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 4, 2, new DateTime(2022, 6, 16, 18, 19, 13, 82, DateTimeKind.Local).AddTicks(2050), "TestName2", "Junior Developer", "TestLastName2", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 5, 3, new DateTime(2022, 6, 16, 18, 19, 13, 82, DateTimeKind.Local).AddTicks(2066), "TestName3", "Junior Developer", "TestLastName3", 500.0, 1.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUserWithRole_UserWithRolesId",
                table: "RoleUserWithRole",
                column: "UserWithRolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "RoleUserWithRole");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserWithRoles");
        }
    }
}
