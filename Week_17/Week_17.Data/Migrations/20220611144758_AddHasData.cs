using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Week_17.Data.Migrations
{
    public partial class AddHasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "HomeNumber" },
                values: new object[,]
                {
                    { 3, "Tbilisi", "Georgia", "55223366" },
                    { 4, "Khutaisi", "Georgia", "55223366" },
                    { 5, "Batumi", "Georgia", "55223366" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 3, 1, new DateTime(2022, 6, 11, 18, 47, 58, 161, DateTimeKind.Local).AddTicks(8145), "TestName1", "Junior Developer", "TestLastName1", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 5, 3, new DateTime(2022, 6, 11, 18, 47, 58, 162, DateTimeKind.Local).AddTicks(6031), "TestName3", "Junior Developer", "TestLastName3", 500.0, 1.0 });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "AddressId", "CreateDate", "FirstName", "JobPosition", "LastName", "Salary", "WorkExperince" },
                values: new object[] { 4, 5, new DateTime(2022, 6, 11, 18, 47, 58, 162, DateTimeKind.Local).AddTicks(6015), "TestName2", "Junior Developer", "TestLastName2", 500.0, 1.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
