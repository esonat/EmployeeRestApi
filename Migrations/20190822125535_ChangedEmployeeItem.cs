using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeRestApi.Migrations
{
    public partial class ChangedEmployeeItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "EmployeeItems",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "EmployeeItems",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "EmployeeItems",
                newName: "department");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "EmployeeItems",
                newName: "dateofbirth");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EmployeeItems",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "dateofbirth",
                table: "EmployeeItems",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "EmployeeItems",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "EmployeeItems",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "department",
                table: "EmployeeItems",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "dateofbirth",
                table: "EmployeeItems",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EmployeeItems",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "EmployeeItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
