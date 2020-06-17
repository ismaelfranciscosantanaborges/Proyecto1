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
            var trabajo = _context.PuestoTrabajo.Find(id);
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

        public PuestoTrabajo borrar(int id)
        {
            PuestoTrabajo p = _context.PuestoTrabajo.Find(id);
            if(p != null){
                _context.PuestoTrabajo.Remove(p);
                _context.SaveChanges();
            }
            return p;
        }

        public PuestoTrabajo modificar(PuestoTrabajo trabajo)
        {
            var employee = _context.PuestoTrabajo.Attach(trabajo);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return trabajo; 
        }
    }
}

