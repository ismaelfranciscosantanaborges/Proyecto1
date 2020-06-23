using System.Collections.Generic;
using ProyectoWeb.Models;

namespace ProyectoWeb.Interfaces
{
    public interface IPuestoTrabajo
    {
        List<PuestoTrabajo> dameTodoTrabajo();
        List<PuestoTrabajo> getOfFilter(string cadena);
        PuestoTrabajo dameElTrabajo(int id);

        PuestoTrabajo nuevo(PuestoTrabajo puestoTrabajo);

        PuestoTrabajo borrar(int id);
        PuestoTrabajo modificar(PuestoTrabajo trabajo);
    }
}