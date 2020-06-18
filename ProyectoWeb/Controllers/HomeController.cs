using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public ViewResult Details(int id)
        {
            DetallesView detalles = new DetallesView();
            //detalles.Usuario = _listaUsuario.dameDetallesUsuario(id??1);
            detalles.PuestoTrabajo = _listaPuestoTrabajo.dameElTrabajo(id);
            detalles.Titulo = "Aqui se mostrara los detalles del Usuario, con sus aptitudes";

            if(detalles.PuestoTrabajo == null){
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
            if(ModelState.IsValid){

                PuestoTrabajo p; 
                if(pt.paraModificar){
                    p = _listaPuestoTrabajo.dameElTrabajo(pt.Id);
                    
                    p.Id = pt.Id;
                    p.Compania = pt.Compania;
                    p.Logo = pt.Logo;
                    p.Url = pt.Url;
                    p.Posicion = pt.Posicion;
                    p.Ubicacion = pt.Ubicacion;
                    p.ComoAplicar = pt.ComoAplicar;
                    p.Correo = pt.Correo;
                    p.Categoria = pt.Categoria;
                    p.DescripcionTrabajo = pt.DescripcionTrabajo;
                    p.FechaPublicacion = pt.FechaPublicacion;
                    p.TipoEmpleado = pt.TipoEmpleado;

                    PuestoTrabajo pModificado = _listaPuestoTrabajo.modificar(p);
                    return RedirectToAction("index");
                }else{
                    p = _listaPuestoTrabajo.nuevo(pt);
                }
                
                return RedirectToAction("details", new {id = p.Id});
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
            
            if(ModelState.IsValid){
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



        [Route("Home/perfilempleado")]
        [Route("Home/perfilempleado/{id}")]
        [HttpPost]
        public ViewResult perfilempleado(int? id)
        {
            return View();
        }

    }
}
