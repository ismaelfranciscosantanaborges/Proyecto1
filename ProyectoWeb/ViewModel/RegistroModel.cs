using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.ViewModel
{
    public class RegistroModel
    {
        [Required(ErrorMessage = "Required"), MaxLength(25, ErrorMessage = "no more than 25 character")]
        public string Name{get;set;}
        [Required(ErrorMessage = "Required"), MaxLength(25, ErrorMessage = "no more than 25 character")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Repite the password")]
        [Compare("Password", ErrorMessage = "The passoword and the confirm password do not match")]
        public string PasswordValidar { get; set; }

        [Display(Name = "Help Password")]
        public string HelpPassword { get; set; }
    }
}