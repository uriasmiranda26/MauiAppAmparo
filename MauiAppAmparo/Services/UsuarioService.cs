using MauiAppAmparo.Models;

namespace MauiAppAmparo.Services
{
    public class UsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public Usuario? AutenticarUsuario(string usuario, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Nome == usuario && u.Senha == senha);
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> ObterTodosUsuarios()
        {
            return _context.Usuarios.ToList();
        }

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
