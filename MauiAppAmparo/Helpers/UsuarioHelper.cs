using MauiAppAmparo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.Helpers
{
    public class UsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService()
        {
            _context = new AppDbContext();
        }

        // Create
        public void AdicionarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Read
        public List<Usuario> ObterTodosUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        // Update
        public void AtualizarUsuario(int id, string nome, string email)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                usuario.Nome = nome;
                usuario.Email = email;
                _context.SaveChanges();
            }
        }

        // Delete
        public void RemoverUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}
