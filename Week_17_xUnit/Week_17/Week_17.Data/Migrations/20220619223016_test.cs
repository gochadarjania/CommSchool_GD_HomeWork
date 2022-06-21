using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week_17.Data.Migrations
{
    public partial class test : Migration
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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HomeNumber" },
                values: new object[] { 3, "Tbilisi", "Georgia", "55223366" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HomeNumber" },
                values: new object[] { 4, "Khutaisi", "Georgia", "55223366" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HomeNumber" },
                values: new object[] { 5, "Batumi", "Georgia", "55223366" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 5, 3, new DateTime(2022, 6, 20, 2, 30, 15, 772, DateTimeKind.Local).AddTicks(6778), "TestName3", "Junior Developer", "TestLastName3", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 3, 4, new DateTime(2022, 6, 20, 2, 30, 15, 771, DateTimeKind.Local).AddTicks(8486), "TestName1", "Junior Developer", "TestLastName1", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 4, 5, new DateTime(2022, 6, 20, 2, 30, 15, 772, DateTimeKind.Local).AddTicks(6763), "TestName2", "Junior Developer", "TestLastName2", 500.0, 1.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_AddressId",
                table: "Persons",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
