using MauiAppAmparo.Models;

namespace MauiAppAmparo.Services
{
    public class ContatoEmergenciaService
    {
        private readonly AppDbContext _context;

        public ContatoEmergenciaService()
        {
            _context = new AppDbContext();
        }

        public void AdicionarContato(ContatoEmergencia contato)
        {
            _context.ContatosEmergencia.Add(contato);
            _context.SaveChanges();
        }

        public List<ContatoEmergencia> ObterContatosPorIdoso(int idIdoso)
        {
            return _context.ContatosEmergencia.Where(c => c.IdIdoso == idIdoso).ToList();
        }

        public void RemoverContato(int id)
        {
            var contato = _context.ContatosEmergencia.Find(id);
            if (contato != null)
            {
                _context.ContatosEmergencia.Remove(contato);
                _context.SaveChanges();
            }
        }
    }
}
