using MauiAppAmparo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.Helpers
{
    public class PressaoArterialHelper
    {
        private readonly AppDbContext _context;

        public PressaoArterialHelper()
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
