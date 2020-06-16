using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProyectoWeb.Models;

namespace ProyectoWeb.Data
{
    public partial class ProyectoWebContext : DbContext
    {
        public ProyectoWebContext()
        {
        }

        public ProyectoWebContext(DbContextOptions<ProyectoWebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PuestoTrabajo> PuestoTrabajo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPuestoTrabajo> UsuarioPuestoTrabajo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PuestoTrabajo>(entity =>
            {
                entity.Property(e => e.TipoEmpleado)
                    .HasColumnName("TipoEmpleo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComoAplicar)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Compania)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionTrabajo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPublicacion).HasColumnType("datetime");

                entity.Property(e => e.Logo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Aptitudes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Profesional)
                    .HasColumnName("Profecional")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioContra)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioNombre)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioPuestoTrabajo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Usuario_PuestoTrabajo");

                entity.HasOne(d => d.IdPuestoTrabajoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdPuestoTrabajo)
                    .HasConstraintName("FK__Usuario_P__IdPue__4BAC3F29");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Usuario_P__IdUsu__4AB81AF0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
