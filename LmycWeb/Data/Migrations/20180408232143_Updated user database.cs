using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LmycWeb.Data.Migrations
{
    public partial class Updateduserdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SailingExperience",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SailingExperience",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
