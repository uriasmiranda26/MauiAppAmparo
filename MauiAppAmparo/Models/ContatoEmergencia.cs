using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiAppAmparo.Models
{
    public class ContatoEmergencia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Nome { get; set; }

        [Required]
        [Phone]
        public required string Telefone { get; set; }

        public required string Relacao { get; set; } // Ex: "Filho", "Vizinho", "Cuidador"

        // Relacionamento com Idoso
        public int IdIdoso { get; set; }
        [ForeignKey("IdIdoso")]
        public Idoso Idoso { get; set; }
    }
}
