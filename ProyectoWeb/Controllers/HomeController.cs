using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Mocks;
using ProyectoWeb.Models;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegistosAlmacenado _registrosAlmacenado;
        private readonly IRegistosAlmacenado _listaUsuario;
        private readonly IPuestoTrabajo _listaPuestoTrabajo;

        public HomeController(IRegistosAlmacenado registosAlmacenado, IPuestoTrabajo puestoTrabajo, IRegistosAlmacenado listaUsuario)
        {
            _registrosAlmacenado = registosAlmacenado;

            _listaUsuario = listaUsuario;

            _listaPuestoTrabajo = puestoTrabajo;


        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            //var listaUsuario = _listaUsuario.dameTodosLosUsuarios();
            return View(_listaPuestoTrabajo.dameTodoTrabajo());
            //return View("~/MisVistas/Index.cshtml");
        }

        [Route("Home/Details/{id?}")]
        public ViewResult Details(int? id)
        {
            DetallesView detalles = new DetallesView();
            //detalles.Usuario = _listaUsuario.dameDetallesUsuario(id??1);
            detalles.PuestoTrabajo = _listaPuestoTrabajo.dameElTrabajo(id??1);
            detalles.Titulo = "Aqui se mostrara los detalles del Usuario, con sus aptitudes";
            return View(detalles);
        }
        [Route("Home/Login")]
        [Route("Home/Login/{id}")]
        public ViewResult Login(int? id)
        {

            return View();
        }
        [Route("Home/Signup")]
        [Route("Home/Signup/{id}")]
        public ViewResult Signup(int? id)
        {

            return View();
        }
        [Route("Home/Creatjob")]
        [HttpGet]
        public ViewResult Creatjob()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Creatjob(PuestoTrabajo pt)
        {
            if(ModelState.IsValid){
                PuestoTrabajo p = _listaPuestoTrabajo.nuevo(pt);
                return RedirectToAction("details", new {id = p.Id});
            }
            return View();
        }

        [Route("Home/perfilempleado")]
        [Route("Home/perfilempleado/{id}")]
        [HttpPost]
        public ViewResult perfilempleado(int? id)
        {

            return View();
        }

    }
}
