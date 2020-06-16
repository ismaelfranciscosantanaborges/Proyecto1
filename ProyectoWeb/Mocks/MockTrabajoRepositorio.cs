using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Models;

namespace ProyectoWeb.Mocks
{
    public class MockTrabajoRepositorio: IPuestoTrabajo
    {
        List<PuestoTrabajo> listaTrabajo;
        public MockTrabajoRepositorio(){
            listaTrabajo = new List<PuestoTrabajo>();

            listaTrabajo.Add( new PuestoTrabajo{
                Id = 1,
                Compania = "LegoList",
                TipoEmpleado = ETipoEmpleado.PartTime,
                Logo = "https://LegoList/Img/logo.png",
                Url = "https://LegoList",
                Posicion = "Developer",
                Ubicacion = "Santo Domingo",
                ComoAplicar = "Llenando el formulario",
                Correo = "legolist@gmail.com",
                Categoria = ECategoria.Analysis,
                DescripcionTrabajo = "Esto es un trabajo sumamente importante para mi",
                FechaPublicacion = DateTime.Now
            }

            );
        }

        public List<PuestoTrabajo> dameTodoTrabajo(){
            return listaTrabajo;
        }

        public PuestoTrabajo dameElTrabajo(int id){

            return listaTrabajo.FirstOrDefault(x => x.Id == id);
        }

        public PuestoTrabajo nuevo(PuestoTrabajo puestoTrabajo)
        {
            puestoTrabajo.Id = listaTrabajo.Max(x => x.Id) + 1;
            puestoTrabajo.FechaPublicacion = DateTime.Now;
            puestoTrabajo.Logo = "";
    
            listaTrabajo.Add(puestoTrabajo);
            return puestoTrabajo;
        }
    }
}

