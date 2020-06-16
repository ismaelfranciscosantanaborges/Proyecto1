using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Administrador: Usuario
    {
        public Administrador()
        {
            TipoUsuario = ETipoUsuario.Administrador;
        }
    }
}
