using System.Collections.Generic;
using ProyectoWeb.Models;

namespace ProyectoWeb.ViewModel
{
    public class DetallesView
    {
        public DetallesView()
        {
            Users = new List<string>(); 
        }
        public string Titulo { get; set; }
        public PuestoTrabajo PuestoTrabajo {get;set;}
        public List<UsuarioPuestoTrabajo> ListUsuarioPT {get;set;}
        public List<string> Users { get; set; }
    }
}