using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Mandatory Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mandatory Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember")]
        public bool Remember { get; set; }
    }
}