using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Models
{
    public class Usuario
    {

        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public ETipoUsuario TipoUsuario { get; protected set; }
        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public string Apellido {  get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public string UsuarioNombre { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public string UsuarioContra { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(100, ErrorMessage = "no more than 50 character")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(13, ErrorMessage = "no more than 50 character")]
        public string Telefono { get; set; }
        
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage= "Incorrect Format")]
        public String Cedula { get; set; }
        public string Profesional { get; set; }

        public string Aptitudes { get; set; }

    }
}
