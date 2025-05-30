using MauiAppAmparo.Models;
using Microsoft.EntityFrameworkCore;


namespace MauiAppAmparo
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Idoso> Idosos { get; set; }
        public DbSet<PressaoArterial> PressoesArteriais { get; set; }
        public DbSet<Glicemia> Glicemias { get; set; }
        public DbSet<Lembrete> Lembretes { get; set; }
        public DbSet<ContatoEmergencia> ContatosEmergencia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "appdata.db");
            Console.WriteLine($"Database path: {databasePath}");
            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}
