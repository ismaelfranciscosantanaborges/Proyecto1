using System;
using System.Collections.Generic;

namespace ProyectoWeb.Data
{
    public partial class Usuario1
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioContra { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public int? TipoUsuario { get; set; }
        public string Profecional { get; set; }
        public string Telefono { get; set; }
        public string Aptitudes { get; set; }
    }
}
