using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductApp.Migrations
{
    public partial class turkishProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 11, 29, 15, 15, 15, 447, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 11, 29, 15, 15, 15, 447, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 11, 29, 15, 15, 15, 447, DateTimeKind.Local).AddTicks(9612));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AtCreated",
                value: new DateTime(2022, 11, 27, 14, 36, 54, 367, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AtCreated",
                value: new DateTime(2022, 11, 27, 14, 36, 54, 367, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AtCreated",
                value: new DateTime(2022, 11, 27, 14, 36, 54, 367, DateTimeKind.Local).AddTicks(1805));
        }
    }
}
