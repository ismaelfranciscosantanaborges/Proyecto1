using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoWeb.Migrations
{
    public partial class Identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "UsuarioPuestoTrabajo",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "PuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicacion",
                value: new DateTime(2020, 6, 21, 17, 49, 14, 563, DateTimeKind.Local).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "UsuarioPuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdUsuario",
                value: "e618b7ca-b1a7-4e50-abe8-63fa61d72b42");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "UsuarioPuestoTrabajo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "PuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicacion",
                value: new DateTime(2020, 6, 18, 21, 38, 53, 952, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "UsuarioPuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdUsuario",
                value: 1);
        }
    }
}
