using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb.Data;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Models;

namespace ProyectoWeb.Mocks
{
    public class MockTrabajoRepositorio: IPuestoTrabajo
    {
        //List<PuestoTrabajo> listaTrabajo;
        private readonly AppDbContext _context; 
        public MockTrabajoRepositorio(AppDbContext context){
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
            
            List<PuestoTrabajo> listPT = _context.PuestoTrabajo.ToList();
            listPT.Reverse();

            return listPT;
        }

        public PuestoTrabajo dameElTrabajo(int id){
            var trabajo = _context.PuestoTrabajo.Find(id);
            return trabajo;
        }

        public List<PuestoTrabajo> getOfFilter(string cadena)
        {
            List<PuestoTrabajo> listPT;
            if(cadena != null)
            {
                listPT = _context.PuestoTrabajo.Where(x => x.Posicion.Contains(cadena)).ToList();
                listPT.Reverse();
            }else
            {
                listPT = dameTodoTrabajo();
            }
            
                    // var query = from s in _context.PuestoTrabajo
                    // where EF.Functions.Like(s.Categoria.ToString(), $"%{cadena}%")
                    // select s;
            return listPT;
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
            if(p != null)
            {
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

