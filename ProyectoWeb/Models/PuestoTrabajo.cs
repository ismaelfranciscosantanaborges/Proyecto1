
using System;

namespace ProyectoWeb.Models
{
    public class PuestoTrabajo
    {
        public int Id { get; set; }
        public string Compania { get; set; }  
        public ETipoEmpleado TipoEmpleado { get; set; }  
        public string Logo {get;set;}
        public string Url {get;set;}
        public string Posicion { get; set; }
        public string Ubicacion {get;set;}
        public string ComoAplicar { get; set; }
        public string Correo { get; set; }
        public ECategoria Categoria { get; set; }
        public string DescripcionTrabajo { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}