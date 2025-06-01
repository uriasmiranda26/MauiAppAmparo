using MauiAppAmparo.Models;

namespace MauiAppAmparo.Services
{
    public class PressaoArterialService
    {
        private readonly AppDbContext _context;

        public PressaoArterialService()
        {
            _context = new AppDbContext();
        }

        public void AdicionarPressao(PressaoArterial pressao)
        {
            _context.PressoesArteriais.Add(pressao);
            _context.SaveChanges();
        }

        public List<PressaoArterial> ObterPressaoPorIdoso(int idIdoso)
        {
            return _context.PressoesArteriais.Where(p => p.IdIdoso == idIdoso).ToList();
        }

        public void RemoverPressao(int id)
        {
            var pressao = _context.PressoesArteriais.Find(id);
            if (pressao != null)
            {
                _context.PressoesArteriais.Remove(pressao);
                _context.SaveChanges();
            }
        }
    }
}
