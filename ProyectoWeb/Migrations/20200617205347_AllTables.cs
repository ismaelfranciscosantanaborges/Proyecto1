using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoWeb.Migrations
{
    public partial class AllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PuestoTrabajo",
                columns: new[] { "Id", "Categoria", "ComoAplicar", "Compania", "Correo", "DescripcionTrabajo", "FechaPublicacion", "Logo", "Posicion", "TipoEmpleado", "Ubicacion", "Url" },
                values: new object[] { 1, 2, "Llenando el formulario", "LegoList", "legolist@gmail.com", "Esto es un trabajo sumamente importante para mi", new DateTime(2020, 6, 17, 16, 53, 47, 97, DateTimeKind.Local).AddTicks(280), "https://LegoList/Img/logo.png", "Developer", 2, "Santo Domingo", "https://LegoList" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Apellido", "Aptitudes", "Cedula", "Correo", "Nombre", "Profesional", "Telefono", "TipoUsuario", "UsuarioContra", "UsuarioNombre" },
                values: new object[] { 1, "Perez", "Java Avanzado", "402-6536424-2", "samuel@gmail.com", "Samuel", null, "829-535-7464", 0, "123456", "samuelElFinalll" });

            migrationBuilder.InsertData(
                table: "UsuarioPuestoTrabajo",
                columns: new[] { "Id", "IdPuestoTrabajo", "IdPuestoTrabajoNavigationId", "IdUsuario", "IdUsuarioNavigationId", "ParaAplicar" },
                values: new object[] { 1, 1, null, 1, null, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UsuarioPuestoTrabajo",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
