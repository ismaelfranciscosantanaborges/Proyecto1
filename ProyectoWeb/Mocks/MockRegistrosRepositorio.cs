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
                    Imagen = "https://imagen/23.png",
                    Telefono = "829-535-7464",
                    UsuarioContra = "123456",
                    UsuarioNombre = "samuelElFinalll"
                });
            listaRegistro.Add(new Poster
                {
                    Id = 2,
                    Nombre = "Lola",
                    Apellido = "Mendez",
                    Correo = "lola@gmail.com",
                    Imagen = "https://imagen/23.png",
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
                Imagen = "https://imagen/yika.png",
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
                Imagen = "https://imagen/isaac.png",
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
                Imagen = "https://imagen/klk.png",
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
                Imagen = "https://imagen/lajosef.png",
                Telefono = "829-222-7464",
                UsuarioContra = "123456",
                UsuarioNombre = "laRealll"
            });

        }
        public BaseUser dameDatos(int id)
        {
            return listaRegistro.FirstOrDefault(x => x.Id == id);
        }
    }
}
