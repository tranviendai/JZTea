using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JZTea.Migrations
{
    /// <inheritdoc />
    public partial class Db01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "icon",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: "cream",
                column: "icon",
                value: "ic02.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: "ice drink",
                column: "icon",
                value: "ic04.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: "juice",
                column: "icon",
                value: "ic03.png");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: "milk tea",
                column: "icon",
                value: "ic01.png");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 11,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 12,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 13,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 14,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 15,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 16,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 17,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 18,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 855, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 19,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 856, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 20,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 22, 5, 59, 856, DateTimeKind.Local).AddTicks(45));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "icon",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 1,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 2,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 3,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 4,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 5,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 6,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 7,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 8,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 9,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 10,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 11,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 12,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 13,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 14,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 15,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 16,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 17,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 18,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 19,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "id",
                keyValue: 20,
                column: "postDate",
                value: new DateTime(2023, 7, 8, 18, 13, 15, 242, DateTimeKind.Local).AddTicks(6754));
        }
    }
}
