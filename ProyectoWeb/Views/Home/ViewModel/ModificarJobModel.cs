using ProyectoWeb.Models;

namespace ProyectoWeb.Views.Home.ViewModel
{
    public class ModificarJobModel: PuestoTrabajo
    {
        public ModificarJobModel(){
            paraModificar =false;
        }
        public ModificarJobModel(PuestoTrabajo p){
            
            Id = p.Id;
            Compania = p.Compania;
            TipoEmpleado = p.TipoEmpleado;
            Logo = p.Logo;
            Url = p.Url;
            Posicion = p.Posicion;
            Ubicacion = p.Ubicacion;
            ComoAplicar = p.ComoAplicar;
            Correo = p.Correo;
            Categoria = p.Categoria;
            DescripcionTrabajo = p.DescripcionTrabajo;
            FechaPublicacion = p.FechaPublicacion;
            paraModificar = true;
        }
        public bool paraModificar { get; set; }
    }
}