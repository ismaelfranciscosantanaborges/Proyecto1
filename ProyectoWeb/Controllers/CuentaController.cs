
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    public class CuentaController : Controller
    {
        private readonly UserManager<IdentityUser> _gestionUsuarios;
        private readonly SignInManager<IdentityUser> _gestionLogin;

        public CuentaController(UserManager<IdentityUser> gestionUsuarios, SignInManager<IdentityUser> gestionLogin)
        {
            _gestionUsuarios = gestionUsuarios;

            _gestionLogin = gestionLogin;


        }

        [HttpGet]
        [Route("Account/Signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/Signup")]
        public async Task<IActionResult> Signup(RegistroModel model)
        {
            if(ModelState.IsValid){
                var usuario = new IdentityUser{
                    UserName = model.Email,
                    Email = model.Email
                };

                var resultado = await _gestionUsuarios.CreateAsync(usuario, model.Password);

                if(resultado.Succeeded){
                    await _gestionLogin.SignInAsync(usuario, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in resultado.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }
    }
}
