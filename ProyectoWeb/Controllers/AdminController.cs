using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers {
    [Authorize]
    public class AdminController : Controller {
        private readonly RoleManager<IdentityRole> _gestionRoles;

        public UserManager<UserAplication> _gestionUser { get; }

        public AdminController (RoleManager<IdentityRole> gestionRoles,
            UserManager<UserAplication> gestionUser) {
            _gestionUser = gestionUser;
            _gestionRoles = gestionRoles;

        }

        [HttpGet]
        [Route ("Admin/CreateRole")]
        public IActionResult CreateRole () {
            return View ();
        }

        [HttpPost]
        [Route ("Admin/CreateRole")]
        public async Task<IActionResult> CreateRole (CreateRolViewModel model) {
            if (ModelState.IsValid) {

                IdentityRole identityRole = new IdentityRole {
                    Name = model.RolName
                };

                IdentityResult result = await _gestionRoles.CreateAsync (identityRole);

                if (result.Succeeded) {
                    return RedirectToAction ("Index", "Home");
                }

                foreach (IdentityError error in result.Errors) {
                    ModelState.AddModelError ("", error.Description);
                }

            }
            return View (model);
        }

        [HttpGet]
        [Route ("Admin/Roles")]
        public IActionResult ListRoles () {

            var roles = _gestionRoles.Roles;
            return View (roles);
        }

        [HttpGet]
        [Route ("Admin/EditRole")]
        public async Task<IActionResult> EditRole (string id) {

            var role = await _gestionRoles.FindByIdAsync (id);

            if (role == null) {
                ViewBag.ErrorMessage = $"Role with Id = {id} not find";
                return View ("Error");
            }

            var model = new EditRoleViewModel 
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in _gestionUser.Users) {
                if (await _gestionUser.IsInRoleAsync(user, role.Name)) {
                    model.Users.Add(user.UserName);
                }
            }

            return View (model);
        }

        [HttpPost]
        [Route ("Admin/EditRole")]
        public async Task<IActionResult> EditRole(EditRoleViewModel modell) {

            var role = await _gestionRoles.FindByIdAsync(modell.Id);

            if (role == null) {
                ViewBag.ErrorMessage = $"Role with Id = {modell.Id} not find";
                return View ("Error");
            }
            else
            {
                role.Name = modell.RoleName;

                var result = await _gestionRoles.UpdateAsync(role);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                
                foreach (var error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }

            }

            return View (modell);
        }

    }
}