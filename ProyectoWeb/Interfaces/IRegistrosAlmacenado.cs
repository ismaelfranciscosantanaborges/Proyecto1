using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public interface IRegistosAlmacenado
    {
        Usuario dameDetallesUsuario(int id);
        List<Usuario> dameTodosLosUsuarios();
        Usuario nuevo(Usuario baseUser);
    }
}
