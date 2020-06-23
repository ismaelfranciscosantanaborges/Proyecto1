using System.Collections.Generic;
using ProyectoWeb.Data;
using ProyectoWeb.Models;

namespace ProyectoWeb.Interfaces
{
    public interface IUserJob
    {
        List<UsuarioPuestoTrabajo> dameUserJob();
        UsuarioPuestoTrabajo dameElUserJob(string id);
        List<UsuarioPuestoTrabajo> dameTodoUserJob(string id);

        UsuarioPuestoTrabajo nuevo(UsuarioPuestoTrabajo userJob);

        UsuarioPuestoTrabajo borrar(int id);    
        //UsuarioPuestoTrabajo modificar(PuestoTrabajo trabajo);
    }
}