using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoWeb.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegistosAlmacenado _registrosAlmacenado;
        public HomeController(IRegistosAlmacenado registosAlmacenado)
        {
            _registrosAlmacenado = registosAlmacenado;
        }

        public string Index()
        {
            return _registrosAlmacenado.dameDatos(2).Correo;
        }
    }
}
