using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MauiAppAmparo.Models
{
    public class Lembrete
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TipoLembrete { get; set; } // Ex: "Medicamento", "Consulta", "Exame"

        [Required]
        public string Descricao { get; set; } // Ex: "Tomar remédio às 08:00" ou "Consulta com cardiologista"

        [Required]
        public DateTime DataHoraLembrete { get; set; }

        public bool Resolvido { get; set; } = false;

        // Relacionamento com Idoso
        public int IdIdoso { get; set; }
        [ForeignKey("IdIdoso")]
        public Idoso Idoso { get; set; }
    }

}
