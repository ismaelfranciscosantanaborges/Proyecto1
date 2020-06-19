using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.ViewModel
{
    public class CreateRolViewModel
    {
        [Required(ErrorMessage = "This campo is Obligatory")]
        [Display(Name = "Rol")]
        public string RolName { get; set; }
    }
}