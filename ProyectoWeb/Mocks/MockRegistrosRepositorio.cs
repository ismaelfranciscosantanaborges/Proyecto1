using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Mocks
{
    public class MockRegistrosRepositorio : IRegistosAlmacenado
    {
        List<BaseUser> listaRegistro;
        public MockRegistrosRepositorio()
        {
            listaRegistro = new List<BaseUser>();

                //Esto esta simulando la data que viene de la  base de datos
            listaRegistro.Add(new Administrador
                {
                    Id = 1,
                    Nombre = "Samuel",
                    Apellido = "Perez",
                    Correo = "samuel@gmail.com",
                    Cedula = "402-6536424-2",
                    Telefono = "829-535-7464",
                    UsuarioContra = "123456",
                    UsuarioNombre = "samuelElFinalll",
                    Aptitudes = ""
                });
            listaRegistro.Add(new Poster
                {
                    Id = 2,
                    Nombre = "Lola",
                    Apellido = "Mendez",
                    Correo = "lola@gmail.com",
                    Cedula = "402-6530004-2",
                    Telefono = "829-536-1111",
                    UsuarioContra = "123453456",
                    UsuarioNombre = "lolita"
                });
            listaRegistro.Add(new Poster
            {
                Id = 3,
                Nombre = "Yikauri",
                Apellido = "Montero",
                Correo = "Yika@gmail.com",
                Cedula = "402-6536111-2",
                Telefono = "829-535-7464",
                UsuarioContra = "micontrasenia",
                UsuarioNombre = "tuRealYika"
            });
            listaRegistro.Add(new User
            {
                Id = 4,
                Nombre = "Isaac",
                Apellido = "Manzueta",
                Correo = "mazueta33@gmail.com",
                Cedula = "402-6444444-2",
                Telefono = "829-444-7464",
                UsuarioContra = "123456",
                UsuarioNombre = "samuelElFinalll"
            });
            listaRegistro.Add(new User
            {
                Id = 5,
                Nombre = "Luis David",
                Apellido = "Borges",
                Correo = "lindonReal@gmail.com",
                Cedula = "402-6599994-2",
                Telefono = "829-679-7464",
                UsuarioContra = "123456",
                UsuarioNombre = "BorgesDavid"
            });
            listaRegistro.Add(new User
            {
                Id = 6,
                Nombre = "Josefina",
                Apellido = "Caraballo",
                Correo = "josefinaTuMami@gmail.com",
                Cedula = "402-6530000-2",
                Telefono = "829-222-7464",
                UsuarioContra = "123456",
                UsuarioNombre = "laRealll"
            });

        }
        public BaseUser dameDetallesUsuario(int id)
        {
            return listaRegistro.FirstOrDefault(x => x.Id == id);
        }

        public List<BaseUser> dameTodosLosUsuarios()
        {
            return listaRegistro;
        }
    }
}
