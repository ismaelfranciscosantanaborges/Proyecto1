﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ProyectoWeb.Models;

namespace ProyectoWeb.Models
{
    public partial class UsuarioPuestoTrabajo
    {
        [Key]
        public int Id {get;set;}
        [Required]
        public string IdUsuario { get; set; }
        [Required]
        public int IdPuestoTrabajo { get; set; }
        [Required]
        public bool ParaAplicar { get; set; }

        public virtual PuestoTrabajo IdPuestoTrabajoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
