using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoWeb.Data;

namespace ProyectoWeb.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public virtual DbSet<PuestoTrabajo> PuestoTrabajo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPuestoTrabajo> UsuarioPuestoTrabajo { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            // modelBuilder.Entity<PuestoTrabajo>().ToTable("PuestoTrabajo");
            // modelBuilder.Entity<Usuario>().ToTable("Usuario");
            // modelBuilder.Entity<UsuarioPuestoTrabajo>().ToTable("UsuarioPuestoTrabajo");
            

            modelBuilder.Entity<PuestoTrabajo>().HasData( new PuestoTrabajo{
                Id = 1,
                Compania = "LegoList",
                TipoEmpleado = ETipoEmpleado.PartTime,
                Logo = "https://LegoList/Img/logo.png",
                Url = "https://LegoList",
                Posicion = "Developer",
                Ubicacion = "Santo Domingo",
                ComoAplicar = "Llenando el formulario",
                Correo = "legolist@gmail.com",
                Categoria = ECategoria.Administration,
                DescripcionTrabajo = "Esto es un trabajo sumamente importante para mi",
                FechaPublicacion = DateTime.Now
            });

            modelBuilder.Entity<Usuario>().HasData(new Usuario
                {
                    Id = 1,
                    Nombre = "Samuel",
                    Apellido = "Perez",
                    Correo = "samuel@gmail.com",
                    Cedula = "402-6536424-2",
                    Telefono = "829-535-7464",
                    UsuarioContra = "123456",
                    UsuarioNombre = "samuelElFinalll",
                    Aptitudes = "Java Avanzado"
                });

            modelBuilder.Entity<UsuarioPuestoTrabajo>().HasData(new UsuarioPuestoTrabajo{
                Id = 1,
                IdPuestoTrabajo = 1,
                IdUsuario =1,
                ParaAplicar = true
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}