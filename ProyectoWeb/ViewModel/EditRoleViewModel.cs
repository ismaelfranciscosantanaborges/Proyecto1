using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.ViewModel
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        public EditRoleViewModel()
        {
            Users = new List<string>(); 
        }
        [Required(ErrorMessage = "The role name is required")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}