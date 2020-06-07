using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Administrador: BaseUser
    {
        public Administrador()
        {
            TipoUsuario = ETipoUsuario.Administrador;
        }
    }
}
