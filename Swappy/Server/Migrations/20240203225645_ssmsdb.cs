using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swappy.Server.Migrations
{
    /// <inheritdoc />
    public partial class ssmsdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3331), new DateTime(2024, 2, 4, 6, 56, 45, 691, DateTimeKind.Local).AddTicks(3341) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5045), new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5048), new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 2, 4, 4, 51, 2, 207, DateTimeKind.Local).AddTicks(4690) });
        }
    }
}
