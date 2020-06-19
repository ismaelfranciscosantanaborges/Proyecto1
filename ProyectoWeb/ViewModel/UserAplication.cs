using Microsoft.AspNetCore.Identity;

namespace ProyectoWeb.ViewModel
{
    public class UserAplication:IdentityUser
    {
        public string HelpPassword { get; set; }
    }
}