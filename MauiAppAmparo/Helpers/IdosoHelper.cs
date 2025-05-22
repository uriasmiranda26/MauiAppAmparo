using MauiAppAmparo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.Helpers
{
    public class IdosoService
    {
        private readonly AppDbContext _context;

        public IdosoService()
        {
            _context = new AppDbContext();
        }

        public void AdicionarIdoso(Idoso idoso)
        {
            _context.Idosos.Add(idoso);
            _context.SaveChanges();
        }

        public List<Idoso> ObterTodosIdosos()
        {
            return _context.Idosos.ToList();
        }

        public void AtualizarIdoso(int id, DateTime dataNascimento, string contatoEmergencia)
        {
            var idoso = _context.Idosos.Find(id);
            if (idoso != null)
            {
                idoso.DataNascimento = dataNascimento;
                idoso.ContatoEmergencia = contatoEmergencia;
                _context.SaveChanges();
            }
        }

        public void RemoverIdoso(int id)
        {
            var idoso = _context.Idosos.Find(id);
            if (idoso != null)
            {
                _context.Idosos.Remove(idoso);
                _context.SaveChanges();
            }
        }
    }
}
