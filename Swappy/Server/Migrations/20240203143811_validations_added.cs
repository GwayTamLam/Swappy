using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swappy.Server.Migrations
{
    /// <inheritdoc />
    public partial class validations_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1540), new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1229), new DateTime(2024, 2, 3, 22, 38, 10, 861, DateTimeKind.Local).AddTicks(1237) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3149), new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3151), new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 2, 3, 15, 43, 51, 703, DateTimeKind.Local).AddTicks(2809) });
        }
    }
}
