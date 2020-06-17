
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.Models
{
    public class PuestoTrabajo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required"), MaxLength(50, ErrorMessage = "no more than 50 character")]
        public string Compania { get; set; }  
        public ETipoEmpleado TipoEmpleado { get; set; }  
        
        public string Logo {get;set;}
        [Required(ErrorMessage = "Required"), MaxLength(200, ErrorMessage = "no more than 200 character")]

        public string Url {get;set;}
        [Required(ErrorMessage = "Required"), MaxLength(20, ErrorMessage = "no more than 15 character")]
        public string Posicion { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(200, ErrorMessage = "no more than 200 character")]

        public string Ubicacion {get;set;}
        [Required(ErrorMessage = "Required"), MaxLength(500, ErrorMessage = "no more than 500 character")]

        public string ComoAplicar { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage= "Incorrect Format")]
        public string Correo { get; set; }
        public ECategoria Categoria { get; set; }
        [Required(ErrorMessage = "Required"), MaxLength(1000, ErrorMessage = "no more than 1000 character")]

        public string DescripcionTrabajo { get; set; }
        
        public DateTime FechaPublicacion { get; set; }
    }
}