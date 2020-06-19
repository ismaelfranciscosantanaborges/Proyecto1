using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoWeb.Migrations
{
    public partial class Extend_IndentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HelpPassword",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicacion",
                value: new DateTime(2020, 6, 18, 21, 38, 53, 952, DateTimeKind.Local).AddTicks(7570));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HelpPassword",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "PuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicacion",
                value: new DateTime(2020, 6, 17, 16, 53, 47, 97, DateTimeKind.Local).AddTicks(280));
        }
    }
}
