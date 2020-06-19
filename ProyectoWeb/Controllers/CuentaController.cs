
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly UserManager<UserAplication> _gestionUsuarios;
        private readonly SignInManager<UserAplication> _gestionLogin;

        public CuentaController(UserManager<UserAplication> gestionUsuarios, SignInManager<UserAplication> gestionLogin)
        {
            _gestionUsuarios = gestionUsuarios;

            _gestionLogin = gestionLogin;


        }

        [HttpGet]
        [Route("Account/Signup")]
        [AllowAnonymous]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/Signup")]
        [AllowAnonymous]
        public async Task<IActionResult> Signup(RegistroModel model)
        {
            if(ModelState.IsValid){
                var usuario = new UserAplication{
                    UserName = model.Email,
                    Email = model.Email,
                    HelpPassword = model.HelpPassword
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

        [Route("Account/Login")]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("Account/Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _gestionLogin.PasswordSignInAsync(
                    model.Email, model.Password, model.Remember, false
               );

               if(result.Succeeded){
                   return RedirectToAction("Index", "Home");
               }
               ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
        }
 
        [HttpPost]
        [Route("Account/SignOut")]
        public async Task<IActionResult> SignOut(){
            await _gestionLogin.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        
    }
}
