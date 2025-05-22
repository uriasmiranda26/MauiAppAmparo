using Microsoft.Maui;
using MauiAppAmparo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            optionsBuilder.UseSqlite("Filename=appdata.db");
        }
    }
}
