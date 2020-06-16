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
                Id =1,
                Compania = "LegoList",
                TipoEmpleado = ETipoEmpleado.Medio_Tiempo,
                Logo = "https://LegoList/Img/logo.png",
                Url = "https://LegoList",
                Posicion = "Developer",
                Ubicacion = "hsjsjsjsjs",
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

    }
}