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
        public string Nome { get; set; }

        [Required]
        [Phone]
        public string Telefone { get; set; }

        public string Relacao { get; set; } // Ex: "Filho", "Vizinho", "Cuidador"

        // Relacionamento com Idoso
        public int IdIdoso { get; set; }
        [ForeignKey("IdIdoso")]
        public Idoso Idoso { get; set; }
    }
}
