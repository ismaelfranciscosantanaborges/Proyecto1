using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class User:BaseUser
    {
        public User()
        {
            TipoUsuario = ETipoUsuario.User;
        }
    }
}
