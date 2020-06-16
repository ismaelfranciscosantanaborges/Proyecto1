using System;
using System.Collections.Generic;
using ProyectoWeb.Models;

namespace ProyectoWeb.Data
{
    public partial class UsuarioPuestoTrabajo
    {
        public int? IdUsuario { get; set; }
        public int? IdPuestoTrabajo { get; set; }
        public bool? ParaAplicar { get; set; }

        public virtual PuestoTrabajo IdPuestoTrabajoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
