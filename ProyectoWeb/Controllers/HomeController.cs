using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Mocks;
using ProyectoWeb.Models;
using ProyectoWeb.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegistosAlmacenado _registrosAlmacenado;
        private MockRegistrosRepositorio _listaUsuario;
        public HomeController(IRegistosAlmacenado registosAlmacenado)
        {
            _registrosAlmacenado = registosAlmacenado;

            _listaUsuario = new MockRegistrosRepositorio();
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            var listaUsuario = _listaUsuario.dameTodosLosUsuarios();
            return View(listaUsuario);
            //return View("~/MisVistas/Index.cshtml");
        }
        [Route("Home/Details")]
        [Route("Home/Details/{id}")]
        public ViewResult Details(int? id)
        {
            
            DetallesView detalles = new DetallesView();
            detalles.Usuario = _listaUsuario.dameDetallesUsuario(id??1);
            detalles.Titulo = "Aqui se mostrara los detalles del Usuario, con sus aptitudes";
            return View(detalles);
        }
        [Route("Home/Login")]
        [Route("Home/Login/{id}")]
        public ViewResult Login(int? id)
        {

            return View();
        }

    }
}
