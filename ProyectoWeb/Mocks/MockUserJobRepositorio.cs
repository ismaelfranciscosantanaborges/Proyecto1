using ProyectoWeb.Data;
using ProyectoWeb.Interfaces;
using ProyectoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWeb.Mocks
{
    public class MockUserJobRepositorio : IUserJob
    {
        private readonly AppDbContext _context;
        public MockUserJobRepositorio(AppDbContext context)
        {
            this._context = context;
        }

        public UsuarioPuestoTrabajo borrar(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioPuestoTrabajo dameElUserJob(string id)
        {
            return _context.UsuarioPuestoTrabajo.FirstOrDefault(x => x.IdUsuario == id);
        }

        public List<UsuarioPuestoTrabajo> dameTodoUserJob(string id)
        {
            return _context.UsuarioPuestoTrabajo.Where(x => x.IdUsuario == id).ToList();
        }

        public List<UsuarioPuestoTrabajo> dameTodoUserJob()
        {
            return _context.UsuarioPuestoTrabajo.ToList();
        }

        public List<UsuarioPuestoTrabajo> dameUserJob()
        {
            throw new NotImplementedException();
        }

        public UsuarioPuestoTrabajo nuevo(UsuarioPuestoTrabajo userJob)
        {
            _context.UsuarioPuestoTrabajo.Add(userJob);
            _context.SaveChanges();
            return userJob;
        }

    }
}
