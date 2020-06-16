using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public interface IRegistosAlmacenado
    {
        BaseUser dameDetallesUsuario(int id);
        List<BaseUser> dameTodosLosUsuarios();
        BaseUser nuevo(BaseUser baseUser);
    }
}
