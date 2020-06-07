using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Poster: BaseUser
    {
        public Poster()
        {
            TipoUsuario = ETipoUsuario.Poster;
        }
    }
}
