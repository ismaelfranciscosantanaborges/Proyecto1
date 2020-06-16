using System;
using System.Collections.Generic;

namespace ProyectoWeb.Data
{
    public partial class PuestoTrabajo1
    {
        public int Id { get; set; }
        public string Compania { get; set; }
        public int? TipoEmpleo { get; set; }
        public string Logo { get; set; }
        public string Url { get; set; }
        public string Posicion { get; set; }
        public string Ubicacion { get; set; }
        public string ComoAplicar { get; set; }
        public string Correo { get; set; }
        public int? Categoria { get; set; }
        public string DescripcionTrabajo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
