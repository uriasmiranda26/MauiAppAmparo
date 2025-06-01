using MauiAppAmparo.Models;

namespace MauiAppAmparo.Services
{
    public class GlicemiaService
    {
        private readonly AppDbContext _context;

        public GlicemiaService()
        {
            _context = new AppDbContext();
        }

        public void AdicionarGlicemia(Glicemia glicemia)
        {
            _context.Glicemias.Add(glicemia);
            _context.SaveChanges();
        }

        public List<Glicemia> ObterGlicemiaPorIdoso(int idIdoso)
        {
            return _context.Glicemias.Where(p => p.IdIdoso == idIdoso).ToList();
        }

        public void RemoverGlicemia(int id)
        {
            var glicemia = _context.Glicemias.Find(id); // Corrected variable name from "pressao" to "glicemia"
            if (glicemia != null)
            {
                _context.Glicemias.Remove(glicemia); // Corrected DbSet reference from "PressoesArteriais" to "Glicemias"
                _context.SaveChanges();
            }
        }
    }
}
