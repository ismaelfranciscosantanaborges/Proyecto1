using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoWeb.Data;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Models;

namespace ProyectoWeb.Mocks
{
    public class MockTrabajoRepositorio: IPuestoTrabajo
    {
        //List<PuestoTrabajo> listaTrabajo;
        private readonly ProyectoWebContext _context; 
        public MockTrabajoRepositorio(ProyectoWebContext context){
            _context = context;

            // listaTrabajo = new List<PuestoTrabajo>();

            // listaTrabajo.Add( new PuestoTrabajo{
            //     Id = 1,
            //     Compania = "LegoList",
            //     TipoEmpleado = ETipoEmpleado.PartTime,
            //     Logo = "https://LegoList/Img/logo.png",
            //     Url = "https://LegoList",
            //     Posicion = "Developer",
            //     Ubicacion = "Santo Domingo",
            //     ComoAplicar = "Llenando el formulario",
            //     Correo = "legolist@gmail.com",
            //     Categoria = ECategoria.Analysis,
            //     DescripcionTrabajo = "Esto es un trabajo sumamente importante para mi",
            //     FechaPublicacion = DateTime.Now
            // }

            // );
        }

        public List<PuestoTrabajo> dameTodoTrabajo(){
           
            return _context.PuestoTrabajo.ToList();
        }

        public PuestoTrabajo dameElTrabajo(int id){
            var trabajo = _context.PuestoTrabajo.FirstOrDefault(x => x.Id == id);
            //trabajo.TipoEmpleado = ((ETipoEmpleado)trabajo.TipoEmpleado);
            
            // switch(tipoTrabajo){
            //     case 1:
            //         trabajo.TipoEmpleado = ETipoEmpleado.FullTime;
            //     break;
            //     case 2:
            //         trabajo.TipoEmpleado = ETipoEmpleado.PartTime;
            //     break;
            //     case 3:
            //         trabajo.TipoEmpleado = ETipoEmpleado.Freelancer;
            //     break;
            //     default:
            //             trabajo.TipoEmpleado = ETipoEmpleado.PartTime;
            //     break;
            // }

            return trabajo;
        }

        public PuestoTrabajo nuevo(PuestoTrabajo puestoTrabajo)
        {
            //puestoTrabajo.Id = _context.PuestoTrabajo.Max(x => x.Id) + 1;
            puestoTrabajo.FechaPublicacion = DateTime.Now;
            puestoTrabajo.Logo = "";
    
            _context.PuestoTrabajo.Add(puestoTrabajo);
            _context.SaveChanges();
            return puestoTrabajo;
        }
    }
}

