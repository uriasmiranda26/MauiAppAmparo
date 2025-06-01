using MauiAppAmparo.Models;

namespace MauiAppAmparo.Services
{
    public class LembreteService
    {
        private readonly AppDbContext _context;

        public LembreteService()
        {
            _context = new AppDbContext();
        }

        public void AdicionarLembrete(Lembrete lembrete)
        {
            _context.Lembretes.Add(lembrete);
            _context.SaveChanges();
        }

        public List<Lembrete> ObterLembretesPendentes()
        {
            return _context.Lembretes.Where(l => !l.Resolvido).ToList();
        }

        public void ResolverLembrete(int id)
        {
            var lembrete = _context.Lembretes.Find(id);
            if (lembrete != null)
            {
                lembrete.Resolvido = true;
                _context.SaveChanges();
            }
        }

        public void RemoverLembrete(int id)
        {
            var lembrete = _context.Lembretes.Find(id);
            if (lembrete != null)
            {
                _context.Lembretes.Remove(lembrete);
                _context.SaveChanges();
            }
        }
    }
}
