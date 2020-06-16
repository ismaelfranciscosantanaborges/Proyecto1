using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public abstract class BaseUser
    {
        public int Id { get; set; }
        public ETipoUsuario TipoUsuario { get; protected set; }

        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioContra { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public String Cedula { get; set; }
        public string Profesional { get; set; }
        public string Aptitudes { get; set; }

    }
}
