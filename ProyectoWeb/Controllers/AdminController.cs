using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers {
    
    //[Authorize(Roles = "Admin")]
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

        [HttpGet]
        [Route("Admin/EditUserRole")]
        public async Task<IActionResult> EditUserRole(string roleId){
            ViewBag.roleId = roleId;

            var role = await _gestionRoles.FindByIdAsync(roleId);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} not find";
                return View("Error");
            }

            var model = new List<UserRoleModel>();

            foreach (var user in _gestionUser.Users)
            {   
                var userRoleModel = new UserRoleModel{
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if(await _gestionUser.IsInRoleAsync(user, role.Name))
                {
                    userRoleModel.IsSelect = true;
                }else
                {
                    userRoleModel.IsSelect = false;
                }

                model.Add(userRoleModel);
            }

            return View(model);
        }

        [HttpPost]
        [Route("Admin/EditUserRole")]
        public async Task<IActionResult> EditUserRole(List<UserRoleModel> model, string roleId){
            var role = await _gestionRoles.FindByIdAsync(roleId);

            if(role == null){
                ViewBag.ErrorMessage = $"Role with Id = {roleId} not find";
                return View("Error");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _gestionUser.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if(model[i].IsSelect && !(await _gestionUser.IsInRoleAsync(user, role.Name)))
                {
                    result = await _gestionUser.AddToRoleAsync(user, role.Name);
                }else if(!model[i].IsSelect && await _gestionUser.IsInRoleAsync(user, role.Name))
                {
                    result = await _gestionUser.RemoveFromRoleAsync(user, role.Name);
                }else
                {
                    continue;
                }

                if(result.Succeeded)
                {
                    if(i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new {Id = roleId});
                }
            }

            return RedirectToAction("EditRole", new {Id = roleId});
        }

        [HttpGet]
        [Route("Admin/ListUsers")]
        public IActionResult ListUsers(){
            var users = _gestionUser.Users;
            return View(users);
        }

        [HttpGet]
        [Route("Admin/EdtiUser")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _gestionUser.FindByIdAsync(id);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with id = {id} not find";
                return View("Error");
            }

            var userClaims = await _gestionUser.GetClaimsAsync(user);
            var userRole = await _gestionUser.GetRolesAsync(user);

            var model = new EditUserModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                HelpPassword = user.HelpPassword,
                Notifications = userClaims.Select( c => c.Value).ToList(),
                Roles = userRole
            };

            return View(model);
        }

        [HttpPost]
        [Route("Admin/EdtiUser")]
        public async Task<IActionResult> EditUser(EditUserModel model)
        {
            var user = await _gestionUser.FindByIdAsync(model.Id);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with id = {model.Id} not find";
                return View("Error");
            }else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.HelpPassword = model.HelpPassword;

                var result = await _gestionUser.UpdateAsync(user);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpPost]
        [Route("Admin/DeleteUser")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _gestionUser.FindByIdAsync(id);

            if(user == null)
            {
                ViewBag.Title = $"User with Id = {id} not find";
                return View("Error");
            }else
            {
                var result = await _gestionUser.DeleteAsync(user);

                if(result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers");
            }
        }
        
        [HttpPost]
        [Route("Admin/DeleteRole")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _gestionRoles.FindByIdAsync(id);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {id} not find";
                return View("Error");
            }
            else
            {
                var result = await _gestionRoles.DeleteAsync(role);

                if( result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListRoles");
            }

        }

          [HttpGet]
        [Route("Admin/GestionRolesUser")]
        public async Task<IActionResult> GestionRolesUser(string idUser)
        {
            ViewBag.IdUser = idUser;

            var user = await _gestionUser.FindByIdAsync(idUser);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"The user with id = {idUser} not find";
                
                return View("Error");
            }

            var model = new List<RoleUserModel>();

            foreach (var role in _gestionRoles.Roles)
            {
                var roleUserModel = new RoleUserModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if(await _gestionUser.IsInRoleAsync(user, role.Name))
                {
                    roleUserModel.IsSelect = true;
                }else
                {
                    roleUserModel.IsSelect = false;
                }

                model.Add(roleUserModel);
            }

            return View(model);
        }

        [HttpPost]
        [Route("Admin/GestionRolesUser")]
        public async Task<IActionResult> GestionRolesUser(List<RoleUserModel> model, string Id)
        {
            var user = await _gestionUser.FindByIdAsync(Id);

            if(user == null)
            {
                ViewBag.ErrorMessage = $"The user with id = {Id} not find";
                return View("Error");
            }

            var roles = await _gestionUser.GetRolesAsync(user);
            var result = await _gestionUser.RemoveFromRolesAsync(user, roles);

            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "You cannot delete users with roles");
                return View(model);
            }

            result = await _gestionUser.AddToRolesAsync(user, 
                model.Where(x => x.IsSelect).Select(y => y.RoleName));

            if(!result.Succeeded )
            {
                ModelState.AddModelError("", "you cannot add the selected user to the roles");
                return View(model);
            }

            return RedirectToAction("EditUser", new {Id = Id});
        }











    }

    
}