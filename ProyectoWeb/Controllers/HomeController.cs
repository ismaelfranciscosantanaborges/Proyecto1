using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Data;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Mocks;
using ProyectoWeb.Models;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IRegistosAlmacenado _listaUsuario;
        private readonly IUserJob _userJob;
        private readonly UserManager<UserAplication> _gestionUser;

        private readonly IPuestoTrabajo _listaPuestoTrabajo;
        public HomeController(IPuestoTrabajo puestoTrabajo, IRegistosAlmacenado listaUsuario,
                              IUserJob userJob, UserManager<UserAplication> gestionUser)
        {
            _gestionUser = gestionUser;
            _userJob = userJob;

            _listaUsuario = listaUsuario;

            _listaPuestoTrabajo = puestoTrabajo;


        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index(string cadena = "")
        {
            //var listaUsuario = _listaUsuario.dameTodosLosUsuarios();
            PuestoTrabajoModel model = new PuestoTrabajoModel();
            model.listPT = _listaPuestoTrabajo.getOfFilter(cadena);
            model.listUPT = _userJob.dameTodoUserJob(User.getUserId());


            return View(model);
            //return View("~/MisVistas/Index.cshtml");
        }

        [Route("Home/Details/{id?}")]
        public async Task<ViewResult> Details(int id)
        {
            DetallesView detalles = new DetallesView();
            //detalles.Usuario = _listaUsuario.dameDetallesUsuario(id??1);
            detalles.PuestoTrabajo = _listaPuestoTrabajo.dameElTrabajo(id);
            detalles.ListUsuarioPT = _userJob.dameTodoUserJob();
            var model = new List<string>();

            foreach (var user in _gestionUser.Users)
            {
                var userRoleModel =  user.UserName;
                foreach (var item in detalles.ListUsuarioPT)
                {
                    if(user.Id == item.IdUsuario && item.ParaAplicar == true)
                    {
                        model.Add(userRoleModel);
                    }
                }
                
            }

            ////////////////////////////
            detalles.Users = model;
            detalles.Titulo = "Aqui se mostrara los detalles del Usuario, con sus aptitudes";

            if (detalles.PuestoTrabajo == null)
            {
                Response.StatusCode = 404;
                return View("RegistroNoEncontrado", id);
            }
            return View(detalles);
        }

        // [Route("Home/Signup")]
        // public ViewResult Signup()
        // {
        //     RegistroModel r = new RegistroModel();
        //     return View(r);
        // }
        [Route("Home/Creatjob")]
        [HttpGet]
        public ViewResult Creatjob()
        {
            // if(id != null){

            //     var trabajo = _listaPuestoTrabajo.dameElTrabajo(id??1);
            //     ModificarJobModel model = new ModificarJobModel(trabajo);
            //     return View(model);
            // }
            ModificarJobModel model2 = new ModificarJobModel();

            return View(model2);
        }

        [HttpPost]
        public IActionResult Creatjob(ModificarJobModel pt)
        {
            if (ModelState.IsValid)
            {

                PuestoTrabajo p = _listaPuestoTrabajo.nuevo(pt);

                UsuarioPuestoTrabajo upt = new UsuarioPuestoTrabajo();
                upt.IdUsuario = User.getUserId();
                upt.IdPuestoTrabajo = p.Id;
                upt.ParaAplicar = false;
                _userJob.nuevo(upt);


                return RedirectToAction("details", new { id = p.Id });
            }
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            PuestoTrabajo p = _listaPuestoTrabajo.dameElTrabajo(id);

            return View(p);

        }

        [HttpPost]
        public IActionResult Edit(PuestoTrabajo model)
        {

            if (ModelState.IsValid)
            {
                var trabajo = _listaPuestoTrabajo.dameElTrabajo(model.Id);

                trabajo.Compania = model.Compania;
                trabajo.Logo = model.Logo;
                trabajo.Url = model.Url;
                trabajo.Posicion = model.Posicion;
                trabajo.Ubicacion = model.Ubicacion;
                trabajo.ComoAplicar = model.ComoAplicar;
                trabajo.Correo = model.Correo;
                trabajo.Categoria = model.Categoria;
                trabajo.DescripcionTrabajo = model.DescripcionTrabajo;
                trabajo.TipoEmpleado = model.TipoEmpleado;

                PuestoTrabajo pModificado = _listaPuestoTrabajo.modificar(trabajo);
                return RedirectToAction("index");
            }

            return View(model);

        }

        [HttpPost]
        [Route("Home/DeleteJob")]
        public IActionResult DeleteJob(int id)
        {
            var job = _listaPuestoTrabajo.dameElTrabajo(id);

            if (job == null)
            {
                ViewBag.Title = $"Job with Id = {id} not find";
                return View("Error");
            }
            else
            {
                var result = _listaPuestoTrabajo.borrar(id);
                return RedirectToAction("Index", "Home");
            }


        }

        [HttpPost]
        [Route("Home/Aply")]
        public IActionResult Aply(int id)
        {
            var job = _listaPuestoTrabajo.dameElTrabajo(id);

            if (job == null)
            {
                ViewBag.Title = $"Job with id = {id} not find";
                return View("Error");
            }
            else
            {
                UsuarioPuestoTrabajo upt = new UsuarioPuestoTrabajo();
                upt.IdPuestoTrabajo = job.Id;
                upt.IdUsuario = User.getUserId();
                upt.ParaAplicar = true;

                _userJob.nuevo(upt);
                return RedirectToAction("Index", "Home");
            }
        }



        [Route("Home/perfilempleado")]
        [Route("Home/perfilempleado/{id}")]
        [HttpPost]
        public ViewResult perfilempleado()
        {
            return View();
        }
        [Route("Api/PuestoTrabajo")]
        public JsonResult json()
        {
            return Json(_listaPuestoTrabajo.dameTodoTrabajo());
        }

        [Route("Api/Users")]
        public JsonResult json2()
        {
            return Json(_listaUsuario.dameTodosLosUsuarios());
        }



    }
}
