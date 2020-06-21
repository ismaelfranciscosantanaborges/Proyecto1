using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb.ViewModel
{
    public class EditUserModel
    {
        public EditUserModel()
        {
            Notifications = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string HelpPassword { get; set; }
        public List<string> Notifications { get; set; }
        public IList<string> Roles { get; set; }
    }
}